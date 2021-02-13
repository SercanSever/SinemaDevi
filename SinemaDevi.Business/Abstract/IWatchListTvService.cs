using SinemaDevi.Business.Dtos;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface IWatchListTvService
    {
        void Add(WatchListTv watchListTv);
        List<WatchListTvDto> GetAllWithUserId(int userId);
        WatchListTv Get(int id);
        void Update(WatchListTv watchListTvModel);
    }
}
