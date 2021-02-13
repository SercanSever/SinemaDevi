<%@ Page Title="Sinema Devi / Edit Actors" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminActorPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminActorPage" %>

<asp:Content ID="ActorPageContentHead" ContentPlaceHolderID="head" runat="server">
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
<asp:Content ID="ActorPageContentBody" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="AdminPage.aspx">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Actors</li>
            </ol>
            <div class="col-lg-12">
                <h1 class="page-header">Actors</h1>
            </div>
        </div>
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div id="divActorEdit" class="col-md-3" runat="server" visible="true" style="visibility:visible">
                        <div class="panel-heading" style="background-color:steelblue"><strong>Edit Actors</strong></div>
                        <div class="form-group">
                            <label>Actor Name</label>
                            <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                            <asp:TextBox class="form-control" ID="txtActorName" placeholder="Will" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Actor Surname</label>
                            <asp:TextBox class="form-control" ID="txtActorSurName" placeholder="Smith" runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Photo</label>
                            <asp:FileUpload ID="uploadActor" runat="server" />
                        </div>

                        <div class="form-group checkbox">
                            <label>
                                <asp:CheckBox ID="checkActor" runat="server" />Is Active
                            </label>
                        </div>
                        <div>
                            <asp:LinkButton class="btn btn-primary btn-md" ID="btnSave" runat="server" OnClick="btnSave_Click">Save</asp:LinkButton>
                        </div>
                    </div>
                    <div id="divUpdateActor" class="col-md-3" style="position:absolute;" runat="server" visible="false">
                        <asp:LinkButton class="fa fa-lg fa-close" ID="closeUpdate" runat="server" Style="float: right; margin-right: 20px; margin-top: 22px;" OnClick="closeUpdate_Click"></asp:LinkButton>
                        <div class="panel-heading" style="background-color: steelblue"><strong>Update Actors</strong></div>
                        <div class="form-group">
                            <label>Actor Name</label>
                            <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
                            <asp:TextBox class="form-control" ID="txtUpdateActorName" placeholder="Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Actor Surname</label>
                            <asp:TextBox class="form-control" ID="txtUpdateActorSurname" placeholder="Surname" runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Photo</label>
                            <asp:FileUpload ID="fileUpdateActor" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="lblAlert" Visible="false" style="color:red; font-size:large" runat="server" Text="Dosya Seçilmedi !"></asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Image runat="server" Visible="false" ID="imgActor" Width="100" />                          
                        </div>

                        <div class="form-group checkbox">
                            <label>
                                <asp:CheckBox ID="checkUpdateActor" runat="server" />Is Active
                            </label>
                        </div>
                        <div>
                            <asp:LinkButton class="btn btn-primary btn-md" ID="btnUpdateActor" runat="server" OnClick="btnUpdateActor_Click">Update</asp:LinkButton>
                        </div>
                    </div>
                    <div class="col-md-9" style="position:sticky;">
                        <div class="panel-heading" style="background-color: lightsteelblue"><strong>List Of Actors</strong></div>

                        <table class="table table-fixed">
                            <thead>
                                <tr>
                                    <th class="col-xs-3">Name</th>
                                    <th class="col-xs-3">Surname</th>
                                    <th class="col-xs-1">Photo</th>
                                    <th class="col-xs-2">Is Active</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptActors" runat="server" OnItemCommand="rptActors_ItemCommand">
                                    <ItemTemplate>
                                        <tr style="height: 75px;">
                                            <td class="col-xs-3"><%#Eval("Name") %></td>
                                            <td class="col-xs-3"><%#Eval("SurName") %></td>
                                            <td class="col-xs-1">
                                                <img class="imgActor" width="40" src='../Uploads/<%#Eval("CoverImage") %>' /></td>
                                            <td class="col-xs-2"><%#Eval("IsActive") %></td>
                                            <td class="col-xs-1">
                                                <asp:LinkButton class="btn btn-sm btn-primary" CommandArgument='<%#Eval("Id")%>' CommandName="Update" ID="btnUpdate" runat="server" Style="float: right" OnClick="btnUpdate_Click">Update</asp:LinkButton>
                                            </td>
                                            <td class="col-xs-2">
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
