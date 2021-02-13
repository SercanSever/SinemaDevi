using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.WebSite
{
    public partial class WebSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] == null)
            {
                Response.Redirect("~/Administrator/AdminLoginPage.aspx");
            }
            else
            {
                logOutHide.Attributes.Add("style", "visibility:visible");
            }
            lblSessionUser.Text = Session["UserName"]?.ToString();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/WebSite/SinemaDevi.Login.aspx");

        }
    }
}