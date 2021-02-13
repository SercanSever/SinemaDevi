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
    public partial class AdminTvSeriesPage : System.Web.UI.Page
    {
        ITvService _tvSeriesManager = new TvManager(new EfTvDal());
        ICategoryService _categoryManager = new CategoryManager(new EfCategoryDal());
        ITvSeriesCategoryService _tvSeriesCategoryManager = new TvSeriesCategoryManager(new EfTvCategoryDal());
        IActorService _actorManager = new ActorManager(new EfActorDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadListOfTvSeries();
                ListCategories();
                LoadListOfActors();
            }

        }
        private void LoadListOfTvSeries()
        {
            rptTvSeriesList.DataSource = _tvSeriesManager.GetAll();
            rptTvSeriesList.DataBind();
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

        protected void btnAddTvSeries_Click(object sender, EventArgs e)
        {
            TvSeriesCategory tvSeriesCategory = new TvSeriesCategory();
            Tv tv = new Tv();
            tv.Name = txtNameTv.Text;
            tv.Writer = txtWriterTv.Text;
            tv.Director = txtDirectorTv.Text;
            tv.ImdbScore = Convert.ToDouble(txtImdb.Text);
            tv.Trailer = txtTrailerTv.Text;
            tv.Summary = txtSummaryTv.Text;
            tv.Year = DateTime.Parse(txtYearTv.Text);
            tv.IsActive = checkIsActive.Checked;

            if (fileTvPhoto.HasFile)
            {
                var fileName = fileTvPhoto.FileName;
                FileInfo fileInfo = new FileInfo(fileName);
                var extension = fileInfo.Extension;
                var newFileName = $"{Guid.NewGuid()}{extension}";
                string path = $"{Server.MapPath("~/Uploads")}/{newFileName}";
                fileTvPhoto.SaveAs(path);
                tv.CoverImage = newFileName;
            }
            
            _tvSeriesManager.Add(tv);
            tvSeriesCategory.CategoryId = Convert.ToInt32(listCategories.SelectedValue);
            tvSeriesCategory.TvSeriesId = tv.Id;
            _tvSeriesCategoryManager.Add(tvSeriesCategory);
            LoadListOfTvSeries();
            Clear();
        }

        protected void rptTvSeriesList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Update")
            {
                //
            }
            else
            {
                var tvModel = _tvSeriesManager.Get(id);
                tvModel.IsActive = !tvModel.IsActive;
                _tvSeriesManager.Update(tvModel);
                Response.Redirect($"~/Administrator/AdminTvSeriesPage.aspx");
            }
        }
        private void Clear()
        {
            txtNameTv.Text = string.Empty;
            txtWriterTv.Text = string.Empty;
            txtDirectorTv.Text = string.Empty;
            txtImdb.Text = string.Empty;
            txtTrailerTv.Text = string.Empty;
            txtSummaryTv.Text = string.Empty;
            txtYearTv.Text = string.Empty;
            checkIsActive.Checked = false;
        }
    }
}