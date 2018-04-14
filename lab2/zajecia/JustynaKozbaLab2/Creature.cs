using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab2
{
    abstract class Creature
    {
        /// <summary>
        /// Imię stworzenia
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ulubiony kolor
        /// </summary>
        public string FavouriteColor { get; set; }

        /// <summary>
        /// Maksymalna prędkość
        /// </summary>
        public int MaxSpeed { get; set; }

        // nowy obiekt z (int)DateTime.Now.Ticks
        Random random = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// Funkcja zwwracająca losową predkość z przedziału od 0 do MaxSpeed
        /// </summary>
        /// <returns></returns>
        public virtual int GetCurrentSpeed()
        {
            int currentSpeed = random.Next(MaxSpeed);
            return currentSpeed;
        }
    }
}
