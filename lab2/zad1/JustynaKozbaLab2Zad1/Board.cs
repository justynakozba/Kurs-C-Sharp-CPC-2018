using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;


namespace JustynaKozbaLab2Zad1
{
    /// <summary>
    /// Klasa dziedzicząca po klasie Panel, służąca do reprezentacji graficznej pola gry
    /// </summary>
    public class Board : Panel
    {
        /// <summary>
        /// Pole typu graphic reprezentujące grafikę
        /// </summary>
        protected Graphics graphic;

        /// <summary>
        /// Pole przechowujące tablice dwuwymiarową
        /// </summary>
        protected Block[,] grid;

        /// <summary>
        /// Pole przechowujące szerokośc ekranu
        /// </summary>
        protected int screenWidth;

        /// <summary>
        /// Pole przechowujące wysokość ekranu
        /// </summary>
        protected int screenHeight;

        /// <summary>
        /// Kontruktor bezparametyczny inicjalizujący klasę
        /// </summary>
        public Board()
        {
            screenWidth = 10;
            screenHeight = 10;
            this.Size = new System.Drawing.Size(screenWidth * Block.size + 4, screenHeight * Block.size + 4);
            grid = new Block[screenWidth, screenHeight];

            for (int i = 0; i < screenWidth; i++)
                for (int j = 0; j < screenHeight; j++)
                    grid[i, j] = new Block(i, j);
            graphic = CreateGraphics();
            this.Show();
        }

        /// <summary>
        /// Konstruktor tworzący planszę o danych wymiarach
        /// </summary>
        /// <param name="x">szerokosc</param>
        /// <param name="y">wysokosc</param>
        public Board(int width, int height)
        {
            if (width <= 0 || height <= 0) width = height = 10;
            screenWidth = width;
            screenHeight = height;
            this.Size = new System.Drawing.Size(screenWidth * Block.size + 4, screenHeight * Block.size + 4);
            grid = new Block[screenWidth, screenHeight];
            for (int i = 0; i < screenWidth; i++)
                for (int j = 0; j < screenHeight; j++)
                    grid[i, j] = new Block(i, j);
            graphic = CreateGraphics();
            this.Show();
        }

        /// <summary>
        /// Metoda sprawdzająca rozmiar używana do sprawdzania czy dana figura zmieści się na planszy
        /// </summary>
        /// <param name="x">szerokość</param>
        /// <param name="y">wysokość</param>
        /// <returns>bool vale</returns>
        public bool CheckSize(int width, int height)
        {
            if (width < 0 || width >= screenWidth || height < 0 || height >= screenHeight) return false;
            else return true;
        }

        /// <summary>
        ///Metoda DrawBlock rysująca bloczek
        /// </summary>
        /// <param name="x">wysokość </param>
        /// <param name="y">szerokość</param>
        /// <returns></returns>
        public bool DrawBlock(int width, int height)
        {
            if (!CheckSize(width, height))
                return false;
            if (grid[width, height].InUse)
                return false;
            grid[width, height].Draw(graphic);
            return true;
        }

        /// <summary>
        /// Metoda RefreshScreen - odświeża planszę
        /// </summary>
        public void RefreshScreen()
        {
            for (int i = 0; i < screenWidth; i++)
                for (int j = 0; j < screenHeight; j++)
                {
                    if (grid[i, j].InUse)
                        grid[i, j].Draw(graphic);
                }
        }

        /// <summary>
        /// Metoda Reset - resetuje planszę, czyści ekran
        /// </summary>
        public void Reset()
        {
            for (int i = 0; i < screenWidth; i++)
                for (int j = 0; j < screenHeight; j++)
                    grid[i, j].Remove(graphic, BackColor);
        }

    }

}