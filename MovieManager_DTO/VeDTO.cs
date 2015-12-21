using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class VeDTO
    {
        private int _ID;
        private GheDTO _Ghe;
        private int _GiaVe;
        private bool _TinhTrang;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public GheDTO Ghe
        {
            get { return _Ghe; }
            set { _Ghe = value; }
        }

        public int GiaVe
        {
            get { return _GiaVe; }
            set { _GiaVe = value; }
        }

        public bool TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
    }
}
