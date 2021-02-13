using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie Get(int id);
        void Update(Movie movie);
        List<Movie> GetAllStatus();
        void Add(Movie movie);
        List<Movie> GetAllByCategoryId(int categoryId);
        List<Movie> GetAllWithIsActive();
        List<Movie> GetLastFive();
        List<Movie> GetAllWithSearch(string text);
    }
}
