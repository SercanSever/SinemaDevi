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
    public partial class WebSite_Home : System.Web.UI.Page
    {
        IActorService _actorManager = new ActorManager(new EfActorDal());
        IMovieService _movieManager = new MovieManager(new EfMovieDal());
        ITvService _tvManager = new TvManager(new EfTvDal());
        IWatchListMovieService _watchListMovie = new WatchListMovieManager(new EfWatchListMovieDal());
        IWatchListTvService _watchListTvManager = new WatchListTvManager(new EfWatchListTvDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadActors();
                LoadTrailers();
                LoadMovies();
                LoadTvSeries();
            }

        }
        private void LoadActors()
        {
            rptActorImages.DataSource = _actorManager.GetAllStatus();
            rptActorImages.DataBind();
        }
        private void LoadTrailers()
        {
            rptTrailers.DataSource = _movieManager.GetLastFive();
            rptTrailers.DataBind();
        }
        private void LoadMovies()
        {
            rptMovies.DataSource = _movieManager.GetAllStatus();
            rptMovies.DataBind();
        }
        private void LoadTvSeries()
        {
            rptTvSeries.DataSource = _tvManager.GetAllStatus();
            rptTvSeries.DataBind();
        }

        protected void rptMovies_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            WatchListMovie watchListMovie = new WatchListMovie();
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Add")
            {
                if (Session["Id"] == null)
                {
                    return;
                }
                else
                {
                    var movieModel = _movieManager.Get(id);
                    watchListMovie.MovieId = movieModel.Id;
                    watchListMovie.UserId = Convert.ToInt32(Session["Id"]);
                    watchListMovie.IsActive = true;
                    _watchListMovie.Add(watchListMovie);
                }

            }
        }

        protected void rptTvSeries_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            WatchListTv watchListTv = new WatchListTv();
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Add")
            {
                if (Session["Id"] == null)
                {
                    return;
                }
                else
                {
                    var tvModel = _tvManager.Get(id);
                    watchListTv.TvSeriesId = tvModel.Id;
                    watchListTv.UserId = Convert.ToInt32(Session["Id"]);
                    watchListTv.IsActive = true;
                    _watchListTvManager.Add(watchListTv);
                }

            }
        }
    }
}