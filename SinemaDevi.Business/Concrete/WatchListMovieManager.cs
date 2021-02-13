using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Dtos;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{
    public class WatchListMovieManager : IWatchListMovieService
    {
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        private IWatchListMovieDal _watchListMovieDal;

        public WatchListMovieManager(IWatchListMovieDal watchListMovieDal)
        {
            _watchListMovieDal = watchListMovieDal;
        }

        public void Add(WatchListMovie watchListMovieModel)
        {
            _watchListMovieDal.Add(watchListMovieModel);
        }

        public List<WatchListMovieDto> GetAllWithUserId(int userId)
        {

            var list = _context.Database.SqlQuery<WatchListMovieDto>($"select m.CoverImage,m.[Name],m.Id from WatchListMovie as w inner join Movie as m on w.MovieId = m.Id inner join [User] as u on u.Id = '{userId}' where w.IsActive = 1").ToListAsync().Result;
            return list;

        }

        public WatchListMovie Get(int id)
        {
            return _watchListMovieDal.Get(p => p.MovieId == id);
        }

        public void Update(WatchListMovie watchListMovieModel)
        {
            _watchListMovieDal.Update(watchListMovieModel);
        }
    }
}
