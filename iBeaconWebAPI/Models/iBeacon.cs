using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iBeaconWebAPI.Models
{
    public class iBeacon
    {
        public string UUID { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
        public string APIUrl { get; set; }
    }
}