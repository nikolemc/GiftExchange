using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GiftExchangeApp.Models;

namespace GiftExchangeApp.Controllers
{
    public class GiftExchangeTablesController : Controller
    {
        private GiftExchangeDataEntities db = new GiftExchangeDataEntities();

        // GET: GiftExchangeTables
        public ActionResult Index()
        {
            return View(db.GiftExchangeTables.ToList());
        }

        // GET: GiftExchangeTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftExchangeTable giftExchangeTable = db.GiftExchangeTables.Find(id);
            if (giftExchangeTable == null)
            {
                return HttpNotFound();
            }
            return View(giftExchangeTable);
        }

        // GET: GiftExchangeTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GiftExchangeTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Contents,GiftHint,WrappingPaperColor,Height,Width,Depth,Weight,IsOpened")] GiftExchangeTable giftExchangeTable)
        {
            if (ModelState.IsValid)
            {
                db.GiftExchangeTables.Add(giftExchangeTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(giftExchangeTable);
        }

        // GET: GiftExchangeTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftExchangeTable giftExchangeTable = db.GiftExchangeTables.Find(id);
            if (giftExchangeTable == null)
            {
                return HttpNotFound();
            }
            return View(giftExchangeTable);
        }

        // POST: GiftExchangeTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Contents,GiftHint,WrappingPaperColor,Height,Width,Depth,Weight,IsOpened")] GiftExchangeTable giftExchangeTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giftExchangeTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(giftExchangeTable);
        }

        // GET: GiftExchangeTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiftExchangeTable giftExchangeTable = db.GiftExchangeTables.Find(id);
            if (giftExchangeTable == null)
            {
                return HttpNotFound();
            }
            return View(giftExchangeTable);
        }

        // POST: GiftExchangeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GiftExchangeTable giftExchangeTable = db.GiftExchangeTables.Find(id);
            db.GiftExchangeTables.Remove(giftExchangeTable);
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
