using MovieManager_BUS;
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

namespace MovieManager.Login_Signup
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private static Login _instance;
        public delegate void LoginSuccessHandler(NguoiDungDTO nguoiDungDTO);
        public delegate void ExitHandler(UserControl uc);
        public event ExitHandler Close;
        public event LoginSuccessHandler LoginSuccess;
        protected Login()
        {
            InitializeComponent();
        }

        public static Login Instance()
        {
            if (_instance == null)
            {
                _instance = new Login();
            }
            return _instance;
        }

        private void SetWarningMessage(String msg)
        {
            tbWarningMessage.Text = msg;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            NguoiDungDTO nguoiDungDTO = CheckLogin(tbUserName.Text, pbPassword.Password);
            if (nguoiDungDTO != null)
            {
                LoginSuccess(nguoiDungDTO);
                Close(this);
            }
            else
            {
                SetWarningMessage("Username hoặc Password chưa chính xác.");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close(this);
        }

        private NguoiDungDTO CheckLogin(String UserName, String Password)
        {
            NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
            return nguoiDungBUS.Login(UserName, Password);
            //return false;
        }

        private void tbUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbWatermarkUser.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                tbWatermarkUser.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void pbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

            if (pbPassword.Password == "")
            {
                tbWatermarkPass.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                tbWatermarkPass.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            _instance = null;
        }


    }
}
