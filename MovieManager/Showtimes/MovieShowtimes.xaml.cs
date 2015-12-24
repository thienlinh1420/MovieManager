using MovieManager_BUS;
using MovieManager_DTO;
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
using System.Windows.Controls.Primitives;

namespace MovieManager.Showtimes
{
    /// <summary>
    /// Interaction logic for MovieShowtimes.xaml
    /// </summary>
    public partial class MovieShowtimes : UserControl
    {
        public MovieShowtimes()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CumRapChieuPhimBUS cumBUS = new CumRapChieuPhimBUS();
            List<CumRapChieuPhimDTO> listCineplex = cumBUS.GetListCineplex();
            foreach (var item in listCineplex)
            {
                var cineplexIndex = new CineplexIndex();
                cineplexIndex.SetInfo(item);
                cineplexIndex.MouseLeftButtonUp += tblCineplex_MouseLeftButtonUp;
                
                wpnCineplex.Children.Add(cineplexIndex);
            }
        }

        private void tblCineplex_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selector = (CineplexIndex)sender;
            int CineplexID = (int)selector.Tag;
            var rapBUS = new RapChieuPhimBUS();
            List<RapChieuPhimDTO> listCinema = rapBUS.GetListRapChieuPhim(CineplexID);
            wpnCinema.Children.Clear();
            foreach (var item in listCinema)
            {
                var cinemaIndex = new CinemaIndex();
                cinemaIndex.SetInfo(item);
                cinemaIndex.Checked += tblCinema_Checked;
                wpnCinema.Children.Add(cinemaIndex);
            }
        }

        private void tblCinema_Checked(object sender, RoutedEventArgs e)
        {
            if (pnShowtimesInfo.Visibility == System.Windows.Visibility.Collapsed)
            {
                pnShowtimesInfo.Visibility = System.Windows.Visibility.Visible;
            }
            CinemaIndex selector =(CinemaIndex)sender;
            int CinemaID = (int)selector.Tag;
            var rapBUS = new RapChieuPhimBUS();
            var rapDTO = rapBUS.Search(CinemaID); 
            var suatChieuBUS = new SuatChieuBUS();
            List<DateTime> listDate = suatChieuBUS.GetDate();
            LoadShowtimesInfo(rapDTO, listDate);
        }

        private void btnCalendar_Checked(object sender, RoutedEventArgs e)
        {
            ButtonCalendar btnChecked = (ButtonCalendar)sender;
            DateTime date = btnChecked.Date;
            RapChieuPhimDTO rapDTO = btnChecked.RapChieuPhimDTO;
            var suatChieuBUS = new SuatChieuBUS();
            var phimBUS = new PhimBUS();
            List<PhimDTO> listFilms = phimBUS.SearchByDate(date, rapDTO);
            pnFilmInfoInShowtimes.Children.Clear();
            foreach (var film in listFilms)
            {
                List<SuatChieuDTO> listShowings = suatChieuBUS.GetListShowings(film.ID);
                FilmInfoInShowtimes filmInfo = new FilmInfoInShowtimes();
                filmInfo.SetInfo(film, listShowings);
                pnFilmInfoInShowtimes.Children.Add(filmInfo);
            }
        }

        public void LoadShowtimesInfo(RapChieuPhimDTO rapDTO, List<DateTime> listDate)
        {
            tblCinemaName.Text = rapDTO.Ten;
            pnCalendar.Children.Clear();
            foreach (var date in listDate)
            {
                
                ButtonCalendar btnCalendar = new ButtonCalendar();
                btnCalendar.SetDate(date, rapDTO);
                if (listDate.IndexOf(date) == 0)//first element
                {
                    btnCalendar.IsChecked = true;
                    btnCalendar_Checked(btnCalendar, new RoutedEventArgs());
                }
                btnCalendar.Checked += btnCalendar_Checked;
                pnCalendar.Children.Add(btnCalendar);
            }
        }

    }
}
