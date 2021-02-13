<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinemaDevi.SignUp.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.SinemaDevi_SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet" />

    <!-- Main CSS-->
    <link href="../TemplateSignUp/css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="page-wrapper bg-dark p-t-100 p-b-50">
                <div class="wrapper wrapper--w900">
                    <div class="card card-6">
                        <div class="card-heading">
                            <h2 class="title">Create Account for Sinema<a href="SinemaDevi.Home.aspx"><strong style="color: cornflowerblue">Devi</strong></a></h2>
                        </div>
                        <div class="card-body">
                            <div>
                                <div class="form-row">
                                    <div class="name">Name</div>
                                    <div class="value">
                                        <asp:TextBox ID="txtName" runat="server" class="input--style-6" placeholder="Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="name">Email address</div>
                                    <div class="value">
                                        <div class="input-group">
                                            <asp:TextBox ID="txtEmail" runat="server" class="input--style-6" placeholder="example@email.com"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="name">Username</div>
                                    <div class="value">
                                        <div class="input-group">
                                            <asp:TextBox ID="txtUserName" runat="server" class="input--style-6" placeholder="Username"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="name">Password</div>
                                    <div class="value">
                                        <div class="input-group">
                                            <asp:TextBox ID="txtPassword" runat="server" class="input--style-6" placeholder="Password"></asp:TextBox>
                                        </div>
                                        <div class="label--desc">En az 8 karakter olmalıdır.</div>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="name">Re-enter Password</div>
                                    <div class="value">
                                        <div class="input-group">
                                            <asp:TextBox ID="txtRePassword" runat="server" class="input--style-6" placeholder="Password"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <asp:LinkButton ID="btnSignUp" OnClick="btnSignUp_Click" class="btn btn--radius-2 btn--blue-2" Text="Let's Finish This" runat="server" />
                            <div class="label--desc">
                                Already have an Account ?
                                <asp:LinkButton OnClick="Unnamed_Click" Text="Sign In" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Jquery JS-->
    <script src="../TemplateSignUp/vendor/jquery/jquery.min.js"></script>


    <!-- Main JS-->
    <script src="../TemplateSignUp/js/global.js"></script>

</body>
</html>
