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
    public class ControlItemsController : Controller
    {
        private RMFSystemsDB db = new RMFSystemsDB();

        // GET: ControlItems
        public ActionResult Index()
        {
            var controlItems = db.ControlItems.Include(c => c.Control);
            return View(controlItems.ToList());
        }

        // GET: ControlItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ControlItem controlItem = db.ControlItems.Find(id);
            if (controlItem == null)
            {
                return HttpNotFound();
            }
            return View(controlItem);
        }

        // GET: ControlItems/Create
        public ActionResult Create()
        {
            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlCode");
            return View();
        }

        // POST: ControlItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ControlItemCode,ControlId,Description,AssessmentObjective")] ControlItem controlItem)
        {
            if (ModelState.IsValid)
            {
                db.ControlItems.Add(controlItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlCode", controlItem.ControlId);
            return View(controlItem);
        }

        // GET: ControlItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ControlItem controlItem = db.ControlItems.Find(id);
            if (controlItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlCode", controlItem.ControlId);
            return View(controlItem);
        }

        // POST: ControlItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ControlItemCode,ControlId,Description,AssessmentObjective")] ControlItem controlItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(controlItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlCode", controlItem.ControlId);
            return View(controlItem);
        }

        // GET: ControlItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ControlItem controlItem = db.ControlItems.Find(id);
            if (controlItem == null)
            {
                return HttpNotFound();
            }
            return View(controlItem);
        }

        // POST: ControlItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ControlItem controlItem = db.ControlItems.Find(id);
            db.ControlItems.Remove(controlItem);
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
