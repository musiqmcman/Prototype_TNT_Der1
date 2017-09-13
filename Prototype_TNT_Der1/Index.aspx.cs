using Eventrix_Client;
using Eventrix_Client.Model;
using Eventrix_Client.Model.ClientDefinition;
using Eventrix_Client.Model.ServiceClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageFile img = new ImageFile();
            FileUploadClient fuc = new FileUploadClient();
            List<EventModel> display = new List<EventModel>();
            EventServiceClient esc = new EventServiceClient();
            display = esc.findAllEvent();
            string htmltag = "";
            for(int i = 0; i < 4; i++)
            {
                EventModel em = display[i];
                string EventID = Convert.ToString(em.EventID);
                string output = "";
                string imgLocation = "";
                img = fuc.getImageById(EventID);
                if (img == null)
                {
                    output = "Events/Eventrix_Default_Image.png";
                }
                else
                {
                    imgLocation = img.Location;
                    output = imgLocation.Substring(imgLocation.IndexOf('E')); //trim string path from Event
                }
                htmltag += "<div class='col-md-6 wow fadeInRight'>";
                htmltag += "<div class='media'>";
                htmltag += "<a class='media-left' href='EventDetails.aspx?EventID=" + em.EventID + "'>";
                htmltag += "<img src='" + output + "' alt='' style='height:230px;'></a>";  //image
                htmltag += "<div class='media-body'>";
                htmltag += "<h2 class='media-heading'><a href='EventDetails.aspx?EventID=" + em.EventID + "'>" + em.Name + "</a></h2>";
                htmltag += "<p>" + em.sDate + ", till " + em.eDate + "</p>";
                htmltag += " </div>";
                htmltag += "<!-- /.media-body -->";
                htmltag += "</div>";
                htmltag += "<!-- /.media -->";
                htmltag += "</div>";

                //< div class="col-md-6 wow fadeInRight">
                //        <div class="media">
                //            <a class="media-left" href="#">
                //                <span class="icon bg1 flaticon-increasing5"></span>
                //            </a>
                //            <div class="media-body">
                //                <h2 class="media-heading"><a href = "#" > Global business</a></h2>
                //                <p>Assertively target turnkey technologies whereas covalent ROI.Distinctively grow viral mindshare rather than collaborative meta-services redibly initiate.</p>
                //            </div>
                //            <!-- /.media-body -->
                //        </div>
                //        <!-- /.media -->
                //    </div>
            }
            divImage.InnerHtml = htmltag;
        }
    }
}