using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace KuyaTest.Controllers
{
    public class CRMController : ApiController
    {
        // GET api/crm
        public HttpResponseMessage Get()
        {

            Random rndgen = new Random();
            return new HttpResponseMessage()
            {
                Content = new StringContent(rndgen.Next().ToString())
            };
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
