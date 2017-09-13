using Eventrix_Client.Model.ClientDefinition;
using Newtonsoft.Json;
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
    public class EventServiceClient
    {
        string BASE_URL = "http://localhost:53056/EventService.svc/";


        //Deletions        
        public string deleteEvent(string id)
        {
            string json = null;
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                json = webClient.UploadString(BASE_URL + "deleteEvent/" + id, "DELETE", "");

                return json;
            }
            catch
            {
                return "";
            }
        }

        //Insertions
        public string createEvent(EventAttributes _event)
        {
            string response = null;
            string data = null;
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(EventAttributes));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _event);
                data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                response = webClient.UploadString(BASE_URL + "createEvent", "POST", data);

                return response;
            }
            catch
            {
                return null;
            }
        }

        //Update
        public bool editEvent(string id, EventAttributes _event)
        {
            string response = null;
            string data = null;
            //   EventAttributes acc = null;
            try
            {
                EventAttributes acc = new EventAttributes();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                    typeof(EventAttributes));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _event);
                data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                response = webClient.UploadString(BASE_URL + "editEvent/" + id, "PUT", data);
                acc = JsonConvert.DeserializeObject<EventAttributes>(response);

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Getters

        public List<EventAttributes> GetAllEvent()
        {
            string json = null;
            //    acc = null;
            try
            {
                WebClient webClient = new WebClient();
                json = webClient.DownloadString(BASE_URL + "GetAllEvent");
                List<EventAttributes> acc = JsonConvert.DeserializeObject<List<EventAttributes>>(json);

                return acc;
            }
            catch
            {
                return null;
            }
        }

        public EventAttributes GetEventByEventID(string id)
        {
            string json = null;
            EventAttributes acc = new EventAttributes();
            try
            {
                WebClient webClient = new WebClient();
                json = webClient.DownloadString(BASE_URL + "GetEventByEventID/" + id);
                acc = JsonConvert.DeserializeObject<EventAttributes>(json);

                return acc;
            }
            catch
            {
                return null;
            }
        }

        public EventAttributes GetEventByAddressID(string id)
        {
            string json = null;
            EventAttributes acc = new EventAttributes();
            try
            {
                WebClient webClient = new WebClient();
                json = webClient.DownloadString(BASE_URL + "GetEventByAddressID/" + id);
                acc = JsonConvert.DeserializeObject<EventAttributes>(json);

                return acc;
            }
            catch
            {
                return null;
            }
        }

        public List<EventAttributes> GetEventByHostID(string id)
        {
            string json = null;
            try
            {
                WebClient webClient = new WebClient();
                json = webClient.DownloadString(BASE_URL + "GetEventByHostID/" + id);
                List<EventAttributes> acc = JsonConvert.DeserializeObject<List<EventAttributes>>(json);
                return acc;
            }
            catch
            {
                return null;
            }
        }

    }
}