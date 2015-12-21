using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class DanhGiaBinhLuanDTO
    {
        private int _ID;
        private int _IDPhim;
        private NguoiDungDTO _NguoiDung;
        private int _DiemDanhGia;
        private string _BinhLuan;
        private DateTime _ThoiGian;

       

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int IDPhim
        {
            get { return _IDPhim; }
            set { _IDPhim = value; }
        }

        public NguoiDungDTO NguoiDung
        {
            get { return _NguoiDung; }
            set { _NguoiDung = value; }
        }

        public int DiemDanhGia
        {
            get { return _DiemDanhGia; }
            set { _DiemDanhGia = value; }
        }

        public string BinhLuan
        {
            get { return _BinhLuan; }
            set { _BinhLuan = value; }
        }

        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }

    }
}
