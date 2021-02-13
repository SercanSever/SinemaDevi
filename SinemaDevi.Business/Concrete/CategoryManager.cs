using SinemaDevi.Business.Abstract;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Concrete
{


    public class CategoryManager : ICategoryService
    {
       
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetAllByStatus()
        {
            var context = new SinemaDeviDBContext();
            var query = context.Categories.ToList();
            var result = query.Where(p => p.IsActive == true).ToList();
            return result;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(p => p.Id == id);
        }

    }
}
