using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }

      

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            decimal quote = 50;
            if (DateTime.Now.Year - table.DateOfBirth.Year < 25)
            {
                quote += 25;
            }
            if (DateTime.Now.Year - table.DateOfBirth.Year < 18)
            {
                quote += 75;
            }
            if (table.CarYear < 2000 == table.CarYear > 25)
            {
                quote += 25;
            }
            if (table.CarMake.ToLower() == "porsche")
            {
                quote += 25;
                if (table.CarModel.ToLower() == "911 Carrera")
                {
                    quote += 25;
                }
            }
            if (table.SpeedingTickets > 0)
            {
                quote = table.SpeedingTickets * 10 + quote;
            }
            if (table.DUI == true)
            {
                quote = quote * 1.25m;
            }
            if (table.CoverageType == true)
            {
                quote = quote * 1.5m;
            }
            table.Quote = quote;

            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
