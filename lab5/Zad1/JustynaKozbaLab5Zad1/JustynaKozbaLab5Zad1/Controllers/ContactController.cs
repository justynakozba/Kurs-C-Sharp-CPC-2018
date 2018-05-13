using JustynaKozbaLab5Zad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustynaKozbaLab5Zad1.Controllers
{
    public class ContactController : Controller
    {
        /// <summary>
        /// Wprowadzono zestaw danych jakim jest kolekacja, w celu zachowania go między kolejnymi stronami www
        /// </summary>
        static List<ContactForm> contactForm = new List<ContactForm>();
        
        /// <summary>
        /// Wygenerowano automatycznie controller z akcjami odczytu i zapisu,
        /// dostosowano go tak aby odnosił sie do modelu ContactForm poprzez zmiany parametrów 
        /// Do każdej metody automatycznie wygenerowano widok.
        /// </summary>
        /// <returns></returns>
        // GET: Contact
        public ActionResult Index()
        {
            return View(contactForm);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View(contactForm[id]);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(ContactForm contact)
        {
            try
            {
                // TODO: Add insert logic here
                contactForm.Add(contact);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View(contactForm[id]);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ContactForm contact)
        {
            try
            {
                // TODO: Add update logic here
                contactForm[id] = contact;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View(contactForm[id]);
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ContactForm contact)
        {
            try
            {
                // TODO: Add delete logic here
                contactForm.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
