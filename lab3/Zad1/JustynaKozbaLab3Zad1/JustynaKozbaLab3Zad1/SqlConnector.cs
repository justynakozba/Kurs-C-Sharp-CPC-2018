using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace JustynaKozbaLab3Zad1
{
    /// <summary>
    /// Klasa SqlConnector odpowiedzialna za wykonywanie operacji na bazie danych.
    /// Do jej implementacji został wykorzystany wzorzec projektowy Singleton. 
    /// Celem było stworzenie instancji klasy, do której będziemy mogli odwołać się 
    /// z każdego miejsca w kodzie, z rónych Form.
    /// Link do przykładu na którym się wzorowałam: https://msdn.microsoft.com/en-us/library/ff650316.aspx
    /// </summary>
    class SqlConnector
    {
        private static SqlConnector instance; // instancja SqlConnector - Singleton
        private SqlConnection connection; // obiekt klasy SqlConnection odpowiedzialny za wykonywanie połączenia z bazą danych
        private SqlDataAdapter adapter; // objekt klasy SqlDataAdapter który służy do wypełnienia DataSet i aktualizowania bazy danych 

        /// <summary>
        /// Właściwość sql, przy pierwszym wywołaniu tworzy statyczny obiekt - wzorzec projektowy Singleton
        /// </summary>
        public static SqlConnector sql
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlConnector();
                }
                return instance;
            }
        }
 
        /// <summary>
        /// Metoda odpwiadająca za łączenie z konkretną bazą danych
        /// </summary>
        public SqlConnector()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-VR1D9PV; database= JustynaKozbaLab3Zad1; Trusted_Connection=yes");
        }

        /// <summary>
        /// Metoda odowiadająca za wykonywanie zapytań w bazie danych
        /// </summary>
        /// <param name="query"></param>
        public void ExecuteQuerry(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Metoda odpowiadająca za wyświetlanie zaktualizowanych danych w bazie
        /// </summary>
        /// <param name="query"></param>
        /// <param name="grid"></param>
        public void ViewDataSql(string query, DataGridView grid)
        {
            grid.DataSource = null;
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        /// <summary>
        /// Metoda odpowidająca za usuwanie danych z bazy
        /// </summary>
        /// <param name="query"></param>
        public void RemoveData(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Connection = connection;
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
