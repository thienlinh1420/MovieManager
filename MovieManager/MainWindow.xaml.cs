using MovieManager_BUS;
using MovieManager_DTO;
using MovieManager.MovieInfo;
using MovieManager.Login_Signup;
using MovieManager.Showtimes;
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
using MovieManager.Thumbnail;

namespace MovieManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NguoiDungDTO _currentUser = null;


        public MainWindow()
        {
            InitializeComponent();
            ucHeader.Login += Login;
            ucHeader.Logout += Logout;
            ucHeader.ShowFilmsPage += ShowFilmsPage;
            ucHeader.ShowCinemasPage += ShowCinemasPage;
            ucHeader.ShowMovieShowtimes += ShowMovieShowtimes;
            ucHeader.ShowFilmInfo += ShowFilmInfo;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ShowFilmsPage();
            ShowCinemasPage();
            
        }
        private void ShowMovieShowtimes()
        {
            pnShowList.Children.Clear();
            pnShowList.ItemWidth = 1000;
            pnShowList.ItemHeight = double.NaN;
            var movieShowtimes = new MovieShowListCineplex(MovieShowListCineplex.Mode.ListShowtimes);

            pnShowList.Children.Add(movieShowtimes);
        }

        private void ShowCinemasPage()
        {
            pnShowList.Children.Clear();
            pnShowList.ItemWidth = 1000;
            pnShowList.ItemHeight = double.NaN;
            var movieShowtimes = new MovieShowListCineplex(MovieShowListCineplex.Mode.ListCinema);
           
            pnShowList.Children.Add(movieShowtimes);

        }

        private void ShowFilmsPage()
        {
            pnShowList.Children.Clear();
            pnShowList.ItemHeight = 270;
            pnShowList.ItemWidth = 180;
            PhimBUS phimBUS = new PhimBUS();
            List<PhimDTO> lstPhimDTO = phimBUS.GetListFilm();
            foreach (PhimDTO phimDTO in lstPhimDTO)
            {
                MovieThumbnail mvtn = new MovieThumbnail();
                mvtn.SetData(phimDTO);
                mvtn.ShowFilmInfo += ShowFilmInfo;
                mvtn.WatchTrailer += WatchTrailer;
                //mvtn.GotoCinema += GotoCinema;
                //mvtn.GotoShowtime += GotoShowtime;
                pnShowList.Children.Add(mvtn);
            }
        }

        public void Login()
        {

            Login login = MovieManager.Login_Signup.Login.Instance();
            login.Close += RemoveOverlayGrid;
            login.LoginSuccess += LoginSuccess;
            AddOverlayGrid(login);

        }

        private void Logout()
        {
            _currentUser = null;
        }

        private void AddOverlayGrid(Control control)
        {
            if (OverlayGrid.Children.Contains(control) == false)
            {
                OverlayGrid.Children.Add(control);
                OverlayGrid.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public void RemoveOverlayGrid(Control control)
        {
            OverlayGrid.Visibility = System.Windows.Visibility.Hidden;
            OverlayGrid.Children.Remove(control);
            //if (control.ToString() == "MovieManager.YouTubePlayer")
            //{
            //    YouTubePlayer yt = (YouTubePlayer)control;
            //    yt.DisposeWebBrower();
            //}
        }
        private void OverlayGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Grid overlayGrid = (Grid)sender;
            Control uc = (Control)overlayGrid.Children[0];
            if (uc.IsMouseOver == false)
            {
                RemoveOverlayGrid(uc);
            }
        }
        private void OverlayGrid_KeyDown(object sender, KeyEventArgs e)
        {
           switch (e.Key)
            {
                case Key.Escape:
                    {
                        Grid overlayGrid = (Grid)sender;
                        Control uc = (Control)overlayGrid.Children[0];
                        RemoveOverlayGrid(uc);
                        break;
                    }
            }
        }

        public void LoginSuccess(NguoiDungDTO nguoiDungDTO)
        {
            _currentUser = nguoiDungDTO;
            ucHeader.LoginSuccess(nguoiDungDTO);
        }

        private void ShowFilmInfo(PhimDTO phimDTO)
        {
            FilmDetail detail = FilmDetail.Instance();
            detail.Login += Login;
            detail.MovieInfoSet(phimDTO, _currentUser);
            AddOverlayGrid(detail);
            
        }

        private void WatchTrailer(PhimDTO phimDTO)
        {
            YouTubePlayer ytPlayer = YouTubePlayer.Instance();
            OverlayGrid.Children.Add(ytPlayer);
            OverlayGrid.Visibility = System.Windows.Visibility.Visible;
            ytPlayer.ShowYouTubeVideo(phimDTO.Trailer + "&autoplay=1");
        }

        private void GotoShowtime(PhimDTO phimDTO)
        {
            throw new NotImplementedException();
        }

        private void GotoCinema(PhimDTO phimDTO)
        {
            pnShowList.Children.Clear();
            pnShowList.ItemWidth = 1000;
            pnShowList.ItemHeight = double.NaN;
            var movieShowtimes = new MovieShowListCineplex(MovieShowListCineplex.Mode.ListShowtimes);

            pnShowList.Children.Add(movieShowtimes);
            RapChieuPhimBUS rapBUS = new RapChieuPhimBUS();
            RapChieuPhimDTO rapDTO = rapBUS.Search(1);
            //movieShowtimes.GotoCinema(rapDTO);
            //movieShowtimes.GotoCinema(phimDTO);
            //chưa xong!!!!!!!!!!!!
        }
    }
}
