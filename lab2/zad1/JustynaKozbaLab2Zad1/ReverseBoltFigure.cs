﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JustynaKozbaLab2Zad1
{
    /// <summary>
    /// Klasa ReverseBoltFigure dziedzicząca po clasie abstrakcyjnej Figure i interfejsach ICreate i IRorate
    /// Klasa abstrakcyjna Figure zawiera informacje uniwersalne dla każdej figury takie jak kolor, współrzędne oraz kąt.
    /// Zawiera też metody uniwersalne używane dla każdej z figur takie jak MoveAngle oraz ResetFigure. Dziedziczone interfejsy
    /// zawierają informacje i o tworzeniu figury oraz jej obrocie, implementacja interfejsu jest oddzielna dla każdej klasy potomnej.
    /// </summary>
    class ReverseBoltFigure : Figure, ICreate, IRotate
    {
        /// <summary>
        /// Implementacja interfejsu ICreate
        /// </summary>
        public void Create()
        {
            color = Color.Pink; // Ustawienie koloru na różowy dla figury w  kształcie odwróconej błyskawicy
            grid[1, 0] = grid[1, 1] = grid[0, 1] = grid[0, 2] = true; // Zmiana odpowiednich pól w siatce tak, aby utworzyć odwróconą błyskawicę
        }

        /// <summary>
        /// Implementacja interfejsu IRorate
        /// </summary>
        public void Rotate()
        {
            MoveAngle(); // Przesunięcie kąta 
            ResetFigure(); // Zresetowanie figury 

            //Przesunięcie figury w zależnosci od kąta ustawienia
            switch (angle)
            {
                case 0:
                case 180:
                    grid[1, 0] = grid[1, 1] = grid[0, 1] = grid[0, 2] = true;
                    break;
                case 90:
                case 270:
                    grid[0, 0] = grid[1, 0] = grid[1, 1] = grid[2, 1] = true;
                    break;
                default:
                    break;
            }
        }
    }
}

