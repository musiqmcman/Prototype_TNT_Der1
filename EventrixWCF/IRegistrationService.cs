using EventrixWCF.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EventrixWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegistrationService" in both code and config file together.
    [ServiceContract]
    public interface IRegistrationService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "registerHost", ResponseFormat =
        WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string RegisterHost(Host host);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "registerGuest", ResponseFormat =
            WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string RegisterGuest(EventGuest guest);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "registerStaff", ResponseFormat =
        WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string RegisterStaff(EventStaff staff);

    }
}
