using JustynaKozbaLab6Zad11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace JustynaKozbaLab6Zad11.Controllers
{
    public class EmployeesController : Controller
    {
        /// <summary>
        /// Wykonanie metody GetAllEmployees
        /// </summary>
        /// <returns></returns>
        // GET: Employees
        public ActionResult Index()
        {
            IEnumerable<EmployeeModel> employee = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60419/api/");
                //HTTP GET
                var responseTask = client.GetAsync("employee");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<EmployeeModel>>();
                    readTask.Wait();

                    employee = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    employee = Enumerable.Empty<EmployeeModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(employee);
        }


    /// <summary>
    /// Wykonanie metody Post 
    /// </summary>
    /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60419/api/employee");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<EmployeeModel>("employee", employee);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(employee);
        }

        /// <summary>
        /// Wykonanie metody Put 
        /// </summary>
        public ActionResult Edit(int id)
        {
            EmployeeModel employee = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60419/api/");
                //HTTP GET
                var responseTask = client.GetAsync("employee?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<EmployeeModel>();
                    readTask.Wait();

                    employee = readTask.Result;
                }
            }

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60419/api/employee");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<EmployeeModel>("employee", employee);
                putTask.Wait();


                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        /// <summary>
        /// Wykonanie metody Delete 
        /// </summary>
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60419/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("employee/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");

        }
    }
}