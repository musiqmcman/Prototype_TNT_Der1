using Eventrix_Client;
using Eventrix_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin LoginClient = new UserLogin();
            GuestModel guest = new GuestModel();
            EventHostModel host = new EventHostModel();
            StaffModel staff = new StaffModel();
            string pass = txtLogPass.Text;
            string email = txtUserName.Text;

            host = LoginClient.hostLogin(email, pass);
            if (host == null)  //if user is not a host then check guest and host
            {
                guest = LoginClient.Guestlogin(email, pass);
                if (guest == null) //user is not a host nor a guest
                {
                    staff = LoginClient.staffLogin(email, pass);
                    if (staff == null) //the user is neither staff, guest nor host
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else    //the user is a staff
                    {
                        SetSessions(staff);
                        Response.Redirect("Index.aspx");
                    }
                }
                else   //the user is a guest
                {
                    SetSessions(guest);
                    Response.Redirect("Index.aspx");
                }
            }
            else  //the user is a host
            {
                // txtLogName.Text = host.NAME;
                SetSessions(host);
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            if (mycheckbox.Checked == false)  // register as Guest
            {
                GuestModel _guest = new GuestModel();
                GuestServiceClient g_client = new GuestServiceClient();
                _guest.NAME = txtName.Text;
                _guest.SURNAME = txtSurname.Text;
                _guest.EMAIL = txtEmail.Text;
                _guest.PASS = txtPass.Text;
                _guest.USERTYPE = "PUBLIC";
                bool isReg = g_client.createGuest(_guest);
                if (isReg == true)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Write("<scrpt>alert('Host Not Created');</script>");
                }
            }
            else  //register as event host
            {
                EventHostModel _host = new EventHostModel();
                HostServiceClient _hostClient = new HostServiceClient();
                _host.NAME = txtName.Text;
                _host.EMAIL = txtEmail.Text;
                _host.SURNAME = txtSurname.Text;
                _host.PASS = txtPass.Text;
                bool isReg = _hostClient.createHost(_host);
                if (isReg == true)
                {
                    Response.Write("<scrpt>Alert('Host Created');</script>");
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Write("<scrpt>alert('Host Not Created');</script>");
                }
            }
        }

        public void SetSessions(EventHostModel _host)
        {
            Session.Add("ID", _host.ID.ToString());
            Session.Add("Name", _host.NAME);
            Session.Add("Surname", _host.SURNAME);
            Session.Add("Email", _host.EMAIL);
            Session.Add("Level", "Host");
        }

        public void SetSessions(GuestModel _guest)
        {
            Session.Add("ID", _guest.ID.ToString());
            Session.Add("Name", _guest.NAME);
            Session.Add("Surname", _guest.SURNAME);
            Session.Add("Email", _guest.EMAIL);
            Session.Add("TYPE", _guest.USERTYPE);
            Session.Add("Level", "Guest");
        }

        public void SetSessions(StaffModel _staff)
        {
            Session.Add("ID", _staff.ID.ToString());
            Session.Add("Name", _staff.NAME);
            Session.Add("Surname", _staff.SURNAME);
            Session.Add("Email", _staff.EMAIL);
            Session.Add("Occupation", _staff.Occupation);
             Session.Add("EventID", _staff.EventID.ToString());
            Session.Add("Level", "Staff");
        }
    }
}