using INF272Prac2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PeopleList()
        {
            List<Person> people = new List<Person>
            {
                new Person 
                { StudentNo = "123456", 
                    StudentName = "John", 
                    StudentSurname = "Doe", 
                    StudentEmail = "johndoe1@gmail.com",
                    MyLink = "~/HTML/Person01.html"
                },

                 new Person
                { StudentNo = "654321",
                    StudentName = "Jefe",
                    StudentSurname = "Patron",
                    StudentEmail = "jefepatron@gmail.com",
                    MyLink = "~/HTML/Person02.html"
                },

                  new Person
                { StudentNo = "135799",
                    StudentName = "Rele",
                    StudentSurname = "Gile",
                    StudentEmail = "relegile@gmail.com",
                    MyLink = "~/HTML/Person03.html"
                },

                   new Person
                { StudentNo = "657889",
                    StudentName = "Rubi",
                    StudentSurname = "Rose",
                    StudentEmail = "rubirose@gmail.com",
                    MyLink = "~/HTML/Person04.html"
                },

                    new Person
                { StudentNo = "098765",
                    StudentName = "Kyllian",
                    StudentSurname = "Haaland",
                    StudentEmail = "kyllianhaaland@gmail.com",
                    MyLink = "~/HTML/Person05.html"
                }
            };
            return View(people);
        }
    }
}