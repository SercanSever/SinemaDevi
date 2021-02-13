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
    public class ExceptionLogManager:IExceptionLogService
    {
        SinemaDeviDBContext _sinemaDeviDBContext = new SinemaDeviDBContext();
        private IExceptionLogDal _exceptionLogDal;

        public ExceptionLogManager(IExceptionLogDal exceptionLogDal)
        {
            _exceptionLogDal = exceptionLogDal;
        }

        public List<ExceptionLog> GetAll()
        {
            return _exceptionLogDal.GetAll();
        }

        public void Add(ExceptionLog exception)
        {
            _exceptionLogDal.Add(exception);
        }

        public string Count()
        {
            return _exceptionLogDal.GetAll().Count().ToString();
        }
    }
}
