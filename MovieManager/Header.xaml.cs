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

namespace MovieManager
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public delegate void HeaderEventHandler();
        public event HeaderEventHandler Login;
        public event HeaderEventHandler Logout;
        public event HeaderEventHandler ShowFilmsPage;
        public event HeaderEventHandler ShowCinemasPage;
        public event HeaderEventHandler ShowMovieShowtimes;

        enum CalledEvent { Login, ShowFilmsPage, ShowCinemasPage, MovieShowtimes}
        public Header()
        {
            InitializeComponent();
            btnLogin.Tag = CalledEvent.Login;
            btnFilms.Tag = CalledEvent.ShowFilmsPage;
            btnCinemas.Tag = CalledEvent.ShowCinemasPage;
            btnMovieShowtimes.Tag = CalledEvent.MovieShowtimes;
        }

        private void btnHeader_Click(object sender, RoutedEventArgs e)
        {
            Button btnClicked = (Button)sender;
            CalledEvent calledEvent =(CalledEvent) btnClicked.Tag;
            switch (calledEvent)
            {
                case CalledEvent.Login:
                    {
                        Login();
                        break;
                    }
                case CalledEvent.ShowFilmsPage:
                    {
                        ShowFilmsPage();
                        break;
                    }
                case CalledEvent.ShowCinemasPage:
                    {
                        ShowCinemasPage();
                        break;
                    }
                case CalledEvent.MovieShowtimes:
                    {
                        ShowMovieShowtimes();
                        break;
                    }
            }
        }

        public void LoginSuccess(NguoiDungDTO nguoiDungDTO)
        {
            Profile ucProfile = new Profile(nguoiDungDTO);
            ucProfile.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            ucProfile.Width = 150;
            ucProfile.Margin = new Thickness(0, 0, 10, 0);
            ucProfile.Logout += LogoutMethod;
            btnLogin.Visibility = System.Windows.Visibility.Hidden;
            UserControlHeaderGrid.Children.Add(ucProfile);
        }

        public void LogoutMethod(Profile ucProfile)
        {
            UserControlHeaderGrid.Children.Remove(ucProfile);
            btnLogin.Visibility = System.Windows.Visibility.Visible;
            Logout();
        }
    }
}
