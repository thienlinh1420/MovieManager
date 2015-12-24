using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager_DAO
{
    public class CumRapChieuPhimDAO
    {
        public List<CumRapChieuPhimDTO> GetListCineplex()
        {
            List<CumRapChieuPhimDTO> listCineplex = new List<CumRapChieuPhimDTO>();
            MovieManagerDataContext context = new MovieManagerDataContext();
            var data = from cum in context.CUM_RAP_CHIEU_PHIM
                       select cum;
            foreach (var item in data)
            {
                CumRapChieuPhimDTO cumRapChieuPhimDTO = new CumRapChieuPhimDTO();
                cumRapChieuPhimDTO.ID = item.ID;
                cumRapChieuPhimDTO.Ten = item.Ten;
                
                listCineplex.Add(cumRapChieuPhimDTO);
            }
            return listCineplex;
        }
    }
}
