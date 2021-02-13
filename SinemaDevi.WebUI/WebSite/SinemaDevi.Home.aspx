<%@ Page Title="SinemaDevi" Language="C#" MasterPageFile="~/WebSite/WebSite.Master" AutoEventWireup="true" CodeBehind="SinemaDevi.Home.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.WebSite_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container1 {
            position: relative;
            overflow: hidden;
            width: 100%;
            padding-top: 56.25%; /* 16:9 Aspect Ratio (divide 9 by 16 = 0.5625) */
        }

        /* Then style the iframe to fit in the container div with full height and width */
        .responsive-iframe {
            position: absolute;
            top: 0;
            left: 0;
            bottom: 0;
            right: 0;
            width: 100%;
            height: 100%;
        }

        /* Three columns side by side */
        .column {
            float: left;
            width: 90%;
            margin-bottom: 16px;
            padding: 0 8px;
            opacity: 0.8;
        }

        /* Display the columns below each other instead of side by side on small screens */
        @media screen and (max-width: 400px) {
            .column {
                width: 100%;
                display: block;
            }
        }

        /* Add some shadows to create a card effect */
        .card {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        }

        /* Some left and right padding inside the container */
        .container {
            padding: 0 16px;
        }

            /* Clear floats */
            .container::after, .row::after {
                content: "";
                clear: both;
                display: table;
            }

        .title {
            color: grey;
        }

        .button {
            border: none;
            outline: 0;
            display: inline-block;
            padding: 8px;
            color: white;
            background-color: #000;
            text-align: center;
            cursor: pointer;
            width: 100%;
        }

            .button:hover {
                background-color: #555;
            }


        /*Footer*/
        .footer {
            position: absolute;
            right: 0;
            bottom: 0;
            left: 0;
            padding: 1rem;
            background-color: #efefef;
            text-align: center;
        }

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section id="about" class="about section-show">
        <!-- ======= About Me ======= -->
        <div class="about-me container">
            <div class="section-title">
                <h2 style="font-size: larger"><strong>Home</strong></h2>
            </div>
        
            <div class="row">
                <div id="carouselExampleControls" class="carousel slide col-lg-12" data-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <div class="container1">
                                <iframe class="responsive-iframe" src="https://www.youtube.com/embed/pU8-7BX9uxs"></iframe>
                            </div>
                        </div>
                        <asp:Repeater ID="rptTrailers" runat="server">
                            <ItemTemplate>
                                <div class="carousel-item">
                                    <div class="container1">
                                        <iframe class="responsive-iframe" src="<%#Eval("Trailer")%>"></iframe>
                                        <div class="carousel-caption d-none d-md-block">
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>
            <br />
        </div>
        <!-- End About Me -->

        <!-- Testimonials -->
        <div class="testimonials container">
            <div class="section-title">
                <h2 style="font-size: xx-large"><strong>Movies</strong></h2>
            </div>
            <div class="owl-carousel testimonials-carousel">
                <asp:Repeater ID="rptMovies" runat="server" OnItemCommand="rptMovies_ItemCommand">
                    <ItemTemplate>
                        <div class="column">
                            <div class="card">
                                <a style="text-decoration: none" href='SinemaDevi.MovieDetails.aspx?id=<%#Eval("Id")%>'>
                                    <img src="../Uploads/<%#Eval("CoverImage") %>" style="width: 100%" /></a>
                                <div class="container">
                                    <h2><%#Eval("Name")%></h2>
                                    <p class="title">IMDB : <%#Eval("ImdbScore")%></p>
                                    <p>
                                        <asp:LinkButton ID="btnWatchlistAdd" CommandArgument='<%#Eval("Id")%>' CommandName="Add" class="button" runat="server">Add Watchlist</asp:LinkButton>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

        <!-- End Testimonials  -->

        <div class="testimonials container">
            <div class="section-title">
                <h2 style="font-size: xx-large"><strong>TV Series</strong></h2>
            </div>
            <div class="owl-carousel testimonials-carousel">
                <asp:Repeater ID="rptTvSeries" runat="server" OnItemCommand="rptTvSeries_ItemCommand">
                    <ItemTemplate>
                        <div class="column">
                            <div class="card">
                                <a style="text-decoration: none" href='TVSeriesDetails.aspx?id=<%#Eval("Id")%>'>
                                    <img src="../Uploads/<%#Eval("CoverImage") %>" style="width: 100%" /></a>
                                <div class="container">
                                    <h2><%#Eval("Name")%></h2>
                                    <p class="title">IMDB : <%#Eval("ImdbScore")%></p>
                                    <p>
                                        <asp:LinkButton ID="btnWatchlistAdd" CommandArgument='<%#Eval("Id")%>' CommandName="Add" class="button" runat="server">Add Watchlist</asp:LinkButton>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <!-- End Testimonials  -->

        <div class="testimonials container">
            <div class="section-title">
                <h2 style="font-size: xx-large"><strong>Actors</strong></h2>
            </div>

            <div class="owl-carousel testimonials-carousel">
                <asp:Repeater ID="rptActorImages" runat="server">
                    <ItemTemplate>
                        <div class="testimonial-item">
                            <a style="text-decoration: none;" href="SinemaDevi.Actors.aspx">
                                <img src="../Uploads/<%#Eval("CoverImage") %>" /></a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <!-- End Testimonials  -->
        <br />
        <div class="footer" style="color: black; opacity: 0.7;"><strong>Designed By Sercan SEVER :)</strong><strong></strong></div>
    </section>
    <!-- End About Section -->
</asp:Content>
