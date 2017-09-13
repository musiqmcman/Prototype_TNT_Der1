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
    public class MappingClient
    {
        string BASE_URL = "http://localhost:53056/MappingService.svc/";

        //insertions
        public int insertAddress(EventAddress _address)
        {
            string response = null;
            string data = null;
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(
                typeof(EventAddress));
                MemoryStream mem = new MemoryStream();
                ser.WriteObject(mem, _address);
                data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                WebClient webClient = new WebClient();
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                response = webClient.UploadString(BASE_URL + "insertAddress", "POST", data);
                return Convert.ToInt32(response);
            }
            catch
            {
                return -1;
            }
        }

        //getters
        public EventAddress getAddressById(string id)
        {
            string json = null;
            EventAddress addr = new EventAddress();
            try
            {
                WebClient webClient = new WebClient();
                json = webClient.DownloadString(BASE_URL + "getAddressById/" + id);
                addr = JsonConvert.DeserializeObject<EventAddress>(json);
                return addr;
            }
            catch
            {
                return null;
            }
        }

        public List<EventAddress> getAllAddresses()
        {
            // string json = null;
            // List<EventAddress> addr = null;
            try
            {
                WebClient webClient = new WebClient();
                string json = webClient.DownloadString(BASE_URL + "getAllAddresses");
                List<EventAddress> addr = JsonConvert.DeserializeObject<List<EventAddress>>(json);

                return addr;
            }
            catch
            {
                return null;
            }
        }

    }
}