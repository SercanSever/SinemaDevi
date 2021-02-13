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
    public partial class SinemaDevi_TvSeries : System.Web.UI.Page
    {
        ICategoryService _categoryManager = new CategoryManager(new EfCategoryDal());
        ITvService _tvManager = new TvManager(new EfTvDal());
        IWatchListTvService _watchListTvManager = new WatchListTvManager(new EfWatchListTvDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
                if (Request.QueryString.Count == 0)
                {
                    LoadTvSeries();
                }
                else
                {
                    int categoryId = Convert.ToInt32(Request.QueryString["Id"]);
                    LoadTvSeries(categoryId);
                }
            }

        }
        private void LoadCategories()
        {
            rptCategories.DataSource = _categoryManager.GetAllByStatus();
            rptCategories.DataBind();
        }
        private void LoadTvSeries(int categoryId = 0)
        {
            var listOFTvSeries = new List<Tv>();
            if (categoryId == 0)
            {
                listOFTvSeries = _tvManager.GetAllStatus();
            }
            else
            {
                listOFTvSeries = _tvManager.GetAllByCategoryId(categoryId);
            }
            rptTvSeries.DataSource = listOFTvSeries;
            rptTvSeries.DataBind();

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadTvSeries();
            }
            else
            {
                SearchTvSeries();
            }

        }
        private void SearchTvSeries()
        {
            rptTvSeries.DataSource = _tvManager.GetAllWithSearch(txtSearch.Text);
            rptTvSeries.DataBind();
        }
    }
}