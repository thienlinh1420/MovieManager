using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class KhuyenMaiDTO
    {
        private int _ID;
        private RapChieuPhimDTO _RapChieuPhim;
        private string _Ten;
        private string _ChiTiet;
        private string _DieuKien;

        public int ID
        {
            get { return _ID;}
            set{_ID = value;}
        }

        public RapChieuPhimDTO RapChieuPhim
        {
            get { return _RapChieuPhim; }
            set { _RapChieuPhim = value; }
        }

        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        public string ChiTiet
        {
            get { return _ChiTiet; }
            set { _ChiTiet = value; }
        }

        public string DieuKien
        {
            get { return _DieuKien; }
            set { _DieuKien = value; }
        }
    }
}
