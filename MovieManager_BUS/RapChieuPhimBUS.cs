using MovieManager_DAO;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_BUS
{
    public class RapChieuPhimBUS
    {
        public List<RapChieuPhimDTO> GetListRapChieuPhim(int CineplexID)
        {
            RapChieuPhimDAO rapDAO = new RapChieuPhimDAO();
            return rapDAO.GetListRapChieuPhim(CineplexID);
        }
        public RapChieuPhimDTO Search(int CinemaID)
        {
            RapChieuPhimDAO rapDAO = new RapChieuPhimDAO();
            return rapDAO.Search(CinemaID);
        }
    }
}
