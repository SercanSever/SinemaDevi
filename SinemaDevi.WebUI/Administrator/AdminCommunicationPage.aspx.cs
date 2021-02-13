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
    public partial class AdminCommunicationPage : System.Web.UI.Page
    {
        ICommunicationService _communicationManager = new CommunicationManager(new EfCommunicationDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            rptMessages.DataSource = _communicationManager.GetAllDesc();
            rptMessages.DataBind();
        }
    }
}