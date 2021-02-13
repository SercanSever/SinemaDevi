using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Dtos;
using SinemaDevi.DataAccess.Abstract;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace SinemaDevi.Business.Concrete
{

    public class UserManager : IUserService
    {
        SinemaDeviDBContext _sinemaDeviDBContext = new SinemaDeviDBContext();

        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User AdminLoginWithEmail(string email)
        {
            return _userDal.Get(p => p.Email == email);
        }

        public string Count()
        {
            return _userDal.GetAll().Count().ToString();
        }

        public List<UserDto> GetAllWithEnteranceDate()
        {
            var list = _sinemaDeviDBContext.Database.SqlQuery<UserDto>("select u.[Name],u.[Email],u.[UserName],MAX(e.[EnteranceDate]) as EnteranceDate,u.IsActive from [User] as u inner join [EnteranceLog] as e on u.Id = e.UserId group by u.[Name], u.Id, u.Email, u.UserName, u.IsActive").ToListAsync().Result;
            return list;

        }


        public User UserLogin(string email)
        {
            return _userDal.Get(p => p.Email == email);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public string Encrypt(string text)
        {
            try
            {
                string hash = "";

                byte[] data = Encoding.Default.GetBytes(text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(Encoding.Default.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return Convert.ToBase64String(results, 0, results.Length);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
      
        }
        public string Decrypt(string text)
        {
            try
            {
                string hash = "";

                byte[] data = Convert.FromBase64String(text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(Encoding.Default.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return Encoding.Default.GetString(results);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
