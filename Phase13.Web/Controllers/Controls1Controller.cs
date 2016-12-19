using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Phase13.Web.DataContexts;
using RMF.Entities;

namespace Phase13.Web.Controllers
{
    public class Controls1Controller : Controller
    {
        private RMFSystemsDB db = new RMFSystemsDB();

        // GET: Controls1
        public ActionResult Index()
        {
            var controls = db.Controls.Include(c => c.FamilyControl);
            return View(controls.ToList());
        }

        // GET: Controls1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Control control = db.Controls.Find(id);
            if (control == null)
            {
                return HttpNotFound();
            }
            return View(control);
        }

        // GET: Controls1/Create
        public ActionResult Create()
        {
            ViewBag.FamilyControlId = new SelectList(db.FamilyControls, "Id", "FamilyName");
            return View();
        }

        // POST: Controls1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ControlName,FamilyControlId")] Control control)
        {
            if (ModelState.IsValid)
            {
                db.Controls.Add(control);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FamilyControlId = new SelectList(db.FamilyControls, "Id", "FamilyName", control.FamilyControlId);
            return View(control);
        }

        // GET: Controls1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Control control = db.Controls.Find(id);
            if (control == null)
            {
                return HttpNotFound();
            }
            ViewBag.FamilyControlId = new SelectList(db.FamilyControls, "Id", "FamilyName", control.FamilyControlId);
            return View(control);
        }

        // POST: Controls1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ControlName,FamilyControlId")] Control control)
        {
            if (ModelState.IsValid)
            {
                db.Entry(control).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FamilyControlId = new SelectList(db.FamilyControls, "Id", "FamilyName", control.FamilyControlId);
            return View(control);
        }

        // GET: Controls1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Control control = db.Controls.Find(id);
            if (control == null)
            {
                return HttpNotFound();
            }
            return View(control);
        }

        // POST: Controls1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Control control = db.Controls.Find(id);
            db.Controls.Remove(control);
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
