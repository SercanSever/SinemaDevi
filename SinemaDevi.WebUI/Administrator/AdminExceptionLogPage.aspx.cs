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
    public partial class AdminExceptionLogPage : System.Web.UI.Page
    {
        IExceptionLogService _exceptionLogManager = new ExceptionLogManager(new EfExceptionLogDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadExceptions();
        }
        private void LoadExceptions()
        {
            rptExceptionLog.DataSource = _exceptionLogManager.GetAll();
            rptExceptionLog.DataBind();
        }
    }
}