using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class RapChieuPhimDTO
    {
        private int _ID;
        private int _IDCumRapChieuPhim;
        private string _Ten;
        private string _DiaChi;

        public int ID
        {
            get{ return _ID;}
            set { _ID = value; }
        }

        public int IDCumRapChieuPhim
        {
            get { return _IDCumRapChieuPhim; }
            set { _IDCumRapChieuPhim = value; }
        }
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
    }
}
