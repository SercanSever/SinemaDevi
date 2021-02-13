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
    public class ToDoListManager : IToDoListService
    {
        private IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void Add(ToDoList toDoList)
        {
            _toDoListDal.Add(toDoList);
        }

        public void Delete(ToDoList toDoList)
        {
            _toDoListDal.Delete(toDoList);
        }

        public ToDoList Get(int id)
        {
            return _toDoListDal.Get(p => p.Id == id);
        }

        public List<ToDoList> GetAll()
        {
            return _toDoListDal.GetAll();
        }
    }
}
