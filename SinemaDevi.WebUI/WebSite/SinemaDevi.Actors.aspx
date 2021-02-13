<%@ Page Title="" Language="C#" MasterPageFile="~/WebSite/WebSite.Master" AutoEventWireup="true" CodeBehind="SinemaDevi.Actors.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.SinemaDevi_Actors" %>

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
                    <div class="col-md-12 form-group">
                        <input type="text" name="name" class="form-control" id="name" placeholder="Travis Fimmel.." data-rule="minlen:4" data-msg="Please enter at least 4 chars" />
                        <div class="validate"></div>
                    </div>
                </div>
                <div class="row portfolio-container">
                    <asp:Repeater ID="rptActors" runat="server">
                        <ItemTemplate>
                            <div class="col-lg-4 col-md-6 portfolio-item filter-app">
                                <div class="portfolio-wrap">
                                    <img src="../Uploads/<%#Eval("CoverImage") %>" class="img-fluid" alt="">
                                    <div class="portfolio-info">
                                        <h4><%#Eval("Name")%></h4>
                                        <p></p>
                                       
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
