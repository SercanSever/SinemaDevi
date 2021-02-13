using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SinemaDevi.Business.Concrete
{
    public class EnteranceLogManager : IEnteranceLogService
    {
        
        private IEnteranceLogDal _enteranceLogDal;
        SinemaDeviDBContext _context = new SinemaDeviDBContext();
        public EnteranceLogManager(IEnteranceLogDal enteranceLogDal)
        {
            _enteranceLogDal = enteranceLogDal;
        }

        public void Add(EnteranceLog enteranceLog)
        {
            
            User user = _context.Users.FirstOrDefault();
            enteranceLog.UserId = Convert.ToInt32(HttpContext.Current.Session["Id"]);
            enteranceLog.EnteranceDate = DateTime.Now;
            enteranceLog.IpAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            _enteranceLogDal.Add(enteranceLog);
        }
    }

}
