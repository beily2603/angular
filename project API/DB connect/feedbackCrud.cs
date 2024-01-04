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
        static Tech_AngularEntities context = new Tech_AngularEntities();

        public static List<Feedback> Get()
        {
            return context.Feedbacks.ToList();
        }

        public static Feedback Get(int id)
        {
            return context.Feedbacks.FirstOrDefault(f=>f.id==id);
        }

        public static void Post(Feedback feedback)
        {
            feedback.date = DateTime.Now;
            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }

        public static void Put(int id,int likes)
        {
            Feedback f = context.Feedbacks.FirstOrDefault(fe=>fe.id==id);
            if (f!=null)
            {
                f.likes = likes;
            }
            context.SaveChanges();

        }
    }
}
