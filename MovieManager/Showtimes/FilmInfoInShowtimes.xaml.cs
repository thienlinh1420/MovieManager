using MovieManager_DTO;
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

namespace MovieManager.Showtimes
{
    /// <summary>
    /// Interaction logic for FilmInfoInShowtimes.xaml
    /// </summary>
    public partial class FilmInfoInShowtimes : UserControl
    {
        public FilmInfoInShowtimes()
        {
            InitializeComponent();
        }

        public void SetInfo(PhimDTO phimDTO, List<TimeSpan> listTime)
        {
            tblTittle.Text = phimDTO.Ten.ToUpper();
            imgPoster.Source = new BitmapImage(new Uri(@"/MovieManager;component/Resources/Images/" + phimDTO.PathPoster, UriKind.Relative));
            foreach (var time in listTime)
            {
                Button btnTime = new Button();
                btnTime.Content = time.ToString(@"hh\:mm") + "\n  " + DateTime.Today.Add(time).ToString("tt");
                btnTime.Style = (Style)FindResource("ButtonTimeStyle");
                btnTime.Tag = time;
                pnTime.Children.Add(btnTime);
            }
        }
    }
}
