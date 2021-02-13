<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SinemaDevi.Login.aspx.cs" Inherits="SinemaDevi.WebUI.WebSite.SinemaDevi_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <style>
        *,
        *::before,
        *::after {
            box-sizing: border-box;
        }

        html,
        body {
            height: 100%;
            font-family: Open Sans;
        }


        /*--------------------
Buttons
--------------------*/
        .btn {
            display: block;
            background: #bded7d;
            color: white;
            text-decoration: none;
            margin: 20px 0;
            padding: 15px 15px;
            border-radius: 5px;
            position: relative;
        }

            .btn::after {
                content: "";
                position: absolute;
                z-index: 1;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                -webkit-transition: all 0.2s ease-in-out;
                transition: all 0.2s ease-in-out;
                box-shadow: inset 0 3px 0 rgba(0, 0, 0, 0), 0 3px 3px rgba(0, 0, 0, 0.2);
                border-radius: 5px;
            }

            .btn:hover::after {
                background: rgba(0, 0, 0, 0.1);
                box-shadow: inset 0 3px 0 rgba(0, 0, 0, 0.2);
            }

        .btn-social {
            padding-left: 64px;
            position: relative;
            z-index: 1;
        }

            .btn-social .fa {
                position: absolute;
                top: 0;
                left: 0;
                z-index: 1;
                width: 50px;
                height: 100%;
                text-align: center;
                background: rgba(0, 0, 0, 0.1);
                line-height: 3.2;
                border-radius: 5px 0 0 5px;
            }

        .btn-facebook {
            background-color: #3b5897;
        }

        .btn-twitter {
            background-color: #53abee;
        }

        .btn-google {
            background-color: #de4e3b;
        }

        .btn-linkedin {
            background-color: #00a1db;
        }

        /*--------------------
Form
--------------------*/
        .form fieldset {
            border: none;
            padding: 0;
            margin: 20px 0;
            position: relative;
        }

            .form fieldset #txtPassword, #txtEmail, #txtUserName {
                width: 100%;
                height: 48px;
                color: #333333;
                padding: 15px 40px 15px 15px;
                border-radius: 5px;
                font-size: 14px;
                outline: none !important;
                border: 1px solid rgba(0, 0, 0, 0.3);
                box-shadow: inset 0 1px 4px rgba(0, 0, 0, 0.2);
                vertical-align: top;
            }

        .form button {
            width: 100%;
            outline: none !important;
            background: linear-gradient(-5deg, #79b52c, #94d63d);
            border: none;
            text-transform: uppercase;
            font-weight: bold;
            box-shadow: 0 3px 0px rgba(115, 136, 89, 0.2);
            text-shadow: 0 2px 3px rgba(0, 0, 0, 0.2);
        }

        #btnSave {
            width: 100%;
            outline: none !important;
            background: linear-gradient(-5deg, #79b52c, #94d63d);
            border: none;
            text-transform: uppercase;
            font-weight: bold;
            box-shadow: 0 3px 0px rgba(115, 136, 89, 0.2);
            text-shadow: 0 2px 3px rgba(0, 0, 0, 0.2);
        }

        #btnSıgnIn {
            width: 100%;
            outline: none !important;
            background: linear-gradient(-5deg, #79b52c, #94d63d);
            border: none;
            text-transform: uppercase;
            font-weight: bold;
            box-shadow: 0 3px 0px rgba(115, 136, 89, 0.2);
            text-shadow: 0 2px 3px rgba(0, 0, 0, 0.2);
        }
        /*--------------------
Signup
--------------------*/
        .signup {
            position: absolute;
            top: 50%;
            left: 50%;
            -webkit-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
            z-index: 1;
            width: 800px;
            background: white;
            border-radius: 10px;
            box-shadow: 0 3px 25px rgba(0, 0, 0, 0.2);
            overflow: hidden;
            display: -webkit-box;
            display: flex;
        }

        .signup-connect,
        .signup-classic {
            width: 50%;
            padding: 30px 50px;
        }

        .signup-connect {
            background: linear-gradient(134deg, #fbce50, #e08106);
            color: white;
        }

            .signup-connect h1 {
                font-size: 30px;
                margin-top: 10px;
                margin-bottom: 40px;
                text-shadow: 0 2px 3px rgba(0, 0, 0, 0.1);
            }

        .signup-classic h2 {
            font-size: 16px;
            font-weight: normal;
            margin-top: 23px;
            margin-bottom: 43px;
            text-shadow: 0 2px 3px rgba(0, 0, 0, 0.1);
        }

        .signup-classic fieldset::after {
            content: "\f007";
            font-family: FontAwesome;
            position: absolute;
            right: 15px;
            top: 17px;
            z-index: 2;
            width: 20px;
            color: rgba(0, 0, 0, 0.2);
            text-align: center;
        }

        .signup-classic fieldset.email::after {
            content: "\f0e0";
        }

        .signup-classic fieldset.password::after {
            content: "\f023";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="signup">
            <div class="signup-connect">
                <h1>Sign in to  <a style="text-decoration: none" href="SinemaDevi.Home.aspx">SİNEMADEVİ</a> </h1>
                <a href="#" class="btn btn-social btn-facebook"><i class="fa fa-facebook"></i>Sign in with Facebook</a>
                <a href="#" class="btn btn-social btn-twitter"><i class="fa fa-twitter"></i>Sign in with Twitter</a>
                <a href="#" class="btn btn-social btn-google"><i class="fa fa-google"></i>Sign in with Google</a>
            </div>
            <div class="signup-classic">
                <h2>Or use the classical way</h2>
                <div class="form">
                    <fieldset class="username">
                        <asp:TextBox ID="txtUserName" placeholder="Username" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset class="email">
                        <asp:TextBox ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset class="password">
                        <asp:TextBox ID="txtPassword" TextMode="Password" placeholder="password" runat="server"></asp:TextBox>
                    </fieldset>
                    <asp:CheckBox class="checkbox100" ID="checkRemember" runat="server" />
                    Remember Me
                    <asp:LinkButton class="btn btn-primary btn-md" ID="btnSıgnIn" runat="server" OnClick="btnSıgnIn_Click">Sıgn In !</asp:LinkButton>
                    <p>Or</p>
                    <asp:LinkButton OnClick="btnSave_Click" class="btn btn-primary btn-md" ID="btnSave" runat="server">Create New Account..</asp:LinkButton>

                </div>
            </div>
        </div>
    </form>
</body>

</html>
