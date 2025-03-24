using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projekat.Data;
using Projekat.Models;

namespace Projekat.Controllers
{
    public class kupcisController : Controller
    {
        private ProjekatContext db = new ProjekatContext();

        // GET: kupcis
        public ActionResult Index()
        {
            return View(db.kupcis.ToList());
        }

        // GET: kupcis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kupci kupci = db.kupcis.Find(id);
            if (kupci == null)
            {
                return HttpNotFound();
            }
            return View(kupci);
        }

        // GET: kupcis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kupcis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ImeIPrezime,Email,Poruka")] kupci kupci)
        {
            if (ModelState.IsValid)
            {
                db.kupcis.Add(kupci);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kupci);
        }

        // GET: kupcis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kupci kupci = db.kupcis.Find(id);
            if (kupci == null)
            {
                return HttpNotFound();
            }
            return View(kupci);
        }

        // POST: kupcis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Poruka,ImeIPrezime,Email")] kupci kupci)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kupci).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kupci);
        }

        // GET: kupcis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kupci kupci = db.kupcis.Find(id);
            if (kupci == null)
            {
                return HttpNotFound();
            }
            return View(kupci);
        }

        // POST: kupcis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kupci kupci = db.kupcis.Find(id);
            db.kupcis.Remove(kupci);
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
