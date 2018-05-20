using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustynaKozbaLab6.Dto
{
    /// <summary>
    /// Dodano klasę zawierająca pozycje tabeli
    /// </summary>
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}