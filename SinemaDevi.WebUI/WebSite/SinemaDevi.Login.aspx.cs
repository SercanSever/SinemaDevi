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

namespace SinemaDevi.WebUI.WebSite
{
    public partial class SinemaDevi_Login : System.Web.UI.Page
    {
        IUserService _userManager = new UserManager(new EfUserDal());
        IEnteranceLogService _logManager = new EnteranceLogManager(new EfEnteranceLogDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Email"] != null && Request.Cookies["UserName"]!=null)
            {
                txtUserName.Text = Request.Cookies["UserName"].Value;
                txtEmail.Text = Request.Cookies["Email"].Value;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/WebSite/SinemaDevi.SignUp.aspx");
        }

        protected void btnSıgnIn_Click(object sender, EventArgs e)
        {         
            var userName = txtUserName.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var login = _userManager.UserLogin(email);
            var DePassword = _userManager.Decrypt(login.Password);
            if (login != null)
            {
                if (login.UserName == userName || DePassword == password)
                {
                    Session.Add("UserName", $"{login.UserName}");
                    Session.Add("Id", $"{login.Id}");
                    EnteranceLog enteranceLog = new EnteranceLog();
                    _logManager.Add(enteranceLog);
                    if (checkRemember.Checked)
                    {
                        Response.Cookies["UserName"].Value = txtUserName.Text;
                        Response.Cookies["Email"].Value = txtEmail.Text;
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddHours(12);
                        Response.Cookies["Email"].Expires = DateTime.Now.AddHours(12);
                        
                    }
                    Response.Redirect("~/WebSite/SinemaDevi.Home.aspx");

                }
            }
            
            
        }
    }
}