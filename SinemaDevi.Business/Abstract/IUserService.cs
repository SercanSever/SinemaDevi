using SinemaDevi.Business.Dtos;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaDevi.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User AdminLoginWithEmail(string email);
        string Count();
        List<UserDto> GetAllWithEnteranceDate();
        User UserLogin(string email);
        void Add(User user);
        string Encrypt(string text);
        string Decrypt(string text);
    }
}
