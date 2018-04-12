using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab2
{
    class Horse : Creature, IMovable
    {

        /// <summary>
        /// Imie konia
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ulubiony kolor
        /// </summary>
        public string FavouriteColor { get; set; }

        public Horse()
        {

        }

        /// <summary>
        /// Konstruktor parametryczny
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="FavouriteColor"></param>
        public Horse(String newName, string favouriteColor)
        {
            this.Name = newName;
            this.FavouriteColor = favouriteColor;
        }

        /// <summary>
        /// Przykłądowa funkcja, która zwraca jakiś tekst
        /// </summary>
        /// <returns></returns>
        public string DoSomething()
        {
            return "Do something";
        }

        /// <summary>
        /// zwracanie informacji o objekcie
        /// </summary>
        /// <returns>String- informacje o objekcie</returns>
        override public string ToString()
        {
            return $"My name is {Name} and my favourite color is {FavouriteColor}";
        }


        /// <summary>
        /// 
        /// </summary>
        public string Go()
        {
            return $"M,m going";
         
        }
    }

    
}
