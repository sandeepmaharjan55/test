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
    public class HouseOwnerInfoController : Controller
    {
        private villageprofileEntities db = new villageprofileEntities();

        // GET: HouseOwnerInfo
        public ActionResult Index()
        {
            return View(db.tbl_house_owner_infos.ToList());
        }

        // GET: HouseOwnerInfo/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_owner_infos tbl_house_owner_infos = db.tbl_house_owner_infos.Find(id);
            if (tbl_house_owner_infos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_owner_infos);
        }

        // GET: HouseOwnerInfo/Create
        public ActionResult Create()
        {
            
           
            ViewBag.health = new SelectList(db.tbl_health_condition, "id", "health_condition");
            return View();
        }

        // POST: HouseOwnerInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ghar_number,full_name,education,profession,mobile_number,date_of_birth,birth_place,gender,temporary_address,health,religion,citizenship_number,citizenship_release_date,citizenship_release_district,created_at,updated_at")] tbl_house_owner_infos tbl_house_owner_infos,
            string otherprofession,string prof,string othereducation, string edu, string othergender, string gen, string otherreligion, string reli)
        {
            
            if (ModelState.IsValid)
            {
                #region
                if (tbl_house_owner_infos.profession == "Other")
                {
                    prof = otherprofession;
                }
                else
                {
                   prof = tbl_house_owner_infos.profession;
                }
                if (tbl_house_owner_infos.education == "Other")
                {
                    edu = othereducation;
                }
                else
                {
                    edu = tbl_house_owner_infos.education;
                }
                if (tbl_house_owner_infos.gender == "Other")
                {
                    gen = othergender;
                }
                else
                {
                    gen = tbl_house_owner_infos.gender;
                }
                if (tbl_house_owner_infos.religion == "Other")
                {
                    reli = otherreligion;
                }
                else
                {
                    reli = tbl_house_owner_infos.religion;
                }

                #endregion
                db.tbl_house_owner_infos.Add(new tbl_house_owner_infos()
                {
                    ghar_number = tbl_house_owner_infos.ghar_number,
                    full_name = tbl_house_owner_infos.full_name,
                    education = edu,
                    profession = prof,
                    mobile_number = tbl_house_owner_infos.mobile_number,
                    date_of_birth = tbl_house_owner_infos.date_of_birth,
                    birth_place = tbl_house_owner_infos.birth_place,
                    gender = gen,
                    temporary_address = tbl_house_owner_infos.temporary_address,
                    health = tbl_house_owner_infos.health,
                    religion = reli,
                    citizenship_number = tbl_house_owner_infos.citizenship_number,
                    citizenship_release_date = tbl_house_owner_infos.citizenship_release_date,
                    citizenship_release_district = tbl_house_owner_infos.citizenship_release_district,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_house_owner_infos);
        }

        // GET: HouseOwnerInfo/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_owner_infos tbl_house_owner_infos = db.tbl_house_owner_infos.Find(id);
            if (tbl_house_owner_infos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_owner_infos);
        }

        // POST: HouseOwnerInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ghar_number,full_name,education,profession,mobile_number,date_of_birth,birth_place,gender,temporary_address,health,religion,citizenship_number,citizenship_release_date,citizenship_release_district,created_at,updated_at")] tbl_house_owner_infos tbl_house_owner_infos)
        {
            if (ModelState.IsValid)
            {
                var houseowner = new tbl_house_owner_infos
                {
                    id= tbl_house_owner_infos.id,
                    ghar_number = tbl_house_owner_infos.ghar_number,
                    full_name = tbl_house_owner_infos.full_name,
                    education = tbl_house_owner_infos.education,
                    profession = tbl_house_owner_infos.profession,
                    mobile_number = tbl_house_owner_infos.mobile_number,
                    date_of_birth = tbl_house_owner_infos.date_of_birth,
                    birth_place = tbl_house_owner_infos.birth_place,
                    gender = tbl_house_owner_infos.gender,
                    temporary_address = tbl_house_owner_infos.temporary_address,
                    health = tbl_house_owner_infos.health,
                    religion = tbl_house_owner_infos.religion,
                    citizenship_number = tbl_house_owner_infos.citizenship_number,
                    citizenship_release_date = tbl_house_owner_infos.citizenship_release_date,
                    citizenship_release_district = tbl_house_owner_infos.citizenship_release_district,
                    created_at = tbl_house_owner_infos.created_at,
                    updated_at = DateTime.Now
                };
                db.Entry(houseowner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_house_owner_infos);
        }

        // GET: HouseOwnerInfo/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_owner_infos tbl_house_owner_infos = db.tbl_house_owner_infos.Find(id);
            if (tbl_house_owner_infos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_owner_infos);
        }

        // POST: HouseOwnerInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tbl_house_owner_infos tbl_house_owner_infos = db.tbl_house_owner_infos.Find(id);
            db.tbl_house_owner_infos.Remove(tbl_house_owner_infos);
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
