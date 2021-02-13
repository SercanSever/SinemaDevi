using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface IToDoListService
    {
        List<ToDoList> GetAll();
        void Add(ToDoList toDoList);
        ToDoList Get(int id);
        void Delete(ToDoList toDoList);
    }
}
