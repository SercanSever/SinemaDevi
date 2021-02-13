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
    public partial class SinemaDevi_Contact : System.Web.UI.Page
    {
        ICommunicationService _communicationManager = new CommunicationManager(new EfCommunicationDal());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Communication communicationModel = new Communication();
            communicationModel.Name = txtContactName.Text;
            communicationModel.Surname = txtContactSurname.Text;
            communicationModel.Email = txtContactEmail.Text;
            communicationModel.Message = txtContactMessage.Text;
            communicationModel.SendDate = DateTime.Now;
            _communicationManager.Add(communicationModel);
            Response.Redirect($"~/WebSite/SinemaDevi.Contact.aspx");
        }
    }
}