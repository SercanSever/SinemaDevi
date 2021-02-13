using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.Administrator
{
    public partial class AdminMoviePage : System.Web.UI.Page
    {
        
        IMovieService _movieManager = new MovieManager(new EfMovieDal());
        ICategoryService _categoryManager = new CategoryManager(new EfCategoryDal());
        IActorService _actorManager = new ActorManager(new EfActorDal());
        IMovieCastService _castManager = new MovieCastManager(new EfMovieCastDal());
        IMovieCategoryService _movieCategory = new MovieCategoryManager(new EfMovieCategory());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadListOfMovies();
                LoadListOfActors();
                ListCategories();
            }
           
        }
        private void LoadListOfMovies()
        {
            rptMovieList.DataSource = _movieManager.GetAll();
            rptMovieList.DataBind();
        }
        
        private void LoadListOfActors()
        {
            rptActors.DataSource = _actorManager.GetAllStatus();
            rptActors.DataBind();
        }
        private void ListCategories()
        {
            listCategories.DataSource = _categoryManager.GetAll();
            listCategories.DataTextField = "Name";
            listCategories.DataValueField = "Id";
            listCategories.DataBind();
        }

        protected void rptMovieList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Update")
            {
                //
            }
            else
            {
                var movieModel = _movieManager.Get(id);
                movieModel.IsActive = !movieModel.IsActive;
                _movieManager.Update(movieModel);
                Response.Redirect($"~/Administrator/AdminMoviePage.aspx");
            }
        }

        protected void btnAddMovie_Click(object sender, EventArgs e)
        {
            MovieCategory movieCategory = new MovieCategory();
            Movie movie = new Movie();
            movie.Name = txtNameMovie.Text;
            movie.Writer = txtWriterMovie.Text;
            movie.Director = txtDirectorMovie.Text;
            movie.ImdbScore = Convert.ToDouble(txtImdb.Text);
            movie.Trailer = txtTrailerMovie.Text;
            movie.Summary = txtSummoryMovie.Text;
            movie.Year = DateTime.Parse(txtYearMovie.Text);
            movie.IsActive = checkIsActive.Checked;
            
            if (fileMoviePhoto.HasFile)
            {
                var fileName = fileMoviePhoto.FileName;
                FileInfo fileInfo = new FileInfo(fileName);
                var extension = fileInfo.Extension;
                var newFileName = $"{Guid.NewGuid()}{extension}";
                string path = $"{Server.MapPath("~/Uploads")}/{newFileName}";
                fileMoviePhoto.SaveAs(path);
                movie.CoverImage = newFileName;
            }
            _movieManager.Add(movie);
            movieCategory.CategoryId = Convert.ToInt32(listCategories.SelectedValue);
            movieCategory.MovieId = movie.Id;
            _movieCategory.Add(movieCategory);
            LoadListOfMovies();
            Clear();
        }
        private void Clear()
        {
            txtNameMovie.Text = string.Empty;
            txtWriterMovie.Text = string.Empty;
            txtDirectorMovie.Text = string.Empty;
            txtImdb.Text = string.Empty;
            txtTrailerMovie.Text = string.Empty;
            txtSummoryMovie.Text = string.Empty;
            txtYearMovie.Text = string.Empty;
            checkIsActive.Checked = false;
        }
        
    }
}