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
    public partial class AdminPage : System.Web.UI.Page
    {
        ICommentService _commentManager = new CommentManager(new EfCommentDal());
        IExceptionLogService _exceptionLogManager = new ExceptionLogManager(new EfExceptionLogDal());
        IUserService _userManager = new UserManager(new EfUserDal());
        ICommunicationService _communicationManager = new CommunicationManager(new EfCommunicationDal());
        IToDoListService _toDoListService = new ToDoListManager(new EfToDoListDal());
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAllCommants.Text = _commentManager.Count();
            lblAllExceptions.Text = _exceptionLogManager.Count();
            lblAllUsers.Text = _userManager.Count();
            lblAllMessages.Text = _communicationManager.Count();
            LoadMessages();
            LoadToDoList();
            
        }

        private void LoadMessages()
        {
            rptMessagesMainPage.DataSource = _communicationManager.GetLastTen();
            rptMessagesMainPage.DataBind();
        }

        protected void btnToDoListAdd_Click(object sender, EventArgs e)
        {
            if (txtToDoListAdd.Text=="")
            {
                return;
            }
            else
            {
                ToDoList toDoList = new ToDoList();
                toDoList.Content = txtToDoListAdd.Text;
                _toDoListService.Add(toDoList);
                txtToDoListAdd.Text = "";
                LoadToDoList();             
            }      
        }
        private void LoadToDoList()
        {
            rptToDoList.DataSource = _toDoListService.GetAll();
            rptToDoList.DataBind();
        }

        protected void rptToDoList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Delete")
            {
                var toDoList = _toDoListService.Get(id);
                _toDoListService.Delete(toDoList);
            }
            LoadToDoList();
            
        }
    }

}