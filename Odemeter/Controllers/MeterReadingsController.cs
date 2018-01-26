using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Odemeter.Models;

namespace Odemeter.Controllers
{
    public class MeterReadingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MeterReadings
        public ActionResult Index()
        {
            return View(db.MeterReadings.ToList());
        }

        // GET: MeterReadings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeterReading meterReading = db.MeterReadings.Find(id);
            if (meterReading == null)
            {
                return HttpNotFound();
            }
            return View(meterReading);
        }

        // GET: MeterReadings/Create
        public ActionResult Create()
        {
            var trans = db.Transporters.ToList();
            ViewBag.transporters = db.Transporters.ToList();
            return View();
        }

        // POST: MeterReadings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TransporterID,Address,Odemeter,TimeStamp,fileURL")] MeterReading meterReading)
        {
            if (ModelState.IsValid)
            {
                db.MeterReadings.Add(meterReading);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meterReading);
        }

        // GET: MeterReadings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeterReading meterReading = db.MeterReadings.Find(id);
            if (meterReading == null)
            {
                return HttpNotFound();
            }
            return View(meterReading);
        }

        // POST: MeterReadings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TransporterID,Address,Odemeter,TimeStamp,fileURL")] MeterReading meterReading)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meterReading).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meterReading);
        }

        // GET: MeterReadings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeterReading meterReading = db.MeterReadings.Find(id);
            if (meterReading == null)
            {
                return HttpNotFound();
            }
            return View(meterReading);
        }

        // POST: MeterReadings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeterReading meterReading = db.MeterReadings.Find(id);
            db.MeterReadings.Remove(meterReading);
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
