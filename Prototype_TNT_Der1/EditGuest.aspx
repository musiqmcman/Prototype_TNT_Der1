<%@ Page Title="" Language="C#" MasterPageFile="~/Eventrix.Master" AutoEventWireup="true" CodeBehind="EditGuest.aspx.cs" Inherits="Prototype_TNT_Der1.EditGuest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?key=AIzaSyAI5uzweLamk9Tsnk01MwXpY4APBAfmbpw&sensor=false&libraries=places"></script>
    <script type="text/javascript">
        google.maps.event.addDomListener(window, 'load', function () {
            var places = new google.maps.places.Autocomplete(document.getElementById('txtPlaces'));
            google.maps.event.addListener(places, 'place_changed', function () {
                var place = places.getPlace();
                var address = place.formatted_address;
                var latitude = place.geometry.location.lat();
                var longitude = place.geometry.location.lng();
                document.getElementById("TextBox2").innerHTML = address;
                document.getElementById("TextBox3").innerHTML = latitude;
                document.getElementById("TextBox4").innerHTML = longitude;
                var mesg = "Address: " + address;
                mesg += "\nLatitude: " + latitude;
                mesg += "\nLongitude: " + longitude;
                alert(mesg);
            });
        });
    </script>
    <link rel="stylesheet" href="css/event-management.css" />
    <link href="css/Validation.css" rel="stylesheet" />
    <link href="css/ModalsProgress.css" rel="stylesheet" />
    <script src="scripts/js/Validation.js"></script>
    <style>
        .drpdwnList {
            background-color: red;
        }
    </style>
    <section class="page-header-wrapper">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="page-header">
                        <h1>Edit Your Details</h1>
                    </div>
                </div>
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
 

    <div class="container">
        <div class="event-wrap">
            <div class="event-html" style="width: 175%;">
                <input id="tab-1" type="radio" name="tab" class="event-detail" checked /><label for="tab-1" class="tab">Edit Details</label>
                <input id="tab-2" type="radio" name="tab" class="guest-detail" /><label for="tab-2" class="tab">Event Details</label>
                <input id="tab-3" type="radio" name="tab" visible="false" class="ticket-detail" /><label for="tab-3" class="tab"></label>
                <input id="tab-4" type="radio" name="tab" visible="false" class="product-detail" /><label for="tab-4" class="tab"></label>

                <div class="event-form">

                <div class="guest-detail-htm" id="eventDetals" runat="server"> <%--Guest Details--%>
                    <asp:Table runat="server" CssClass="group" align="center">
                   <asp:TableRow>
                        <asp:TableHeaderCell>
                            <label for="txtEventName" class="label">Event Name</label>
                        </asp:TableHeaderCell>
                        <asp:TableCell>
                            <br/><asp:Label ID="lblEventName" runat="server" class="input" Height="45px" Width="370px"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableHeaderCell>
                            <label for="txtEventName" class="label">Ticket Price</label>
                        </asp:TableHeaderCell>
                        <asp:TableCell>
                            <br/><asp:Label ID="lblPrice" runat="server" class="input" Height="45px" Width="370px"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableHeaderCell>
                            <label for="txtEventName" class="label">Country Name:</label>
                        </asp:TableHeaderCell>
                        <asp:TableCell>
                            <br/><asp:Label ID="lblCountry" runat="server" class="input" Height="45px" Width="370px"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableHeaderCell>
                            <label for="txtEventName" class="label">Province:</label>
                        </asp:TableHeaderCell>
                        <asp:TableCell>
                            <br/><asp:Label ID="lblProvince" runat="server" class="input" Height="45px" Width="370px"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableHeaderCell>
                            <label for="txtEventName" class="label">City</label>
                        </asp:TableHeaderCell>
                        <asp:TableCell>
                            <br/><asp:Label ID="lblCity" runat="server" class="input" Height="45px" Width="370px"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableHeaderCell>
                            <label for="txtEventName" class="label">Street Name</label>
                        </asp:TableHeaderCell>
                        <asp:TableCell>
                            <br/><asp:Label ID="lblStreet" runat="server" class="input" Height="45px" Width="370px"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                 </asp:Table>
				<%--<div class="group">
					<label for="email" class="label">Email Address</label>
					<input id="email" type="text" class="input"/>
				</div>--%>
				<%--<div class="group">
					<input runat="server" id="btnReg" type="submit" class="button" value="Sign Up"/>
				</div>--%>
				<div class="hr"></div>
                </div>

                    <div class="event-detail-htm" >
                        <div >
                    <h1>
                        <label for="user" id="lblResponse" visible="false" runat="server" class="label"></label>
                    </h1>
                </div>

                <div id="turnoff" runat="server">

                <div class="group">
					<label for="user" class="label">Username</label>
                    <asp:TextBox ID="txtName" class="input" runat="server"></asp:TextBox>
				</div>
                <div class="group">
					<label for="user" class="label">Lastname</label>
                    <asp:TextBox ID="txtLastname" class="input" runat="server"></asp:TextBox>

				</div>
                <div class="group">
					<label for="email" class="label">Email Address</label>
                    <asp:TextBox TextMode="email" ID="txtEmail" runat="server" class="input"></asp:TextBox>
				</div>
				
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="updatePanel2" runat="server"><ContentTemplate>
                <div id="divPass" class="group" visible="false" runat="server">
					<label for="pass" class="label">Password</label>
					<asp:TextBox TextMode="password" ID="txtPassword" runat="server" Visible="false" data-type="password" class="input"></asp:TextBox>

				</div>
                <div class="group" id="divNewpass" visible="false" runat="server">
					<label for="resert_pass" class="label">Enter New Password</label>
                    <asp:TextBox TextMode="password" ID="txtNewPas" runat="server" Visible="false" data-type="password" class="input"></asp:TextBox>
				</div>
                <div class="group" id="divConfirmPass" visible="false" runat="server">
					<label for="resert_pass" class="label">Confirm New Password</label>
                     <asp:TextBox TextMode="password" ID="txtConfirmPas" Visible="false" runat="server" data-type="password" class="input"></asp:TextBox>
				</div>
                 
                <div class="group">
                    <div>
                    <asp:DropDownList ID="drpType" runat="server" class="drpdwnlist" PlaceHolder="Select Ticket Type" AutoPostBack="True">
                        <asp:ListItem Value="1" Text="Regular"></asp:ListItem>
                        <asp:ListItem Value="2" Text="VIP"></asp:ListItem>
                        <asp:ListItem Value="3" Text="VVIP"></asp:ListItem>
                    </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Required Field" ControlToValidate="drpType" CssClass="reqFieldValid">*</asp:RequiredFieldValidator>
                </div>
                
                </div>
                <div class="group">
                    <asp:button ID="btnReset" runat="server" Text="Reset Password" OnClick="btnReset_Click" class="button" Height="46px" Width="163px" />
                </div>
                </ContentTemplate></asp:UpdatePanel>
                </div><!-- /.turnoff tag -->
                
				<div class="group">
                    <table style="border:hidden; width:40%;">
                        <tr>
                            <td><asp:Button ID="btnEdit" runat="server" Text="Submit Changes" OnClick="btnEdit_Click" class="button" Height="45px" Width="163px"></asp:Button></td>
                            <td><asp:Label ID="space" runat="server" Text="                 "></asp:Label></td>
                            <td> <asp:Button ID="btnDelete" runat="server" Text="Cancel Event" OnClick="btnDelete_Click" class="button" Height="46px" Width="163px"></asp:Button></td>
                        </tr>
                        </table>
                </div>
                <div class="hr"></div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- /.container -->
</asp:Content>
