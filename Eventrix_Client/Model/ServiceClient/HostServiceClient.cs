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
using Newtonsoft.Json;

namespace Eventrix_Client.Model.ServiceClient
{
    public class HostServiceClient
    {
        string BASE_URL = "http://localhost:53056/ServiceHost.svc/";

        public List<EventHostModel> findAllhost()
        {
            try
            {
                var webclient = new WebClient();
                var json = webclient.DownloadString(BASE_URL + "findallhost");
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<EventHostModel>>(json);
            }
            catch
            {
                return null;
            }
        }
        public EventHostModel hostLogin(string email, string password)
        {
            EventHostModel person = new EventHostModel();
            string json = null;
            //  BaseUser person = null;
            JavaScriptSerializer js = null;
            try
            {
                WebClient webClient = new WebClient();
                json = webClient.DownloadString(BASE_URL + "login?email=" + email + "&password=" + password);//
                js = new JavaScriptSerializer();
                person = JsonConvert.DeserializeObject<EventHostModel>(json);
                return person;
                // var webclient = new WebClient();
                //string url = string.Format(BASE_URL + "hostLogin/{0}", email);
                //var json = webclient.DownloadString(url);
                //var js = new JavaScriptSerializer();
                //_host = js.Deserialize<EventHostModel>(json);
                ////  return _host;
                //if (_host.PASS == pass)
                //{
                //    return _host;
                //}
                //else
                //{
                //    return null;
                //}

            }
            catch
            {
                return null;
            }
        }
        public EventHostModel findhsotbyID(string id)
        {
            try
            {
                var webclient = new WebClient();
                string url = string.Format(BASE_URL + "findHostbyID/{0}", id);
                var json = webclient.DownloadString(url);
                var js = new JavaScriptSerializer();
                return js.Deserialize<EventHostModel>(json);
            }
            catch
            {
                return null;
            }
        }

        public bool createHost(EventHostModel _host)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(EventHostModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _host);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "createHost", "POST", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool editHost(EventHostModel _host)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(EventHostModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _host);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "editHost", "PUT", data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteHost(EventHostModel _host)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(EventHostModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _host);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webclient = new WebClient();
                webclient.Headers["Content-type"] = "application/json";
                webclient.Encoding = Encoding.UTF8;
                webclient.UploadString(BASE_URL + "deleteHost", "DELETE", data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}