using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonManager.Models;

namespace PersonManager.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.PersonList = new Opreations().Persons;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Person person = new Opreations().SearchPersonById(id);
            if (person == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                //return View(person);
                ViewBag.PersonList = new Opreations().Persons;

                return View("Index", person);
            }

        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            new Opreations().EditPersonDetails(person);
            ViewBag.PersonList = new Opreations().Persons;

            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            ViewBag.PersonList = new Opreations().DeletePerson(id);

            return View("Index");
        }
    }
}