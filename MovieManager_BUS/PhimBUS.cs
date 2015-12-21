using MovieManager_DAO;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_BUS
{
    public class PhimBUS
    {
        private PhimDAO phimDAO;
        public PhimBUS()
        {
           phimDAO  = new PhimDAO();
        }
        public List<PhimDTO> GetListFilm()
        {
            return phimDAO.GetListFilm();
        }
        public List<PhimDTO> SearchByText(String searchText)
        {
            return phimDAO.SearchByText(searchText);
        }


    }
}
