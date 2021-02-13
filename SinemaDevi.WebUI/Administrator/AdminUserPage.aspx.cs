using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.Business.Dtos;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.Administrator
{
    public partial class AdminUserPage : System.Web.UI.Page
    {
        IUserService _userManager = new UserManager(new EfUserDal());

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {   
            rptUsers.DataSource = _userManager.GetAllWithEnteranceDate();
            rptUsers.DataBind();
        }
    }
}