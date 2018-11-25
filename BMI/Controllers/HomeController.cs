using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMI.Models;

namespace BMI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            {
                var person = new Person();
                //          var viewResult = new ViewResult();
                //            ViewData["Vehicle"] = vehicle;

                return View();
            }
        }
        [HttpPost]
        public ActionResult Index(Person person)
        {

            
            string personname = person.PersonName;
            string personcategory = person.PersonCategory.ToString();
            double personheight = person.PersonHeight;
            double personweight = person.PersonWeight;
            double personbmi = 0;

            personbmi = ((personweight) / (personheight * 2));

            if (personbmi <= 18.4)
                {
                person.PersonBMI = personbmi;
                person.PersonCategory = Category.Underweight;
            }

            if (personbmi >= 18.4 && personbmi <= 24.9)
            {
                person.PersonBMI = personbmi;
                person.PersonCategory = Category.Normal;
            }

            if (personbmi >= 25.0 && personbmi <= 29.9)
            {
                person.PersonBMI = personbmi;
                person.PersonCategory = Category.Overweight;
            }

            if (personbmi >= 30.0)
            {
                person.PersonBMI = personbmi;
                person.PersonCategory = Category.Obese;
            }

            ViewData["Person"] = person;

            return View(person);
        
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}


