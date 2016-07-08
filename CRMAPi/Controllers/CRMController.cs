using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace KuyaTest.Controllers
{
    public class CRMController : Controller
    {
        // GET api/crm
        public ActionResult Get()
        {
            return Content("Hi there!");
        }

        // GET api/crm/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/crm
        public void Post([FromBody]string value)
        {
        }

        // PUT api/crm/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/crm/5
        public void Delete(int id)
        {
        }
    }
}
