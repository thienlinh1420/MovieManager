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
        public List<SuatChieuDTO> GetListFilm()
        {
            List<SuatChieuDTO> lstSuatChieuDTO = new List<SuatChieuDTO>();
            String query = "SELECT * FROM SUAT_CHIEU";
            DataTable dt = DataProvider.ExcuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
                suatChieuDTO.ID = Convert.ToInt32(dr["ID"]);
                suatChieuDTO.ThoiGian = Convert.ToDateTime(dr["Thoi_gian"]);
                lstSuatChieuDTO.Add(suatChieuDTO);
            }
            return lstSuatChieuDTO;
        }
        public SuatChieuDTO Search(int ID)
        {
            SuatChieuDTO suatChieuDTO = new SuatChieuDTO();
            String query = "SELECT * FROM SUAT_CHIEU WHERE ID =" + ID.ToString();
            DataTable dt = DataProvider.ExcuteQuery(query);
            if (dt.Rows.Count != 0)
            {
                suatChieuDTO.ID = ID;
                suatChieuDTO.ThoiGian = Convert.ToDateTime(dt.Rows[0]["Thoi_gian"]);
                return suatChieuDTO;
            }
            else
            {
                return null;
            }

        }
    }
}
