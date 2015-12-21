using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        private NguoiDungDTO nguoiDungDTO;
        public delegate void LogoutHandler(Profile ucProfile);
        public event LogoutHandler Logout;
        enum CalledEvent { Logout }
        public Profile(NguoiDungDTO nguoiDungDTO)
        {
            InitializeComponent();
            this.nguoiDungDTO = nguoiDungDTO;
            SetNameProfile();
            menuItemLogout.Tag = CalledEvent.Logout;
        }
        public void SetNameProfile()
        {
            ProfileName.Label = nguoiDungDTO.HoTen;
        }


        private void RibbonSplitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            RibbonSplitMenuItem menuItem = (RibbonSplitMenuItem)sender;
            CalledEvent calledEvent = (CalledEvent)menuItem.Tag;
            switch (calledEvent)
            {
                case CalledEvent.Logout:
                    {
                        Logout(this);
                        break;
                    }
            }
        }

    }
}
