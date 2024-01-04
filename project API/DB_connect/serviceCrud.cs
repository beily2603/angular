using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_connect
{
    public static class serviceCrud
    {
        static angularDBEntities context = new angularDBEntities();

        public static List<service> Get()
        {
            return context.services.ToList();
        }

    

        public static service Get(int id)
        {
            return context.services.FirstOrDefault(f => f.id == id);
        }

        //public static void Post(Service s)
        //{
        //    
        //    context.services.Add(s);
        //    context.SaveChanges();
        //}

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
