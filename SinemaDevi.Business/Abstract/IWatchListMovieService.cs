using SinemaDevi.Business.Dtos;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface IWatchListMovieService
    {
        void Add(WatchListMovie watchListMovieModel);
        List<WatchListMovieDto> GetAllWithUserId(int userId);
        WatchListMovie Get(int id);
        void Update(WatchListMovie watchListMovieModel);
    }
}
