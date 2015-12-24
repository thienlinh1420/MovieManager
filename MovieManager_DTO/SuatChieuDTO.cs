using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class SuatChieuDTO
    {
        private string _ID;
        private DateTime _NgayChieu;
        private TimeSpan _GioChieu;

        public TimeSpan GioChieu
        {
            get { return _GioChieu; }
            set { _GioChieu = value; }
        }

        public DateTime NgayChieu
        {
            get { return _NgayChieu; }
            set { _NgayChieu = value; }
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

     
    }
}
