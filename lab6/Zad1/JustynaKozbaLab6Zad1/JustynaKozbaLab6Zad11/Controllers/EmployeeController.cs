using JustynaKozbaLab6Zad11.DataBase;
using JustynaKozbaLab6Zad11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace JustynaKozbaLab6Zad11.Controllers
{
    public class EmployeeController : ApiController
    {
        /// <summary>
        /// Dodanie metody GetAllEmployees która pobiera wszytskich istniejących pracowników 
        /// </summary>
        /// <returns></returns>
        // GET: Employee
        public IHttpActionResult GetAllEmployees()
        {
            IList<EmployeeModel> students = null;

            using (var ctx = new DataBaseContext1())
            {
                students = ctx.Employee.Include("StudentAddress")
                            .Select(e => new EmployeeModel()
                            {
                                id = e.id,
                                FirstName = e.FirstName,
                                LastName = e.LastName,
                                Age = e.Age,
                                Possition = e.Possition,
                                Salary = e.Salary
                            }).ToList<EmployeeModel>();
            }

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }

        /// <summary>
        /// Metoda dodająca nowy element na podstawie przesłanych danych, metoda dodaje nowego pracownika
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public IHttpActionResult PostNewEmployee(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var context = new DataBaseContext1())
            {
                context.Employee.Add(new Employee()
                {
                    id = employee.id,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Age = employee.Age,
                    Possition = employee.Possition,
                    Salary = employee.Salary
                });

                context.SaveChanges();
            }

            return Ok();
        }

        /// <summary>
        /// Metoda pozwalająca na modyfikację danych o pracowniku
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public IHttpActionResult Put(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DataBaseContext1())
            {
                var existingEmployee = ctx.Employee.Where(e => e.id == employee.id)
                                                        .FirstOrDefault<Employee>();

                if (existingEmployee != null)
                {
                    existingEmployee.FirstName = employee.FirstName;
                    existingEmployee.LastName = employee.LastName;
                    existingEmployee.Age = employee.Age;
                    existingEmployee.Possition = employee.Possition;
                    existingEmployee.Salary = employee.Salary;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();

        }

        /// <summary>
        /// Metoda pozwalająca na usunięcie pracownika
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid employee id");

            using (var ctx = new DataBaseContext1())
            {
                var employee = ctx.Employee
                    .Where(e => e.id == id)
                    .FirstOrDefault();

                ctx.Entry(employee).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}