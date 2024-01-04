using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
     public static class feedbacks
    {

     static angularDBEntities context=new angularDBEntities();


    //public feedback(angularDBEntities context)
    //{
    //  this.context = context;
    //}
    public static List<Feedback> Get()
    {
      Console.WriteLine("get");
      return context.Feedbacks.ToList();
    }
    public static Feedback Get(int id)
    {
      return context.Feedbacks.Find(id);
    }

    }
}

