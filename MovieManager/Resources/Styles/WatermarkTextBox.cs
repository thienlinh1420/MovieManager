using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MovieManager.Resources.Styles
{
    class WatermarkTextBox : Control
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(WatermarkTextBox), new FrameworkPropertyMetadata(string.Empty));
        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.Register("Watermark", typeof(string), typeof(WatermarkTextBox), new FrameworkPropertyMetadata(string.Empty));
        public static readonly DependencyProperty TextWrappingProperty = DependencyProperty.Register("TextWrapping", typeof(TextWrapping), typeof(WatermarkTextBox), new FrameworkPropertyMetadata(TextWrapping.NoWrap));
        public static readonly DependencyProperty AcceptsReturnProperty = DependencyProperty.Register("AcceptsReturn", typeof(bool), typeof(WatermarkTextBox), new FrameworkPropertyMetadata(false));
       

        public WatermarkTextBox()
        {
            ResourceDictionary myResource = new ResourceDictionary();
            myResource.Source = new Uri("/MovieManager;component/Resources/Styles/WatermarkTextBoxStyle.xaml", UriKind.Relative);
            this.Style = (Style)myResource["WatermarkTextBoxStyle"];
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

        public TextWrapping TextWrapping
        {
            get { return (TextWrapping)GetValue(TextWrappingProperty); }
            set { SetValue(TextWrappingProperty, value); }
        }

        public bool AcceptsReturn
        {
            get { return (bool)GetValue(AcceptsReturnProperty); }
            set { SetValue(AcceptsReturnProperty, value); }
        }
    }
}
