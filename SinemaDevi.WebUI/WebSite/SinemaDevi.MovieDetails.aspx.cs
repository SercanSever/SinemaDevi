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
    public partial class SinemaDevi_MovieDetails : System.Web.UI.Page
    {
        ICommentService _commentManager = new CommentManager(new EfCommentDal());
        IMovieService _movieManager = new MovieManager(new EfMovieDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int movieId = Convert.ToInt32(Request.QueryString["Id"]);
                LoadMovie(movieId);
                LoadComments(movieId);
            }
          
            
        }
        private void LoadComments(int id)
        {
            rptComments.DataSource = _commentManager.GetMovieId(id);
            rptComments.DataBind();
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            
            if (Session["Id"] == null)
            {
                txtComment.Text = "Yorum Yapmak İçin Üye Olun..";
                return;   
            }
           
            Comment commentModel = new Comment();
            Movie movieModel = new Movie();
            User userModel = new User();
            userModel.Id = Convert.ToInt32 (Session["Id"]);
            userModel.UserName = Session["UserName"].ToString();
            int movieId = Convert.ToInt32(Request.QueryString["Id"]);
            movieModel.Id = movieId;
            commentModel.Content = txtComment.Text;
            commentModel.CreationTime = DateTime.Now;
            commentModel.IsActive = false;
            commentModel.MovieId = movieModel.Id;
            commentModel.UserId = userModel.Id;
            commentModel.UserName = userModel.UserName;
            _commentManager.Add(commentModel); 
        }
        private void LoadMovie(int id)
        {
        
            var movie = _movieManager.Get(id);
            coverImage.ImageUrl = $"../Uploads/{movie.CoverImage}";
            lblDirector.Text = movie.Director;
            lblWriter.Text = movie.Writer;
            lblYear.Text = movie.Year.ToShortDateString();
            lblSummary.Text = movie.Summary;
            lblMovieName.Text = movie.Name;
            lblImdb.Text = movie.ImdbScore.ToString();
            trailer.Src = movie.Trailer;
            
            
            
        }
    }
}