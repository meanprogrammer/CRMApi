using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DudzAPI.Controllers
{
    public class CRMController : ApiController
    {
        // GET api/crm
        [System.Web.Http.HttpGet, System.Web.Http.Route("api/crm/get")]
        public HttpResponseMessage Get()
        {

            Random rndgen = new Random();
            return new HttpResponseMessage()
            {
                Content = new StringContent(rndgen.Next().ToString())
            };
        }

        // GET api/crm/5
        [System.Web.Http.HttpGet, System.Web.Http.Route("api/crm/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            string value = string.Format("{0}-{1}-{2}", id, id, id);
            return new HttpResponseMessage()
            {
                Content = new StringContent(value)
            };
        }

        // POST api/crm
        [System.Web.Http.HttpPost, System.Web.Http.Route("api/crm/post")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("SOMETHING IS POSTED!")
            };
        }

        [System.Web.Http.HttpPost, System.Web.Http.Route("api/crm/put")]
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("PUT PUT PUT")
            };
        }

        [System.Web.Http.HttpPost, System.Web.Http.Route("api/crm/delete")]
        public HttpResponseMessage Delete(int id)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("DEL DEL DEL")
            };
        }
    }
}