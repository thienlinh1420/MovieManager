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
    /// Interaction logic for MovieThumbnail.xaml
    /// </summary>
    public partial class MovieThumbnail : UserControl
    {
        public delegate void FilmHandler(PhimDTO phimDTO);
        public event FilmHandler ShowFilmInfo;
        public event FilmHandler WatchTrailer;

        public MovieThumbnail()
        {
            InitializeComponent();
            this.ucMoviePopup.btnFilmInfo.Click += btnFilmInfo_Click;
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            this.overlayIconButton.Visibility = System.Windows.Visibility.Visible;
            //Mouse.OverrideCursor = Cursors.Hand;
            popupMovie.IsOpen = true;
        }
        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            //Mouse.OverrideCursor = Cursors.Arrow;
            if (ucMoviePopup.IsMouseOver == false)
            {
                this.overlayIconButton.Visibility = System.Windows.Visibility.Collapsed;
                popupMovie.IsOpen = false;
            }
        }
      
        private void ucMoviePopup_MouseLeave(object sender, MouseEventArgs e)
        {
            if (ucMovieThumbnail.IsMouseOver == false)
            {
                this.overlayIconButton.Visibility = System.Windows.Visibility.Collapsed;
                //Mouse.OverrideCursor = Cursors.Arrow;
                popupMovie.IsOpen = false;
            }
        }

       
        public void SetData(PhimDTO phimDTO)
        {
            this.textFilmName.Text = phimDTO.Ten;
            BitmapImage poster = new BitmapImage(new Uri(@"/MovieManager;component/Resources/Images/" + phimDTO.PathPoster, UriKind.Relative));
            this.imgThumbnail.Source = poster;
            this.ucMoviePopup.SetFilmInfo(phimDTO.Ten, phimDTO.IMDb, phimDTO.NamSanXuat);
            this.imgThumbnail.Tag = phimDTO;
        }

        //private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    MovieInfo info = new MovieInfo();
        //    info.MovieInfoSet(infoMovie.ID);
        //    info.Show();
        //}
        private void btnFilmInfo_Click(object sender, RoutedEventArgs e)
        {
            ShowFilmInfo((PhimDTO)this.imgThumbnail.Tag);
            popupMovie.IsOpen = false;
        }

        private void textFilmName_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFilmInfo((PhimDTO)this.imgThumbnail.Tag);
            popupMovie.IsOpen = false;
        }

        private void WatchTrailerCalled(object sender, MouseButtonEventArgs e)
        {
            WatchTrailer((PhimDTO)this.imgThumbnail.Tag);
            popupMovie.IsOpen = false;
        }
    }
}
