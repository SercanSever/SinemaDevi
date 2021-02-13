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
    public partial class TVSeriesDetails : System.Web.UI.Page
    {
        ICommentService _commentManager = new CommentManager(new EfCommentDal());
        ITvService _tvManager = new TvManager(new EfTvDal());
        ITvSeriesCategoryService _tvSeriesCategory = new TvSeriesCategoryManager(new EfTvCategoryDal());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int tvSeriesId = Convert.ToInt32(Request.QueryString["Id"]);
                LoadTvSeries(tvSeriesId);
                LoadComments(tvSeriesId);
            }


        }
        private void LoadComments(int id)
        {
            rptComments.DataSource = _commentManager.GetTvSeriesId(id);
            rptComments.DataBind();
        }

        private void LoadTvSeries(int id)
        {
            try
            {
                var tv = _tvManager.Get(id);
                coverImage.ImageUrl = $"../Uploads/{tv.CoverImage}";
                lblDirector.Text = tv.Director;
                lblWriter.Text = tv.Writer;
                lblYear.Text = tv.Year.ToShortDateString();
                lblSummary.Text = tv.Summary;
                lblTvSeriesName.Text = tv.Name;
                lblImdb.Text = tv.ImdbScore.ToString();
                trailer.Src = tv.Trailer;
            }
            catch (Exception)
            {
                Response.Redirect($"~/WebSite/SinemaDevi.Home.aspx");
            }



        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            if (Session["Id"] == null)
            {
                txtComment.Text = "Yorum Yapmak İçin Üye Olun..";
                return;
            }

            Comment commentModel = new Comment();
            Tv tvModel = new Tv();
            User userModel = new User();
            userModel.Id = Convert.ToInt32(Session["Id"]);
            userModel.UserName = Session["UserName"].ToString();
            int tvSeriesId = Convert.ToInt32(Request.QueryString["Id"]);
            tvModel.Id = tvSeriesId;
            commentModel.Content = txtComment.Text;
            commentModel.CreationTime = DateTime.Now;
            commentModel.IsActive = false;
            commentModel.TvId = tvModel.Id;
            commentModel.UserId = userModel.Id;
            _commentManager.Add(commentModel);

        }
    }
}