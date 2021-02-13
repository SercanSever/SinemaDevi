<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLoginPage.aspx.cs" Inherits="SinemaDevi.WebUI.Administrator.AdminLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login / Admin</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../TemplateLogin/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../TemplateLogin/fonts/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../TemplateLogin/fonts/Linearicons-Free-v1.0.0/icon-font.min.css" rel="stylesheet" />
    <link href="../TemplateLogin/vendor/animate/animate.css" rel="stylesheet" />
    <link href="../TemplateLogin/vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" />
    <link href="../TemplateLogin/vendor/animsition/css/animsition.min.css" rel="stylesheet" />
    <link href="../TemplateLogin/vendor/select2/select2.min.css" rel="stylesheet" />
    <link href="../TemplateLogin/vendor/daterangepicker/daterangepicker.css" rel="stylesheet" />
    <link href="../TemplateLogin/css/main.css" rel="stylesheet" />
    <link href="../TemplateLogin/css/util.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="limiter">
                <div class="container-login100">
                    <div class="wrap-login100 p-t-50 p-b-90">
                        <div class="login100-form validate-form flex-sb flex-w">
                            <span class="login100-form-title p-b-51">Admin / Login
                            </span>
                            <div class="wrap-input100 validate-input m-b-16" data-validate="Email is required">                            
                                <asp:TextBox class="input100" ID="txtEmail" runat="server" placeholder="E-mail" ></asp:TextBox>
                                <span class="focus-input100"></span>
                            </div>
                            <div class="wrap-input100 validate-input m-b-16" data-validate="Password is required">                  
                                <asp:TextBox class="input100" type="password" ID="txtPassword"  placeholder="Password" runat="server"></asp:TextBox>
                                <span class="focus-input100"></span>
                            </div>
                            <div class="flex-sb-m w-full p-t-3 p-b-24">
                                <div class="contact100-form-checkbox">
                                    <asp:CheckBox class="checkbox100" ID="checkRemember" runat="server" /> Remember Me
                                </div>                              
                            </div>
                            <div class="container-login100-form-btn m-t-17">
                                <asp:LinkButton class="login100-form-btn" ID="btnLogin" runat="server" OnClick="btnLogin_Click">Login</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <script src="../TemplateLogin/vendor/jquery/jquery-3.2.1.min.js"></script>
            <script src="../TemplateLogin/vendor/animsition/js/animsition.min.js"></script>
            <script src="../TemplateLogin/vendor/bootstrap/js/popper.js"></script>
            <script src="../TemplateLogin/vendor/bootstrap/js/bootstrap.min.js"></script>
            <script src="../TemplateLogin/vendor/select2/select2.min.js"></script>
            <script src="../TemplateLogin/vendor/daterangepicker/moment.min.js"></script>
            <script src="../TemplateLogin/vendor/daterangepicker/daterangepicker.js"></script>
            <script src="../TemplateLogin/vendor/countdowntime/countdowntime.js"></script>
            <script src="../TemplateLogin/js/main.js"></script>
        </div>
    </form>
</body>
</html>
