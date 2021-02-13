using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.Administrator
{
    public partial class AdminLoginPage : System.Web.UI.Page
    {
        IUserService _userManager = new UserManager(new EfUserDal());
        IEnteranceLogService _enteranceLogManager = new EnteranceLogManager(new EfEnteranceLogDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Email"] != null)
            {
                txtEmail.Text = Request.Cookies["Email"].Value;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var admin = _userManager.AdminLoginWithEmail(email);
            if (admin != null)
            {
                if (admin.Email == email || admin.Password == password)
                {

                    if (admin.Name == "Admin")
                    {
                        Session.Add("UserName", $"{admin.UserName}");
                        Session.Add("Id", $"{admin.Id}");
                        EnteranceLog enterance = new EnteranceLog();
                        _enteranceLogManager.Add(enterance);
                        if (checkRemember.Checked)
                        {
                            Response.Cookies["Email"].Value = txtEmail.Text;
                            Response.Cookies["Email"].Expires = DateTime.Now.AddHours(1);
                            
                        }
                        Response.Redirect("~/Administrator/AdminPage.aspx");
                    }
                }
            }
        }
    }
}