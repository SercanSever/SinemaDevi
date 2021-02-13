<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminCommentPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminCommentPage" %>

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
                <li class="active">Comments</li>
            </ol>
        </div>
        <!--/.row-->

        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Comments</h1>
            </div>
        </div>
        <!--/.row-->
        <div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">List of Comments</div>
                        <div class="panel-body">
                            <div class="col-md-12">
                                <div class="col-md-12" style="position: sticky;">
                                    <table class="table table-fixed">
                                        <thead>
                                            <tr>
                                                <th class="col-xs-2">CreationTime</th>
                                                <th class="col-xs-5">Content</th>
                                                <th class="col-xs-1"></th>
                                                <th class="col-xs-3">Is Active</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="rptComments" runat="server" OnItemCommand="rptComments_ItemCommand">
                                                <ItemTemplate>
                                                    <tr style="height: 75px;">
                                                        <td class="col-xs-3"><%#Eval("CreationTime") %></td>
                                                        <td class="col-xs-2">
                                                            <textarea class="form-control" rows="3"> <%#Eval("Content") %></textarea>
                                                        <td>
                                                        <td class="col-xs-1"><%#Eval("IsActive") %></td>
                                                        <td class="col-xs-1">           
                                                                <asp:LinkButton  class="btn btn-sm btn-success" CommandArgument='<%#Eval("Id")%>' CommandName="Confirm" ID="btnIsActive" runat="server">Confirm / Display</asp:LinkButton>
                                                        </td>
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
