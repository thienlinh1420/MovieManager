using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieManager_DTO;

namespace MovieManager_DAO
{
    //public class Ve
    //{
    //    public List<VeDTO> GetListFilm()
    //    {
    //        List<VeDTO> lstVeDTO = new List<VeDTO>();
    //        String query = "SELECT * FROM VE";
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            VeDTO veDTO = new VeDTO();
    //            veDTO.ID = Convert.ToInt32(dr["ID"]);
    //            //GheDAO gheDAO = new GheDAO();
    //            //GheDTO gheDTO = gheDAO.Search(Convert.ToInt32(dr["ID_GHE"]));
    //            veDTO.GiaVe = Convert.ToInt32(dr["Gia_ve"]);
    //            veDTO.TinhTrang = Convert.ToBoolean(dr["Tinh_trang"]);
    //            lstVeDTO.Add(veDTO);
    //        }
    //        return lstVeDTO;
    //    }
    //    public VeDTO Search(int ID)
    //    {
    //        VeDTO veDTO = new VeDTO();
    //        String query = "SELECT * FROM VE WHERE ID =" + ID.ToString();
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        if (dt.Rows.Count != 0)
    //        {
    //            veDTO.ID = ID;
    //            GheDAO gheDAO = new GheDAO();
    //            GheDTO gheDTO = gheDAO.Search(Convert.ToInt32(dt.Rows[0]["ID_GHE"]));
    //            veDTO.GiaVe = Convert.ToInt32(dt.Rows[0]["Gia_ve"]);
    //            veDTO.TinhTrang = Convert.ToBoolean(dt.Rows[0]["Tinh_trang"]);
    //            return veDTO;
    //        }
    //        else
    //        {
    //            return null;
    //        }

    //    }
    //}
}
