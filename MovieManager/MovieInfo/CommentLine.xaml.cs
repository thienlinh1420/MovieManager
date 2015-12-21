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

namespace MovieManager.MovieInfo
{
    /// <summary>
    /// Interaction logic for CommentLine.xaml
    /// </summary>
    public partial class CommentLine : UserControl
    {
        public CommentLine()
        {
            InitializeComponent();
        }

        public void SetComment(DanhGiaBinhLuanDTO danhGiaBinhLuanDTO)
        {
            tblName.Text = danhGiaBinhLuanDTO.NguoiDung.HoTen;
            if (danhGiaBinhLuanDTO.DiemDanhGia != -1)
            {
                tblPoint.Text = danhGiaBinhLuanDTO.DiemDanhGia.ToString();
            }
            tblContent.Text = danhGiaBinhLuanDTO.BinhLuan;
            tblTime.Text = danhGiaBinhLuanDTO.ThoiGian.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
