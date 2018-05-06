using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4Zad1.Model
{
    public class Customers : Entity
    {
        /// <summary>
        /// Pole klasy przechowujące inforamcje o imieniu klienta 
        /// </summary>
        [Required]
        public String Name { get; set; }

        /// <summary>
        /// Pole klasy przechowujące inforamcje o nazwisku klienta 
        /// </summary>
        [Required]
        public String LastName { get; set; }

        /// <summary>
        /// Pole klasy przechowujące inforamcje o numerze id zamówienia będące kluczem obcym 
        /// </summary>
        [ForeignKey("OrderId")]
        public virtual Orders Orders { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        /// Metoda odpowiadająca za przepisanie wybranych wartości na String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Imię: " + Name + " Nazwisko: " + LastName + " Numer zamówienia: " + OrderId;
        }

        public virtual List<Invoices> Invoices { get; set; }
    }
}
