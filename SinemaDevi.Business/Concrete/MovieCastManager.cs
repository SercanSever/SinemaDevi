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
    public class MovieCastManager:IMovieCastService
    {
        private IMovieCastDal _movieCastDal;

        public MovieCastManager(IMovieCastDal movieCastDal)
        {
            _movieCastDal = movieCastDal;
        }
    }
}
