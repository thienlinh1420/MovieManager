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
        public List<SuatChieuDTO> GetListShowings(DateTime date)
        {
            SuatChieuDAO suatChieuDAO = new SuatChieuDAO();
            return suatChieuDAO.GetListShowings(date);
        }

        public List<TimeSpan> GetTime(int CinemaID, int FilmID, DateTime date)
        {
            SuatChieuDAO suatChieuDAO = new SuatChieuDAO();
            List<TimeSpan> listTime = suatChieuDAO.GetTime(CinemaID, FilmID, date);
            return listTime.OrderByDescending(t => t.Minutes).ToList();
        }
    }
}
