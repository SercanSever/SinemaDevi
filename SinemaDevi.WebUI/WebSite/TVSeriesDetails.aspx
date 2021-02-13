<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TVSeriesDetails.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.TVSeriesDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />


    <meta content="" name="descriptison" />
    <meta content="" name="keywords" />

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet" />

    <!-- Vendor CSS Files -->
    <link href="../TemplateClient/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../TemplateClient/vendor/icofont/icofont.min.css" rel="stylesheet" />
    <link href="../TemplateClient/vendor/remixicon/remixicon.css" rel="stylesheet" />
    <link href="../TemplateClient/vendor/owl.carousel/assets/owl.carousel.min.css" rel="stylesheet" />
    <link href="../TemplateClient/vendor/boxicons/css/boxicons.min.css" rel="stylesheet" />
    <link href="../TemplateClient/vendor/venobox/venobox.css" rel="stylesheet" />


    <!-- Template Main CSS File -->
    <link href="../TemplateClient/css/style.css" rel="stylesheet" />
    <title></title>
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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <section id="about" class="about section-show">
                    <!-- ======= About Me ======= -->
                    <div class="about-me container">
                        <main id="main">
                            <!-- ======= Portfolio Details ======= -->
                            <div id="portfolio-details" class="portfolio-details">
                                <div class="container">

                                    <div class="row">

                                        <div class="col-lg-8">

                                            <a style="text-decoration: none" href='SinemaDevi.Home.aspx'>
                                                <h2 class="portfolio-title">SinemaDevi</h2>
                                            </a>
                                            <div class="owl-carousel portfolio-details-carousel">
                                                <asp:Image ID="coverImage" runat="server" />

                                            </div>
                                        </div>
                                        <div class="col-lg-4 portfolio-info">
                                            <%-- Name --%>
                                            <h3>
                                                <asp:Label ID="lblTvSeriesName" runat="server" />
                                            </h3>
                                            <ul>
                                                <li><strong>Categories</strong>:
                                                <asp:Label ID="lblCategories" Text="" runat="server" /></li>
                                                <li><strong>Year</strong>:
                                                <asp:Label ID="lblYear" Text="" runat="server" /></li>
                                                <li><strong>Director</strong>:
                                                <asp:Label ID="lblDirector" Text="" runat="server" />
                                                </li>
                                                <li><strong>Writer</strong>:
                                                <asp:Label ID="lblWriter" Text="" runat="server" />
                                                </li>
                                                <li><strong>Cast</strong>:
                                                <asp:Label ID="lblCast" Text="" runat="server" />
                                                </li>
                                                <li><strong>IMDB</strong>:
                                                <asp:Label ID="lblImdb" Text="" runat="server" />
                                                </li>
                                                <li><strong>SINEMADEVI</strong>:
                                                <asp:Label ID="lblSinemaDeviScore" Text="" runat="server" />
                                                </li>
                                            </ul>
                                            <%-- Summary --%>
                                            <p>
                                                <asp:Label ID="lblSummary" runat="server" Text="">

                                                </asp:Label>
                                            </p>
                                        </div>
                                        <div class="container1">
                                            <iframe id="trailer" class="responsive-iframe" src="" runat="server"></iframe>
                                        </div>

                                        <div id="contact" class="contact col-md-12">
                                            <div class="container">
                                                <div class="section-title">
                                                    <h2>Comments</h2>
                                                    <asp:Repeater ID="rptComments" runat="server">
                                                        <ItemTemplate>
                                                            <div class="col-md-12 d-flex align-items-stretch" style="margin-top: 5px;">
                                                                <div class="info-box">
                                                                    <i class="bx bx-comment-detail"></i>
                                                                    <h3><%#Eval("UserName") %></h3>
                                                                    <h5><%#Eval("CreationTime") %></h5>
                                                                    <p><%#Eval("Content") %></p>
                                                                </div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                    <br />
                                                    <p>Add Comment</p>
                                                </div>
                                                <div role="form" class="php-email-form mt-4">

                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtComment" TextMode="MultiLine" runat="server" class="form-control" Rows="5" placeholder="Message"></asp:TextBox>
                                                    </div>

                                                    <div class="text-center">
                                                        <asp:Button ID="btnComment" type="submit" runat="server" Text="Send Comment" OnClick="btnComment_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- End Portfolio Details -->

                        </main><!-- End #main -->

                    </div>
                </section>
                <!-- End About Section -->
            </div>
        </div>
    </form>
    <script src="../TemplateClient/vendor/jquery/jquery.min.js"></script>
    <script src="../TemplateClient/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../TemplateClient/vendor/jquery.easing/jquery.easing.min.js"></script>
    <script src="../TemplateClient/vendor/php-email-form/validate.js"></script>
    <script src="../TemplateClient/vendor/waypoints/jquery.waypoints.min.js"></script>
    <script src="../TemplateClient/vendor/counterup/counterup.min.js"></script>
    <script src="../TemplateClient/vendor/owl.carousel/owl.carousel.min.js"></script>
    <script src="../TemplateClient/vendor/isotope-layout/isotope.pkgd.min.js"></script>
    <script src="../TemplateClient/vendor/venobox/venobox.min.js"></script>
    <!-- Template Main JS File -->
    <script src="../TemplateClient/js/main.js"></script>
</body>
</html>
