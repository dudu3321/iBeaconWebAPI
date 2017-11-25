using iBeaconWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iBeaconWebAPI.Controllers
{
    public class iBeaconController : ApiController
    {
        iBeacon[] Beacons = new iBeacon[] {
            new iBeacon{ UUID = "1", Minor = "1", Major = "1" , APIUrl = "https://tw.yahoo.com/"},
            new iBeacon{ UUID = "1", Minor = "1", Major = "2" , APIUrl = "https://tw.news.yahoo.com/"},
            new iBeacon{ UUID = "1", Minor = "1", Major = "3" , APIUrl = "https://tw.stock.yahoo.com/"},
            new iBeacon{ UUID = "1", Minor = "1", Major = "4" , APIUrl = "https://movies.yahoo.com.tw/"}
        };

        //取得所有Beaconc呼叫的API URL
        public IEnumerable<iBeacon> GetAllBeacons()
        {
            return Beacons;
        }

        //取得特定Beaconc呼叫的API URL
        [HttpPost]
        public IHttpActionResult GetBeaconAPI(iBeacon beacon)
        {
            var result = Beacons.FirstOrDefault(x => x.UUID == beacon.UUID && x.Major == beacon.Major && x.Minor == beacon.Minor);
            if (result == null)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return Ok(result.APIUrl);
        }
    }
}
