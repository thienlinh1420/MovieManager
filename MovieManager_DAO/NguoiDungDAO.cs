using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DAO
{
    public class NguoiDungDAO
    {
        public NguoiDungDTO Login(String TaiKhoan, String MatKhau)
        {
            NguoiDungDTO nguoiDungDTO = Search(TaiKhoan);
            if (nguoiDungDTO == null || MatKhau != nguoiDungDTO.MatKhau)
            {
                return null;
            }
            return nguoiDungDTO;
        }
        public NguoiDungDTO Search(String TaiKhoan)
        {
            NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from nguoidung in context.NGUOI_DUNG
                       where nguoidung.Tai_khoan == TaiKhoan
                       select nguoidung;
            var item = data.FirstOrDefault();
            if (item != null)
            {
                nguoiDungDTO.TaiKhoan = TaiKhoan;
                nguoiDungDTO.MatKhau = item.Mat_khau;
                nguoiDungDTO.HoTen = item.Ho_ten;
                nguoiDungDTO.DiaChi= item.Dia_chi;
                nguoiDungDTO.NgaySinh = Convert.ToDateTime(item.Ngay_sinh);
                nguoiDungDTO.SoDienThoai = item.So_dien_thoai;
                nguoiDungDTO.CMND = item.CMND;
                return nguoiDungDTO;
            }
            else
            {
                return null;
            }
        }
        public List<NguoiDungDTO> GetListUser()
        {
            List<NguoiDungDTO> lstNguoiDungDTO = new List<NguoiDungDTO>();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from nguoidung in context.NGUOI_DUNG
                       select nguoidung;
            foreach (var item in data)
            {
                NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();
                nguoiDungDTO.TaiKhoan = item.Tai_khoan;
                nguoiDungDTO.MatKhau = item.Mat_khau;
                nguoiDungDTO.HoTen = item.Ho_ten;
                nguoiDungDTO.DiaChi = item.Dia_chi;
                nguoiDungDTO.NgaySinh = Convert.ToDateTime(item.Ngay_sinh);
                nguoiDungDTO.SoDienThoai = item.So_dien_thoai;
                nguoiDungDTO.CMND = item.CMND;
                lstNguoiDungDTO.Add(nguoiDungDTO);
            }
            return lstNguoiDungDTO;
        }
    }
}
