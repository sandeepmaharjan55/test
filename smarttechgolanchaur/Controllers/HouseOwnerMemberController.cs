using System;
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
    public class HouseOwnerMemberController : Controller
    {
        private villageprofileEntities db = new villageprofileEntities();

        // GET: HouseOwnerMember
        public ActionResult Index()
        {
            return View(db.tbl_owner_members.ToList());
        }

        // GET: HouseOwnerMember/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_owner_members tbl_owner_members = db.tbl_owner_members.Find(id);
            if (tbl_owner_members == null)
            {
                return HttpNotFound();
            }
            return View(tbl_owner_members);
        }

        // GET: HouseOwnerMember/Create
        public ActionResult Create()
        {
            ViewBag.OwnerID = new SelectList(db.tbl_house_owner_infos, "id", "full_name");
            return View();
        }

        // POST: HouseOwnerMember/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,owner_id,full_name,gender,date_of_birth,cast,profession,profession_position,religion,education,living_place,abroad_occupation,health_condition,physical_disability_condition,marriage_status,language,created_at,updated_at")] tbl_owner_members tbl_owner_members)
        {
            if (ModelState.IsValid)
            {
                db.tbl_owner_members.Add(tbl_owner_members);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_owner_members);
        }

        // GET: HouseOwnerMember/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_owner_members tbl_owner_members = db.tbl_owner_members.Find(id);
            if (tbl_owner_members == null)
            {
                return HttpNotFound();
            }
            return View(tbl_owner_members);
        }

        // POST: HouseOwnerMember/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,owner_id,full_name,gender,date_of_birth,cast,profession,profession_position,religion,education,living_place,abroad_occupation,health_condition,physical_disability_condition,marriage_status,language,created_at,updated_at")] tbl_owner_members tbl_owner_members)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_owner_members).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_owner_members);
        }

        // GET: HouseOwnerMember/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_owner_members tbl_owner_members = db.tbl_owner_members.Find(id);
            if (tbl_owner_members == null)
            {
                return HttpNotFound();
            }
            return View(tbl_owner_members);
        }

        // POST: HouseOwnerMember/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tbl_owner_members tbl_owner_members = db.tbl_owner_members.Find(id);
            db.tbl_owner_members.Remove(tbl_owner_members);
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
