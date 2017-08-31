using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class Event_IdeasController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Event_Ideas
        public ActionResult Index()
        {
            return View(db.Event_Ideas.ToList());
        }

        // GET: Event_Ideas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Ideas event_Ideas = db.Event_Ideas.Find(id);
            if (event_Ideas == null)
            {
                return HttpNotFound();
            }
            return View(event_Ideas);
        }

        // GET: Event_Ideas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event_Ideas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Create([Bind(Include = "Id,Name,Date,Address,Notes")] Event_Ideas event_Ideas)
        {
            if (ModelState.IsValid)
            {
                db.Event_Ideas.Add(event_Ideas);
                db.SaveChanges();
                return Json(0);
            }

            return Json(-1);
        }

        // GET: Event_Ideas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Ideas event_Ideas = db.Event_Ideas.Find(id);
            if (event_Ideas == null)
            {
                return HttpNotFound();
            }
            return View(event_Ideas);
        }

        // POST: Event_Ideas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Edit([Bind(Include = "Id,Name,Date,Address,Notes")] Event_Ideas event_Ideas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(event_Ideas).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { isSuccessful = true });
            }
            return Json(new { isSuccessful = false });
        }

        // GET: Event_Ideas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Ideas event_Ideas = db.Event_Ideas.Find(id);
            if (event_Ideas == null)
            {
                return HttpNotFound();
            }
            return View(event_Ideas);
        }

        // POST: Event_Ideas/Delete/5
        [HttpPost, ActionName("Delete")]
        public JsonResult DeleteConfirmed(int id)
        {
            Event_Ideas event_Ideas = db.Event_Ideas.Find(id);
            db.Event_Ideas.Remove(event_Ideas);
            db.SaveChanges();
            return Json(new { isSuccessful = true });
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
