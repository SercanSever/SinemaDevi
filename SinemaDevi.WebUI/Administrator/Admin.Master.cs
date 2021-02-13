using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.Administrator
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        ICommunicationService _communicationManager = new CommunicationManager(new EfCommunicationDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] == null)
            {
                Response.Redirect("~/Administrator/AdminLoginPage.aspx");
            }
            lblsession.Text = Session["UserName"]?.ToString();

            lblMEssageCount.Text = _communicationManager.Count();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Administrator/AdminLoginPage.aspx");
        }
    }
}