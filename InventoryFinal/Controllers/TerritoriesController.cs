using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventoryFinal.Models;

namespace InventoryFinal.Controllers
{
    public class TerritoriesController : Controller
    {
        private InventoryDBContext db = new InventoryDBContext();

        // GET: Territories
        public ActionResult Index()
        {
            var territories = db.Territories.Include(t => t.TerrRegion);
            return View(territories.ToList());
        }

        // GET: Territories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territories territories = db.Territories.Find(id);
            if (territories == null)
            {
                return HttpNotFound();
            }
            return View(territories);
        }

        // GET: Territories/Create
        public ActionResult Create()
        {
            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "RegionDesc");
            return View();
        }

        // POST: Territories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TerritoryID,TerritoryDesc,RegionID")] Territories territories)
        {
            if (ModelState.IsValid)
            {
                db.Territories.Add(territories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "RegionDesc", territories.RegionID);
            return View(territories);
        }

        // GET: Territories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territories territories = db.Territories.Find(id);
            if (territories == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "RegionDesc", territories.RegionID);
            return View(territories);
        }

        // POST: Territories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TerritoryID,TerritoryDesc,RegionID")] Territories territories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(territories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "RegionDesc", territories.RegionID);
            return View(territories);
        }

        // GET: Territories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territories territories = db.Territories.Find(id);
            if (territories == null)
            {
                return HttpNotFound();
            }
            return View(territories);
        }

        // POST: Territories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Territories territories = db.Territories.Find(id);
            db.Territories.Remove(territories);
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
