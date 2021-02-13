<%@ Page Title="" Language="C#" MasterPageFile="~/WebSite/WebSite.Master" AutoEventWireup="true" CodeBehind="SinemaDevi.WatchList.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.SinemaDevi_WatchList" %>

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
             
                <div class="row">
                    <div class="col-lg-12 d-flex justify-content-center">
                        <ul id="portfolio-flters">
                            <a href="SinemaDevi.WatchList.aspx">
                                <li>Movies</li>
                            </a>
                            <a href="SinemaDevi.TvWatchList.aspx">
                                <li>TvSeries</li>
                            </a>
                        </ul>
                    </div>
                </div>
                <div class="row portfolio-container">
                    <asp:Repeater ID="rptWatchlist" runat="server" OnItemCommand="rptWatchlist_ItemCommand">
                        <ItemTemplate>
                            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
                                <div class="portfolio-wrap">
                                    <img src="../Uploads/<%#Eval("CoverImage") %>" class="img-fluid" alt="">
                                    <div class="portfolio-info">
                                        <h4><%#Eval("Name") %></h4>
                                        <p>
                                        </p>
                                        <div class="portfolio-links">
                                            <asp:LinkButton ID="btnDeleteWatchList" runat="server" CommandArgument='<%#Eval("Id")%>' CommandName="Delete" title="Remove"><i class="bx bx-arrow-from-top"></i></i></asp:LinkButton>

                                            <a href='SinemaDevi.MovieDetails.aspx?id=<%#Eval("Id")%>' title="Movie Details"><i class="bx bx-link"></i></a>
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
