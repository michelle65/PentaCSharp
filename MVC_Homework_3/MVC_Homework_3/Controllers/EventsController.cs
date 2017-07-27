using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Homework_2.Models;
using Microsoft.AspNet.Identity;

namespace MVC_Homework_2.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Events
        [AllowAnonymous]
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            var events = db.Events.Include(e => e.ApplicationUser).Where(e => e.ApplicationUserId.Equals(userId));
            return View(events.ToList());
        }

        // GET: Events/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
           // ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "FirstName");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,FirstName,LastName,Title,Details,Location,DateAndTime,ApplicationUserId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                @event.ApplicationUserId = User.Identity.GetUserId();
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //  ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "FirstName", @event.ApplicationUserId);
            //  return View(@event);
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "FirstName", @event.ApplicationUserId);
            return View(@event);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string userId = User.Identity.GetUserId();
            Event @event = db.Events.Where(e => e.ApplicationUserId.Equals(userId)).First(e => e.EventId == id);

            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "FirstName", @event.ApplicationUserId);
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,FirstName,LastName,Title,Details,Location,DateAndTime,ApplicationUserId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                @event.ApplicationUserId = User.Identity.GetUserId();
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationUserId = new SelectList(db.Users, "Id", "FirstName", @event.ApplicationUserId);
            return View(@event);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Subscribe(int id)
        {
            // many to many

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
