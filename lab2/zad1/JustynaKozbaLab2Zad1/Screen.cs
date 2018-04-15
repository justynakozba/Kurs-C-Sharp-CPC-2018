using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JustynaKozbaLab2Zad1
{
    /// <summary>
    ///Klasa dziedzicząca po klasie Board, służąca do rysowania i obracania figur
    ///Klasa Board zawiera informacje o grafice gry
    /// </summary>
    public class Screen : Board
    {

        /// <summary>
        ///Pole klasy reprezentujące figurę
        /// </summary>
        private Figure figure;

        /// <summary>
        ///Konstruktor bezparametryczny
        /// </summary>
        public Screen()
        {
        }

        /// <summary>
        /// Konstruktor parametryczny
        /// Współrzędne figury to współrzędna jej lewego górnego rogu
        /// </summary>
        /// <param name="x">współrzędna figury x</param>
        /// <param name="y">współrzędna figury y</param>
        public Screen(int x, int y)
            : base(x, y)
        {
        }

        /// <summary>
        /// Metod rysująca figurę
        /// </summary>
        /// <param name="x">współrzędna x</param>
        /// <param name="y">współrzędna y</param>
        /// <param name="figure">figura</param>
        /// <returns>figura</returns>
        public bool DrawFigure(int x, int y, Figure figure)
        {
            if (!CheckSize(x, y))
            {
                return false;
            }
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j])
                    {
                        if (!CheckSize(x + i, y + j))
                        {
                            return false;
                        }
                        if (grid[x + i, y + j].InUse)
                        {
                            return false;
                        }
                    }
                }
            }
            figure.x = x;
            figure.y = y;
            if (this.figure != figure)
            {
                this.figure = figure;
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j])
                    {
                        grid[x + i, y + j].Color = figure.color;
                        DrawBlock(x + i, y + j);
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Metoda odpowiadająca za poruszanie się figur w dół
        /// </summary>
        /// <returns></returns>
        public bool Down()
        {
            if (this.figure == null)
            {
                return false;
            }
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j] && (j == 3 || !figure.grid[i, j + 1]))
                    {
                        if (!CheckSize(figure.x + i, figure.y + j + 1))
                        {
                            return false;
                        }
                        if (grid[figure.x + i, figure.y + j + 1].InUse)
                        {
                            return false;
                        }
                    }
                }
            }

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j])
                    {
                        grid[figure.x + i, figure.y + j].Remove(graphic, BackColor);
                    }
                }
            }
 
            DrawFigure(figure.x, figure.y + 1, figure);
            return true;
        }

        /// <summary>
        /// Metoda umożliwiajaca przesunięcie figury w lewo
        /// </summary>
        /// <returns></returns>
        public bool MoveLeft()
        {
            if (figure == null)
                return false;
            int i, j;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j] && (i == 0 || !figure.grid[i - 1, j]))
                    {
                        if (!CheckSize(figure.x + i - 1, figure.y + j))
                            return false;
                        if (grid[figure.x + i - 1, figure.y + j].InUse)
                            return false;
                    }
                }

            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    if (figure.grid[i, j]) grid[figure.x + i, figure.y + j].Remove(graphic, BackColor);
            DrawFigure(figure.x - 1, figure.y, figure);
            return true;
        }

        /// <summary>
        /// Metoda umożliwiajaca przesunięicie figury w prawo
        /// </summary>
        /// <returns></returns>
        public bool MoveRight()
        {
            if (figure == null) return false;
            int i, j;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j] && (i == 3 || !figure.grid[i + 1, j]))
                    {
                        if (!CheckSize(figure.x + i + 1, figure.y + j)) return false;
                        if (grid[figure.x + i + 1, figure.y + j].InUse) return false;
                    }
                }

            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    if (figure.grid[i, j]) grid[figure.x + i, figure.y + j].Remove(graphic, BackColor);
            DrawFigure(figure.x + 1, figure.y, figure);
            return true;
        }


        /// <summary>
        ///Metoda implemetująca obrót figury
        /// </summary>
        public void Rotate()
        {
            int i, j;

            bool[,] oldGrid = new bool[4, 4];
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    oldGrid[i, j] = figure.grid[i, j];
                }
            }

            // Rzutowanie w dół interfejsu IRotate
            IRotate rotatable = (IRotate)figure;
            rotatable.Rotate();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (figure.grid[i, j] && !CheckSize(figure.x + i, figure.y + j))
                    {
                        return;
                    }
                    if (figure.grid[i, j] && !oldGrid[i, j] && grid[figure.x + i, figure.y + j].InUse)
                    {
                        return;
                    }
                }
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (oldGrid[i, j])
                    {
                        grid[figure.x + i, figure.y + j].Remove(graphic, BackColor);
                    }
                }
            }

            DrawFigure(figure.x, figure.y, figure);
        }

        /// <summary>
        /// Metoda odpowiadająca za kasowanie linii
        /// </summary>
        /// <param name="n">numer linii</param>
        public void CleanLine(int n)
        {
            if (!CheckSize(1, n))
            {
                return;
            }
            for (int i = 0; i < screenWidth; i++)
            {
                grid[i, n].Remove(graphic, BackColor);
            }
        }



        public void RemoveItem()
        {
            for (int z = 1; z < 5; z++)
            {
                Block a = new Block(figure.x + z, figure.y + z);
                a.InUse=false;
            }
        }

        /// <summary>
        /// Metoda odpowiadająca za przesunięcie linii
        /// </summary>
        /// <param name="n">numer linii</param>
        public void MoveLine(int n)
        {
            if (n < 0 || n >= screenHeight - 1)
            {
                return;
            }
            int i;
            for (i = 0; i < screenWidth; i++)
            {
                if (!grid[i, n].InUse)
                {
                    grid[i, n + 1].Remove(graphic, BackColor);
                    continue;
                }
                grid[i, n + 1].Color=grid[i, n].Color;
                grid[i, n + 1].Draw(graphic);
                grid[i, n].Remove(graphic, BackColor);
            }
        }

        /// <summary>
        /// Metoda zwracająca ilość linii
        /// </summary>
        public int Linie()
        {
            int n = screenHeight - 1;
            int i;
            int cnt = 0;
            bool ifLine = true;
            while (n > 0 && cnt < 4)
            {
                for (i = 0; i < screenWidth; i++)
                {
                    if (!grid[i, n].InUse)
                    {
                        ifLine = false;
                    }
                }
                if (ifLine)
                {
                    cnt++;
                    for (int m = n - 1; m >= 0; m--)
                    {
                        MoveLine(m);
                    }
                }
                else n--;
                ifLine = true;
            }
            return cnt;
        }

        /// <summary>
        /// Metoda zwracająca figurę
        /// </summary>
        /// <returns></returns>
        public Figure GetFigur()
        {
            return figure;
        }
    }
}
