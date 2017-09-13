using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eventrix_Client.Model.ClientDefinition.Users;
using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace Eventrix_Client.Model.ServiceClient
{
    public class StaffServiceClient
    {
        string BASE_URL = "http://localhost:53056/ServiceStaff.svc/";

        public List<StaffModel> findAllStaff()
        {
            try
            {
                var webclient = new WebClient();
                var json = webclient.DownloadString(BASE_URL + "findallstaff");
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<StaffModel>>(json);
            }
            catch
            {
                return null;
            }
        }
        public StaffModel StaffLogin(string email, string pass)
        {
            StaffModel _staff = new StaffModel();
            try
            {
                var webclient = new WebClient();
                string url = string.Format(BASE_URL + "staffLogin/{0}", email);
                var json = webclient.DownloadString(url);
                var js = new JavaScriptSerializer();
                _staff = js.Deserialize<StaffModel>(json);
                if (_staff.PASS.Equals(pass))
                {
                    return _staff;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public StaffModel findStaffbyID(string id)
        {
            try
            {
                var webclient = new WebClient();
                string url = string.Format(BASE_URL + "findStaffbyID/{0}", id);
                var json = webclient.DownloadString(url);
                var js = new JavaScriptSerializer();
                return js.Deserialize<StaffModel>(json);
            }
            catch
            {
                return null;
            }
        }

        public bool createStaff(StaffModel _staff)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(StaffModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _staff);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "createStaff", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool editStaff(StaffModel _staff)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(StaffModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _staff);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "editStaff", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteStaff(StaffModel _staff)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(StaffModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _staff);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "deleteStaff", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}