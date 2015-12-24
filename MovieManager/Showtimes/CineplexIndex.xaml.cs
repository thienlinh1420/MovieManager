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
    /// Interaction logic for CineplexIndex.xaml
    /// </summary>
    public partial class CineplexIndex : UserControl
    {
        public CineplexIndex()
        {
            InitializeComponent();
        }

        public void SetInfo(CumRapChieuPhimDTO cumrapDTO)
        {
            tblName.Text = cumrapDTO.Ten;
            this.Tag = cumrapDTO.ID;
        }
       
    }
}
