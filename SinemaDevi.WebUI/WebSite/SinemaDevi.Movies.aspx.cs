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
    public partial class SinemaDevi_Movie : System.Web.UI.Page
    {
        ICategoryService _categoryManager = new CategoryManager(new EfCategoryDal());
        IMovieService _movieManager = new MovieManager(new EfMovieDal());
        IWatchListMovieService _watchListMovie = new WatchListMovieManager(new EfWatchListMovieDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategorie();

                if (Request.QueryString.Count == 0)
                {
                    LoadMovies();
                }
                else
                {
                    int categoryId = Convert.ToInt32(Request.QueryString["Id"]);
                    LoadMovies(categoryId);
                }
            }

        }
        private void LoadCategorie()
        {
            rptCategories.DataSource = _categoryManager.GetAllByStatus();
            rptCategories.DataBind();
        }

        private void LoadMovies(int categoryId = 0)
        {
            var listOFMovies = new List<Movie>();
            if (categoryId == 0)
            {
                listOFMovies = _movieManager.GetAllWithIsActive();
            }
            else
            {
                listOFMovies = _movieManager.GetAllByCategoryId(categoryId);
            }
            rptMovies.DataSource = listOFMovies;
            rptMovies.DataBind();

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadMovies();
            }
            else
            {
                SearchMovies();
            }
            
        }
        private void SearchMovies()
        {
            rptMovies.DataSource = _movieManager.GetAllWithSearch(txtSearch.Text);
            rptMovies.DataBind();
        }
    }
}