using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class GheDTO
    {
        private int _ID;
        private string _ViTri;
        private string _LoaiGhe;
        private string _Phong;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string ViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; }
        }

        public string LoaiGhe
        {
            get { return _LoaiGhe; }
            set { _LoaiGhe = value; }
        }

        public string Phong
        {
            get { return _Phong; }
            set { _Phong = value; }
        }
    }
}
