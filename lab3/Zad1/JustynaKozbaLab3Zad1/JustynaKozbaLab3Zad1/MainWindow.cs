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
            SqlConnector.sql.ViewDataSql("SELECT * FROM Books JOIN Authors ON Books.IdAuthor = Authors.id where Title like '" + textBoxSearchByTittle.Text + "'", dataGridViewLibrary);

        }

        /// <summary>
        /// Przycisk odpowiadajcy za wyszukiwanie książki po wydawnictwie w jakim została wydana,
        /// połączono dwie tabele Books oraz PulishingHouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchPublishingHouse_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql("SELECT Title, InternationalStandardBookNumber,AuthorName, AuthorLastName, Name FROM Books JOIN Authors ON Books.IdAuthor = Authors.id JOIN PublishingHouse on Books.IdPublishingHouse = PublishingHouse.id where  Name ='" + textBoxSearchPublishingHouse.Text + "'", dataGridViewLibrary);

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
        /// Przycisk odpowiadający za edycję danych Ksiązki w tabeli, poprzez kliknięcie wybranej pozycji w wyświetlonej tabeli
        /// należy wpisać zmieniony tytuł książki oraz numer ISBN w odpowiednim TexBoxie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            String id = dataGridViewLibrary.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (textBoxEditBookTitle.Text != "")
            {
                SqlConnector.sql.ExecuteQuerry("UPDATE Books set Title ='" + textBoxEditBookTitle.Text + "' WHERE id =" + id);
            }

            if (textBoxEditBookNumber.Text != "")
            {
                SqlConnector.sql.RemoveData("UPDATE Books set InternationalStandardBookNumber ='" + textBoxEditBookNumber.Text + "' WHERE id =" + id);
            }

            SqlConnector.sql.ViewDataSql("SELECT* FROM Books", dataGridViewLibrary);
        }

        /// <summary>
        /// Przycisk odpowiadający za wyświetlenie wsytskich autorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAuthors_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql("SELECT * FROM Authors", dataGridViewLibrary);
        }

        /// <summary>
        /// Przycisk odpowiadający za edycję danych Autora w tabeli, poprzez kliknięcie wybranej pozycji wyświetlonej tabeli
        /// należy wpisać Imię i Nazwisko w odpowiednim TexBoxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            String id = dataGridViewLibrary.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (textBoxEditName.Text != "")
            {
                SqlConnector.sql.ExecuteQuerry("UPDATE Authors set AuthorName ='" + textBoxEditName.Text + "' WHERE id =" + id);
            }

            if (textBoxEditLastName.Text != "")
            {
                SqlConnector.sql.RemoveData("UPDATE Authors set AuthorLastName ='" + textBoxEditLastName.Text + "' WHERE id =" + id);
            }

            SqlConnector.sql.ViewDataSql("SELECT* FROM Authors", dataGridViewLibrary);
        }

        /// <summary>
        /// Przycisk odpowiadający za wyświetlenie wszytskich wydawnictw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowPublishingHouse_Click(object sender, EventArgs e)
        {
            SqlConnector.sql.ViewDataSql("SELECT * FROM PublishingHouse", dataGridViewLibrary);
        }

        /// <summary>
        /// Przycisk odpowiadający za edycję danych Wydawnictwa w tabeli, poprzez kliknięcie wybranej pozycji wyświetlonej tabeli
        /// należy wpisać Nazwę i E-mail w odpowiednim TexBoxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditPublishingHouse_Click(object sender, EventArgs e)
        {
            String id = dataGridViewLibrary.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (textBoxEditPublishingHouseName.Text != "")
            {
                SqlConnector.sql.ExecuteQuerry("UPDATE PublishingHouse set Name ='" + textBoxEditPublishingHouseName.Text + "' WHERE id =" + id);
            }

            if (textBoxEditPublishingHouseEmail.Text != "")
            {
                SqlConnector.sql.RemoveData("UPDATE PublishingHouse set Email ='" + textBoxEditPublishingHouseEmail.Text + "' WHERE id =" + id);
            }

            SqlConnector.sql.ViewDataSql("SELECT * FROM PublishingHouse", dataGridViewLibrary);
        }
    }
}
