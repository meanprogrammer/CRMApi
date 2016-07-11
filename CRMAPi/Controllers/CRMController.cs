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
        public HttpResponseMessage Get(int id)
        {
            string value = string.Format("{0}-{1}-{2}", id,id,id);
            return new HttpResponseMessage()
            {
                Content = new StringContent( value )
            };
        }

        // POST api/crm
        public HttpResponseMessage Post([FromBody]string value)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("SOMETHING IS POSTED!")
            };
        }

        // PUT api/crm/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("PUT PUT PUT")
            };
        }

        // DELETE api/crm/5
        public HttpResponseMessage Delete(int id)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("DEL DEL DEL")
            };
        }
    }
}
