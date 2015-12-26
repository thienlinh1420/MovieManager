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

       public List<SuatChieuDTO> GetListShowings(DateTime date)
       {
           List<SuatChieuDTO> listShowings = new List<SuatChieuDTO>();
           MovieManagerDataContext context = new MovieManagerDataContext();
           
               var data = from showing in context.SUAT_CHIEU
                          where showing.Ngay_chieu == date
                          select showing;

               foreach (var item in data)
               {
                   SuatChieuDTO showings = new SuatChieuDTO();
                   showings.ID = item.ID;
                   showings.NgayChieu = (DateTime)item.Ngay_chieu;
                   showings.GioChieu = (TimeSpan)item.Gio_chieu;
                   listShowings.Add(showings);
               }
           
           return listShowings;
       }

       public List<TimeSpan> GetTime(int CinemaID, int FilmID, DateTime date)
       {
           List<TimeSpan> listTime = new List<TimeSpan>();
           MovieManagerDataContext context = new MovieManagerDataContext();

           var data = from showing in context.DANH_SACH_PHIM
                      join sc in context.SUAT_CHIEU on showing.ID_SUAT_CHIEU equals sc.ID
                      where showing.ID_RAP_CHIEU_PHIM == CinemaID && showing.ID_PHIM == FilmID &&
                            sc.Ngay_chieu == date
                      select sc;

           foreach (var item in data)
           {
               listTime.Add((TimeSpan)item.Gio_chieu);
           }
           return listTime;
       }
    }
}
