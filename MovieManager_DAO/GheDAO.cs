using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieManager_DTO;

namespace MovieManager_DAO
{
    //public class GheDAO
    //{
    //    public List<GheDTO> GetListFilm()
    //    {
    //        List<GheDTO> lstGheDTO = new List<GheDTO>();
    //        String query = "SELECT * FROM GHE";
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            GheDTO gheDTO = new GheDTO();
    //            gheDTO.ID = Convert.ToInt32(dr["ID"]);
    //            gheDTO.ViTri = dr["Vi_tri_ghe"].ToString();
    //            gheDTO.LoaiGhe = dr["Loai_ghe"].ToString();
    //            gheDTO.Phong = dr["Phong"].ToString();
    //            lstGheDTO.Add(gheDTO);
    //        }
    //        return lstGheDTO;
    //    }
    //    public GheDTO Search(int ID)
    //    {
    //        GheDTO gheDTO = new GheDTO();
    //        String query = "SELECT * FROM GHE WHERE ID =" + ID.ToString();
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        if (dt.Rows.Count != 0)
    //        {
    //            gheDTO.ID = ID;
    //            gheDTO.ViTri = dt.Rows[0]["Vi_tri_ghe"].ToString();
    //            gheDTO.LoaiGhe= dt.Rows[0]["Loai_ghe"].ToString();
    //            gheDTO.Phong = dt.Rows[0]["Phong"].ToString();
    //            return gheDTO;
    //        }
    //        else
    //        {
    //            return null;
    //        }

    //    }
    //}
}
