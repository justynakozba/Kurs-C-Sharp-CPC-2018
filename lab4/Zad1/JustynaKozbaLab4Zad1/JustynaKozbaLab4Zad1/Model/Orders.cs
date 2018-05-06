using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4Zad1.Model
{
   public class Orders : Entity
    {
        /// <summary>
        /// Pole klasy przechowujące inforamcje o nazwie produktu
        /// </summary>
        [Required]
        public String ProductName { get; set; }

        /// <summary>
        /// Pole klasy przechowujące inforamcje o ilości zamówionych produktów
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Pole klasy przechowujące inforamcje o cenie produktu
        /// </summary>
        [Required]
        public int Price { get; set; }

        public virtual List<Customers> Customers { get; set; }
        public override string ToString()
        {
            return "Nazwa produktu: " + ProductName + " Ilość: " + Quantity + " Cena: " + Price;
        }
    }
}
