using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{
    public class TvCastManager:ITvCastService
    {
        private ITvCastDal _tvCastDal;

        public TvCastManager(ITvCastDal tvCastDal)
        {
            _tvCastDal = tvCastDal;
        }
    }
}
