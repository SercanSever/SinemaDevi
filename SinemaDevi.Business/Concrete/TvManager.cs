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
    public class TvManager : ITvService
    {
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        private ITvDal _tvDal;

        public TvManager(ITvDal tvDal)
        {
            _tvDal = tvDal;
        }

        public List<Tv> GetAll()
        {
            return _tvDal.GetAll();
        }

        public void Update(Tv tvModel)
        {
            _tvDal.Update(tvModel);
        }

        public Tv Get(int id)
        {
            return _tvDal.Get(p => p.Id == id);
        }

        public void Add(Tv tv)
        {
            _tvDal.Add(tv);
        }

        public List<Tv> GetAllStatus()
        {
            var list = _context.Database.SqlQuery<Tv>("select top 10* from Tv t where t.IsActive=1 order by Id desc").ToListAsync().Result;
            return list;
        }

        public List<Tv> GetAllByCategoryId(int categoryId)
        {
            string sql = $"select * from Tv t inner join TvSeriesCategory tc on t.Id = tc.TvSeriesId inner join Category c on c.Id = '{categoryId}' where c.Id = tc.CategoryId and t.IsActive = 1";
            var list = _context.Database.SqlQuery<Tv>(sql).ToListAsync().Result;
            return list;
        }

        public List<Tv> GetAllWithSearch(string text)
        {
            return _tvDal.GetAll().Where(p => p.Name.Contains(text)).Where(p=>p.IsActive==true).ToList();
        }
    }
}
