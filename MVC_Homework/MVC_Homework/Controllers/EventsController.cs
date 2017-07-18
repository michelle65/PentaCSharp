using MVC_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Homework.Controllers
{
    public class EventsController : Controller
    {
        public static List<Event> evnt = new List<Event>();
        static int count = 0;
        // GET: Events
        public ActionResult Index()
        {
            return View(evnt);
        }

        public ActionResult Details(int id)
        {
            //var local
            Event ev = evnt.FirstOrDefault(u => u.EventId == id);
            return View(ev);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event ev)
        {

            if (ev.Title == null)
            {
                return new HttpNotFoundResult();
            }
            else
            { 
                count++;
                ev.EventId = count;
                evnt.Add(ev);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Event ev = evnt.FirstOrDefault(u => u.EventId == id);
            return View("Create", ev);

        }

        [HttpPost]
        public ActionResult Update(Event ev)
        {
            Event existingEvent = evnt.FirstOrDefault(u => u.EventId == ev.EventId);
            existingEvent.Title = ev.Title;
            existingEvent.Details = ev.Details;
            existingEvent.Location = ev.Location;
            existingEvent.DateAndTime = ev.DateAndTime;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Event ev = evnt.FirstOrDefault(u => u.EventId == id);
            evnt.Remove(ev);
            return RedirectToAction("Index");
        }
    }
}