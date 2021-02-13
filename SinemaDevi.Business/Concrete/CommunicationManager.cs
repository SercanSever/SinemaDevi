using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SinemaDevi.Business.Concrete
{
    public class CommunicationManager : ICommunicationService
    {
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        private ICommunicationDal _communicationDal;

        public CommunicationManager(ICommunicationDal communicationDal)
        {
            _communicationDal = communicationDal;
        }

        public void Add(Communication communication)
        {
            _communicationDal.Add(communication);
        }

        public List<Communication> GetAll()
        {
            return _communicationDal.GetAll();
        }

        public string Count()
        {
            return _communicationDal.GetAll().Count().ToString();
        }

        public List<Communication> GetAllDesc()
        {
            var list = _context.Database.SqlQuery<Communication>("select * from Communication order by Id desc").ToListAsync().Result;
            return list;
        }

        public List<Communication> GetLastTen()
        {
            var list = _context.Database.SqlQuery<Communication>("select top 5* from Communication order by Id desc").ToListAsync().Result;
            return list;
        }
    }
}
