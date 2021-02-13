using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{
    public class TvSeriesCategoryManager:ITvSeriesCategoryService
    {
        private ITvSeriesCategoryDal _tvSeriesCategory;

        public TvSeriesCategoryManager(ITvSeriesCategoryDal _tvSeriesCategoryDal)
        {
            _tvSeriesCategory = _tvSeriesCategoryDal;
        }

        public void Add(TvSeriesCategory tvSeriesCategory)
        {
            _tvSeriesCategory.Add(tvSeriesCategory);
        }
    }
}
