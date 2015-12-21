using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieManager_DTO;

namespace MovieManager_DAO
{
    public class DanhGiaBinhLuanDAO
    {
        public List<DanhGiaBinhLuanDTO> GetListComments(int FilmID)
        {
            List<DanhGiaBinhLuanDTO> lstDanhgiaDTO = new List<DanhGiaBinhLuanDTO>();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from danhGiaVaBinhLuan in context.DANH_GIA_VA_BINH_LUAN
                    where danhGiaVaBinhLuan.ID_PHIM == FilmID
                    select danhGiaVaBinhLuan;
            //String query = "SELECT * FROM DANH_GIA_VA_BINH_LUAN WHERE ID_PHIM = " + FilmID.ToString();
            //DataTable dt = DataProvider.ExcuteQuery(query);
            foreach (var item in data)
            {
                DanhGiaBinhLuanDTO danhgiaDTO = new DanhGiaBinhLuanDTO();
                danhgiaDTO.ID = item.ID;
                danhgiaDTO.IDPhim = FilmID;
                NguoiDungDAO nguoidungDAO = new NguoiDungDAO();
                NguoiDungDTO nguoidungDTO = nguoidungDAO.Search(item.ID_NGUOI_DUNG);
                danhgiaDTO.NguoiDung = nguoidungDTO;
                danhgiaDTO.DiemDanhGia = (int)item.Diem_danh_gia;
                danhgiaDTO.BinhLuan = item.Binh_luan;
                danhgiaDTO.ThoiGian = (DateTime)item.Thoi_gian;
                lstDanhgiaDTO.Add(danhgiaDTO);
            }
            return lstDanhgiaDTO;
        }

        public DanhGiaBinhLuanDTO Search(int ID)
        {
            DanhGiaBinhLuanDTO danhgiaDTO = new DanhGiaBinhLuanDTO();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from danhGiaVaBinhLuan in context.DANH_GIA_VA_BINH_LUAN
                       where danhGiaVaBinhLuan.ID == ID
                       select danhGiaVaBinhLuan;
            DANH_GIA_VA_BINH_LUAN item = data.FirstOrDefault();
            if (item != null)
            {
                danhgiaDTO.ID = ID;                
                danhgiaDTO.IDPhim = Convert.ToInt32(item.ID_PHIM);
                NguoiDungDAO nguoidungDAO = new NguoiDungDAO();
                NguoiDungDTO nguoidungDTO = nguoidungDAO.Search(item.ID_NGUOI_DUNG);
                danhgiaDTO.NguoiDung = nguoidungDTO;
                danhgiaDTO.DiemDanhGia = (int)item.Diem_danh_gia;
                danhgiaDTO.BinhLuan = item.Binh_luan;
                danhgiaDTO.ThoiGian = (DateTime)item.Thoi_gian;
                return danhgiaDTO;
            }
            else
            {
                return null;
            }
        }

        public bool AddItem(DanhGiaBinhLuanDTO danhGiaVaBinhLuanDTO)
        {
            try
            {
                DANH_GIA_VA_BINH_LUAN item = new DANH_GIA_VA_BINH_LUAN();
                item.ID = danhGiaVaBinhLuanDTO.ID;
                item.ID_NGUOI_DUNG = danhGiaVaBinhLuanDTO.NguoiDung.TaiKhoan;
                item.ID_PHIM = danhGiaVaBinhLuanDTO.IDPhim;
                item.Diem_danh_gia = danhGiaVaBinhLuanDTO.DiemDanhGia;
                item.Binh_luan = danhGiaVaBinhLuanDTO.BinhLuan;
                item.Thoi_gian = danhGiaVaBinhLuanDTO.ThoiGian;

                MovieManagerDataContext context = new MovieManagerDataContext();
                context.DANH_GIA_VA_BINH_LUAN.Add(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
