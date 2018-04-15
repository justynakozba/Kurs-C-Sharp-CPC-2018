using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace JustynaKozbaLab2Zad1
{
    /// <summary>
    /// Klasa TrangleFigure dziedzicząca po clasie abstrakcyjnej Figure i interfejsach ICreate i IRorate
    /// Klasa abstrakcyjna Figure zawiera informacje uniwersalne dla każdej figury takie jak kolor, współrzędne oraz kąt.
    /// Zawiera też metody uniwersalne używane dla każdej z figur takie jak MoveAngle oraz ResetFigure. Dziedziczone interfejsy
    /// zawierają informacje i o tworzeniu figury oraz jej obrocie, implementacja interfejsu jest oddzielna dla każdej klasy potomnej.
    /// </summary>
    class TrangleFigure : Figure, ICreate, IRotate
    {
        /// <summary>
        /// Implementacja interfejsu ICreate
        /// </summary>
        public void Create()
        {
            color = Color.Blue; // Ustawienie koloru na niebieski dla trójkąta
            grid[1, 0] = grid[0, 1] = grid[1, 1] = grid[2, 1] = true; // Zmiana odpowiednich pól w siatce tak, aby utworzyć trójkąt
        }

        /// <summary>
        /// Implementacja interfejsu IRorate
        /// </summary>
        public void Rotate()
        {
            MoveAngle(); // Przesunięcie kąta // FIXME
            ResetFigure(); // Zresetowanie figury // FIXME
            //Przesunięcie figury w zależnosci od kąta ustawienia
            switch (angle)
            {
                case 0:
                    grid[1, 0] = grid[0, 1] = grid[1, 1] = grid[2, 1] = true;
                    break;
                case 90:
                    grid[0, 0] = grid[0, 1] = grid[0, 2] = grid[1, 1] = true;
                    break;
                case 180:
                    grid[0, 0] = grid[1, 0] = grid[2, 0] = grid[1, 1] = true;
                    break;
                case 270:
                    grid[1, 0] = grid[1, 1] = grid[1, 2] = grid[0, 1] = true;
                    break;
                default:
                    break;
            }
        }
    }
}

