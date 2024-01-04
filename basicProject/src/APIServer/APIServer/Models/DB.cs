using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIServer.Models
{
  public class DB
  {
    public static List<Service> myServices { get; set; } = new List<Service>{

    new Service() {title="מיתוג", image="../../../assets/ביאור 2021-12-27 205413.png", description="תיאור מיתוג",price=50, priceFor="שעה",showDetails=false},
    new Service(){title="עיצוב מוצר", image="M5.354 5.119 7.538.792A.516.516 0 0 1 8 .5c.183 0 .366.097.465.292l2.184 4.327 4.898.696A.537.537 0 0 1 16 6.32a.548.548 0 0 1-.17.445l-3.523 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256a.52.52 0 0 1-.146.05c-.342.06-.668-.254-.6-.642l.83-4.73L.173 6.765a.55.55 0 0 1-.172-.403.58.58 0 0 1 .085-.302.513.513 0 0 1 .37-.245l4.898-.696zM8 12.027a.5.5 0 0 1 .232.056l3.686 1.894-.694-3.957a.565.565 0 0 1 .162-.505l2.907-2.77-4.052-.576a.525.525 0 0 1-.393-.288L8.001 2.223 8 2.226v9.8z", description="תיאור עיצוב מוצר",price=100, priceFor="שעה",showDetails=false},
    new Service(){ title= "עימוד", image= "....", description= "תיאור עימוד",price= 50, priceFor="שעה", showDetails = false},
    new Service() { title= "כרזות ומודעות", image= "....", description= "תיאור כרזות ומודעות",price= 50, priceFor= "שעה", showDetails = false},
    new Service(){ title= "קמפיינים", image= "....", description= "תיאור קמפיינים",price= 50, priceFor= "שעה", showDetails = false},
    new Service(){ title= "עיצוב כללי", image= "....", description= "תיאור מיתוג",price= 50, priceFor= "שעה", showDetails = false}
    };
    public static List<Response> Responses { get; set; } = new List<Response>
    {
      new Response(){firstName="שרי",description="תודה!!!!!!!!!", lastName="שנברגר", Email="Sari@gmail.com", phonNumber="111111", likes=0},
      new Response(){firstName="בילי",description="מושלם!!!!", lastName="קלרמן", Email="Beily@gmail.com", phonNumber="222222", likes=0},
      new Response(){firstName="נחמי",description="אין עליכם, פשוט אליפות!!!!!", lastName="מוזס", Email="Nechami@gmail.com", phonNumber="3333333", likes = 0},

    };

  }
}

