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
    public class FamilyControlsController : Controller
    {
        private RMFSystemsDB db = new RMFSystemsDB();

        // GET: FamilyControls
        public ActionResult Index()
        {
            return View(db.FamilyControls.ToList());
        }

        // GET: FamilyControls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyControl familyControl = db.FamilyControls.Find(id);
            if (familyControl == null)
            {
                return HttpNotFound();
            }
            return View(familyControl);
        }

        // GET: FamilyControls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyControls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FamilyName,FamilyDescription")] FamilyControl familyControl)
        {
            if (ModelState.IsValid)
            {
                db.FamilyControls.Add(familyControl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familyControl);
        }

        // GET: FamilyControls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyControl familyControl = db.FamilyControls.Find(id);
            if (familyControl == null)
            {
                return HttpNotFound();
            }
            return View(familyControl);
        }

        // POST: FamilyControls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FamilyName,FamilyDescription")] FamilyControl familyControl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familyControl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(familyControl);
        }

        // GET: FamilyControls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilyControl familyControl = db.FamilyControls.Find(id);
            if (familyControl == null)
            {
                return HttpNotFound();
            }
            return View(familyControl);
        }

        // POST: FamilyControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FamilyControl familyControl = db.FamilyControls.Find(id);
            db.FamilyControls.Remove(familyControl);
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
