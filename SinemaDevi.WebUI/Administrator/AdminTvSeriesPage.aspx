<%@ Page Title="Sinem Devi / Edit Tv Series" Language="C#" MasterPageFile="~/Administrator/Admin.Master" AutoEventWireup="true" CodeBehind="AdminTvSeriesPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminTvSeriesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .table-fixed {
            width: 100%;
        }

            .table-fixed tbody {
                height: 400px;
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
<asp:Content ID="TvSeriesPageContentBody" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
        <div class="row">
            <ol class="breadcrumb">
                <li><a href="AdminPage.aspx">
                    <em class="fa fa-home"></em>
                </a></li>
                <li class="active">Tv Series</li>
            </ol>
            <div class="col-lg-12">
                <h1 class="page-header">Tv Series</h1>
            </div>
        </div>
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="col-md-12">                     
                        <div class="col-md-12">
                            <div class="panel-heading" style="background-color: lightsteelblue; margin-top: 12px;"><strong>List Of Tv Series</strong></div>
                            <table class="table table-fixed">
                                <thead>
                                    <tr>
                                        <th class="col-xs-4">Name</th>
                                        <th class="col-xs-2">Year</th>
                                        <th class="col-xs-2">Imdb</th>
                                        <th class="col-xs-2">Is Active</th>
                                        <th class="col-xs-2">Edit</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rptTvSeriesList" runat="server" OnItemCommand="rptTvSeriesList_ItemCommand">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="col-xs-4"><%#Eval("Name")%></td>
                                                <td class="col-xs-2"><%#Convert.ToDateTime(Eval("Year")).ToShortDateString()%></td>
                                                <td class="col-xs-2"><%#Eval("ImdbScore") %></td>
                                                <td class="col-xs-2"><%#Eval("IsActive") %></td>
                                                <td>
                                                    <asp:LinkButton class="btn btn-sm btn-primary" runat="server"  CommandArgument='<%#Eval("id")%>' CommandName="Update">Update</asp:LinkButton></td>
                                                <td>
                                                    <asp:LinkButton class="btn btn-sm btn-danger" runat="server"  CommandArgument='<%#Eval("id")%>' CommandName="Delete">Delete</asp:LinkButton></td>

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
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="col-md-12">
                        <div class="panel-heading" style="background-color: steelblue"><strong>Tv Series Informations / Add Tv Series</strong></div>
                        <div class="col-md-3">
                            <div class="form-group">

                                <label>Name</label>
                                <asp:TextBox ID="txtNameTv" runat="server" class="form-control" placeholder="Name"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Year</label>
                                <asp:TextBox ID="txtYearTv" runat="server" class="form-control" placeholder="YYYY.MM.DD"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Director</label>
                                <asp:TextBox ID="txtDirectorTv" runat="server" class="form-control" placeholder="Director"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Writer</label>
                                <asp:TextBox ID="txtWriterTv" runat="server" class="form-control" placeholder="Writer"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>IMDB</label>
                                <asp:TextBox ID="txtImdb" runat="server" class="form-control" placeholder="8.2"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Trailer</label>
                                <asp:TextBox ID="txtTrailerTv" runat="server" class="form-control" placeholder="Url.."></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Summary</label>
                                <asp:TextBox ID="txtSummaryTv" runat="server" TextMode="MultiLine" Rows="4" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3 col-lg-2">
                            <div class="form-group">
                                <label>Categories</label>
                                <asp:ListBox ID="listCategories" SelectionMode="Multiple" runat="server"></asp:ListBox>
                            </div>

                        </div>
                        <div class="col-md-2 col-lg-3 col-md-offset-1">
                            <div class="form-group">
                                <label>Photo</label>
                                <asp:FileUpload ID="fileTvPhoto" runat="server" />
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group checkbox">
                                <label>
                                    <asp:CheckBox ID="checkIsActive" runat="server" />Is Active
                                </label>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
     
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="col-md-12">
                        <div class="panel-heading" style="background-color: steelblue"><strong>Add Actors</strong></div>

                        <div class="col-md-12">
                            <div class="panel-heading" style="background-color: lightsteelblue; margin-top: 12px;"><strong>List Of Actors</strong></div>
                            <table class="table table-fixed">
                                <thead>
                                    <tr>
                                        <th class="col-xs-6">Name</th>
                                        <th class="col-xs-3">Photo</th>
                                        <th class="col-xs-2">Is Active</th>
                                        <th class="col-xs-1">Add</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rptActors" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="col-xs-6"><%#Eval("Name")%></td>
                                                <td class="col-xs-3">
                                                    <img class="imgActor" width="40" src='../Uploads/<%#Eval("CoverImage") %>' />
                                                </td>
                                                <td class="col-xs-2"><%#Eval("IsActive") %></td>
                                                <td class="col-xs-1">
                                                    <div class="checkbox">
                                                        <label>
                                                            <input type="checkbox" value="">Add
                                                        </label>
                                                    </div>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <asp:LinkButton ID="btnAddTvSeries" class="btn btn-lg btn-primary col-md-4" Style="margin-left: 370px; margin-top: 20px;" runat="server" OnClick="btnAddTvSeries_Click">Add TV Series</asp:LinkButton>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
