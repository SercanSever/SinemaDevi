<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="#">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Dashboard</li>
            </ol>
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Dashboard</h1>
            </div>
        </div>
        <!--/.row-->

        <div class="panel panel-container">
            <div class="row">

                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-teal panel-widget border-right">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-user color-blue"></em>
                            <div class="large">
                                <asp:Label ID="lblAllUsers" Text="" runat="server" />
                            </div>
                            <div class="text-muted">Users</div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-blue panel-widget border-right">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-comments color-orange"></em>
                            <div class="large">
                                <asp:Label ID="lblAllCommants" Text="" runat="server" />
                            </div>
                            <div class="text-muted">Comments</div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-orange panel-widget border-right">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-users color-teal"></em>
                            <div class="large">
                                <asp:Label ID="lblAllMessages" Text="" runat="server" />
                            </div>
                            <div class="text-muted">Messages</div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-6 col-md-3 col-lg-3 no-padding">
                    <div class="panel panel-red panel-widget ">
                        <div class="row no-padding">
                            <em class="fa fa-xl fa-bug color-red"></em>
                            <div class="large">
                                <asp:Label ID="lblAllExceptions" Text="" runat="server" />
                            </div>
                            <div class="text-muted">Exceptions</div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/.row-->
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-md-6">
                <div class="panel panel-default chat">
                    <div class="panel-heading">
                        <a style="text-decoration: none" href="AdminCommunicationPage.aspx">Messages</a>
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body">
                        <ul>

                            <asp:Repeater ID="rptMessagesMainPage" runat="server">
                                <ItemTemplate>
                                    <li class="left clearfix">
                                        <span class="chat-img pull-left">
                                            <img src="../Assets/17004.png" alt="User Avatar" class="img-circle" style="width: 60px;" />
                                        </span>
                                        <div class="chat-body clearfix">
                                            <div class="header">
                                                <strong class="primary-font"><%#Eval("Name") %></strong>
                                                <small class="text-muted"><%#Eval("SendDate") %></small>
                                            </div>
                                            <p><%#Eval("Message") %></p>
                                        </div>
                                    </li>

                                </ItemTemplate>
                            </asp:Repeater>

                        </ul>
                    </div>

                </div>
            </div>
            <!--/.col-->


            <div class="col-md-6">
                <div class="panel panel-default ">
                    <div class="panel-heading">
                        To Do List
                        <span class="pull-right clickable panel-toggle panel-button-tab-left"><em class="fa fa-toggle-up"></em></span>
                    </div>
                    <div class="panel-body timeline-container">
                        <ul class="todo-list">
                            <asp:Repeater ID="rptToDoList" runat="server" OnItemCommand="rptToDoList_ItemCommand">
                                <ItemTemplate>
                                    <li class="todo-list-item">
                                        <label><%#Eval("Content")%></label>
                                        <div class="pull-right action-buttons">
                                            <asp:LinkButton ID="btnDelToDoList" CommandArgument='<%#Eval("Id")%>' CommandName="Delete" runat="server"><em class="fa fa-trash"></em></asp:LinkButton>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div class="input-group">
                            <asp:TextBox class="form-control input-md" ID="txtToDoListAdd" runat="server" placeholder="Add new task"></asp:TextBox>
                            <span class="input-group-btn">

                                <asp:Button class="btn btn-primary btn-md" ID="btnToDoListAdd" runat="server" Text="Add" OnClick="btnToDoListAdd_Click" />
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <!--/.col-->

        </div>
        <!--/.row-->
    </div>
    <!--/.main-->

</asp:Content>
