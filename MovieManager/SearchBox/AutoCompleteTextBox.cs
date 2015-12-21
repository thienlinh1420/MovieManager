using MovieManager_BUS;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace MovieManager.SearchBox
{
    public class AutoCompleteTextBox : Control
    {

        public static readonly DependencyProperty IconPlacementProperty = DependencyProperty.Register("IconPlacement", typeof(IconPlacement), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(IconPlacement.Left));
        public static readonly DependencyProperty IconVisibilityProperty = DependencyProperty.Register("IconVisibility", typeof(Visibility), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(Visibility.Visible));
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(object), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.Register("Watermark", typeof(string), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(string.Empty));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(string.Empty));
        public static readonly DependencyProperty IsDropDownOpenProperty = DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(false));
        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty ItemTemplateSelectorProperty = DependencyProperty.Register("ItemTemplateSelector", typeof(DataTemplateSelector), typeof(AutoCompleteTextBox));
        public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.Register("IsLoading", typeof(bool), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(false));
        public static readonly DependencyProperty LoadingContentProperty = DependencyProperty.Register("LoadingContent", typeof(object), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty NoValueProperty = DependencyProperty.Register("NoValue", typeof(bool), typeof(AutoCompleteTextBox), new FrameworkPropertyMetadata(false));


        public delegate void ShowFilmInfoHandler(PhimDTO phimDTO);
        public event ShowFilmInfoHandler Item_Click;

        private TextBox _editor;
        private Selector _itemsSelector;

        public Selector ItemsSelector
        {
            get { return _itemsSelector; }
            set { _itemsSelector = value; }
        }

        public TextBox Editor
        {
            get { return _editor; }
            set { _editor = value; }
        }
        public IconPlacement IconPlacement
        {
            get { return (IconPlacement)GetValue(IconPlacementProperty); }

            set { SetValue(IconPlacementProperty, value); }
        }

        public Visibility IconVisibility
        {
            get { return (Visibility)GetValue(IconVisibilityProperty); }

            set { SetValue(IconVisibilityProperty, value); }
        }

        public object Icon
        {
            get { return GetValue(IconProperty); }

            set { SetValue(IconProperty, value); }
        }

        public string Watermark
        {
            get { return (string)GetValue(WatermarkProperty); }

            set { SetValue(WatermarkProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }

            set { SetValue(TextProperty, value); }
        }

        public bool IsDropDownOpen
        {
            get { return (bool)GetValue(IsDropDownOpenProperty); }

            set { SetValue(IsDropDownOpenProperty, value); }
        }

        public bool NoValue
        {
            get { return (bool)GetValue(NoValueProperty); }

            set { SetValue(NoValueProperty, value); }
        }

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }

            set { SetValue(ItemTemplateProperty, value); }
        }

        public DataTemplateSelector ItemTemplateSelector
        {
            get { return ((DataTemplateSelector)(GetValue(AutoCompleteTextBox.ItemTemplateSelectorProperty))); }
            set { SetValue(AutoCompleteTextBox.ItemTemplateSelectorProperty, value); }
        }

        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }

            set { SetValue(IsLoadingProperty, value); }
        }

        public object LoadingContent
        {
            get { return GetValue(LoadingContentProperty); }

            set { SetValue(LoadingContentProperty, value); }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Editor = Template.FindName("PART_Editor", this) as TextBox;
            ItemsSelector = Template.FindName("PART_Selector", this) as ListBox;
            if (Editor != null)
            {
                Editor.TextChanged += OnEditorTextChanged;
                Editor.LostFocus += OnEditorLostFocus;
                Editor.PreviewKeyDown += OnEditorKeyDown;
                
            }
            if (ItemsSelector != null)
            {
                ItemsSelector.MouseLeftButtonUp += OnSelectItem;
            }
        }

        private void OnEditorKeyDown(object sender, KeyEventArgs e)
        {
            if (!NoValue && IsDropDownOpen)
            {
               switch (e.Key)
               {
                   case Key.Up:
                       {
                           if (ItemsSelector.SelectedIndex == -1)
                           {
                               ItemsSelector.SelectedIndex = ItemsSelector.Items.Count - 1;
                           }
                           else
                           {
                               ItemsSelector.SelectedIndex -= 1;
                           }
                           break;
                       }
                   case Key.Down:
                       {
                           if (ItemsSelector.SelectedIndex == ItemsSelector.Items.Count - 1)
                           {
                               ItemsSelector.SelectedIndex = -1;
                           }
                           else
                           {
                               ItemsSelector.SelectedIndex += 1;
                           }
                           break;
                       }
                   case Key.Enter:
                       {
                           AutoCompleteTextBoxItem item = ItemsSelector.SelectedItem as AutoCompleteTextBoxItem;
                           MessageBox.Show(item.tblFilmName.Text);
                           break;
                       }
               }
            }
        }

        private void OnSelectItem(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (NoValue == false)
            {
                AutoCompleteTextBoxItem item = (AutoCompleteTextBoxItem)ItemsSelector.SelectedItem;
                PhimDTO phimDTO = (PhimDTO)item.Tag;
                Item_Click(phimDTO);
                IsDropDownOpen = false;
                Editor.Text = "";
            }
        }

        private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            if (Editor.Text != "")
            {
                Thread thread = new Thread(new ParameterizedThreadStart(GetSuggestion));
                thread.Start(new object[] 
                {  
                    Editor.Text
                });
            }
            else if (Editor.Text == "" && IsDropDownOpen == true)
            {
                IsDropDownOpen = false;
            }
        }
        public void GetSuggestion(object param)
        {
            object[] args = param as object[];
            String searchText = Convert.ToString(args[0]);
            PhimBUS phimBUS = new PhimBUS(); 
            List<PhimDTO> list = phimBUS.SearchByText(searchText);
            this.Dispatcher.BeginInvoke(new Action<List<PhimDTO>>(DisplaySuggestion), DispatcherPriority.Background, new object[] {list});
        }

        public void DisplaySuggestion(List<PhimDTO> lstFilm)
        {
            List<AutoCompleteTextBoxItem> lstActb = new List<AutoCompleteTextBoxItem>();
            if (lstFilm.Count != 0)
            {
                foreach (PhimDTO item in lstFilm)
                {
                    AutoCompleteTextBoxItem actbi = new AutoCompleteTextBoxItem();
                    actbi.Width = this.ActualWidth;
                    actbi.SetData(item);
                    NoValue = false;
                    lstActb.Add(actbi);
                }
                ItemsSelector.ItemsSource = lstActb;
            }
            else
            {
                String[] NoValueString = {"Không tìm thấy kết quả nào"};
                NoValue = true;
                ItemsSelector.ItemsSource = NoValueString;
            }
            IsDropDownOpen = true;
        }
        private void OnEditorLostFocus(object sender, RoutedEventArgs e)
        {
            if (!IsKeyboardFocusWithin)
            {
                IsDropDownOpen = false;
            }
        }
    }
}
