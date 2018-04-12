using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab2
{
    public partial class FormMainWindow : Form
    {
        /// <summary>
        /// Komstruktor domyślny
        /// </summary>
        public FormMainWindow()
        {
            InitializeComponent();

            // i się zamyka
           // Close();
        }
        /// <summary>
        /// Przycisk tworzący nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Utworzenie obiektu nowego okna
            /// </summary>
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
            formAbout.setLabelText("Moj interesujący napis");
        }

        /// <summary>
        /// Dodawanie tekstu do textBoxConsole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            //tworzymy obiekt
            Horse horse = new Horse("Bojack", "Black");

            //doklejamy informacje o objekcie oraz dodajemy nową linię 
            textBoxConsol.Text += horse + Environment.NewLine;

            // dodajemy inforamje z metody DoSomething
            textBoxConsol.Text += horse.DoSomething() + Environment.NewLine;

        }
    }
}
