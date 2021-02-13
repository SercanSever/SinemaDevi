<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUserPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminUserPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li>
                    <a href="#">
                        <em class="fa fa-home"></em>
                    </a>
                </li>
                <li class="active">Users</li>
            </ol>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Users</h1>
            </div>
        </div>
        <div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">List of Users</div>
                        <div class="panel-body">
                            <div class="col-md-12">
                                <div class="col-md-12" style="position: sticky;">

                                    <table class="table table-fixed">
                                        <thead>
                                            <tr>
                                                <th class="col-xs-3">Name</th>
                                                <th class="col-xs-3">Email</th>
                                                <th class="col-xs-2">Username</th>
                                                <th class="col-xs-2">Last Enterance</th>
                                                <th class="col-xs-1">IsActive</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptUsers" runat="server">
                                                <ItemTemplate>
                                                    <tr style="height: 75px;">
                                                        <td class="col-xs-3"><%#Eval("Name") %></td>
                                                        <td class="col-xs-3"><%#Eval("Email") %></td>
                                                        <td class="col-xs-3"><%#Eval("UserName") %></td>
                                                        <td class="col-xs-3"><%#Eval("EnteranceDate")%></td>
                                                        <td class="col-xs-1"><%#Eval("IsActive")%></td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
