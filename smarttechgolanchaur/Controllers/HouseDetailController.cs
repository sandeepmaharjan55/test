﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using smarttechgolanchaur.Models;

namespace smarttechgolanchaur.Controllers
{
    public class HouseDetailController : Controller
    {
        private villageprofileEntities db = new villageprofileEntities();

        // GET: HouseDetail
        public ActionResult Index()
        {
            return View(db.tbl_house_details.ToList());
        }


        // GET: HouseDetail/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_details tbl_house_details = db.tbl_house_details.Find(id);
            if (tbl_house_details == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_details);
        }

        // GET: HouseDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HouseDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ghar_number,old_gabisa,old_ward_number,tole,house_latitude,house_longitude,code,house_owner_name,total_house_member,created_at,updated_at")] tbl_house_details tbl_house_details)
        {
            if (ModelState.IsValid)
            {
                db.tbl_house_details.Add(tbl_house_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_house_details);
        }

        // GET: HouseDetail/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_details tbl_house_details = db.tbl_house_details.Find(id);
            if (tbl_house_details == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_details);
        }

        // POST: HouseDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ghar_number,old_gabisa,old_ward_number,tole,house_latitude,house_longitude,code,house_owner_name,total_house_member,created_at,updated_at")] tbl_house_details tbl_house_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_house_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_house_details);
        }

        // GET: HouseDetail/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_details tbl_house_details = db.tbl_house_details.Find(id);
            if (tbl_house_details == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_details);
        }

        // POST: HouseDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tbl_house_details tbl_house_details = db.tbl_house_details.Find(id);
            db.tbl_house_details.Remove(tbl_house_details);
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
