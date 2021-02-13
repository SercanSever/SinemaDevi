using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface IActorService
    {
        List<Actor> GetAll();
        List<Actor> GetAllStatus();
        void Add(Actor actor);
        Actor Get(int id);
        void Update(Actor actor);
    }
}
