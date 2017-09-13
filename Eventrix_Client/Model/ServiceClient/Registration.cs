using Eventrix_Client.Model.ClientDefinition.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace Eventrix_Client.Model.ServiceClient
{
    public class Registration
    {
        string BASE_URL = "http://localhost:53056/RegistrationService.svc/";

        public string RegisterHost(EventHostModel _host)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(EventHostModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _host);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                string response = webClient.UploadString(BASE_URL + "registerHost", "POST", data);

                return response;
            }
            catch
            {
                return null;
            }
        }

        public string RegisterGuest(GuestModel _guest)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(GuestModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _guest);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                string response = webClient.UploadString(BASE_URL + "registerGuest", "POST", data);

                return response;
            }
            catch
            {
                return null;
            }
        }

        public string RegisterStaff(StaffModel _staff)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(StaffModel));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _staff);
                string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                string response = webClient.UploadString(BASE_URL + "registerStaff", "POST", data);

                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}