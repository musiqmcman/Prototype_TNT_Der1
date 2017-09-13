using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventrix_Client.Model.ClientDefinition.Users
{
    public class StaffModel : BaseUser
    {
        public string Occupation
        {
            get; set;
        }
        public int EventID
        {
            get; set;
        }
    }
}