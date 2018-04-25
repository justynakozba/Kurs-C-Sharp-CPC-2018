using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab3Zad1
{
    /// <summary>
    /// Klasa odpowiadająca za dodawanie nowego czytelnika
    /// </summary>
    public partial class AddReader : Form
    {
     
        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public AddReader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda pozwalająca na dodanie nowego czytelnika, użyty została nowa forma służaca do wypełnienia formularza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            if (textBoxAddReaderName.Text != "" && textBoxAddReaderLastName.Text != "" && textBoxAddReaderPesel.Text != "" && textBoxAddReaderCardNumber.Text != "")
            {
                SqlConnector.sql.ExecuteQuerry("INSERT INTO Readers (Name, LastName, PESEL, CardNumber ) values ('" + textBoxAddReaderName.Text + "','" + textBoxAddReaderLastName.Text + "','" + textBoxAddReaderPesel.Text + "','" + textBoxAddReaderCardNumber.Text + "')");
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
                return;
            }
            this.Close();
        }
    }
}
