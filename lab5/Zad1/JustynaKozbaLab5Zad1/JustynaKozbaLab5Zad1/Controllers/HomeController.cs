using JustynaKozbaLab5Zad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustynaKozbaLab5Zad1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Metoda ActionResult zwracająca stronę startową
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Metoda ActionResult wyświetlająca dane kontaktowe
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Metoda ActionResult wyświetlająca ciekawostki
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            return View();
        }
        /// <summary>
        /// Metoda ActionResult zwracająca Exercise1
        /// </summary>
        /// <returns></returns>
        public ActionResult Exercise1()
        {
            ViewBag.Message = "Informacje o nas";

            return View();
        }

        /// <summary>
        /// Metoda ActionResult zwracająca Exercise2
        /// </summary>
        /// <returns></returns>
        public ActionResult Exercise2()
        {
            ViewBag.Message = "Grafik zajęć";

            return View();
        }

        /// <summary>
        /// Metoda ActionResult zwracająca Exercise3
        /// </summary>
        /// <returns></returns>
        public ActionResult Exercise3()
        {
            ViewBag.Message = "Galeria zdjęć";

            return View();
        }

        /// <summary>
        /// Metoda ActionResult zwracająca Exercise4
        /// </summary>
        /// <returns></returns>
        public ActionResult Exercise4()
        {
            ViewBag.Message = "Cennik";

            return View();
        }

        /// <summary>
        /// Metoda ActionResult zwracająca Exercise5
        /// </summary>
        /// <returns></returns>
        public ActionResult Exercise5()
        {
            ViewBag.Message = "Strona logowania";

            return View();
        }

        /// <summary>
        /// Metoda obsługująca zakończenie logowania
        /// </summary>
        /// <param name="contactForm"></param>
        /// <returns></returns>
        public ActionResult SubmitContactForm(ContactForm contactForm)
        {
            try
            {
                TempData["msg"] = "<script>alert('Change succesfully');</script>";
                return RedirectToAction("Index");
            }

            catch
            {
                return View(contactForm);
            }
            

        }
    }
}