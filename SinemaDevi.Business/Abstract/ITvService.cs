using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface ITvService
    {
        List<Tv> GetAll();
        void Update(Tv tvModel);
        Tv Get(int id);
        void Add(Tv tv);
        List<Tv> GetAllStatus();
        List<Tv> GetAllByCategoryId(int categoryId);
        List<Tv> GetAllWithSearch(string text);
    }
}
