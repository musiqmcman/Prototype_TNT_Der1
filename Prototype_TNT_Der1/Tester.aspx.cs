using Eventrix_Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
    public partial class Tester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!IsPostBack)
            //{

            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UpdateModel um = new UpdateModel();
            UpdateClient uc = new UpdateClient();
            um.Name = txtName.Text;
            um.Surname = txtSurname.Text;
         //   UpdateModel newModel = new UpdateModel();
           string newModel = uc.updateAccommo("1",um);
            if(newModel != null)
            {
                txtUpdatedName.Text = newModel;
             //   txtUpdatedSurname.Text = newModel.Surname;
            }
        }
    }
}