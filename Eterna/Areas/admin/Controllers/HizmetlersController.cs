using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eterna.Contexts;
using Eterna.ViewModels;

namespace Eterna.Areas.admin.Controllers
{
    [Authorize]
    public class HizmetlersController : Controller
    {
        private MyContext db = new MyContext();

        // GET: admin/Hizmetlers
        public ActionResult Index()
        {
            return View(db.Hizmetler.ToList());
        }

        // GET: admin/Hizmetlers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hizmetler hizmetler = db.Hizmetler.Find(id);
            if (hizmetler == null)
            {
                return HttpNotFound();
            }
            return View(hizmetler);
        }

        // GET: admin/Hizmetlers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Hizmetlers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Ad,Sira")] Hizmetler hizmetler)
        {
            if (ModelState.IsValid)
            {
                db.Hizmetler.Add(hizmetler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hizmetler);
        }

        // GET: admin/Hizmetlers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hizmetler hizmetler = db.Hizmetler.Find(id);
            if (hizmetler == null)
            {
                return HttpNotFound();
            }
            return View(hizmetler);
        }

        // POST: admin/Hizmetlers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Ad,Sira")] Hizmetler hizmetler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hizmetler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hizmetler);
        }

        // GET: admin/Hizmetlers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hizmetler hizmetler = db.Hizmetler.Find(id);
            if (hizmetler == null)
            {
                return HttpNotFound();
            }
            return View(hizmetler);
        }

        // POST: admin/Hizmetlers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hizmetler hizmetler = db.Hizmetler.Find(id);
            db.Hizmetler.Remove(hizmetler);
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
