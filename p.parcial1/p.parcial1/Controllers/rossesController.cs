using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using p.parcial1.Models;

namespace p.parcial1.Controllers
{
    public class rossesController : Controller
    {
        private Entities db = new Entities();

        // GET: rosses
        public ActionResult Index()
        {
            return View(db.ross.ToList());
        }

        public object Getrosses()
        {
            throw new NotImplementedException();
        }

        // GET: rosses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ross ross = db.ross.Find(id);
            if (ross == null)
            {
                return HttpNotFound();
            }
            return View(ross);
        }

        public object Postross(ross ross)
        {
            throw new NotImplementedException();
        }

        // GET: rosses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: rosses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ross_ID,friendofross,place,email,birthdate")] ross ross)
        {
            if (ModelState.IsValid)
            {
                db.ross.Add(ross);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ross);
        }

        // GET: rosses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ross ross = db.ross.Find(id);
            if (ross == null)
            {
                return HttpNotFound();
            }
            return View(ross);
        }

        // POST: rosses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ross_ID,friendofross,place,email,birthdate")] ross ross)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ross).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ross);
        }

        // GET: rosses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ross ross = db.ross.Find(id);
            if (ross == null)
            {
                return HttpNotFound();
            }
            return View(ross);
        }

        // POST: rosses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ross ross = db.ross.Find(id);
            db.ross.Remove(ross);
            db.SaveChanges();
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
