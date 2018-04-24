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
    public partial class MainWindow : Form
    {
     
        /// <summary>
        /// Konstruktor klasy Search
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk pokazujący tabelę wszytkich ksiązek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql("SELECT* FROM Books", dataGridViewLibrary);

        }

        /// <summary>
        /// Przycisk pozwalający na wyszukiwanie książek po autorze, połączone zostały tutaj dwie tabele, 
        /// tabela Books oraz Authors 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchByAuthor_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql($"SELECT * FROM Books JOIN Authors ON Books.IdAuthor = Authors.id where AuthorLastName like '{textBoxSearchAutor.Text}'", dataGridViewLibrary);
        }

        /// <summary>
        /// Przycisk odpowiadający za dodanie nowej ksiązki oraz wyświetlenie formularza w nowej formie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBook formAbout = new AddBook();
            formAbout.Show();
        }

        /// <summary>
        /// Przycisk odpowiadający za wyszukiwanie książki po tytule, połączono dwie tabele Books oraz Authors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchByTittle_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql("SELECT * FROM Books JOIN Authors ON Books.IdAuthor = Authors.id where Title like '"+ textBoxSearchByTittle.Text+"'", dataGridViewLibrary);

        }

        /// <summary>
        /// Przycisk odpowiadajcy za wyszukiwanie książki po wydawnictwie w jakim została wydana,
        /// połączono dwie tabele Books oraz PulishingHouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchPublishingHouse_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql("SELECT Title, InternationalStandardBookNumber,AuthorName, AuthorLastName, Name FROM Books JOIN Authors ON Books.IdAuthor = Authors.id JOIN PublishingHouse on Books.IdPublishingHouse = PublishingHouse.id where  Name ='" +textBoxSearchPublishingHouse.Text + "'", dataGridViewLibrary);

        }

        /// <summary>
        /// Przycisk odpowiadający za usuwanie ksiązki z tabeli, po zaznaczniu pozycji w tabeli można ją usunąć
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridViewLibrary.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

                SqlConnector.sql.RemoveData("delete Books where id=" + id);
                SqlConnector.sql.ViewDataSql("SELECT* FROM Books", dataGridViewLibrary);

            }
            catch
            {
                MessageBox.Show(" Usuwanie zakończonie niepowodzeniem");
            }
        }

        /// <summary>
        /// Przycisk odpowiadający za edycję danych w tabeli, poprzez kliknięcie wybranej pozycji w wyśiwtlonej tabeli
        /// należy wpisać w odpowiednim TexBoxie informacje jakie chce się edytować
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            String id = dataGridViewLibrary.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (textBoxEditTitle.Text != "")
            {
                SqlConnector.sql.ExecuteQuerry("UPDATE Books set Title ='" + textBoxEditTitle.Text + "' WHERE id =" + id);
            }

             if (textBoxEditNumber.Text != "")
             {
                  SqlConnector.sql.RemoveData("UPDATE Books set InternationalStandardBookNumber ='" + textBoxEditNumber.Text + "' WHERE id =" + id);
             }

            SqlConnector.sql.ViewDataSql("SELECT* FROM Books", dataGridViewLibrary);
        }
    }
}
