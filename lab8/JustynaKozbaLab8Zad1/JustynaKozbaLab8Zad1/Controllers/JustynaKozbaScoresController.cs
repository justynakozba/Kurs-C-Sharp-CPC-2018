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
    public class JustynaKozbaScoresController : Controller
    {
        private DB_9B1FC5_cpc20181Entities4 db = new DB_9B1FC5_cpc20181Entities4();

        // GET: JustynaKozbaScores
        public ActionResult Index()
        {
            var justynaKozbaScore = db.JustynaKozbaScore.Include(j => j.JustynaKozbaScore2);
            return View(justynaKozbaScore.ToList());
        }

        // GET: JustynaKozbaScores/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JustynaKozbaScore justynaKozbaScore = db.JustynaKozbaScore.Find(id);
            if (justynaKozbaScore == null)
            {
                return HttpNotFound();
            }
            return View(justynaKozbaScore);
        }

        // GET: JustynaKozbaScores/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.JustynaKozbaScore, "Id", "Login");
            return View();
        }

        // POST: JustynaKozbaScores/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Login,Score,UserId")] JustynaKozbaScore justynaKozbaScore)
        {
            if (ModelState.IsValid)
            {
                db.JustynaKozbaScore.Add(justynaKozbaScore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.JustynaKozbaScore, "Id", "Login", justynaKozbaScore.UserId);
            return View(justynaKozbaScore);
        }

        // GET: JustynaKozbaScores/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JustynaKozbaScore justynaKozbaScore = db.JustynaKozbaScore.Find(id);
            if (justynaKozbaScore == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.JustynaKozbaScore, "Id", "Login", justynaKozbaScore.UserId);
            return View(justynaKozbaScore);
        }

        // POST: JustynaKozbaScores/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Login,Score,UserId")] JustynaKozbaScore justynaKozbaScore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(justynaKozbaScore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.JustynaKozbaScore, "Id", "Login", justynaKozbaScore.UserId);
            return View(justynaKozbaScore);
        }

        // GET: JustynaKozbaScores/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JustynaKozbaScore justynaKozbaScore = db.JustynaKozbaScore.Find(id);
            if (justynaKozbaScore == null)
            {
                return HttpNotFound();
            }
            return View(justynaKozbaScore);
        }

        // POST: JustynaKozbaScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            JustynaKozbaScore justynaKozbaScore = db.JustynaKozbaScore.Find(id);
            db.JustynaKozbaScore.Remove(justynaKozbaScore);
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
