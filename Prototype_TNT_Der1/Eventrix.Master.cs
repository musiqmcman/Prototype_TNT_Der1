using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
	public partial class Eventrix : System.Web.UI.MasterPage
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count >= 1)
            {
                if (Session["Level"].Equals("Host"))
                {
                    event_management.Visible = true;
                    list_login.Visible = false;
                    list_reg.Visible = false;
                    list_account.Visible = true;
                    MyEvents.Visible = true;
                    //Off Canvas Nav Menu
                    offMyEvents.InnerText = "My Events";
                    offMyEvents.Visible = true;
                    Off_EventManagement.Visible = true;
                    offLogin.Visible = false;
                    offReg.Visible = false;
                    offAcc.Visible = true;
                }
                else if (Session["Level"].Equals("Staff"))
                {
                    event_management.Visible = false;
                    list_login.Visible = false;
                    list_reg.Visible = false;
                    list_account.Visible = true;
                 //   PaymentSetting.Visible = false;
                    DeleteAccount.Visible = false;
                    MyEvents.Visible = false;
                    //Off Canvas Nav Menu
                    offMyEvents.Visible = false;
                    Off_EventManagement.Visible = false;
                    offLogin.Visible = false;
                    offReg.Visible = false;
                    offAcc.Visible = true;
                  //  offPaymentSetting.Visible = false;
                    OffDeleteAcc.Visible = false;
                }
                else if (Session["Level"].Equals("Guest"))
                {
                    event_management.Visible = false;
                    list_login.Visible = false;
                    list_reg.Visible = false;
                    list_account.Visible = true;
                    MyEvents.Visible = true;
                    //Off Canvas Nav Menu
                    offMyEvents.InnerText = "<a href='EventList.aspx'><i class='fa fa-life - ring'></i>Pending Invites</a>";
                    offMyEvents.Visible = true;
                    Off_EventManagement.Visible = false;
                    offLogin.Visible = false;
                    offReg.Visible = false;
                    offAcc.Visible = true;
                }
            }
            else
            {
                event_management.Visible = false;
                list_login.Visible = true;
                list_reg.Visible = true;
                list_account.Visible = false;
                MyEvents.Visible = false;
                //Off Canvas Nav Menu
                offMyEvents.Visible = false;
                Off_EventManagement.Visible = false;
                offLogin.Visible = true;
                offReg.Visible = true;
                offAcc.Visible = false;
            }
        }
	}
}