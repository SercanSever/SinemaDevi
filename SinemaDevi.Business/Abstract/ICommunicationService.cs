using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface ICommunicationService
    {
        void Add(Communication communication);
        List<Communication> GetAll();
        string Count();
        List<Communication> GetAllDesc();
        List<Communication> GetLastTen();
    }
}
