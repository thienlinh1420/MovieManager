using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class SuatChieuDTO
    {
        private int _ID;
        private DateTime _ThoiGian;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }

    }
}
