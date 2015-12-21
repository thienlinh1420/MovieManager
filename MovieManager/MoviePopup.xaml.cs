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
    /// Interaction logic for Popup.xaml
    /// </summary>
    public partial class MoviePopup : UserControl
    {
        public MoviePopup()
        {
            InitializeComponent();
        }
        public void SetFilmInfo(String FilmName, float IMDb, int ProductionYear)
        {
            tblFilmName.Text = FilmName.ToUpper();
            tblIMDb.Text = "Đánh giá: " + IMDb.ToString();
            tblProductionYear.Text = "Năm sản xuất: " + ProductionYear.ToString();
        }
    }
}
