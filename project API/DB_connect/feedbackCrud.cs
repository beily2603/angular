using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DB_connect
{

    public static class feedbackCrud
    {
        static angularDBEntities context = new angularDBEntities();

        public static List<feedback> Get()
        {
            return context.feedbacks.ToList();
        }

        public static feedback Get(int id)
        {
            return context.feedbacks.FirstOrDefault(f => f.id == id);
        }

        public static void Post(feedback feedback)
        {
         
            context.feedbacks.Add(feedback);
            context.SaveChanges();
        }

        public static void Put(int id, int likes)
        {
            feedback f = context.feedbacks.FirstOrDefault(fe => fe.id == id);
            if (f != null)
            {
                f.likes = likes;
            }
            context.SaveChanges();

        }
    }
}
