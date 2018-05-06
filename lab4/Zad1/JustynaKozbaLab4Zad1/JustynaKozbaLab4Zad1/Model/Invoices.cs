using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4Zad1.Model
{
    public class Invoices : Entity
    {
        /// <summary>
        /// Pole klasy przechowujące inforamcje o numerze faktury
        /// </summary>
        [Required]
        public int InvoiceNumber { get; set; }

        /// <summary>
        /// Pole klasy przechowujące inforamcje o dacie wystawienia 
        /// </summary>
        [Required]
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Pole klasy przechowujące inforamcje o id klienta bedące kluczem obcym 
        /// </summary>
        [ForeignKey("CustomerId")]
        public virtual Customers Customers { get; set; }
        public int CustomerId { get; set; }

        public override string ToString()
        {
            return "Numer faktury: " + InvoiceNumber + " Data zamówienia: " + DateOfIssue + " Id klienta: " + CustomerId;
        }
    }
}
