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
    public partial class AddBook : Form
    {
        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public AddBook()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda odpowiadająca za dodawanie nowej książki 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textBoxAddTitle.Text != "" && textBoxAddNumber.Text != "")
            {
                SqlConnector.sql.ExecuteQuerry("INSERT INTO Books (Title, InternationalStandardBookNumber ) values ('"+ textBoxAddTitle.Text + "','" + textBoxAddNumber.Text + "')");
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!");
                return;
            }
            this.Close();

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
