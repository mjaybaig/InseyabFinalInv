﻿using System;
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
    [Authorize(Roles = "Admin")]
    public class ShippersController : Controller
    {
        private InventoryDBContext db = new InventoryDBContext();

        [AllowAnonymous]
        // GET: Shippers
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        [AllowAnonymous]
        // GET: Shippers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        // GET: Shippers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyName,Phone")] Shippers shippers)
        {
            if (ModelState.IsValid)
            {
                db.Shippers.Add(shippers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shippers);
        }

        // GET: Shippers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        // POST: Shippers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyName,Phone")] Shippers shippers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shippers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippers);
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shippers shippers = db.Shippers.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        // POST: Shippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shippers shippers = db.Shippers.Find(id);
            db.Shippers.Remove(shippers);
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
