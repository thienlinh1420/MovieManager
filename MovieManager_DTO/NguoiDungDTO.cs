using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class NguoiDungDTO
    {
        private String _TaiKhoan;
        private String _MatKhau;
        private int _IDLoaiNguoiDung;
        private String _HoTen;
        private String _DiaChi;
        private DateTime _NgaySinh;
        private String _SoDienThoai;
        private String _CMND;


        public int IDLoaiNguoiDung
        {
            get { return _IDLoaiNguoiDung; }
            set { _IDLoaiNguoiDung = value; }
        }
        public String CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }

        public String SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        

        public String DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public String HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        public String MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        public String TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
    }
}
