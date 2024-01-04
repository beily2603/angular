using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ServiceController : ApiController
    {
        [HttpGet]
        // GET: api/Service
        public IHttpActionResult Get()
        {
    
            return Ok(DB_connect.serviceCrud.Get());
        }
        [HttpGet]
        // GET: api/Service/5
        //public IHttpActionResult Get(int id)
        //{
        //    var service = DB.services.FirstOrDefault(x => x.id == id);
        //    return Ok(service);
        //}

        // POST: api/Service
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Service/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Service/5
        public void Delete(int id)
        {
        }
    }
}
