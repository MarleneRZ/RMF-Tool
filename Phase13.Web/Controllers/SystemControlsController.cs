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
    public class SystemControlsController : Controller
    {
        private RMFSystemsDB db = new RMFSystemsDB();

        // GET: SystemControls
        public ActionResult Index()
        {
            var systemControls = db.SystemControls.Include(s => s.Control).Include(s => s.RMFSystem);
            return View(systemControls.ToList());
        }

        // GET: SystemControls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemControl systemControl = db.SystemControls.Find(id);
            if (systemControl == null)
            {
                return HttpNotFound();
            }
            return View(systemControl);
        }

        // GET: SystemControls/Create
        public ActionResult Create()
        {
            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlName");
            ViewBag.RMFSystemId = new SelectList(db.RMFSystems, "Id", "SystemName");
            return View();
        }

        // POST: SystemControls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,RMFSystemId,ControlId,FindingResultDescription,FindingRecommendation,FindingStatus")] SystemControl systemControl)
        {
            if (ModelState.IsValid)
            {
                db.SystemControls.Add(systemControl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlName", systemControl.ControlId);
            ViewBag.RMFSystemId = new SelectList(db.RMFSystems, "Id", "SystemName", systemControl.RMFSystemId);
            return View(systemControl);
        }

        // GET: SystemControls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemControl systemControl = db.SystemControls.Find(id);
            if (systemControl == null)
            {
                return HttpNotFound();
            }
            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlName", systemControl.ControlId);
            ViewBag.RMFSystemId = new SelectList(db.RMFSystems, "Id", "SystemName", systemControl.RMFSystemId);
            return View(systemControl);
        }

        // POST: SystemControls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,RMFSystemId,ControlId,FindingResultDescription,FindingRecommendation,FindingStatus")] SystemControl systemControl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemControl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ControlId = new SelectList(db.Controls, "Id", "ControlName", systemControl.ControlId);
            ViewBag.RMFSystemId = new SelectList(db.RMFSystems, "Id", "SystemName", systemControl.RMFSystemId);
            return View(systemControl);
        }

        // GET: SystemControls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemControl systemControl = db.SystemControls.Find(id);
            if (systemControl == null)
            {
                return HttpNotFound();
            }
            return View(systemControl);
        }

        // POST: SystemControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemControl systemControl = db.SystemControls.Find(id);
            db.SystemControls.Remove(systemControl);
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
