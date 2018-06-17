using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JustynaKozbaLab8Zad1.Models;

namespace JustynaKozbaLab8Zad1.Controllers
{
    public class JustynaKozbaUsersController : Controller
    {
        private DB_9B1FC5_cpc20181Entities4 db = new DB_9B1FC5_cpc20181Entities4();

        // GET: JustynaKozbaUsers
        public ActionResult Index()
        {
            return View(db.JustynaKozbaUsers.ToList());
        }

        // GET: JustynaKozbaUsers/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JustynaKozbaUsers justynaKozbaUsers = db.JustynaKozbaUsers.Find(id);
            if (justynaKozbaUsers == null)
            {
                return HttpNotFound();
            }
            return View(justynaKozbaUsers);
        }

        // GET: JustynaKozbaUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JustynaKozbaUsers/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Login,Name,Surname,Password")] JustynaKozbaUsers justynaKozbaUsers)
        {
            if (ModelState.IsValid)
            {
                db.JustynaKozbaUsers.Add(justynaKozbaUsers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(justynaKozbaUsers);
        }

        // GET: JustynaKozbaUsers/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JustynaKozbaUsers justynaKozbaUsers = db.JustynaKozbaUsers.Find(id);
            if (justynaKozbaUsers == null)
            {
                return HttpNotFound();
            }
            return View(justynaKozbaUsers);
        }

        // POST: JustynaKozbaUsers/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Login,Name,Surname,Password")] JustynaKozbaUsers justynaKozbaUsers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(justynaKozbaUsers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(justynaKozbaUsers);
        }

        // GET: JustynaKozbaUsers/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JustynaKozbaUsers justynaKozbaUsers = db.JustynaKozbaUsers.Find(id);
            if (justynaKozbaUsers == null)
            {
                return HttpNotFound();
            }
            return View(justynaKozbaUsers);
        }

        // POST: JustynaKozbaUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            JustynaKozbaUsers justynaKozbaUsers = db.JustynaKozbaUsers.Find(id);
            db.JustynaKozbaUsers.Remove(justynaKozbaUsers);
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
