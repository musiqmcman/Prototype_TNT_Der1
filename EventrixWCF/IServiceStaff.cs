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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceStaff" in both code and config file together.
    [ServiceContract]
    public interface IServiceStaff
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallstaff", ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<EventStaff> findallstaff();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findStaffbyID/{id}", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        EventStaff findStaffbyID(string id);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createStaff", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        bool createStaff(EventStaff _staff);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editStaff", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        bool editStaff(EventStaff _staff);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteStaff", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        bool deleteStaff(EventStaff _staff);

        //[OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "deleteStaffbyEvent", ResponseFormat = WebMessageFormat.Json,
        //    RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        //bool deleteStaffbyEvent(EventStaff _staff);
    }
}
