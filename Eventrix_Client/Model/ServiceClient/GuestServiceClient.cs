using Eventrix_Client.Model.ClientDefinition.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Eventrix_Client.Model.ServiceClient
{
    public class GuestServiceClient
    {
        private string BASE_URL = "http://localhost:53056/ServiceGuest.svc/";

        public List<GuestModel> findAllGuest()
        {
            try
            {
                var webclient = new WebClient();
                var json = webclient.DownloadString(BASE_URL + "findallguest");
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<GuestModel>>(json);
            }
            catch
            {
                return null;
            }
        }
        public GuestModel GuestLogin(string email, string pass)
        {
            GuestModel _guest = new GuestModel();
            try
            {
                var webclient = new WebClient();
                string url = string.Format(BASE_URL + "GuestLogin/{0}", email);
                var json = webclient.DownloadString(url);
                var js = new JavaScriptSerializer();
                _guest = js.Deserialize<GuestModel>(json);
                if (_guest.PASS.Equals(pass))
                {
                    return _guest;
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
        public GuestModel findGuestbyID(string id)
        {
            try
            {
                var webclient = new WebClient();
                string url = string.Format(BASE_URL + "findGuestbyID/{0}", id);
                var json = webclient.DownloadString(url);
                var js = new JavaScriptSerializer();
                return js.Deserialize<GuestModel>(json);
            }
            catch
            {
                return null;
            }
        }

        public bool createGuest(GuestModel _guest)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GuestModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _guest);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "createGuest", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool editGuest(GuestModel _guest)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GuestModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _guest);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "editGuest", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteGuest(GuestModel _guest)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GuestModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _guest);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "deleteGuest", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}