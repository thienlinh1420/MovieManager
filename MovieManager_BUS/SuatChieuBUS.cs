using MovieManager_DAO;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_BUS
{
    public class SuatChieuBUS
    {
        public List<DateTime> GetDate()
        {
            SuatChieuDAO suatChieuDAO = new SuatChieuDAO();
            return suatChieuDAO.GetDate();
        }
        public List<SuatChieuDTO> GetListShowings(int FilmID)
        {
            SuatChieuDAO suatChieuDAO = new SuatChieuDAO();
            return suatChieuDAO.GetListShowings(FilmID);
        }
    }
}
