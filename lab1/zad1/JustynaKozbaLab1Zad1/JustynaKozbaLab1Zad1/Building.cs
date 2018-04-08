using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab1Zad1
{
    /// <summary>
    /// Klasa reprezentuje budynek. 
    /// </summary>
    class Building
    {
        /// <summary>
        /// name - zmienna przechowująca nazwę budynku
        /// </summary>
        public string name {set; get;}

        /// <summary>
        ///  levelPrice pole typu Price przechowujące informujące o cenie za następny poziom 
        /// </summary>
        public Price levelPrice { set; get; }

        /// <summary>
        /// level - zmienna przechowująca informacje o poziomie budynku
        /// </summary>
        public int level{ set; get;}

        /// <summary>
        /// quantity - zmienna przechowująca informacje o ilości surowca
        /// </summary>
        public int quantity { set; get;}

        /// <summary>
        /// resourcesPerSecond - zmienna reprezentujaca przybywające surowce na sekundę
        /// </summary>
        public int resourcesPerSecond{ set; get;}

        /// <summary>
        /// konstruktor paramatryczny inicjujący jej pola przekazanymi wartościami
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <param name="quantity"></param>
        /// <param name="resourcesPerSec"></param>
        /// <param name="levelPrice"></param>
        public Building(string name, int level, int quantity, int resourcesPerSecond, Price levelPrice)
        {
            this.name = name;
            this.level = level;
            this.quantity = quantity;
            this.resourcesPerSecond = resourcesPerSecond;
            this.levelPrice = levelPrice;

        }

        /// <summary>
        /// metoda aktualizująca ilość surowca 
        /// suma ilości surowca z iloczynem przyrostu ilości surowca w czasie i minionym czasem
        /// </summary>
        /// <param name="timeLapsed">Czas w sekundach</param>
        public void updateValues(int timeLapsed)
        {
            quantity += resourcesPerSecond * timeLapsed;
        }

        /// <summary>
        /// metoda aktualizująca zmianę przyrostu surowca w czasie wraz ze zmianą poziomu
        /// </summary>
        public void upgrade()
        {
            levelPrice.multiply();
            level ++;
            resourcesPerSecond = resourcesPerSecond * 2;
        }

        /// <summary>
        /// metoda zwracająca string zawierający informacje o aktualnym poziomie
        /// </summary>
        /// <returns>string</returns>
        public string getLevelString()
        {
            return "Poziom: " + level;
        }

        /// <summary>
        /// metoda zwracająca string z wartościami ceny za następny poziom 
        /// </summary>
        /// <returns></returns>
        public string getLevelPrices()
        {
            return "Drewno: " + levelPrice.wood.ToString() + " Siano: " + levelPrice.hay + "\nKamień: " + levelPrice.stone + " Złoto: " + levelPrice.gold;
        }
    }
}
