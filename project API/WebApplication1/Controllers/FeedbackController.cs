using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using DB_connect;

namespace WebApplication1.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FeedbackController : ApiController
    {
        [HttpGet]
        // GET: api/Feedback
        public IHttpActionResult Get()
        {
            return Ok(DB_connect.feedbackCrud.Get());
        }
        [HttpGet]
        // GET: api/Feedback/5
        public void Get(int id)
        {
            
        }
        [HttpPost]
        // POST: api/Feedback
        public void Post([FromBody] Models.Feedback value)
        {
         
            DB_connect.feedback feedback = new DB_connect.feedback();
            feedback.id = value.id;
            feedback.firstName = value.name;
            //feedback.likes = value.likes;
            //feedback.content= value.content;
            //feedback.name=value.name;
          DB_connect.feedbackCrud.Post(feedback);
            
        }
        [HttpPut]
        // PUT: api/Feedback/5
        public void Put(int id, [FromBody]int likes)
        {
            //var feedback = DB.feedbacks.FirstOrDefault(c=> c.id == id);
            //if(feedback == null)
            //{
            //    return;
            //}
            //feedback.likes= likes;
            DB_connect.feedbackCrud.Put(id, likes);
        }
        [HttpDelete]
        // DELETE: api/Feedback/5
        public void Delete(int id)
        {
        }
    }
}
