using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventrix_Client.Model.ClientDefinition
{
    public class EventAttributes
    {
        public int _EventID
        {
            get; set;
        }

        public System.Nullable<int> _EH_ID
        {
            get; set;
        }

        public int _AD_Id
        {
            get; set;
        }

        public string _Name
        {
            get; set;
        }

        public string _Type
        {
            get; set;
        }

        public string _Description
        {
            get; set;
        }

        public DateTime _StartDate
        {
            get; set;
        }

        public DateTime _EndDate
        {
            get; set;
        }

        public int _NumTicket
        {
            get; set;
        }

        //public DateTime _TicketStartDate
        //{
        //    get;set;
        //}

        //public DateTime _TicketEndDate
        //{
        //    get;set;
        //}

        public int _NumStaff
        {
            get; set;
        }

        public int _NumProduct
        {
            get; set;
        }
    }
}