using MovieManager_DAO;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_BUS
{
    public class NguoiDungBUS
    {
        private NguoiDungDAO nguoiDungDAO;
        public NguoiDungBUS()
        {
            nguoiDungDAO = new NguoiDungDAO();
        }
        public NguoiDungDTO Login(String TaiKhoan, String MatKhau)
        {
            return nguoiDungDAO.Login(TaiKhoan, MatKhau);
        }
    }
}
