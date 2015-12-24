using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager_DTO;
using System.Data;

namespace MovieManager_DAO
{
    public class RapChieuPhimDAO
    {
        public List<RapChieuPhimDTO> GetListRapChieuPhim(int CineplexID)
        {
            List<RapChieuPhimDTO> listRapDTO = new List<RapChieuPhimDTO>();
            var context = new MovieManagerDataContext();
            var data = from cinema in context.RAP_CHIEU_PHIM
                       where cinema.ID_CUM_RAP_CHIEU_PHIM == CineplexID
                       select cinema;
            foreach (var item in data)
            {
                RapChieuPhimDTO rapDTO = new RapChieuPhimDTO();
                rapDTO.ID = item.ID;
                rapDTO.IDCumRapChieuPhim = (int)item.ID_CUM_RAP_CHIEU_PHIM;
                rapDTO.Ten = item.Ten;
                rapDTO.DiaChi = item.Dia_chi;
                listRapDTO.Add(rapDTO);
            }
            return listRapDTO;
        }

        public RapChieuPhimDTO Search(int ID)
        {
            RapChieuPhimDTO rapDTO = new RapChieuPhimDTO();
            var context = new MovieManagerDataContext();
            var data = from cinema in context.RAP_CHIEU_PHIM
                       where cinema.ID == ID
                       select cinema;
            var item = data.FirstOrDefault();
            if (item != null)
            {
                rapDTO.ID = item.ID;
                rapDTO.IDCumRapChieuPhim = (int)item.ID_CUM_RAP_CHIEU_PHIM;
                rapDTO.Ten = item.Ten;
                rapDTO.DiaChi = item.Dia_chi;
                return rapDTO;
            }
            else
            {
                return null;
            }

        }

        public RAP_CHIEU_PHIM ConvertFromDTO(RapChieuPhimDTO rapDTO)
        {
            var context = new MovieManagerDataContext();
            var data = from cinema in context.RAP_CHIEU_PHIM
                       where cinema.ID == rapDTO.ID
                       select cinema;
            return (RAP_CHIEU_PHIM)data.FirstOrDefault();
        }
    }
}
