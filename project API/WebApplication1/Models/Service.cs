using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB_connect;

namespace WebApplication1.Models
{

    public class Service
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string priceRange { get; set; }
        public int avgServiceTime { get; set; }
        public string[] images { get; set; }
        public Service(int id,string name, string description, string priceRange, int avgServiceTime,params string[] images)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.priceRange = priceRange;
            this.avgServiceTime = avgServiceTime;
            this.images = images;
        }


    }
}