using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TH04.Models;

namespace TH04.Controllers
{
    public class ITEMsController : Controller
    {
        private AnhPhan_DBEntities db = new AnhPhan_DBEntities();

        // GET: ITEMs
        public ActionResult Index()
        {
            var iTEMS = db.ITEMS.Include(i => i.CATEGORy);
            return View(iTEMS.ToList());
        }

        // GET: ITEMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITEM iTEM = db.ITEMS.Find(id);
            if (iTEM == null)
            {
                return HttpNotFound();
            }
            return View(iTEM);
        }

        // GET: ITEMs/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.CATEGORIES, "CategoryId", "CategoryName");
            return View();
        }

        // POST: ITEMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,ItemName,CategoryId,ItemPrice,ItemImageName")] ITEM iTEM)
        {
            if (ModelState.IsValid)
            {
                db.ITEMS.Add(iTEM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.CATEGORIES, "CategoryId", "CategoryName", iTEM.CategoryId);
            return View(iTEM);
        }

        // GET: ITEMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITEM iTEM = db.ITEMS.Find(id);
            if (iTEM == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.CATEGORIES, "CategoryId", "CategoryName", iTEM.CategoryId);
            return View(iTEM);
        }

        // POST: ITEMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,ItemName,CategoryId,ItemPrice,ItemImageName")] ITEM iTEM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iTEM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.CATEGORIES, "CategoryId", "CategoryName", iTEM.CategoryId);
            return View(iTEM);
        }

        // GET: ITEMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ITEM iTEM = db.ITEMS.Find(id);
            if (iTEM == null)
            {
                return HttpNotFound();
            }
            return View(iTEM);
        }

        // POST: ITEMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ITEM iTEM = db.ITEMS.Find(id);
            db.ITEMS.Remove(iTEM);
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
