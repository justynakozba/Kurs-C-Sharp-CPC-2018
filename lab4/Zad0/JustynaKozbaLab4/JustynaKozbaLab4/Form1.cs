using JustynaKozbaLab4.Model;
using JustynaKozbaLab4.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab4
{
    public partial class Form1 : Form
    {
        private readonly Model.AppContext context;
        public RWRepository<Game> Games;

        public Form1()
        {
            InitializeComponent();
            context = new Model.AppContext();
            Games = new RWRepository<Game>(context);
        }

        /// <summary>
        /// pobieranie danych z bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetAllAboutGamesToDataGridView();
        }

        private void GetAllAboutGamesToDataGridView()
        {
            dataGridViewGames.DataSource = Games.GetAll().Select(
                x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Producer = x.Producer

                }
                ).ToList();
            
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string producer = textBoxProducer.Text;
            if(name!=String.Empty && producer !=String.Empty)
            {
                Game newGame = new Game()
                {
                    Name = name,
                    Producer = producer
                };
                Games.Create(newGame);
                MessageBox.Show("Dodano.");
            }
            else
            {
                MessageBox.Show("Wprowadzono złe dane");
            }

        }
    }
}
