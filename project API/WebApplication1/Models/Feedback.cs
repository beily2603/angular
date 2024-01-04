using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public enum Satisfied { s1,s2 ,s3,s4}
    public class Feedback
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public string  content { get; set; }
        //public Satisfied satisfied { get; set; }
        public int likes { get; set; }
        public Feedback(int id,string name, DateTime date, string content,  int likes)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.content = content;
            //this.satisfied = satisfied;
            this.likes = likes;
        }
    }
}