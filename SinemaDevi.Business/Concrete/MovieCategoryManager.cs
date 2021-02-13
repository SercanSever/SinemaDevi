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
    public class MovieCategoryManager:IMovieCategoryService
    {
        private IMovieCategory _movieCategory;

        public MovieCategoryManager(IMovieCategory movieCategory)
        {
            _movieCategory = movieCategory;
        }

        public void Add(MovieCategory movieCategory)
        {
            _movieCategory.Add(movieCategory);
        }
    }
}
