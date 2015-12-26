using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager_DTO;
using System.Data;

namespace MovieManager_DAO
{
    public class SuatChieuDAO
    {
        //public List<SuatChieuDTO> GetListFilm()
        //{
        //    List<SuatChieuDTO> lstSuatChieuDTO = new List<SuatChieuDTO>();
        //    String query = "SELECT * FROM SUAT_CHIEU";
        //    DataTable dt = DataProvider.ExcuteQuery(query);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
        //        suatChieuDTO.ID = Convert.ToInt32(dr["ID"]);
        //        suatChieuDTO.ThoiGian = Convert.ToDateTime(dr["Thoi_gian"]);
        //        lstSuatChieuDTO.Add(suatChieuDTO);
        //    }
        //    return lstSuatChieuDTO;
        //}
        //public SuatChieuDTO Search(int ID)
        //{
        //    SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
        //    String query = "SELECT * FROM SUAT_CHIEU WHERE ID =" + ID.ToString();
        //    DataTable dt = DataProvider.ExcuteQuery(query);
        //    if (dt.Rows.Count != 0)
        //    {
        //        suatChieuDTO.ID = ID;
        //        suatChieuDTO.ThoiGian = Convert.ToDateTime(dt.Rows[0]["Thoi_gian"]);
        //        return suatChieuDTO;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}
        public List<SuatChieuDTO> SearchByTime(DateTime date)
        {
            date = DateTime.Now.Date;
            List<SuatChieuDTO> lstSuatChieuDTO = new List<SuatChieuDTO>();
            var context = new MovieManagerDataContext();
            var data = from showings in context.SUAT_CHIEU
                       where showings.Ngay_chieu == date
                       //where showings.ID == "12012015T03"
                       select showings;
           
            if (data.Count() > 0)
            {
                foreach (var item in data)
                {
                    SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
                    suatChieuDTO.ID = item.ID;
                    suatChieuDTO.NgayChieu = (DateTime)item.Ngay_chieu;
                    suatChieuDTO.GioChieu = (TimeSpan)item.Gio_chieu;
                    lstSuatChieuDTO.Add(suatChieuDTO);
                }
            }
             return lstSuatChieuDTO;
        }

       public List<DateTime> GetDate()
        {
            List<DateTime> listDate = new List<DateTime>();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from date in context.SUAT_CHIEU
                       group date by date.Ngay_chieu into myGroup
                       select myGroup.FirstOrDefault().Ngay_chieu;
           foreach(var item in data)
           {
               listDate.Add((DateTime)item);
           }
           return listDate;
        }

       public List<SuatChieuDTO> GetListShowings(int FilmID)
       {
           List<SuatChieuDTO> listShowings = new List<SuatChieuDTO>();
           MovieManagerDataContext context = new MovieManagerDataContext();
           var data = from film in context.PHIM
                      where film.ID == FilmID
                      select film.SUAT_CHIEU;

           foreach (var item in data)
           {
               SuatChieuDTO showings = new SuatChieuDTO();
               item.First().ID = showings.ID;
               item.First().Ngay_chieu = showings.NgayChieu;
               item.First().Gio_chieu = showings.GioChieu;
               listShowings.Add(showings);
           }
           return listShowings;
       }
    }
}
