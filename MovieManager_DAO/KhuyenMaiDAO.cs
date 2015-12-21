using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieManager_DTO;

namespace MovieManager_DAO
{
    //public class KhuyenMaiDAO
    //{
    //    public List<KhuyenMaiDTO> GetListFilm()
    //    {
    //        List<KhuyenMaiDTO> lstKhuyenMaiDTO = new List<KhuyenMaiDTO>();
    //        String query = "SELECT * FROM PHIM";
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            KhuyenMaiDTO khmaiDTO = new KhuyenMaiDTO();
    //            khmaiDTO.ID = Convert.ToInt32(dr["ID"]);
    //            //RapChieuPhimDAO rapDAO = new RapChieuPhimDAO();
    //            //RapChieuPhimDTO rapDTO = rapDAO.Search(Convert.ToInt32(dr["ID_RAP_CHIEU_PHIM"]));
    //            //khmaiDTO.RapChieuPhim = rapDTO;
    //            khmaiDTO.Ten = dr["Ten"].ToString();
    //            khmaiDTO.ChiTiet = dr["Chi_tiet"].ToString();
    //            khmaiDTO.DieuKien = dr["Dieu_kien"].ToString();               
    //            lstKhuyenMaiDTO.Add(khmaiDTO);
    //        }
    //        return lstKhuyenMaiDTO;
    //    }
    //    public KhuyenMaiDTO Search(int ID)
    //    {
    //        KhuyenMaiDTO khmaiDTO = new KhuyenMaiDTO();
    //        String query = "SELECT * FROM KHUYEN_MAI WHERE ID =" + ID.ToString();
    //        DataTable dt = DataProvider.ExcuteQuery(query);
    //        if (dt.Rows.Count != 0)
    //        {
    //            khmaiDTO.ID = ID;
    //            RapChieuPhimDAO rapDAO = new RapChieuPhimDAO();
    //            RapChieuPhimDTO rapDTO = rapDAO.Search(Convert.ToInt32(dt.Rows[0]["ID_RAP_CHIEU_PHIM"]));
    //            khmaiDTO.RapChieuPhim = rapDTO;
    //            khmaiDTO.Ten = dt.Rows[0]["Ten"].ToString();
    //            khmaiDTO.ChiTiet = dt.Rows[0]["Chi_tiet"].ToString();
    //            khmaiDTO.DieuKien = dt.Rows[0]["Dieu_kien"].ToString(); 
    //            return khmaiDTO;
    //        }
    //        else
    //        {
    //            return null;
    //        }

    //    }
    //}
}
