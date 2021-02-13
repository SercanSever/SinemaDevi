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
    public class WatchListTvManager:IWatchListTvService
    {
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        private IWatchListTvDal _watchListTvDal;
        public WatchListTvManager(IWatchListTvDal watchListTvDal)
        {
            _watchListTvDal = watchListTvDal;
        }

        public void Add(WatchListTv watchListTv)
        {
            _watchListTvDal.Add(watchListTv);
        }

        public List<WatchListTvDto> GetAllWithUserId(int userId)
        {
            var list = _context.Database.SqlQuery<WatchListTvDto>($"select t.CoverImage,t.[Name],t.Id from WatchListTv as w inner join Tv as t on w.TvSeriesId = t.Id inner join [User] as u on u.Id = '{userId}' where w.IsActive = 1").ToListAsync().Result;
            return list;
        }

        public WatchListTv Get(int id)
        {
            return _watchListTvDal.Get(p => p.TvSeriesId == id);
        }

        public void Update(WatchListTv watchListTvModel)
        {
            _watchListTvDal.Update(watchListTvModel);
        }
    }
}
