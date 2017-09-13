﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventrix_Client.Model.ClientDefinition
{
    public class EventAddress
    {
        public int ID
        {
            get; set;
        }
        public string STREET
        {
            get; set;
        }
        public string TOWN
        {
            get; set;
        }
        public string CITY
        {
            get; set;
        }
        public int CODE
        {
            get; set;
        }
        public string LONGITUDE
        {
            get; set;
        }
        public string LATITUDE
        {
            get; set;
        }
        public string URL
        {
            get; set;
        }
    }
}