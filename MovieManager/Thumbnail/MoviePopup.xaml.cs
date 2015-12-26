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

namespace MovieManager.Thumbnail
{
    /// <summary>
    /// Interaction logic for Popup.xaml
    /// </summary>
    public partial class MoviePopup : UserControl
    {
        public MoviePopup()
        {
            InitializeComponent();
        }
        public void SetFilmInfo(PhimDTO phimDTO)
        {
            tblFilmName.Text = phimDTO.Ten.ToUpper();
            tblIMDb.Text = "Đánh giá: " + phimDTO.IMDb.ToString();
            tblProductionYear.Text = "Năm sản xuất: " + phimDTO.NamSanXuat.ToString();
            string summary = phimDTO.TomTat;
            if (summary.Length > 160)
            {
                summary = summary.Substring(0, summary.IndexOf(' ', 160));
                summary = summary.Insert(summary.Length, "...");
            }
            tblSummary.Text = summary;
        }
    }
}
