using Eventrix_Client.Model;
using Eventrix_Client.Model.ClientDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace EventrixWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMappingService" in both code and config file together.
    [ServiceContract]
    public interface IMappingService
    {
        //Insertions
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "insertAddress", ResponseFormat =
        WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int insertAddress(EventAddress _address);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAddressById/{id}", ResponseFormat =
        WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        EventAddress getAddressById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAllAddresses", ResponseFormat =
        WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<EventAddress> getAllAddresses();

    }
}
