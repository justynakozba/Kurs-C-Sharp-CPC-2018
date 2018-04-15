using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JustynaKozbaLab2Zad1
{
    /// <summary>
    /// Klasa SquareFigure dziedzicząca po clasie abstrakcyjnej Figure i interfejsach ICreate i IRorate
    /// Klasa abstrakcyjna Figure zawiera informacje uniwersalne dla każdej figury takie jak kolor, współrzędne oraz kąt.
    /// Zawiera też metody uniwersalne używane dla każdej z figur takie jak MoveAngle oraz ResetFigure. Dziedziczone interfejsy
    /// zawierają informacje i o tworzeniu figury oraz jej obrocie, implementacja interfejsu jest oddzielna dla każdej klasy potomnej.
    /// </summary>
    class SquareFigure : Figure, ICreate, IRotate
    {
        /// <summary>
        /// Implementacja interfejsu ICreate
        /// </summary>
        public void Create()
        {
            color = Color.Orange; // Ustawienie koloru na pomarańczowy dla kwadratu
            grid[0, 0] = grid[1, 0] = grid[0, 1] = grid[1, 1] = true; // Zmiana odpowiednich pól w siatce tak, aby utworzyć kwadrat
        }

        /// <summary>
        /// Implementacja interfejsu IRorate
        /// </summary>
        public void Rotate()
        {
        // Kwadrat zawsze będzie wyglądał tak samo nie zależnie od obrotu.
        }
    }
}

