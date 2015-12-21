using MovieManager_DAO;
using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_BUS
{
    public class DanhGiaBinhLuanBUS
    {
        public List<DanhGiaBinhLuanDTO> GetListComment(int FilmID)
        {
            DanhGiaBinhLuanDAO danhGiaBinhLuanDAO = new DanhGiaBinhLuanDAO();
            return danhGiaBinhLuanDAO.GetListComments(FilmID);
        }

        public bool AddComment(DanhGiaBinhLuanDTO danhGiaVaBinhLuanDTO)
        {
            DanhGiaBinhLuanDAO danhGiaVaBinhLuanDAO = new DanhGiaBinhLuanDAO();
            return danhGiaVaBinhLuanDAO.AddItem(danhGiaVaBinhLuanDTO);
        }
    }
}
