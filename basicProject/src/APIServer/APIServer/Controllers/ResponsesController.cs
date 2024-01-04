using APIServer.Models;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DB;

namespace APIServer.Controllers
{
  [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
  public class ResponsesController : ApiController
    {
    // GET: api/Responses
    [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(DB.feedbacks.Get());
        }

        // GET: api/Responses/5
        public IHttpActionResult Get(int id)
        {
            return Ok(DB.feedbacks.Get(id));
        }

    // POST: api/Responses
    [HttpPost]
    public IHttpActionResult Post([FromBody] Response response)
    {
      Models.DB.Responses.Add(response);
      return Ok(Models.DB.Responses);
    }
    [HttpPut]
    // PUT: api/Responses/5
    public IHttpActionResult Put([FromBody] Response response)
    {
      for (int i = 0; i < Models.DB.Responses.Count; i++)
      {
        if (Models.DB.Responses[i].firstName == response.firstName &&
            Models.DB.Responses[i].lastName == response.lastName &&
            Models.DB.Responses[i].description == response.description &&
            Models.DB.Responses[i].phonNumber == response.phonNumber &&
            Models.DB.Responses[i].Email == response.Email &&
            Models.DB.Responses[i].likes == response.likes - 1)
        {
          Models.DB.Responses[i] = response;
          return Ok(Models.DB.Responses);
        }

      }
      return Ok(Models.DB.Responses);
    }

    // DELETE: api/Responses/5
    public void Delete(int id)
    {
    }
  }
}
