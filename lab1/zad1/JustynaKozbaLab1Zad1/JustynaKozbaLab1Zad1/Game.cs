using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab1Zad1
{
    public partial class Game : Form
    {
        /// <summary>
        /// Nowy obiekt typu Building reprezentujący tartak 
        /// poziom 1
        /// generuje 10 drewna na sekunde
        /// cena za następny poziom - drewno: 300; siano: 200; kamień:100; złoto:50; współczynnik wzrostu cen 2
        /// </summary>
        Building sawMill = new Building("Tartak", 1, 0, 10, new Price(300, 200, 100, 50, 2));

        /// <summary>
        /// Nowy obiekt typu Building reprezentujący młyn
        /// poziom 1
        /// generuje 5 siana na sekunde
        /// cena za następny poziom - drewno: 400; siano: 300; kamień:200; złoto:50; współczynnik wzrostu cen 2
        /// </summary>
        Building windMill = new Building("Młyn", 1, 0, 5, new Price(400, 300, 200, 50, 2));

        /// <summary>
        /// Nowy obiekt typu Building reprezentujący kopalnie kamienia
        /// poziom 1
        /// generuje 3 kamienia na sekunde
        /// cena za następny poziom - drewno: 500; siano: 400; kamień:300; złoto:50; współczynnik wzrostu cen 2
        /// </summary>
        Building stoneMine = new Building("Kopalnia Kamienia", 1, 0, 3, new Price(500, 400, 300, 50, 2));

        /// <summary>
        /// Nowy obiekt typu Building reprezentujący kopalnie złota
        /// poziom 1
        /// generuje 1 złoto na sekunde
        /// cena za następny poziom - drewno: 600; siano: 400; kamień:300; złoto:50; współczynnik wzrostu cen 3
        /// </summary>
        Building goldMine = new Building("Kopalnia Złota", 1, 0, 1, new Price(600, 400, 300, 50, 3));

        /// <summary>
        /// updateInterval - czas w sekundach po którym akualizujemy ilość surowców
        /// </summary>
        int updateInterval = 5;

        /// <summary>
        /// czas dla Timera
        /// </summary>
        int time = 0;
  
        /// <summary>
        /// konstruktor bezparametryczny klasy Game
        /// </summary>
        public Game()
        {
            InitializeComponent();
            updateSawMillLabels();
            updateWindMillLabels();
            updateStoneMineLabels();
            updateGoldMineLabels();
        }

        /// <summary>
        /// metoda aktualizująca zawartość etykiet opisujacych tartak
        /// </summary>
        private void updateSawMillLabels()
        {
            string[] labels = updateBuildinglabels(sawMill);
            labelSawMillName.Text = labels[0];
            labelSawMillLevel.Text = labels[1];
            labelSawMillPrice.Text = labels[2];
            labelSawMillQuantity.Text = labels[3];
        }

        /// <summary>
        /// metoda aktualizująca zawartość etykiet opisujacych młyn
        /// </summary>
        private void updateWindMillLabels()
        {
            string[] labels = updateBuildinglabels(windMill);
            labelWindMillName.Text = labels[0];
            labelWindMillLevel.Text = labels[1];
            labelWindMillPrice.Text = labels[2];
            labelWindMillQuantity.Text = labels[3];
        }

        /// <summary>
        /// metoda aktualizująca zawartość etykiet opisujacych kopalnie kamienia
        /// </summary>
        private void updateStoneMineLabels()
        {
            string[] labels = updateBuildinglabels(stoneMine);
            labelStoneMineName.Text = labels[0];
            labelStoneMineLevel.Text = labels[1];
            labelStoneMinePrice.Text = labels[2];
            labelStoneMineQuantity.Text = labels[3];
        }

        /// <summary>
        /// metoda aktualizująca zawartość etykiet opisujacych kopalnię złota
        /// </summary>
        private void updateGoldMineLabels()
        {
            string[] labels = updateBuildinglabels(goldMine);
            labelGoldMineName.Text = labels[0];
            labelGoldMineLevel.Text = labels[1];
            labelGoldMinePrice.Text = labels[2];
            labelGoldMineQuantity.Text = labels[3];
        }
        
        /// <summary>
        /// metoda aktualizująca etykiety opisujące ilość surowców (etykiety wszystkich budynków)
        /// </summary>
        public void updateQuantity()
        {
            labelSawMillQuantity.Text = sawMill.quantity.ToString();
            labelWindMillQuantity.Text = windMill.quantity.ToString();
            labelStoneMineQuantity.Text = stoneMine.quantity.ToString();
            labelGoldMineQuantity.Text = goldMine.quantity.ToString();

        }

        /// <summary>
        /// Metoda agregująca informacje opisujace budynek
        /// Metoda celowo została utrudniona aby pokazać użycie pętli for -wymaganie obligatoryjne dla tego zadania.
        /// </summary>
        /// <param name="building"></param>
        /// <returns>tablica typu string</returns>
        private string[] updateBuildinglabels(Building building)
        {
            string[] labels = new string[4];
            for (int i = 0; i < 4; i++)
            {
                if(i == 0)
                {
                    labels[i] = building.name.ToString();
                }
                else if (i == 1)
                {
                    labels[i] = building.getLevelString();

                }
                else if(i == 2)
                {
                    labels[i] = building.getLevelPrices();

                }
                else if (i == 3)
                {
                    labels[i] = building.quantity.ToString();

                }
            }
            return labels;
        }

        /// <summary>
        /// metoda implementująca zakup następnego poziomu
        /// </summary>
        /// <param name="building">obiekt typu Building</param>
        private void buyBuilding (Building building)
        {
            if (building.levelPrice.checkPrice(sawMill.quantity, windMill.quantity, stoneMine.quantity, goldMine.quantity))
            {
                sawMill.quantity -= building.levelPrice.wood;
                windMill.quantity -= building.levelPrice.hay;
                stoneMine.quantity -= building.levelPrice.stone;
                goldMine.quantity -= building.levelPrice.gold;

                building.upgrade();
            }
            else
            {
                MessageBox.Show("Brak zasobów aby kupic nowy level");
            }
        }

        /// <summary>
        /// metoda aktualizująca status budynku
        /// </summary>
        /// <param name="building"></param>
        private void updateBuildingStatus(Building building)
        {
            time++;
            if (time >= updateInterval) 
            {
                time = 0;
                building.updateValues(updateInterval);
            }
        }

        /// <summary>
        /// metoda dodająca surowce (helper dla handlowania surowcami)
        /// </summary>
        /// <param name="howMuch"></param>
        private void addResource(int howMuch)
        {
            if (comboBoxMarket2.Text == "Drewno")
            {
                sawMill.quantity += howMuch;
                updateSawMillLabels();

            }
            else if (comboBoxMarket2.Text == "Siano")
            {
                windMill.quantity += howMuch;
                updateWindMillLabels();

            }
            else if (comboBoxMarket2.Text == "Kamień")
            {
                stoneMine.quantity += howMuch;
                updateStoneMineLabels();

            }
            else if (comboBoxMarket2.Text == "Złoto")
            {
                goldMine.quantity += howMuch;
                updateGoldMineLabels();

            }
            else
            {
                MessageBox.Show("Nie ma takiego surowca");
            }

        }

        /// <summary>
        /// Timer mierzący upływający czas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLapsedTime_Tick(object sender, EventArgs e)
        {

            updateBuildingStatus(sawMill);
            updateBuildingStatus(windMill);
            updateBuildingStatus(stoneMine);
            updateBuildingStatus(goldMine);

            updateQuantity();
        }

        /// <summary>
        /// przycisk reprezentujący kupno następnego poziomu dla tartaku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSawMillBuy_Click(object sender, EventArgs e)
        {
            buyBuilding(sawMill);
            updateSawMillLabels();


        }

        /// <summary>
        /// przycisk reprezentujący kupno następnego poziomu dla młyna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWindMillBuy_Click(object sender, EventArgs e)
        {
            buyBuilding(windMill);
            updateWindMillLabels();
        }

        /// <summary>
        /// przycisk reprezentujący kupno następnego poziomu dla kopalni kamienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStoneMineBuy_Click(object sender, EventArgs e)
        {
            buyBuilding(stoneMine);
            updateStoneMineLabels();
        }

        /// <summary>
        /// przycisk reprezentujący kupno następnego poziomu dla kopalni złota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoldMineBuy_Click(object sender, EventArgs e)
        {
            buyBuilding(goldMine);
            updateGoldMineLabels();
        }

        /// <summary>
        /// przycisk  reprezentujący wymainę surowców 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarket1_Click_1(object sender, EventArgs e)
        {
            int howMuch = 0;

            if (comboBoxMarket1.Text == comboBoxMarket2.Text)
            {
                MessageBox.Show("Nie można wymienić " + comboBoxMarket1.Text + " na " + comboBoxMarket2.Text);
                return;
            }

            try
            {
                howMuch = Int32.Parse(textBoxMarket1.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            switch (comboBoxMarket1.Text)
            {
                case "Drewno":
                    if (sawMill.quantity >= howMuch)
                    {
                        sawMill.quantity -= howMuch;
                        addResource(howMuch / 4);
                        updateSawMillLabels();
                    }
                    else
                    {
                        MessageBox.Show("Nie ma wystarczającej ilości surowca aby dokonać wymiany");
                    }
                    break;

                case "Siano":
                    if (windMill.quantity >= howMuch)
                    {
                        windMill.quantity -= howMuch;
                        addResource(howMuch / 3);
                        updateWindMillLabels();
                    }
                    else
                    {
                        MessageBox.Show("Nie ma wystarczającej ilości surowca aby dokonać wymiany");
                    }
                    break;

                case "Kamień":
                    if (stoneMine.quantity >= howMuch)
                    {
                        stoneMine.quantity -= howMuch;
                        addResource(howMuch / 2);
                        updateStoneMineLabels();
                    }
                    else
                    {
                        MessageBox.Show("Nie ma wystarczającej ilości surowca aby dokonać wymiany");
                    }
                    break;

                case "Złoto":
                    if (goldMine.quantity >= howMuch)
                    {
                        goldMine.quantity -= howMuch;
                        addResource(howMuch);
                        updateGoldMineLabels();
                    }
                    else
                    {
                        MessageBox.Show("Nie ma wystarczającej ilości surowca aby dokonać wymiany");
                    }
                    break;

                default:
                    MessageBox.Show("Nie ma takiego surowca");
                    break;
            }
        }
    }
}
