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
    public partial class SinemaDevi_WatchList : System.Web.UI.Page
    {
        IWatchListMovieService _watchListMovie = new WatchListMovieManager(new EfWatchListMovieDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Id"] != null)
                {
                    int userId = Convert.ToInt32(Session["Id"]);
                    LoadWatchlist(userId);
                }
            }

        }
        private void LoadWatchlist(int userId)
        {
            rptWatchlist.DataSource = _watchListMovie.GetAllWithUserId(userId);
            rptWatchlist.DataBind();
        }

        protected void rptWatchlist_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Delete")
            {
                var watchListMovieModel = _watchListMovie.Get(id);
                watchListMovieModel.IsActive = false;
                _watchListMovie.Update(watchListMovieModel);
                Response.Redirect($"~/WebSite/SinemaDevi.WatchList.aspx");

            }
        }
    }
}