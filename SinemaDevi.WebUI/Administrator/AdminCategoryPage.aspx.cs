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


namespace SinemaDevi.WebUI.Administrator
{

    public partial class AdminCategoryPage : System.Web.UI.Page
    {
        ICategoryService _categoryManager = new CategoryManager(new EfCategoryDal());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count>0)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    LoadDataWithId(id);
                }
                LoadListOfCategories();
            }
           

        }

        protected void rptCategories_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Update")
            {

                Response.Redirect($"~/Administrator/AdminCategoryPage.aspx?id={id}");
            }
            else
            {

                var categoryModel = _categoryManager.Get(id);
                categoryModel.IsActive = !categoryModel.IsActive;
                _categoryManager.Update(categoryModel);
                Response.Redirect($"~/Administrator/AdminCategoryPage.aspx");

            }
        }

        private void LoadListOfCategories()
        {
            rptCategories.DataSource = _categoryManager.GetAll();
            rptCategories.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Category categoryModel = new Category();           
            categoryModel.Name = txtCategory.Text;
            categoryModel.IsActive = checkCategory.Checked;
            _categoryManager.Add(categoryModel);
            txtCategory.Text = string.Empty;
            checkCategory.Checked = false;
            LoadListOfCategories();
        }

        protected void btnUpdateEdit_Click(object sender, EventArgs e)
        {

            
            Category categoryModel = new Category();
            divUpdateMaster.Visible = true;
            categoryModel.Id = Convert.ToInt32(lblId.Text);         
            categoryModel.Name = txtCategoryUpdate.Text;
            categoryModel.IsActive = checkCategoryUpdate.Checked;
            _categoryManager.Update(categoryModel);
            txtCategoryUpdate.Text = string.Empty;
            checkCategoryUpdate.Checked = false;
            LoadListOfCategories();



        }

        protected void closeAlertButtonEdit_Click(object sender, EventArgs e)
        {
            divUpdateMaster.Visible = false;
            Response.Redirect($"~/Administrator/AdminCategoryPage.aspx");

        }
        private void LoadDataWithId(int id)
        {
            divUpdateMaster.Visible = true;
            divCategoryEdit.Attributes.Add("style", "visibility:hidden");
            lblId.Text = id.ToString();
            var categoryModel = _categoryManager.Get(id);
            txtCategoryUpdate.Text = categoryModel.Name;
            checkCategoryUpdate.Checked = categoryModel.IsActive;
            lblId.Text = id.ToString();

        }
    }
}