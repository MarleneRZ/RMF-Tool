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
    [Authorize]
    public class RMFSystemsController : Controller
    {
        private RMFSystemsDB db = new RMFSystemsDB();

        // GET: RMFSystems
        public ActionResult Index()
        {
            var rMFSystems = db.RMFSystems.Include(r => r.User);
            return View(rMFSystems.ToList());
        }

        // GET: RMFSystems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RMFSystem rMFSystem = db.RMFSystems.Find(id);
            if (rMFSystem == null)
            {
                return HttpNotFound();
            }
            return View(rMFSystem);
        }

        // GET: RMFSystems/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "FirstName");
            return View();
        }

        // POST: RMFSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SystemName,Confidentiality,Integrity,Availability,AssessmentStartDate,AssessmentEndDate,AssessmentPriority,UserId,StateId,State,AssessmentStatus")] RMFSystem rMFSystem)
        {
            if (ModelState.IsValid)
            {
                db.RMFSystems.Add(rMFSystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "FirstName", rMFSystem.UserId);
            return View(rMFSystem);
        }

        // GET: RMFSystems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RMFSystem rMFSystem = db.RMFSystems.Find(id);
            if (rMFSystem == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "FirstName", rMFSystem.UserId);
            return View(rMFSystem);
        }

        // POST: RMFSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SystemName,Confidentiality,Integrity,Availability,AssessmentStartDate,AssessmentEndDate,AssessmentPriority,UserId,StateId,State,AssessmentStatus")] RMFSystem rMFSystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rMFSystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "FirstName", rMFSystem.UserId);
            return View(rMFSystem);
        }

        // GET: RMFSystems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RMFSystem rMFSystem = db.RMFSystems.Find(id);
            if (rMFSystem == null)
            {
                return HttpNotFound();
            }
            return View(rMFSystem);
        }

        // POST: RMFSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RMFSystem rMFSystem = db.RMFSystems.Find(id);
            db.RMFSystems.Remove(rMFSystem);
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
