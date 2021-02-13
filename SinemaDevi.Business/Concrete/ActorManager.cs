using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{//business codes.
    public class ActorManager:IActorService
    {
        private IActorDal _actorDal;

        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        public List<Actor> GetAll()
        {
            return _actorDal.GetAll();
        }

        public List<Actor> GetAllStatus()
        {
            var context = new SinemaDeviDBContext();
            var query = context.Actors.ToList();
            var result = query.Where(p => p.IsActive == true).ToList();
            return result;
        }

        public void Add(Actor actor)
        {
            _actorDal.Add(actor);
        }

        public Actor Get(int id)
        {
            return _actorDal.Get(p => p.Id == id);
        }

        public void Update(Actor actor)
        {
            _actorDal.Update(actor);
        }
    }
}
