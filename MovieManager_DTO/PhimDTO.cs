using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class PhimDTO
    {
        private int _ID;
        private String _Ten;
        private int _NamSanXuat;
        private bool _TinhTrang;
        private float _IMDb;
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
        
        public float IMDb
        {
            get { return _IMDb; }
            set { _IMDb = value; }
        }

        public bool TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        public int NamSanXuat
        {
            get { return _NamSanXuat; }
            set { _NamSanXuat = value; }
        }

        public String Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
    }
}
