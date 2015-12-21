using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MovieManager_DTO
{
    public class ThongTinPhimDTO
    {
        private int _ID;
        private String _TomTat;
        private String _PathPoster;
        private String _Trailer;
        private int _ThoiLuong;

        public int ThoiLuong
        {
            get { return _ThoiLuong; }
            set { _ThoiLuong = value; }
        }

        public String Trailer
        {
            get { return _Trailer; }
            set { _Trailer = value; }
        }

        public String PathPoster
        {
            get { return _PathPoster; }
            set { _PathPoster = value; }
        }

        public String TomTat
        {
            get { return _TomTat; }
            set { _TomTat = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }
}