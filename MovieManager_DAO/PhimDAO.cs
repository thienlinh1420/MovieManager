using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager_DTO;
using System.Data;

namespace MovieManager_DAO
{
    public class PhimDAO
    {
        public List<PhimDTO> GetListFilm()
        {
            List<PhimDTO> lstPhimDTO = new List<PhimDTO>();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from phim in context.PHIM
                       select phim;
            foreach (var item in data)
            {
                PhimDTO phimDTO = new PhimDTO();
                phimDTO.ID = item.ID;
                phimDTO.Ten = item.Ten;
                phimDTO.NamSanXuat = Convert.ToInt32(item.Nam_san_xuat);
                phimDTO.IMDb = (float)Convert.ToDouble(item.IMDb);
                phimDTO.TomTat = item.Tom_tat;
                phimDTO.PathPoster = item.Duong_dan_Poster;
                phimDTO.Trailer = item.Trailer;
                phimDTO.ThoiLuong = Convert.ToInt32(item.Thoi_luong);
                lstPhimDTO.Add(phimDTO);
            }
            return lstPhimDTO;
        }
        public PhimDTO Search(int ID)
        {
            PhimDTO phimDTO = new PhimDTO();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from phim in context.PHIM
                       where phim.ID == ID
                       select phim;
            var item = data.FirstOrDefault();
            if (item != null)
            {
                phimDTO.ID = ID;
                phimDTO.Ten = item.Ten;
                phimDTO.NamSanXuat = Convert.ToInt32(item.Nam_san_xuat);
                phimDTO.IMDb = (float)Convert.ToDouble(item.IMDb);
                phimDTO.TomTat = item.Tom_tat;
                phimDTO.PathPoster = item.Duong_dan_Poster;
                phimDTO.Trailer = item.Trailer;
                phimDTO.ThoiLuong = Convert.ToInt32(item.Thoi_luong);
                return phimDTO;
            }
            else
            {
                return null;
            }
            
        }

        public List<PhimDTO> SearchByText(String searchText)
        {
            List<PhimDTO> list = new List<PhimDTO>();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from phim in context.PHIM
                       where phim.Ten.StartsWith(searchText)
                       select phim;
           
            if (data.Count() > 0)
            {
                foreach (var item in data)
                {
                    PhimDTO phimDTO = new PhimDTO();
                    phimDTO.ID = Convert.ToInt32(item.ID);
                    phimDTO.Ten = item.Ten;
                    phimDTO.NamSanXuat = Convert.ToInt32(item.Nam_san_xuat);
                    phimDTO.IMDb = (float)Convert.ToDouble(item.IMDb);
                    phimDTO.TomTat = item.Tom_tat;
                    phimDTO.PathPoster = item.Duong_dan_Poster;
                    phimDTO.Trailer = item.Trailer;
                    phimDTO.ThoiLuong = Convert.ToInt32(item.Thoi_luong);
                    list.Add(phimDTO);
                }
            }
            return list;
        }
    }
}
