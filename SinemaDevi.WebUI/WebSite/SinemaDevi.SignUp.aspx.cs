using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace SinemaDevi.WebUI.WebSite
{
    public partial class SinemaDevi_SignUp : System.Web.UI.Page
    {
        IUserService _userManager = new UserManager(new EfUserDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/WebSite/SinemaDevi.Login.aspx");
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            User userModel = new User();
            userModel.Name = txtName.Text;
            userModel.Email = txtEmail.Text;
            userModel.UserName = txtUserName.Text;
            userModel.Password = _userManager.Encrypt(txtPassword.Text);
            if (txtPassword.Text.Length >= 8)
            {
                if (txtPassword.Text == txtRePassword.Text)
                {
                   
                    _userManager.Add(userModel);
                    Response.Redirect($"~/WebSite/SinemaDevi.Login.aspx");
                }
                else
                {
                    return;
                }
            }
        }
    }
}