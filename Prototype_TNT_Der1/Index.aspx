<%@ Page Title="" Language="C#" MasterPageFile="~/Eventrix.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prototype_TNT_Der1.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="x-corp-carousel" class="carousel slide hero-slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#x-corp-carousel" data-slide-to="0" class="active"></li>
            <li data-target="#x-corp-carousel" data-slide-to="1"></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="img/home/home-image-02.png" alt="Hero Slide" />
                <!--Slide Image-->
                <div class="container">
                    <div class="carousel-caption">
                        <h1 class="animated lightSpeedIn">Manage Your Event
                            <br />
                            With Efficiency</h1>
                        <p class="lead animated lightSpeedIn">
                            Create your event online, and try our smart guest import to invite guests.
                            Then send customized email invites with QR codes to your guests.
                        </p>
                    </div>
                    <!--.carousel-caption-->
                </div>
                <!--.container-->
            </div>
            <!--.item-->

            <div class="item">
                <img src="img/home/eventrix-home-Corp-rec.png" alt="Hero Slide" />
                <!--Slide Image-->

                <div class="container">
                    <div class="carousel-caption">

                        <h1 class="animated bounceIn">Check-in Guest And <br/>Monitor Your Event</h1>

                        <p class="lead animated bounceIn">Synchorinize your guest list and monitor arrivals on the device, get full analytics for your event in real time.</p>

                    </div>
                    <!--.carousel-caption-->
                </div>
                <!--.container-->
            </div>
            <!--.item-->
        </div>
        <!--.carousel-inner-->
        <!-- Controls -->
        <a class="left carousel-control" href="#x-corp-carousel" role="button" data-slide="prev">
            <i class="fa fa-angle-left" aria-hidden="true"></i>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#x-corp-carousel" role="button" data-slide="next">
            <i class="fa fa-angle-right" aria-hidden="true"></i>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <!-- #x-corp-carousel-->

    <div class="container">
        <div class="content-wrapper">
            <section class="service-wrapper">
                <h2 class="section-title wow fadeInDown">Upcoming Events</h2>
                <div class="row" runat="server" id="divImage">
                
                </div>
                <!-- /.row -->
            </section>
            <%-- Button to view more details --%>
            <a class='btn btn-primary animated bounceIn' href="EventList.aspx">MORE EVENTS</a>
        </div>
        <!-- /.content-wrapper -->
    </div>
    <!-- /.container -->
</asp:Content>
