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

namespace MovieManager.SearchBox
{
    /// <summary>
    /// Interaction logic for SearchBox.xaml
    /// </summary>
    public partial class SearchBox : UserControl
    {
        public delegate void ShowFilmInfoHandler(PhimDTO phimDTO);
        public event ShowFilmInfoHandler ShowFilmInfo;
        public SearchBox()
        {
            InitializeComponent();
            ucAutoCompleteTextBox.Item_Click += Item_Click;
        }

        private void Item_Click(PhimDTO phimDTO)
        {
            ShowFilmInfo(phimDTO);
        }
    }
}
