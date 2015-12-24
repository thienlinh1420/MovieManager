using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MovieManager.Showtimes
{
    public class CinemaIndex : RadioButton
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(CinemaIndex), new FrameworkPropertyMetadata(string.Empty));
        public string Text
        {
            get { return (string)GetValue(TextProperty); }

            set { SetValue(TextProperty, value); }
        }

        public void SetInfo(RapChieuPhimDTO rapChieuPhimDTO)
        {
            Text = rapChieuPhimDTO.Ten;
            this.Tag = rapChieuPhimDTO.ID;
        }
        public CinemaIndex()
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("/MovieManager;component/Resources/Styles/CinemaIndex.xaml", UriKind.Relative);
            this.Style = (Style)dictionary["CinemaIndexStyle"];
        }
    }
}
