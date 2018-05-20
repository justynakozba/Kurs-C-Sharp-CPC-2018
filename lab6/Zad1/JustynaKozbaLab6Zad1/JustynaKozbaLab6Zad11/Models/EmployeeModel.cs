using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustynaKozbaLab6Zad11.Models
{
    /// <summary>
    /// Klasa zwierająca informacje o nagłówkach tabeli pracowników
    /// </summary>
    public class EmployeeModel
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public string Possition { get; set; }

        public int? Salary { get; set; }
    }
}