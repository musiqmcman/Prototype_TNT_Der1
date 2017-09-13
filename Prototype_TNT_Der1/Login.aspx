<%@ Page Title="" Language="C#" MasterPageFile="~/Eventrix.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Prototype_TNT_Der1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/Validation.css" rel="stylesheet" />
    <link href="css/ModalsProgress.css" rel="stylesheet" />
    <script src="scripts/js/Validation.js"></script>
        <style>
        #modalProgress {
            position: absolute;
            left: 50%;
            top: 50%;
            z-index: 99;
            width: 600px;
            height: 600px;
            margin: -75px 0 0 -75px;
            background-image: url("img/loader.gif");
            background-repeat: no-repeat;
        }

        /*tr, td {
            padding-bottom: 3%;
        }

        label {
            font-weight: bold;
        }*/

        .VeryPoorStrength {
            background: Red;
            color: White;
            font-weight: bold;
        }

        .WeakStrength {
            background: Gray;
            color: White;
            font-weight: bold;
        }

        .AverageStrength {
            background: orange;
            color: black;
            font-weight: bold;
        }

        .GoodStrength {
            background: blue;
            color: White;
            font-weight: bold;
        }

        .ExcellentStrength {
            background: Green;
            color: White;
            font-weight: bold;
        }

        .BarBorder {
            border-style: solid;
            border-width: 1px;
            width: 180px;
            padding: 2px;
            position: absolute;
        }

        /*Suceesful Reg*/
        .alert-box {
            color: #555;
            border-radius: 10px;
            font-family: Tahoma,Geneva,Arial,sans-serif;
            font-size: 11px;
            padding: 10px 36px;
            margin: 10px;
        }

            .alert-box span {
                font-weight: bold;
                text-transform: uppercase;
            }

        .error {
            background: #ffecec url('../../images/error.png') no-repeat 10px 50%;
            border: 1px solid #f5aca6;
        }

        .success {
            background: #e9ffd9 url('../../images/success.png') no-repeat 10px 50%;
            border: 1px solid #a6ca8a;
        }

        .warning {
            background: #fff8c4 url('../../images/warning.png') no-repeat 10px 50%;
            border: 1px solid #f2c779;
        }

        .notice {
            background: #e3f7fc url('../../images/notice.png') no-repeat 10px 50%;
            border: 1px solid #8ed9f6;
        }
        /*End*/
    </style>
    <script type="text/javascript">
        $("document").ready(function () {
            $("txtUserName").css("color", "red");
        });
    </script>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <section class="page-header-wrapper">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="page-header">
                        <h1>WELCOME</h1>
                    </div>
                </div>
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>

    <div class="container">
        <div class="login-wrapper">
        <div class="login-wrap">
            <div class="login-html">
                <input id="tab-1" type="radio" name="tab" class="sign-in" checked /><label for="tab-1" class="tab">Sign In</label>
                <input id="tab-2" type="radio" name="tab" class="sign-up"/><label for="tab-2" class="tab">Sign Up</label>
                <div class="login-form">
                    <div class="sign-in-htm">

                        <asp:Table runat="server" CssClass="group">
                            <asp:TableRow>
                                <asp:TableCell>
                                    <br />
                                    <label runat="server" id="lblLogin" for="user" class="label">Username</label>
                                    <asp:TextBox ID="txtUserName" runat="server" class="input" placeholder="name@mail.co" Height="40px" Width="370px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*Email Address Is Required" ControlToValidate="txtUserName" CssClass="reqFieldValid">* Email Is Required</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="* Enter Valid Email Format" ControlToValidate="txtUserName" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="reqFieldValid" Display="Dynamic"></asp:RegularExpressionValidator>
                                </asp:TableCell>
                            </asp:TableRow>
                            <asp:TableRow>
                                <asp:TableCell>
                                    <label for="pass" class="label">Password</label>
                                    <asp:TextBox ID="txtLogPass" runat="server" type="password" class="input" data-type="password" placeholder="********" Height="40px" Width="370px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*Password Is Required" ControlToValidate="txtLogPass" CssClass="reqFieldValid">* Password Is Required</asp:RequiredFieldValidator>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                                <div class="group">
                                    <asp:Button ID="btnUserLog" class="button" runat="server" Text="Sign In" type="submit" OnClick="btnLogin_Click" />
                                <hr class="hr" />   
                                <a href="ForgotPasword.aspx">Forgot Password?</a>
                                </div>
                    </div>

                    <div class="sign-up-htm">
                            <asp:Table runat="server" CssClass="group">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <br />
                                        <asp:TextBox ID="txtName" runat="server" class="input" placeholder="Name" ToolTip="Enter Name" Height="34px" Width="370px"></asp:TextBox>
                                   </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtSurname" runat="server" class="input" placeholder="Surname" ToolTip="User Surname" Height="34px" Width="370px"></asp:TextBox>
                                   </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtEmail" runat="server" class="input" placeholder="name@mail.co" TextMode="Email" ToolTip="User Email" Height="34px" Width="370px"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtPass" runat="server" class="input" placeholder="Password" TextMode="Password" ToolTip="Enter Password" Height="34px" Width="370px"></asp:TextBox>
                                  </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:TextBox ID="txtPass2" runat="server" class="input" placeholder="Confirm Password" TextMode="Password" ToolTip="Enter Same Password as above" Height="34px" Width="370px"></asp:TextBox>
                                       <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="* Passwords Do Not Match" ControlToCompare="txtPass" ControlToValidate="txtPass2" CssClass="reqFieldValid" Display="Dynamic" EnableViewState="true">* Passwords Do Not Match</asp:CompareValidator>
                                        <br />
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <span>
                                            <asp:CheckBox ID="mycheckbox" runat="server" Text="Event Hosts?" />
                                        </span>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                            <div class="group">
                                <asp:Button class="button" ID="btnRegister" runat="server" Text="Sign Up" type="submit" OnClick="btnRegister_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
    <!-- /.container -->
</asp:Content>
