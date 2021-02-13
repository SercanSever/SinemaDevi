<%@ Page Title="" Language="C#" MasterPageFile="~/WebSite/WebSite.Master" AutoEventWireup="true" CodeBehind="SinemaDevi.Contact.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.SinemaDevi_Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- ======= Contact Section ======= -->
    <section id="about" class="about section-show">
        <div id="contact" class="contact">
            <div class="container">

                <div class="section-title">
                    <h2>Contact</h2>
                    <p>Contact Me</p>
                </div>

                <div class="row mt-2">
                    <div class="col-md-6 mt-4 mt-md-0 d-flex align-items-stretch">
                        <div class="info-box">
                            <i class="bx bx-share-alt"></i>
                            <h3>Social Profiles</h3>
                            <div class="social-links">
                                <a href="https://twitter.com/" class="twitter"><i class="icofont-twitter"></i></a>
                                <a href="https://tr-tr.facebook.com/" class="facebook"><i class="icofont-facebook"></i></a>
                                <a href="https://www.instagram.com/" class="instagram"><i class="icofont-instagram"></i></a>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6 mt-4 mt-md-0 d-flex align-items-stretch">
                        <div class="info-box">
                            <i class="bx bx-envelope"></i>
                            <h3>Email Me</h3>
                            <p>sercan.sever16@gmail.com</p>
                        </div>
                    </div>
                </div>

                <div role="form" class="php-email-form mt-4">
                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <asp:TextBox ID="txtContactName" class="form-control" placeholder="Your Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6 form-group">
                            <asp:TextBox ID="txtContactSurname" class="form-control" placeholder="Your Surname" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-12 form-group">
                            <asp:TextBox ID="txtContactEmail" class="form-control" placeholder="Your Email" runat="server"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtContactMessage" TextMode="MultiLine" runat="server" class="form-control" Rows="5" placeholder="Message"></asp:TextBox>
                    </div>
                    
                    <div class="text-center">
                        <asp:Button ID="Button1" type="submit" runat="server" Text="Send Message" OnClick="Button1_Click" />
                    </div>
                </div>

            </div>
        </div>
    </section>
    <!-- End Contact Section -->
</asp:Content>
