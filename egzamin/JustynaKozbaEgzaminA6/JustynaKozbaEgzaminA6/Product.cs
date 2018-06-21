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

namespace JustynaKozbaEgzaminA6
{
    public partial class Product : Form
    {
        //Utworzenie połaczenia z bazą danych
        SqlConnection connection;
        public Product()
        {
            //Przypisanie źródła bazy danych
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-VR1D9PV; database= Northwind; Trusted_Connection=yes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'northwindDataSet1.Products' . Możesz go przenieść lub usunąć.
            this.productsTableAdapter.Fill(this.northwindDataSet1.Products);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'northwindDataSet.Products' . Możesz go przenieść lub usunąć.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Products WHERE Price BETWEEN 9 and 16", connection);
            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView.DataSource = table;
        }

    }
}
