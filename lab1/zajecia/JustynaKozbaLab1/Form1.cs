using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab1
{
    public partial class Form1 : Form
    {
        int counter = 0; // zmienna określająca czas, który upłynął
        int a = 0;       // zmienna definijąca liczbę zmieniającą kolor tła
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// przycisk zmieniający kolor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            buttonChangeColor.BackColor = Color.AliceBlue;
            buttonChangeColor.Text = "Zmiana";
            
        }

        /// <summary>
        /// pole tekstowe pokazujace wartość hurra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hurra");
        }

        /// <summary>
        /// pole tekstowe pokazujace wpisaną wartość
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeColor1_Click(object sender, EventArgs e)
        {
            buttonChangeColor1.BackColor = Color.Aqua;
            buttonChangeColor1.Text = "Zmiana koloru";
        }
        /// <summary>
        /// przycisk zmieniajacy kolor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNumber1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxNumber1.Text);
            for (int i =0; i<=10; i++)
            {
                counter += i;
                if(counter == 3)
                {
                    MessageBox.Show("Znaleziono 3");
                }
            }

        }
        /// <summary>
        /// dodawanie dwóch liczb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(textBoxNumber2.Text);
            int number2 = Int32.Parse(textBoxNumber3.Text);
            int result = number + number2;
            textBoxNumber4.Text = result.ToString();
            timerCount.Start();
        }

        private void textBoxNumber4_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// zmiana koloru tła pola tekstowego na niebieski po znalezieniu liczby 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNumber5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Int32.Parse(textBoxNumber5.Text);
            }
            catch (Exception error)
            {
                // Wyswietlenie informacji o bledzie
                MessageBox.Show(error.Message);
                a = 0;
            }
            if (a == 5)
            {
                MessageBox.Show("Znaleziono liczbę 5");
                textBoxNumber5.BackColor = Color.Blue;
            }

        }
        /// <summary>
        /// zmiana koloru tła na czerwony po czasie dłuzszym niż 100 od naciśniecia znaku równości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter > 100)
            {
                BackColor = Color.Red;
            }

        }
        /// <summary>
        /// przycisk zatrzymujący zegar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimerStop_Click(object sender, EventArgs e)
        {
            timerCount.Stop();
        }
    }
}
