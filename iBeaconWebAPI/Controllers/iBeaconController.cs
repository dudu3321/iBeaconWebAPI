using iBeaconWebAPI;
using iBeaconWebAPI.Model;
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

        /// <summary>
        /// 取得所有Beacon
        /// </summary>
        /// <returns></returns>
        public IEnumerable<iBeacon> Get()
        {
            iBeaconModel db = new iBeaconModel();
            var a = db.iBeacon;
            return db.iBeacon.ToArray();
        }

        /// <summary>
        /// 取得特定Beacon
        /// </summary>
        /// <param name="beacon"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult POST(iBeacon beacon)
        {
            iBeaconModel db = new iBeaconModel();
            var result = db.iBeacon.FirstOrDefault(x => x.UUID == beacon.UUID && x.Major == beacon.Major && x.Minor == beacon.Minor);
            if (result == null)
                return StatusCode(HttpStatusCode.NoContent);
            else
                return Ok(result);
        }

        /// <summary>
        /// 新增Beacon
        /// </summary>
        /// <param name="beacon"></param>
        /// <returns></returns>
        [HttpPut]
        public IHttpActionResult PUT(iBeacon beacon)
        {
            return Ok();
        } 
    }
}
