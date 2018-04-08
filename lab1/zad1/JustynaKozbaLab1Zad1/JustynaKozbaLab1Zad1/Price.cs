using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab1Zad1
{
    /// <summary>
    /// Klasa reprezentująca cenę jaką trzeba zapłącić
    /// za uaktualnienie do budynku do kolejnego levelu.
    /// </summary>
    class Price
    {
        /// <summary>
        /// wood - zmienna reprezentująca ilość drewna jaką trzeba zapłącić za kolejny poziom.
        /// </summary>
        public int wood { set; get; }

        /// <summary>
        /// hay - zmienna reprezentująca ilość siana jaką trzeba zapłącić za kolejny poziom.
        /// </summary>
        public int hay { set; get; }
 
        /// <summary>
        /// stone - zmienna reprezentująca ilość kamienia jaką trzeba zapłącić za kolejny poziom.
        /// </summary>
        public int stone { set; get; }

        /// <summary>
        /// gold - zmienna reprezentująca ilość złota jaką trzeba zapłącić za kolejny poziom.
        /// </summary>
        public int gold { set; get; }

        /// <summary>
        /// multiplyFactor - zmienna reprezentująca mnożnik.
        /// Mnożnika będziemy używać do generowania cen za kolejne poziomy,
        /// definjuje on szybkość z jaką będą rosły ceny kolejnych poziomów.
        /// </summary>
        public int multiplyFactor { set; get; }

        /// <summary>
        /// Konstruktor parametryczny klasy inicjalizujący jej pola przekazanymi wartościami.
        /// </summary>
        /// <param name="wood"></param>
        /// <param name="hay"></param>
        /// <param name="stone"></param>
        /// <param name="gold"></param>
        /// <param name="multiplyFactor"></param>
        public Price(int wood, int hay, int stone, int gold, int multiplyFactor)
        {
            this.wood = wood;
            this.hay = hay;
            this.stone = stone;
            this.gold = gold;
            this.multiplyFactor = multiplyFactor;

        }

        /// <summary>
        /// Metoda klasy odpowiedzialna za podnoszenie cen.
        /// Każda cena jest mnożona przez wcześniej zdefinowany mnożnik.
        /// </summary>
        public void multiply()
        {
            this.wood += wood * multiplyFactor;
            this.hay += hay * multiplyFactor;
            this.stone += stone * multiplyFactor;
            this.gold += gold * multiplyFactor;
        }

        /// <summary>
        /// Metoda klasy odpowiedzialna za sprawdzenie czy mamy wystarczającą liczbę zasobów
        /// aby zakupić kolejny poziom.
        /// </summary>
        public Boolean checkPrice( int wood, int hay, int stone, int gold)
        {
            if(this.wood <= wood && this.hay <= hay && this.stone <= stone && this.gold <= gold)
            {
                return true;
            }

            return false;
        }
    }
}
