using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timcomeymvc.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List> PersonModel > ();

            people.Add(new PersonModel { FirstName= "Stephanie", LastName="Spears", Age = 29,});
            people.Add(new PersonModel { FirstName = "Matthew", LastName = "O'leary", Age = 34,});
            people.Add(new PersonModel { FirstName = "Cody", LastName = "Long", Age = 25,});

            return View(people);
        }
    }
}