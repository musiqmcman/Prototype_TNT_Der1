﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Eventrix.Master" AutoEventWireup="true" CodeBehind="EventList.aspx.cs" Inherits="Prototype_TNT_Der1.EventList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    	<section class="page-header-wrapper">
					<div class="container">
						<div class="row">
							<div class="col-md-12">
								<div class="page-header">
								  <h1>Events</h1>
								</div>
								<ol class="breadcrumb">
								  <li><a href="#">Home</a></li>
								  <li class="active">View Events</li>
								</ol>
							</div>
						</div><!-- /.row -->
					</div><!-- /.container-fluid -->
            
				</section>
    <div class="container">
					<div class="content-wrapper">
						<div class="inner-content">
					        <ul class="list-inline" id="filter">
					            <li><a class="active" data-group="all">All</a></li>
					            <li><a data-group="red">Conference</a></li>
					            <li><a data-group="green">Seminar</a></li>
					            <li><a data-group="blue">Award Ceremony</a></li>
					            <li><a data-group="letters">Trade Show</a></li>
					            <li><a data-group="numbers">Product Launch</a></li>
					            <li><a data-group="square">Wedding</a></li>
					            <li><a data-group="circle">Family Event</a></li>
					        </ul>

					        <div class="row">
					            <div id="grid" runat ="server">
					  <%--              <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "blue", "square"]'>
					                <div class="single-portfolio">
						                    <img src="img/work/portfolio-1.jpg" alt="">
										<div class="portfolio-links">
							                    <a class="image-link" href="img/work/portfolio-2.jpg"><i class="fa fa-search-plus"></i></a>
							                    <a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
											<li class="fa fa-link">
											 <a href="#" style=" font-size: 18px;
											    font-family: 'Roboto', sans-serif;
											    color: white;">
											  <p>Name</p>
											  <p>Time</p>
											  <p>Date</p>
											  <p>Location</p></a>
											</li>
											</div><!-- /.links -->
					                </div><!-- /.single-portfolio -->
					              </div><!-- /.portfolio-item -->--%>

					               <%-- <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "green", "square"]'>
					                	<div class="single-portfolio">
							                <img src="img/work/portfolio-2.jpg" alt="">
											<div class="portfolio-links">
							                    <a class="image-link" href="img/work/portfolio-2.jpg"><i class="fa fa-search-plus"></i></a>
							                    <a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
											<li class="fa fa-link">
											 <a href="#" style=" font-size: 18px;
											    font-family: 'Roboto', sans-serif;
											    color: white;">
											  <p>Name</p>
											  <p>Time</p>
											  <p>Date</p>
											  <p>Location</p></a>
											</li>
											</div><!-- /.links -->
						                </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "letters", "blue", "square"]'>
					                	<div class="single-portfolio">
						                  	<img src="img/work/portfolio-3.jpg" alt="">
											<div class="portfolio-links">
					                        	<a class="image-link" href="img/work/portfolio-3.jpg"><i class="fa fa-search-plus"></i></a>
					                        	<a href="portfolio-single.html"><i class="fa fa-link"></i></a>
						                   </div><!-- /.links -->
					                    </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "red", "square"]'>
					                	<div class="single-portfolio">
						                	<img src="img/work/portfolio-4.jpg" alt="">
											<div class="portfolio-links">
					                        	<a class="image-link" href="img/work/portfolio-4.jpg"><i class="fa fa-search-plus"></i></a>
					                        	<a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
							                </div><!-- /.links -->
					                  	</div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "red", "circle"]'>
					                	<div class="single-portfolio">
						                  <img src="img/work/portfolio-5.jpg" alt="">
											<div class="portfolio-links">
					                        	<a class="image-link" href="img/work/portfolio-5.jpg"><i class="fa fa-search-plus"></i></a>
					                        	<a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
							                </div><!-- /.links -->
					                  	</div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "red", "square"]'>
					                	<div class="single-portfolio">
						                  	<img src="img/work/portfolio-6.jpg" alt="">
											<div class="portfolio-links">
						                        <a class="image-link" href="img/work/portfolio-6.jpg"><i class="fa fa-search-plus"></i></a>
						                        <a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
						                   	</div><!-- /.links -->
					                  	</div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "green", "circle"]'>
					                	<div class="single-portfolio">
						                  	<img src="img/work/portfolio-7.jpg" alt="">
											<div class="portfolio-links">
						                        <a class="image-link" href="img/work/portfolio-7.jpg"><i class="fa fa-search-plus"></i></a>
						                        <a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
						                    </div><!-- /.links -->
					                  </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "letters", "red", "square"]'>
					                	<div class="single-portfolio">
					                    	<img src="img/work/portfolio-8.jpg" alt="">
											<div class="portfolio-links">
						                        <a class="image-link" href="img/work/portfolio-8.jpg"><i class="fa fa-search-plus"></i></a>
						                        <a href="EventDetails.aspx"><i class="fa fa-link"></i></a>
						                    </div><!-- /.links -->
				                    	</div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "green", "square"]'>
					                	<div class="single-portfolio">
						                    <img src="img/work/portfolio-9.jpg" alt="">
											<div class="portfolio-links">
						                        <a class="image-link" href="img/work/portfolio-9.jpg"><i class="fa fa-search-plus"></i></a>
						                        <a href="portfolio-single.html"><i class="fa fa-link"></i></a>
						                    </div><!-- /.links -->
					                  </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "letters", "green", "circle"]'>
					                	<div class="single-portfolio">
							                <img src="img/work/portfolio-10.jpg" alt="">
											<div class="portfolio-links">
					                        	<a class="image-link" href="img/work/portfolio-10.jpg"><i class="fa fa-search-plus"></i></a>
					                        	<a href="portfolio-single.html"><i class="fa fa-link"></i></a>
							                </div><!-- /.links -->
					                    </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "numbers", "blue", "square"]'>
					                	<div class="single-portfolio">
							                <img src="img/work/portfolio-11.jpg" alt="">
											<div class="portfolio-links">
						                     	<a class="image-link" href="img/work/portfolio-11.jpg"><i class="fa fa-search-plus"></i></a>
						                    	<a href="portfolio-single.html"><i class="fa fa-link"></i></a>
							                </div><!-- /.links -->
					                    </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->

					                <div class="portfolio-item col-sm-6 col-md-4" data-groups='["all", "letters", "red", "square"]'>
					                	<div class="single-portfolio">
						                    <img src="img/work/portfolio-12.jpg" alt="">
											<div class="portfolio-links">
						                        <a class="image-link" href="img/work/portfolio-12.jpg"><i class="fa fa-search-plus"></i></a>
						                        <a href="portfolio-single.html"><i class="fa fa-link"></i></a>
						                    </div><!-- /.links -->
					                  </div><!-- /.single-portfolio -->
					                </div><!-- /.portfolio-item -->--%>
					            </div><!-- /#grid -->
					        </div><!-- /.row -->
						</div><!-- /.inner-content -->
					</div><!-- /.content-wrapper -->
				</div><!-- /.container -->

</asp:Content>