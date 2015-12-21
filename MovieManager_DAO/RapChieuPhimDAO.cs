using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager_DTO;
using System.Data;

namespace MovieManager_DAO
{
    //public class RapChieuPhimDAO
    //{
    //    public List<RapChieuPhimDTO> GetListRapChieuPhim()
    //    {
    //        List<RapChieuPhimDTO> lstRapDTO = new List<RapChieuPhimDTO>();
    //        String query = "SELECT * FROM RAP_CHIEu_PHIM";
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        foreach(DataRow dr in dt.Rows)
    //        {
    //            RapChieuPhimDTO rapDTO = new RapChieuPhimDTO();
    //            rapDTO.ID = Convert.ToInt32(dr["ID"]);
    //            rapDTO.Ten = dr["Ten"].ToString();
    //            rapDTO.DiaChi = dr["Dia_chi"].ToString();
    //            lstRapDTO.Add(rapDTO);
    //        }
    //        return lstRapDTO;
    //    }

    //    public RapChieuPhimDTO Search(int ID)
    //    {
    //        RapChieuPhimDTO rapDTO = new RapChieuPhimDTO();
    //        String query = "SELECT * FROM RAP_CHIEU_PHIM WHERE ID =" + ID.ToString();
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        if(dt.Rows.Count != 0)
    //        {
    //            rapDTO.ID = ID;
    //            rapDTO.Ten = dt.Rows[0]["Ten"].ToString();
    //            rapDTO.DiaChi = dt.Rows[0]["Dia_chi"].ToString();
    //            return rapDTO;
    //        }
    //        else
    //        {
    //            return null;
    //        }
            
    //    }
    //}
}
