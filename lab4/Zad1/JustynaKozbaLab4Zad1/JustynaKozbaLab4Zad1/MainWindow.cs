using JustynaKozbaLab4Zad1.Model;
using JustynaKozbaLab4Zad1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JustynaKozbaLab4Zad1
{
    public partial class MainWindow : Form
    { 
        //uzywamy dany context
        private readonly Model.AppContext context;
        //obiekt typu Repository do pracy z fakturami, klientami i zamówieniami
        public Repository<Invoices> Invoice;
        public Repository<Customers> Customer;
        public Repository<Orders> Order;

        public MainWindow()
        {
            InitializeComponent();
            //tworzenie kontekstu
            context = new Model.AppContext();
            //tworzenie repozytorium
            Invoice = new Repository<Invoices>(context);
            Customer = new Repository<Customers>(context);
            Order = new Repository<Orders>(context);
        }

        /// <summary>
        /// Przycisk dodający nową pozycje do bazy danych 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string productName = textBoxProductName.Text;
            int quantity = 0;
            int price = 0;
            int invoiceNumber = 0;
            DateTime dateOfIssue = DateTime.Now;
            try
            {
                quantity = Int32.Parse(textBoxQuantity.Text);
                price = Int32.Parse(textBoxPrice.Text);
                invoiceNumber = Int32.Parse(textBoxInvoiceNumber.Text);

            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne wartości! ");
            }
            
            //Sprawdzanie,czy są podane przez używkownika wszystkie wymagane pola.
            //Jest to wymagane, ponieważ użyto [Required] przy polach klasy
            if (name != String.Empty && lastName != String.Empty && productName != String.Empty)
            {
                Orders newOrder = new Orders()
                {
                    ProductName = productName,
                    Quantity = quantity,
                    Price = price,

                };
                Order.Create(newOrder);
                int myId =  newOrder.Id;

                Customers newCustomer = new Customers()
                {
                    Name = name,
                    LastName = lastName,
                    OrderId = myId
                };
                Customer.Create(newCustomer);

                int customerId = newCustomer.Id;
                MessageBox.Show(dateOfIssue.ToString());
                Invoices newInvoice = new Invoices()
                {
                    InvoiceNumber = invoiceNumber,
                    DateOfIssue = dateOfIssue,
                    CustomerId = customerId
                };
                Invoice.Create(newInvoice);

                //komunikat informujący o dodaniu informacji
                MessageBox.Show("Dodano");
                //odświeżenie dataGridView 
                GetAllDataAboutInvoicesToDataGridView();
            }
            else
            {
                //komunikat, ze dane sa zle
                MessageBox.Show("Wprowadź poprawne wartości! ");
            }
        }

        /// <summary>
        /// Metoda wyświetlająca wszytski informacje o fakturze 
        /// </summary>
        private void GetAllDataAboutInvoicesToDataGridView()
        {
            //dataGridViewInvoicesData -> w danym dataGridView
            //.DataSource <- jako zrodlo danych do wyswietlania
            // = Invoices <- udwolujemy sie do repozytorium faktur
            // GetAll() <- pobieramy wszystkie faktury z bazy
            // .Select( <- definujemy, jak bedzie wyglowac dane w dataGridView
            // x => new {tutaj opis parametrow} <- ten 'x' mozna rozumiec jako "kadzy pojedynczy obiekt"
            // .ToList() <- zrobi to liste faktur , co umozliwi wyswietlanie w dataGridView
            dataGridViewInvoicesData.DataSource = Invoice.GetAll().Select(
                x => new {
                    Id = x.Id,
                    InvoiceNumber= x.InvoiceNumber,
                    DateOfIssue = x.DateOfIssue,
                    CustomerId = x.CustomerId
  
                }
                ).ToList();
        }

        private void buttonShowInvoices_Click(object sender, EventArgs e)
        {
            GetAllDataAboutInvoicesToDataGridView();
        }

        /// <summary>
        /// Przycisk umożliwiający wyświetlenie wszystkich danych o klientach 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCustomer_Click(object sender, EventArgs e)
        {
            dataGridViewInvoicesData.DataSource = Customer.GetAll().Select(
              x => new {
                  Id = x.Id,
                  Name = x.Name,
                  LastName = x.LastName,
                  OrderId = x.OrderId

              }
              ).ToList();
        }

        /// <summary>
        /// Przycisk odpowiadający za eksport bazy danych do pliku 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            FileInfo F = new FileInfo(openFileDialog.FileName);
            if (!F.Exists)
            {
                F.CreateText();
            }
            StreamWriter sw = File.CreateText(openFileDialog.FileName);
            foreach (Customers t in context.Customer)
            {
                sw.WriteLine(t.ToString());
            }

            foreach (Orders t in context.Order)
            {
                sw.WriteLine(t.ToString());
            }

            foreach (Invoices t in context.Invoice)
            {
                sw.WriteLine(t.ToString());
            }
            sw.Close();
            MessageBox.Show("Zapisano do pliku : " + (openFileDialog.FileName));
        }

        /// <summary>
        /// Przycisk umożliwiający pokazanie wszytskich zamówień 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            dataGridViewInvoicesData.DataSource = Order.GetAll().Select(
             x => new {
                 Id = x.Id,
                 ProductName = x.ProductName,
                 Quantity = x.Quantity,
                 Price = x.Price

             }
             ).ToList();
        }

    }
}
