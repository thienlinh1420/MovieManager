using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DTO
{
    public class CumRapChieuPhimDTO
    {
        private int _ID;
        private string _Ten;

        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }
}
