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
using System.Windows.Shapes;
using MovieManager_DTO;
using MovieManager_BUS;
using System.Windows.Controls.Primitives;

namespace MovieManager.MovieInfo
{
    /// <summary>
    /// Interaction logic for MovieInfo.xaml
    /// </summary>
    public partial class FilmDetail : UserControl
    {
        private static FilmDetail _instance;
        PhimDTO phimDTO;
        NguoiDungDTO nguoiDungDTO;
        public delegate void LoginHandler();
        public event LoginHandler Login;
        protected FilmDetail()
        {
            InitializeComponent();
        }

        public static FilmDetail Instance()
        {
            if (_instance == null)
            {
                _instance = new FilmDetail();
            }
            return _instance;
        }

        public void MovieInfoSet(PhimDTO phimDTO, NguoiDungDTO nguoiDungDTO)
        {

            if (phimDTO != null)
            {
                lbTen.Content = phimDTO.Ten;
                lbNam.Content = phimDTO.NamSanXuat;
                lbDiem.Content = phimDTO.IMDb;
                this.phimDTO = phimDTO;

                BitmapImage poster = new BitmapImage(new Uri(@"/MovieManager;component/Resources/Images/" + phimDTO.PathPoster, UriKind.Relative));
                this.imgFilm.Source = poster;

                txtInfo.Text = phimDTO.TomTat;
                lbTime.Content = phimDTO.ThoiLuong;

                //Tab summary
                tblSummary.Text = phimDTO.TomTat;
                
                //Tab Comment
                if (nguoiDungDTO != null)
                {
                    gridLogin.Visibility = System.Windows.Visibility.Hidden;
                    gridCmt.Visibility = System.Windows.Visibility.Visible;
                    this.nguoiDungDTO = nguoiDungDTO;
                }

                DanhGiaBinhLuanBUS danhGiaBinhLuanBUS = new DanhGiaBinhLuanBUS();
                List<DanhGiaBinhLuanDTO> lstCmt = danhGiaBinhLuanBUS.GetListComment(phimDTO.ID);
                //List<CommentLine> lstCmtLine = new List<CommentLine>();
                //var cmt = lstCmt[0];
                if (lstCmt.Count > 0)
                {
                    foreach (var cmt in lstCmt)
                    //for (int i = 0; i < 10; i++ )
                    {
                        AddComment(cmt);
                    }
                }

                //Tab Trailer
                YouTubePlayer ytPlayer = YouTubePlayer.Instance();
                gridTrailerTab.Children.Add(ytPlayer);
                ytPlayer.ShowYouTubeVideo(phimDTO.Trailer);
            }
        }

        public void AddComment(DanhGiaBinhLuanDTO danhGiaVaBinhLuanDTO)
        {
            CommentLine cmtLine = new CommentLine();
            cmtLine.SetComment(danhGiaVaBinhLuanDTO);
            spComment.Children.Add(cmtLine);
        }
        private void btnSendCmt_Click(object sender, RoutedEventArgs e)
        {
            if (tbCmt.Text == "")
            {
                tblWarning.Visibility = System.Windows.Visibility.Visible;
                return;
            }
            DanhGiaBinhLuanBUS danhGiaBus = new DanhGiaBinhLuanBUS();
            DanhGiaBinhLuanDTO danhGiaDTO = new DanhGiaBinhLuanDTO();

            danhGiaDTO.IDPhim = phimDTO.ID;
            danhGiaDTO.NguoiDung = nguoiDungDTO;
            danhGiaDTO.BinhLuan = tbCmt.Text;
            danhGiaDTO.DiemDanhGia = cbbPoint.SelectedIndex;
            danhGiaDTO.ThoiGian = DateTime.Now;
            AddComment(danhGiaDTO);
            danhGiaBus.AddComment(danhGiaDTO);
            tbCmt.Text = "";
            if (tblWarning.Visibility == System.Windows.Visibility.Visible)
            {
                tblWarning.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void tblLogin_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Grid OverlayGrid = (Grid)this.Parent;
            OverlayGrid.Children.Clear();
            OverlayGrid.Visibility = System.Windows.Visibility.Collapsed;
            Login();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            YouTubePlayer ytPlayer = (YouTubePlayer)gridTrailerTab.Children[0];
            ytPlayer.DisposeWebBrower();
            _instance = null;
        }


    }
}
