using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JustynaKozbaLab2Zad1
{
    /// <summary>
    /// Klasa Block odpowaidająca za tworzenie bloczka i zawierająca informacje o danym bloczku
    /// </summary>
    public class Block
    {
        /// <summary>
        /// Zmienna block reprezentujaca dany bloczek
        /// </summary>
        private Rectangle block;

        /// <summary>
        /// Zmienna color przechowywwująca informacje o kolorze
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Wspołrzędna X
        /// </summary>
        private int x;

        /// <summary>
        /// Wspołrzędna y;
        /// </summary>
        private int y;

        /// <summary>
        /// Zmienna typu bool sprawdzająca czy pole jest zajęte
        /// </summary>
        public bool InUse { get; set; }

        /// <summary>
        /// Rozmiar pojedyńczego bloczka
        /// </summary>
        public const int size = 35;


        /// <summary>
        /// Konstruktor tworzący bloczek o podanych współrzędnych
        /// </summary>
        /// <param name="x">współrzędna x</param>
        /// <param name="y">współrzędna y</param>
        public Block(int x, int y)
        {
            this.x = x;
            this.y = y;
            block = new Rectangle(x * size, y * size, size, size);
            InUse = false;
            Color = Color.White;
        }

        /// <summary>
        /// Konstruktor pozwalający utworzyć bloczek o danych współrzędnych i kolorze
        /// </summary>
        /// <param name="x">współrzędna x</param>
        /// <param name="y">współrzędna y</param>
        /// <param name="color"></param>
        public Block(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.Color = color;
            block = new Rectangle(x * size, y * size, size, size);
            InUse = false;
        }

        /// <summary>
        /// Metoda rysująca bloczek
        /// </summary>
        /// <param name="graphic"></param>
        public void Draw(Graphics graphic)
        {
            SolidBrush brush = new SolidBrush(Color);
            graphic.FillRectangle(brush, block);
            graphic.DrawRectangle(Pens.Black, block);
            InUse = true;
        }

        /// <summary>
        /// Metoda kasująca bloczek
        /// </summary>
        /// <param name="color">color</param>
        public void Remove(Graphics graphic, Color color)
        {
            SolidBrush brush = new SolidBrush(color);
            graphic.FillRectangle(brush, block);
            graphic.DrawRectangle(new Pen(brush), block);
            InUse = false;
        }
    }
}
