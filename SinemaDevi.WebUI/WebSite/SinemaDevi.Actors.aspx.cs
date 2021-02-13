using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.WebSite
{
    public partial class SinemaDevi_Actors : System.Web.UI.Page
    {
        IActorService _actorManager = new ActorManager(new EfActorDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            rptActors.DataSource = _actorManager.GetAllStatus();
            rptActors.DataBind();
        }
    }
}