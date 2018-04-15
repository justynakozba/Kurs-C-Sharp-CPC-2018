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
    /// Klasa abstrakcyjna reprezentująca figurę tworzona z bloczków
    /// </summary>
    abstract public class Figure
    {
        /// <summary>
        /// Tablica dwuwymiarowa reprezentująca stan siatki o wymiarze 4 x 4 bloczki.
        /// Jeżeli wartość pola tablicy ma wartość true to bloczek jest zamalowany
        /// </summary>
        public bool[,] grid;

        /// <summary>
        /// Pole przechowujące informacje o kolorze
        /// </summary>
        public Color color;

        /// <summary>
        /// Pole przechowujące informacje o kątcie
        /// </summary>
        public int angle;

        /// <summary>
        /// Współrzędne x i y figury
        /// </summary>
        public int x;
        public int y;

        /// <summary>
        /// Konstruktor tworzący figurę
        /// </summary>
        public Figure()
        {
            angle = 0;
            x = 0;
            y = 0;
            grid = new bool[4, 4];
            ResetFigure(); //FIXME: slajd 23
        }

        /// <summary>
        /// Metoda resetująca figurę - ustawia stany pól tablicy na false
        /// </summary>
        public void ResetFigure()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    grid[i, j] = false;
                }
            }
        }

        /// <summary>
        /// Metoda odpowiadająca za zmianę wartości kąta o 90 stopni
        /// </summary>
        public void MoveAngle()
        {
            if (angle == 270) 
            {
                angle = 0;
            }
            else
            {
                angle += 90;
            }
        }

    }
}
