﻿using DudzAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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
        public HttpResponseMessage Post(IntegrationModel value)
        {
            //IntegrationModel m = JsonConvert.DeserializeObject(value) as IntegrationModel;
            return new HttpResponseMessage()
            {
                Content = new StringContent(string.Format("POSTED: {0}", value.Description))
            };
        }

        [System.Web.Http.HttpPut, System.Web.Http.Route("api/crm/put")]
        public HttpResponseMessage Put(IntegrationModel value)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(string.Format("PUT: {0} : {1}", value.RecordID, value.Description))
            };
        }

        [System.Web.Http.HttpDelete, System.Web.Http.Route("api/crm/delete")]
        public HttpResponseMessage Delete([FromBody]int id)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(string.Format("DEL DEL DEL : {0}", id))
            };
        }
    }
}