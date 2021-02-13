<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminExceptionLogPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminExceptionLogPage" %>

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
                <li class="active">Exceptions</li>
            </ol>
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Exceptions</h1>
            </div>
        </div>
        <!--/.row-->

        <div>
             <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">List of Exceptions</div>
                        <div class="panel-body">
                            <div class="col-md-12">
                                <div class="col-md-12" style="position: sticky;">
                                    <table class="table table-fixed">
                                        <thead>
                                            <tr>
                                                <th class="col-xs-3">Message</th>
                                                <th class="col-xs-3">Creation Time</th>
                                                <th class="col-xs-2">Explanation</th>
                                                <th class="col-xs-2">StackTrace</th>
                                             
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptExceptionLog" runat="server">
                                                <ItemTemplate>
                                                    <tr style="height: 75px;">
                                                        <td class="col-xs-3"><%#Eval("Message") %></td>
                                                        <td class="col-xs-2"><%#Eval("CreationTime") %></td>
                                                        <td class="col-xs-2"><%#Eval("Explanation") %></td>
                                                        <td class="col-xs-5"><textarea class="form-control" rows="3"> <%#Eval("StackTrace") %></textarea></td>
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
