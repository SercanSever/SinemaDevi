<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminCommunicationPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminCommunicationPage" %>

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
                <li class="active">Communication</li>
            </ol>
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Communication</h1>
            </div>
        </div>
        <!--/.row-->

        <div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">List of Messages</div>
                        <div class="panel-body">
                            <div class="col-md-12">
                                <div class="col-md-12" style="position: sticky;">
                                    <table class="table table-fixed">
                                        <thead>
                                            <tr>
                                                <th class="col-xs-3">Name</th>
                                                <th class="col-xs-3">Surname</th>
                                                <th class="col-xs-2">Email</th>
                                                <th class="col-xs-2">Messsage</th>
                                                <th class="col-xs-1">Send Date</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptMessages" runat="server">
                                                <ItemTemplate>
                                                    <tr style="height: 75px;">
                                                        <td class="col-xs-3"><%#Eval("Name") %></td>
                                                        <td class="col-xs-3"><%#Eval("Surname") %></td>
                                                        <td class="col-xs-3"><%#Eval("Email") %></td>
                                                        <td class="col-xs-2"><textarea class="form-control" rows="3"> <%#Eval("Message") %></textarea></td>
                                                        <td class="col-xs-2"><%#Eval("SendDate") %></td>
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
