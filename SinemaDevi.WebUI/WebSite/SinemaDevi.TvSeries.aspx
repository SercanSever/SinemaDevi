<%@ Page Title="" Language="C#" MasterPageFile="~/WebSite/WebSite.Master" AutoEventWireup="true" CodeBehind="SinemaDevi.TvSeries.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.SinemaDevi_TvSeries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section id="about" class="about section-show">
        <!-- ======= About Me ======= -->
        <div id="portfolio" class="portfolio">
            <div class="container">
                <div class="section-title">
                    <h2>Movies</h2>
                </div>
                <div class="form-row" style="">
                    <div class="col-md-11 form-group">
                        <asp:TextBox class="form-control" ID="txtSearch" placeholder="Vikings.." runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnSearch" class="btn btn-outline-dark" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </div>
                <div class="row">
                    <div class="col-lg-12 d-flex justify-content-center">
                        <ul id="portfolio-flters">
                            <a href="SinemaDevi.TvSeries.aspx">
                                <li>Tümü</li>
                            </a>
                            <asp:Repeater ID="rptCategories" runat="server">
                                <ItemTemplate>
                                    <a href='SinemaDevi.TvSeries.aspx?id=<%#Eval("Id")%>'>
                                        <li><%#Eval("Name") %></li>
                                    </a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                </div>

                <div class="row portfolio-container">
                    <asp:Repeater ID="rptTvSeries" runat="server" OnItemCommand="rptTvSeries_ItemCommand">
                        <ItemTemplate>
                            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
                                <div class="portfolio-wrap">
                                    <img src="../Uploads/<%#Eval("CoverImage") %>" class="img-fluid" alt="">
                                    <div class="portfolio-info">
                                        <h4><%#Eval("Name") %></h4>
                                        <p></p>
                                        <div class="portfolio-links">
                                            <asp:LinkButton ID="btnAddWatchList" runat="server" CommandArgument='<%#Eval("Id")%>' CommandName="Add"><i class="bx bx-plus"></i></asp:LinkButton>
                                            <a href='TVSeriesDetails.aspx?id=<%#Eval("Id")%>' title="Film Detayları"><i class="bx bx-link"></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>

    </section>
    <!-- End Portfolio Section -->
</asp:Content>
