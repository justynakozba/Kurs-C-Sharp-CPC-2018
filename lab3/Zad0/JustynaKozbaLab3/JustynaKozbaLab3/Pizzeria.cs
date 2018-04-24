using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JustynaKozbaLab3
{
    public partial class Pizzeria : Form
    {
        SqlConnection connection;
        public Pizzeria()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-VR1D9PV; database= Pzzeria; Trusted_Connection=yes");
        }

        /// <summary>
        /// Metoda na kliknięcie przycisku 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            // metoda odpwiadająca za wyświetlenie tylko tych pizz które mają cenę większą od podanej w TextBoxPrice
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Pizzas WHERE Price > 0{textBoxPrice.Text}", connection);
            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridViewTable.DataSource = table;
        }


    }
}
