using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventrix_Client.Model.ClientDefinition.Users
{
    public class GuestModel : BaseUser
    {

        public string USERTYPE
        {
            get; set;
        }
    }
}