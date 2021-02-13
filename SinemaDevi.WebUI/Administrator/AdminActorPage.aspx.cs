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
    public partial class AdminActorPage : System.Web.UI.Page
    {
        IActorService _actorManager = new ActorManager(new EfActorDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    imgActor.Visible = true;
                    LoadDataWithId(id);
                }
                LoadListOfActors();
            }

        }
        private void LoadListOfActors()
        {
            rptActors.DataSource = _actorManager.GetAll();
            rptActors.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Actor actorModel = new Actor();
            actorModel.Name = txtActorName.Text;
            actorModel.SurName = txtActorSurName.Text;
            actorModel.IsActive = checkActor.Checked;
            if (uploadActor.HasFile)
            {
                var fileName = uploadActor.FileName;
                FileInfo fileInfo = new FileInfo(fileName);
                var extension = fileInfo.Extension;
                var newFileName = $"{Guid.NewGuid()}{extension}";
                string path = $"{Server.MapPath("~/Uploads")}/{newFileName}";
                uploadActor.SaveAs(path);
                actorModel.CoverImage = newFileName;
            }
            _actorManager.Add(actorModel);
            EditActorEmpty();
            LoadListOfActors();
        }

        protected void rptActors_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Update")
            {
                Response.Redirect($"~/Administrator/AdminActorPage.aspx?id={id}");
            }
            else
            {
                var actorModel = _actorManager.Get(id);
                actorModel.IsActive = !actorModel.IsActive;
                _actorManager.Update(actorModel);
                Response.Redirect($"~/Administrator/AdminActorPage.aspx");
            }
        }

        protected void btnUpdateActor_Click(object sender, EventArgs e)
        {
            Actor actorModel = new Actor();
            divUpdateActor.Visible = true;
            actorModel.Id = Convert.ToInt32(lblId.Text);
            actorModel.Name = txtUpdateActorName.Text;
            actorModel.SurName = txtUpdateActorSurname.Text;
            actorModel.IsActive = checkUpdateActor.Checked;
            if (fileUpdateActor.HasFile)
            {
                var fileName = fileUpdateActor.FileName;
                FileInfo fileInfo = new FileInfo(fileName);
                var extension = fileInfo.Extension;
                var newFileName = $"{Guid.NewGuid()}{extension}";
                string path = $"{Server.MapPath("~/Uploads")}/{newFileName}";
                fileUpdateActor.SaveAs(path);
                actorModel.CoverImage = newFileName;
            }
            if (fileUpdateActor.HasFile == false)
            {
                lblAlert.Visible = true;
                return;
            }
            _actorManager.Update(actorModel);
            UpdateActorEmpty();
            Response.Redirect($"~/Administrator/AdminActorPage.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void closeUpdate_Click(object sender, EventArgs e)
        {
            divUpdateActor.Visible = false;
            UpdateActorEmpty();
            Response.Redirect($"~/Administrator/AdminActorPage.aspx");
        }
        private void EditActorEmpty()
        {
            txtActorName.Text = string.Empty;
            txtActorSurName.Text = string.Empty;
            checkActor.Checked = false;
        }
        private void UpdateActorEmpty()
        {
            txtUpdateActorName.Text = string.Empty;
            txtUpdateActorSurname.Text = string.Empty;
            checkUpdateActor.Checked = false;
        }
        private void LoadDataWithId(int id)
        {
            divUpdateActor.Visible = true;
            divActorEdit.Attributes.Add("style", "visibility:hidden");
            var actorModel = _actorManager.Get(id);
            txtUpdateActorName.Text = actorModel.Name;
            txtUpdateActorSurname.Text = actorModel.SurName;
            checkActor.Checked = actorModel.IsActive;
            imgActor.ImageUrl = $"../Uploads/{actorModel.CoverImage}";
            lblId.Text = id.ToString();
            if (fileUpdateActor.FileName == null)
            {
                return;
            }

        }
    }
}