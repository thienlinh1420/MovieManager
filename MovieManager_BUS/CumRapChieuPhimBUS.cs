using MovieManager_DAO;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_BUS
{
    public class CumRapChieuPhimBUS
    {
        public List<CumRapChieuPhimDTO> GetListCineplex()
        {
            CumRapChieuPhimDAO cumDAO = new CumRapChieuPhimDAO();
            return cumDAO.GetListCineplex();
        }
    }
}
