using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SinemaDevi.WebUI.Administrator
{
    public partial class AdminCommentPage : System.Web.UI.Page
    {
        ICommentService _commentManager = new CommentManager(new EfCommentDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadComments();
        }
        private void LoadComments()
        {
            rptComments.DataSource = _commentManager.GetAllDesc();
            rptComments.DataBind();
        }

        protected void rptComments_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName=="Confirm")
            {
                var commentModel = _commentManager.Get(id);
                commentModel.IsActive = !commentModel.IsActive;
                _commentManager.Update(commentModel);
                Response.Redirect($"~/Administrator/AdminCommentPage.aspx");
            }
            
        }
    }
}