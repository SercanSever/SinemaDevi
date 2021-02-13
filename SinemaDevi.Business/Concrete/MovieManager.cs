using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{

    public class MovieManager : IMovieService
    {
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        private IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetAll();
        }

        public Movie Get(int id)
        {
            return _movieDal.Get(p => p.Id == id);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }

        public List<Movie> GetAllStatus()
        {
            var list = _context.Database.SqlQuery<Movie>("select top 10* from Movie m where m.IsActive=1 order by Id desc").ToListAsync().Result;
            return list;
        }

        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public List<Movie> GetAllByCategoryId(int categoryId)
        {
            string sql = $"select * from Movie m inner join MovieCategory mc on m.Id = mc.MovieId inner join Category c on c.Id = mc.CategoryId where c.Id = '{categoryId}' and m.IsActive = 1";
            var list = _context.Database.SqlQuery<Movie>(sql).ToListAsync().Result;
            return list;
        }

        public List<Movie> GetAllWithIsActive()
        {
            var list = _context.Database.SqlQuery<Movie>("select * from Movie m where m.IsActive=1").ToListAsync().Result;
            return list;
        }

        public List<Movie> GetLastFive()
        {
            var list = _context.Database.SqlQuery<Movie>("select top 5* from Movie order by Id desc").ToListAsync().Result;
            return list;

        }

        public List<Movie> GetAllWithSearch(string text)
        {
            return _movieDal.GetAll().Where(p => p.Name.Contains(text)).Where(p=>p.IsActive==true).ToList();
        }
    }
}
