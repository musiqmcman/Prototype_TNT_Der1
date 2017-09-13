using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
    public partial class EditGuest : System.Web.UI.Page
    {
        private string guestId;
        private string type;
        private string password;
        private string guestUrl;
        private string temp;
        private string _password;
        private WebClient proxy;
        private char quote = '"';

        protected void Page_Load(object sender, EventArgs e)
        {
            guestId = Convert.ToString(Session["ID"]);
            char[] separator = { '!', '\n', '\r' };
            proxy = new WebClient();
            string eventListUrl =
                string.Format("http://localhost:53056/GuestEdit.svc/displayEditGuest/{0}", guestId);
            byte[] _data = proxy.DownloadData(eventListUrl);
            Stream memory = new MemoryStream(_data);
            var reader = new StreamReader(memory);
            string result = reader.ReadToEnd().Replace("Result", "").Replace("displayEditGuest", "").
                Replace(quote + "", "").Replace("{", "").Replace("}", "").Replace(":", "");
            string[] guestDetails = result.Split(separator);
            _password = guestDetails[3];

            if (!IsPostBack)
            {
                txtName.Text = guestDetails[0];
                txtLastname.Text = guestDetails[1];
                txtEmail.Text = guestDetails[2];
                password = guestDetails[3];
                drpType.DataTextField = guestDetails[4];
                temp = "N";
                if (guestDetails[4] == "Regular")
                {
                    drpType.SelectedIndex = 1;
                }
                else if (guestDetails[4] == "VIP")
                {
                    drpType.SelectedIndex = 2;
                }
                else { drpType.SelectedIndex = 3; }
            }
            lblEventName.Text = guestDetails[5];
            lblPrice.Text = "R" + guestDetails[6] + ".00";
            lblCountry.Text = guestDetails[7];
            lblProvince.Text = guestDetails[8];
            lblCity.Text = guestDetails[9];
            lblStreet.Text = guestDetails[10];
            /*
            htmltag = gst.Name + "!" + gst.Surname + "!" + gst.Email + "!" + gst.Password + "!" + gst.Type + " " +
                        eventName + "!" + price + "!" +
                        country + "!" + province + "!" + adCity + "!" + adStreet;
            */
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            if (drpType.SelectedValue == "1")
            {
                drpType.DataTextField = "Regular";
            }
            else if (drpType.SelectedValue == "2")
            {
                drpType.DataTextField = "VIP";
            }
            else
            {
                drpType.DataTextField = "VVIP";
            }
            type = drpType.DataTextField;
            Response.Write("<script>alert('" + temp + "');</script>");
            if (btnReset.Visible == false)
            {
                /////////////////////////////////////
                guestUrl =
                string.Format("http://localhost:53056/GuestEdit.svc/editGuest/{0},{1},{2},{3},{4},{5},{6},{7}", guestId, txtName.Text, txtLastname.Text, txtEmail.Text, type, _password, _password, _password);
                byte[] _data = proxy.DownloadData(guestUrl);
                Stream memory = new MemoryStream(_data);
                var reader = new StreamReader(memory);
                string result = reader.ReadToEnd().Replace("editGuest", "").Replace("Result", "").Replace(quote + "", "").Replace("{", "").Replace("}", "").Replace(":", "");
                turnoff.Visible = false;
                lblResponse.InnerText = result;
                lblResponse.Visible = true;
            }
            else if (btnReset.Visible == true)
            {
                guestUrl =
                string.Format("http://localhost:53056/GuestEdit.svc/editGuest/{0},{1},{2},{3},{4},{5},{6},{7}",
                guestId, txtName.Text, txtLastname.Text, txtEmail.Text, type,
                txtPassword.Text, txtNewPas.Text, txtConfirmPas.Text);
                byte[] _data = proxy.DownloadData(guestUrl);
                Stream memory = new MemoryStream(_data);
                var reader = new StreamReader(memory);
                string result = reader.ReadToEnd().Replace("editGuest", "").Replace("Result", "").
                    Replace(quote + "", "").Replace(quote + "", "").Replace("{", "").Replace("}", "").Replace(":", "");
                turnoff.Visible = false;
                lblResponse.InnerText = result;
                lblResponse.Visible = true;
            }
            else
            {
                Response.Write("<script>alert('Cant edit with null values');</script>");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            temp = "Reset";
            divPass.Visible = true;
            txtPassword.Visible = true;

            divNewpass.Visible = true;
            txtNewPas.Visible = true;

            divConfirmPass.Visible = true;
            txtConfirmPas.Visible = true;
            btnReset.Visible = false;
            btnDelete.Visible = false;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnReset.Visible = false;
            guestUrl =
                string.Format("http://localhost:53056/GuestEdit.svc/removeGuest/{0}",
                guestId);
            byte[] _data = proxy.DownloadData(guestUrl);
            Stream memory = new MemoryStream(_data);
            var reader = new StreamReader(memory);
            string result = reader.ReadToEnd().Replace("removeGuest", "").Replace("Result", "").
                Replace(quote + "", "").Replace(quote + "", "").Replace("{", "").Replace("}", "").Replace(":", "");
            turnoff.Visible = false;
            lblResponse.InnerText = result;
            lblResponse.Visible = true;
            btnDelete.Visible = false;
            eventDetals.Visible = false;
        }
    }
}