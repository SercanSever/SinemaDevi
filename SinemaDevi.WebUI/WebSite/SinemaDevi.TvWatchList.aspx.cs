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
    public partial class SinemaDevi_TvWatchList : System.Web.UI.Page
    {
        IWatchListTvService _watchListTvManager = new WatchListTvManager(new EfWatchListTvDal());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Id"] != null)
                {
                    int userId = Convert.ToInt32(Session["Id"]);
                    LoadWatchListTv(userId);
                }
            }

        }
        private void LoadWatchListTv(int userId)
        {
            rptWatchlistTv.DataSource = _watchListTvManager.GetAllWithUserId(userId);
            rptWatchlistTv.DataBind();
        }


        protected void rptWatchlistTv_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Delete")
            {
                var watchListTvModel = _watchListTvManager.Get(id);
                watchListTvModel.IsActive = false;
                _watchListTvManager.Update(watchListTvModel);
                Response.Redirect($"~/WebSite/SinemaDevi.TvWatchList.aspx");
            }
        }
    }
}