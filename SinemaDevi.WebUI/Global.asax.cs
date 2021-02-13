using SinemaDevi.Business.Abstract;
using SinemaDevi.Business.Concrete;
using SinemaDevi.DataAccess.Concrete.EntityFramework;
using SinemaDevi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SinemaDevi.WebUI
{
    public class Global : System.Web.HttpApplication
    {
        IExceptionLogService _exceptionLogManager = new ExceptionLogManager(new EfExceptionLogDal());
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            try
            {
                var exception = Server.GetLastError();
                ExceptionLog exceptionLog = new ExceptionLog();
                exceptionLog.Message = exception.Message;
                exceptionLog.StackTrace = exception.StackTrace;
                exceptionLog.CreationTime = DateTime.Now;
                exceptionLog.Explanation = exception.Source;
                _exceptionLogManager.Add(exceptionLog);
            }
            catch (Exception)
            {
                Response.Redirect($"~/WebSite/SinemaDevi.Home.aspx");
            }
           
            
        }

    }
}