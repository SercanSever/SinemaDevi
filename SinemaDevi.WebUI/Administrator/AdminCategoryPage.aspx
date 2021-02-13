<%@ Page Title="Sinem Devi / Edit Categories" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminCategoryPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminCategoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
        .table-fixed {
            width: 100%;
        }

            .table-fixed tbody {
                height: 422px;
                overflow-y: auto;
                width: 100%;
            }

            .table-fixed thead,
            .table-fixed tbody,
            .table-fixed tr,
            .table-fixed td,
            .table-fixed th {
                display: block;
            }

                .table-fixed tbody td {
                    float: left;
                }

                .table-fixed thead tr th {
                    float: left;
                    font-size: large;
                }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="AdminPage.aspx">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Category</li>
            </ol>
            <div class="col-lg-12">
                <h1 class="page-header">Category</h1>
            </div>
        </div>
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div id="divCategoryEdit" class="col-md-3" runat="server" visible="true" style="visibility: visible">
                        <div class="panel-heading" style="background-color: steelblue"><strong>Edit Categories</strong></div>
                        <div class="form-group">
                            <label>Category Name</label>
                            <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                            <asp:TextBox class="form-control" ID="txtCategory" placeholder="Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group checkbox">
                            <label>
                                <asp:CheckBox ID="checkCategory" runat="server" />Is Active
                            </label>
                        </div>
                        <div>
                            <asp:LinkButton class="btn btn-primary btn-md" ID="btnSave" runat="server" OnClick="btnSave_Click">Save</asp:LinkButton>
                        </div>
                    </div>
                    <div id="divUpdateMaster" class="col-md-3" style="position: absolute;" runat="server" visible="false">
                        <asp:LinkButton class="fa fa-lg fa-close" ID="closeAlertButtonEdit" runat="server" Style="float: right; margin-right: 20px; margin-top: 22px;" OnClick="closeAlertButtonEdit_Click"></asp:LinkButton>
                        <div class="panel-heading" style="background-color: steelblue"><strong>Update Categories</strong></div>
                        <div class="form-group">
                            <label>Actor Name</label>
                            <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
                            <asp:TextBox class="form-control" ID="txtCategoryUpdate" placeholder="Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group checkbox">
                            <label>
                                <asp:CheckBox ID="checkCategoryUpdate" runat="server" />Is Active
                            </label>
                        </div>
                        <div>
                            <asp:LinkButton class="btn btn-primary btn-md" ID="btnUpdateEdit" runat="server" OnClick="btnUpdateEdit_Click">Update</asp:LinkButton>
                        </div>
                    </div>
                    <div class="col-md-9" style="position: sticky;">
                        <div class="panel-heading" style="background-color: lightsteelblue"><strong>List Of Actors</strong></div>

                        <table class="table table-fixed">
                            <thead>
                                <tr>
                                    <th class="col-xs-6">Name</th>
                                    <th class="col-xs-4">Is Active</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptCategories" runat="server" OnItemCommand="rptCategories_ItemCommand">
                                    <ItemTemplate>
                                        <tr style="height: 75px;">
                                            <td class="col-xs-6"><%#Eval("Name") %></td>
                                            <td class="col-xs-3"><%#Eval("IsActive") %></td>
                                            <td class="col-xs-1">
                                                <asp:LinkButton class="btn btn-sm btn-primary" CommandArgument='<%#Eval("Id")%>' CommandName="Update" ID="btnUpdate" runat="server" Style="float: right">Update</asp:LinkButton>
                                            </td>
                                            <td class="col-xs-1">
                                                <asp:LinkButton class="btn btn-sm btn-danger" CommandArgument='<%#Eval("Id")%>' CommandName="Delete" ID="btnDelete" runat="server">Delete</asp:LinkButton>
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

</asp:Content>
