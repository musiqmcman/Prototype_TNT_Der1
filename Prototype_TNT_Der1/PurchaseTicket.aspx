<%@ Page Title="" Language="C#" MasterPageFile="~/Eventrix.Master" AutoEventWireup="true" CodeBehind="PurchaseTicket.aspx.cs" Inherits="Prototype_TNT_Der1.PurchaseTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <section class="page-header-wrapper">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="page-header">
                        <h1>Ticket Purchase</h1>
                    </div>
                </div>
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </section>

    <div class="container">
        <div class="login-wrapper">
            <div class="login-wrap">
                <div class="login-html">
                    <input id="tab-1" type="radio" name="tab" class="sign-in" checked/><label for="tab-1" class="tab">Guest Info</label>
                    <input id="tab-2" type="radio" name="tab" class="sign-up" /><label for="tab-2" class="tab"></label>
                    <div class="login-form">
                        <div class="sign-in-htm">
                            <asp:Table runat="server" CssClass="group">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <br />
                                        <label runat="server" id="lblName" class="label">Name</label>
                                        <asp:TextBox ID="txtU_name" runat="server" class="input" Height="35px" Width="380px" ></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell>
                                         <label runat="server" id="lblSurname" class="label">Surname</label>
                                        <asp:TextBox ID="txtU_surname" runat="server" class="input" Height="35px" Width="380px" ></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell>
                                        <label runat="server" id="lblemail" class="label">Email</label>
                                        <asp:TextBox ID="txtU_Email" runat="server" class="input" Height="35px" Width="380px"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell>
                                        <label runat="server" id="lblQty" class="label">Quantity</label>
                                        <asp:TextBox TextMode="Number" ID="txtQtys" runat="server" class="input" Height="35px" Width="380px"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                            <div class="group">
                                <hr class="hr" />
                                <asp:Button class="button" ID="btnSave" runat="server" Text="Buy Ticket" type="submit" OnClick="btnSave_Click1"/>
                            </div>
                        </div>

                        <div class="sign-up-htm">
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>

</asp:Content>
