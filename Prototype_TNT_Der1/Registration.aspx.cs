
using Eventrix_Client.Model;
using Eventrix_Client.Model.ServiceClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype_TNT_Der1
{
    public partial class Registration : System.Web.UI.Page
    {
        string SUBFOLDER = "Profile_Pic";
        string EVENT_TRACKER = "";
        GuestSvcClient svcClient = new GuestSvcClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Page.Validate();
                if (!(String.IsNullOrEmpty(txtPass.Text.Trim())))
                {
                    txtPass.Attributes["value"] = txtPass.Text;
                }
                if (!(String.IsNullOrEmpty(txtPass2.Text.Trim())))
                {
                    txtPass2.Attributes["value"] = txtPass2.Text;
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string _ID = "";
            Regex rgx = new Regex(@"\d+");
            char[] separator = { '^' };
            if (mycheckbox.Checked == false)  // register as Guest
            {
                GuestModel _guest = new GuestModel();
                Eventrix_Client.Registration reg = new Eventrix_Client.Registration();
                _guest.NAME = txtName.Text;
                _guest.SURNAME = txtSurname.Text;
                _guest.EMAIL = txtEmail.Text;
                _guest.PASS = txtPass.Text;
                _guest.USERTYPE = "PUBLIC";
                string response = reg.RegisterGuest(_guest);
                txtName.Text = response.TrimEnd('^');
                string[] idContainer = response.Split(separator); // Store the value in the array
                foreach (Match c in rgx.Matches(idContainer[1])) // Remove all non-numerical values to return ID
                {
                    _ID += c.Value;
                }

                if (response != null) //if (response.Contains("successfully"))
                {

                    makeDirectory(_ID);
                    ImageFile mainPic = new ImageFile();
                    mainPic = UploadFile(profilePic, _ID, SUBFOLDER); //replace 1 with actual event ID 
                    string res = svcClient.saveImage(mainPic); // Doesnot retain the correct value
                    string number = res;
                    if (res.Contains("Success"))
                    {
                        EVENT_TRACKER += "\n Image Uploaded successfully";
                        lblWarning.ForeColor = System.Drawing.Color.White;
                        lblWarning.Text = response;
                        lblWarning.Visible = true;
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        EVENT_TRACKER += "\n Could Not Load a Profile Picture";
                        lblWarning.Text = "Could Not Load a Profile Picture";
                        lblWarning.Visible = true;
                    }
                    //Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("Registration.aspx");
                }
            }
            else  //register as event host
            {
                EventHostModel _host = new EventHostModel();
                Eventrix_Client.Registration reg = new Eventrix_Client.Registration();
                _host.NAME = txtName.Text;
                _host.EMAIL = txtEmail.Text;
                _host.SURNAME = txtSurname.Text;
                _host.PASS = txtPass.Text;
                string response = reg.RegisterHost(_host);
                if (response.Contains("successfully"))
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("Registration.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            GuestServiceClient gsc = new GuestServiceClient();

            HostServiceClient _hostClient = new HostServiceClient();
            EventHostModel _hostDB = _hostClient.hostLogin(txtLogName.Text, txtLogPass.Text);
            if (_hostDB == null) //if a user is not a host then search in guest table
            {
                GuestModel _guest = gsc.GuestLogin(txtLogName.Text, txtLogPass.Text);
                if (_guest == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else  //user is not a guest or host..therefore search for staff
                {
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        //uplaoding event image
        private ImageFile UploadFile(FileUpload fileToUpload, string ID, string subfolder)
        {
            int eventID = Convert.ToInt32(ID);
            if (fileToUpload.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(fileToUpload.FileName);
                    string serverLocation = "~/Events/" + eventID.ToString() + "/" + subfolder + "/" + filename;
                    string SaveLoc = Server.MapPath(serverLocation);
                    int fileSize = fileToUpload.PostedFile.ContentLength;
                    string fileExtention = Path.GetExtension(fileToUpload.FileName);

                    if (fileExtention.ToLower() == ".jpg" || fileExtention.ToLower() == ".png" || fileExtention.ToLower() == ".jpeg" && fileSize <= 15728640)
                    {
                        fileToUpload.SaveAs(SaveLoc);
                        ImageFile file = new ImageFile()
                        {
                            ImageId = eventID,
                            EventID = eventID,
                            ImageName = filename,
                            FileSize = fileSize,
                            Location = "Final/Prototype_TNT_Der1/Prototype_TNT_Der1/Events/" + eventID.ToString() + "/" + subfolder + "/" + filename,
                            ContentType = fileExtention,
                            DateUploaded = DateTime.Now.ToString(),
                        };
                        return file;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
                return null;
        }

        protected void makeDirectory(string GuestID)
        {
            string directoryPath = Server.MapPath(string.Format("~/{0}/", "Events/" + GuestID));

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Directory.CreateDirectory(Path.Combine(directoryPath, "Profile_Pic"));
                Directory.CreateDirectory(Path.Combine(directoryPath, "Event_Images"));
                Directory.CreateDirectory(Path.Combine(directoryPath, "Main_Image"));
                Directory.CreateDirectory(Path.Combine(directoryPath, "QR_Codes"));

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory already exists.');", true);
            }
        }

        /* Validating use input */
        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            bool isVal = checkString(txtName.Text, 3);
            RequiredFieldValidator3.Enabled = true;
            if (isVal == false)
            {
                txtName.BorderColor = System.Drawing.Color.Red;
            }
            if (isVal == true)
            {
                txtName.BorderColor = System.Drawing.Color.Green;
            }
        }

        protected void txtSurname_TextChanged(object sender, EventArgs e)
        {
            bool isVal = checkString(txtSurname.Text, 3);
            if (isVal == false)
            {
                txtSurname.BorderColor = System.Drawing.Color.Red;

            }
            if (isVal == true)
            {
                txtSurname.BorderColor = System.Drawing.Color.Green;
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            String emailvalue = txtEmail.Text;
            bool emailIsval = isValidEmail(emailvalue);
            if (emailIsval == false)
            {
                txtEmail.BorderColor = System.Drawing.Color.Red;
            }
            if (emailIsval == true)
            {
                txtEmail.BorderColor = System.Drawing.Color.Green;
            }
        }

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.BorderColor = System.Drawing.Color.Red;
            }
            if (txtPass.Text != "")
            {
                txtPass.BorderColor = System.Drawing.Color.Green;
            }
        }

        protected void txtPass2_TextChanged(object sender, EventArgs e)
        {
            if (txtPass2.Text == "")
            {
                txtPass2.BorderColor = System.Drawing.Color.Red;
            }
            if (txtPass2.Text != "")
            {
                txtPass2.BorderColor = System.Drawing.Color.Green;
            }
        }

        //Utility Methods
        private bool isValidEmail(String email)
        {
            string emailReg = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (email != null)
            {
                return System.Text.RegularExpressions.Regex.IsMatch(email, emailReg);
            }
            else
            {
                return false;
            }
        }
        private bool checkString(String input, int len)
        {
            bool isVal = false;

            if (input.Length < len)
            {
                isVal = false;
            }
            else if (input.Length > len)
            {
                isVal = true;
            }
            return isVal;
        }

        protected void mycheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
