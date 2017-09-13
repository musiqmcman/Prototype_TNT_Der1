using Eventrix_Client;
using Eventrix_Client.Model;
using Eventrix_Client.Model.ClientDefinition;
using Eventrix_Client.Model.ServiceClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
    public partial class EventDetails : System.Web.UI.Page
    {
        int strEventID;
        protected void Page_Load(object sender, EventArgs e)
        {
            String request = (Request.QueryString["EventID"]);
            string HostLevel = Convert.ToString(Session["Level"]);
            int HostID = Convert.ToInt32(Session["ID"]);
            if (HostLevel.Equals("Host"))
            {
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                
            }
            else
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            int EventID = Convert.ToInt32(request);
            strEventID = EventID;
            EventModel em = new EventModel();
            ImageFile img = new ImageFile();
            List<ImageFile> listimages = new List<ImageFile>();
            List<EventProduct> products = new List<EventProduct>();
            EventTicket EB_tickets = new EventTicket();
            EventTicket REG_tickets = new EventTicket();
            EventTicket VIP_tickets = new EventTicket();
            EventTicket VVIP_tickets = new EventTicket();
            EventServiceClient eventClient = new EventServiceClient();
            FileUploadClient fuc = new FileUploadClient();
            TicketServiceClient tsc = new TicketServiceClient();
            ProductServiceClient psc = new ProductServiceClient();

            em = eventClient.findByEventID(request);
            img = fuc.getImageById(request);
            listimages = fuc.getMultipleImagesById(request);
            string output = "";
            string imgLocation = "";
            ImageFile mainPic = new ImageFile();
            if (listimages.Count == 0)
            {
                output = "/Events/eventrix-icon.png";
                string strIhtml = "<img src='" + output + "' class='img-responsive' alt=''/>";
                divImageSlider.InnerHtml = strIhtml;
                secondaryImageSlider.Visible = false;
            }
            else
            if (listimages.Count == 1)  //one pic uploaded
            {
                imgLocation = img.Location;
                output = imgLocation.Substring(imgLocation.IndexOf('E')); //trim string path from Event
                                                                          //image slider
                string strIhtml = "<img src='" + output + "' class='img-responsive' alt=''/>";
                divImageSlider.InnerHtml = strIhtml;
                secondaryImageSlider.Visible = false;
            }
            else //more than one pic uploaded
            {
                mainPic = null;
                mainPic = listimages.First();
                imgLocation = mainPic.Location;
                output = imgLocation.Substring(imgLocation.IndexOf('E')); //trim string path from Event
                                                                          //image slider
                string secImageLocation = listimages[1].Location;
                string strIhtml = "<img src='" + output + "' class='img-responsive' alt=''/>";
                divImageSlider.InnerHtml = strIhtml;
                output = secImageLocation.Substring(imgLocation.IndexOf('E'));
                string secImageSlider = "<div class='item'><img src='" + output + "' class='img-responsive' alt=''/></div>";
                secondaryImageSlider.InnerHtml = secImageSlider;
            }

            string htmltag = "";
            htmltag = "Event Name: " + em.Name;
            EName.InnerHtml = htmltag;

            htmltag = "<span class='title'>Start Date : </span>" + em.sDate;
            StartDate.InnerHtml = htmltag;

            htmltag = "<span class='title'>End Date : </span>" + em.eDate;
            EndDate.InnerHtml = htmltag;

            htmltag = em.Desc;
            Description.InnerHtml = htmltag;

            htmltag = ""; //clean string 
            EB_tickets = tsc.getEBTicket(request);
            REG_tickets = tsc.getRegularTicket(request);
            VIP_tickets = tsc.getVIPTicket(request);
            VVIP_tickets = tsc.getVVIPTicket(request);
            if (EB_tickets != null)
            {
                if(EB_tickets._Price.Equals(0))
                {
                    htmltag += "<li><span class='title'>Early Bird Tickets :Available( " + em.EB_Quantity + ") </span> Price: For Free!, Available Till: " + EB_tickets._EndDate + "</li>";
                }
                else
                {
                    htmltag += "<li><span class='title'>Early Bird Tickets :Available( " + em.EB_Quantity + ") </span> Price: R" + EB_tickets._Price + ", Available Till: " + EB_tickets._EndDate + "</li>";
                }
                htmltag += "<li><a class='btn btn-primary animated bounceIn' href ='PurchaseTicket.aspx?EBT_ID=" + EB_tickets._TicketID + "&E_ID="+ request + "'>Buy Early Bird Ticket</a></li>";
            }

            if (REG_tickets != null)
            {
                if(REG_tickets._Price.Equals(0))
                {
                    htmltag += "<li><span class='title'>Regular Tickets :Available(" + em.Reg_Quantity + ") </span> Price: For Free!, Available Till: " + REG_tickets._EndDate + "</li>";
                }else
                {
                    htmltag += "<li><span class='title'>Regular Tickets :Available(" + em.Reg_Quantity + ") </span> Price: R" + REG_tickets._Price + ", Available Till: " + REG_tickets._EndDate + "</li>";
                }
                htmltag += "<li><a class='btn btn-primary animated bounceIn' href ='PurchaseTicket.aspx?RBT_ID=" + REG_tickets._TicketID + "&E_ID=" + request + "'>Buy Regular Ticket</a></li>";
            }
            if (VIP_tickets != null)
            {
                if(VIP_tickets._Price.Equals(0))
                {
                    htmltag += "<li><span class='title'>VIP Tickets :Available(" + em.VIP_Quantity + ") </span> Price: For Free!, Available Till: " + VIP_tickets._EndDate + "</li>";
                }else
                {
                    htmltag += "<li><span class='title'>VIP Tickets :Available(" + em.VIP_Quantity + ") </span> Price: R" + VIP_tickets._Price + ", Available Till: " + VIP_tickets._EndDate + "</li>";
                }
                htmltag += "<li><a class='btn btn-primary animated bounceIn' href ='PurchaseTicket.aspx?VT_ID=" + VIP_tickets._TicketID + "&E_ID=" + request + "'>Buy VIP Ticket</a></li>";
            }
            if (VVIP_tickets != null)
            {
                if(VVIP_tickets._Price.Equals(0))
                {
                    htmltag += "<li><span class='title'>VVIP Tickets :Available(" + em.VVIP_Quantity + ") </span> Price: For Free!, Available Till: " + VVIP_tickets._EndDate + "</li>";
                }else
                {
                    htmltag += "<li><span class='title'>VVIP Tickets :Available(" + em.VVIP_Quantity + ") </span> Price: R" + VVIP_tickets._Price + ", Available Till: " + VVIP_tickets._EndDate + "</li>";
                }
                htmltag += "<li><a class='btn btn-primary animated bounceIn' href ='PurchaseTicket.aspx?VVT_ID=" + VVIP_tickets._TicketID + "&E_ID=" + request + "'>Buy VVIP Ticket</a></li>";
            }
            ticketInfo.InnerHtml = htmltag;

            //check if ticket entrance is for free
            if (EB_tickets == null && REG_tickets == null && VIP_tickets == null && VVIP_tickets == null)
            {
                AttendEvent.Visible = true;
            }else
            {
                AttendEvent.Visible = false;
            }

            htmltag = ""; //clean string
            products = psc.getProductByEventID(request);
            int PC = products.Count();

            int count = 1;
            if (products != null)
            {
               if(PC != 0)
                {
                    htmltag = "<span class='title'>Products Sold</span>";
                    ProductsHeading.InnerHtml = htmltag;
                    htmltag = "";
                }
                foreach (EventProduct ep in products)
                {
                    htmltag += "<li><span class='title'>" + count + ". " + ep._Name + "</span>Price: R" + ep._Price + "</li>";
                    count++;
                }
                Products.InnerHtml = htmltag;
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditEvent.aspx?EventID=" + strEventID);
        }
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("EventList.aspx?dl=" + strEventID);
            
        }
    }
}