using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopbProj.Models;

namespace ShopbProj.Controllers
{
    public class ShopbridgesController : Controller
    {
        private CRUDDBEntities db = new CRUDDBEntities();

        // GET: Shopbridges
        public ActionResult Index()
        {
            return View(db.Shopbridges.ToList());
        }

        // GET: Shopbridges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopbridge shopbridge = db.Shopbridges.Find(id);
            if (shopbridge == null)
            {
                return HttpNotFound();
            }
            return View(shopbridge);
        }

        // GET: Shopbridges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shopbridges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Price,Uploadfile")] Shopbridge shopbridge)
        {
            if (ModelState.IsValid)
            {
                db.Shopbridges.Add(shopbridge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopbridge);
        }

        // GET: Shopbridges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopbridge shopbridge = db.Shopbridges.Find(id);
            if (shopbridge == null)
            {
                return HttpNotFound();
            }
            return View(shopbridge);
        }

        // POST: Shopbridges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Price,Uploadfile")] Shopbridge shopbridge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopbridge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopbridge);
        }

        // GET: Shopbridges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopbridge shopbridge = db.Shopbridges.Find(id);
            if (shopbridge == null)
            {
                return HttpNotFound();
            }
            return View(shopbridge);
        }

        // POST: Shopbridges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shopbridge shopbridge = db.Shopbridges.Find(id);
            db.Shopbridges.Remove(shopbridge);
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
