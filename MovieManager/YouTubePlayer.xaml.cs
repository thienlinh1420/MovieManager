using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MovieManager_BUS;

namespace MovieManager
{
    /// <summary>
    /// Interaction logic for YouTubePlayer.xaml
    /// </summary>
    public partial class YouTubePlayer : UserControl
    {
        private static YouTubePlayer _instance;
        protected YouTubePlayer()
        {
            InitializeComponent();
        }

        public static YouTubePlayer Instance()
        {
            if (_instance == null)
            {
                _instance = new YouTubePlayer();
            }
            return _instance;
        }

        public void ShowYouTubeVideo(String videoCode)
        {
            //videoCode += "&autoplay=1";
            WebBrowserExtensions.ShowYouTubeVideo(wbYouTubePlayer, videoCode);
        }
        public void DisposeWebBrower()
        {
            wbYouTubePlayer.Dispose();
            
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            DisposeWebBrower();
            _instance = null;
        }


        
    }
}
