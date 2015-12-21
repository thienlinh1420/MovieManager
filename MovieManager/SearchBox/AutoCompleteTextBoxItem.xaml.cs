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
    /// Interaction logic for AutoCompleteTextBoxItem.xaml
    /// </summary>
    public partial class AutoCompleteTextBoxItem : UserControl
    {
        public AutoCompleteTextBoxItem()
        {
            InitializeComponent();
        }

        public void SetData(PhimDTO phimDTO)
        {
            BitmapImage source = new BitmapImage(new Uri(@"/MovieManager;component/Resources/Images/" + phimDTO.PathPoster, UriKind.Relative));
            imgPoster.Source = source;
            tblFilmName.Text = phimDTO.Ten;
            this.Tag = phimDTO;
        }
    }
}
