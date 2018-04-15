using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustynaKozbaLab2Zad1
{

    /// <summary>
    /// Zmienna wyliczeniowa typu enum zawierająca nazyw figur
    /// </summary>
    public enum FigureType
    {
        L,
        ReverseL,
        Stick,
        Square,
        Triangle,
        Bolt,
        ReverseBolt
    }

    public partial class Tetris : Form
    {
        /// <summary>
        /// Wartość wskazująca przejście na następny poziom i zmianę szybkości spadania klocków
        /// </summary>
        const int barriere1 = 5;
        const int barriere2 = 10;
        const int pointPerLevel = 10;


        /// <summary>
        /// Pole reprezentujące planszę gry
        /// </summary>
        private Screen mainScreen;

        /// <summary>
        /// Pole reprezentujące nastepną figurę
        /// </summary>
        private Screen nextFigure;

        /// <summary>
        /// Pole reprezentujące poziom gry
        /// </summary>
        public int level;

        /// <summary>
        /// Pole reprezentujące punkty
        /// </summary>
        public int points;

        /// <summary>
        /// Pole reprezentujące prędkość spadania figur
        /// </summary>
        private bool speed;

        /// <summary>
        /// Pole reprezentujące status gry
        /// </summary>
        private bool gameStatus;

        /// <summary>
        /// Pole reprezentujące pauze w grze
        /// </summary>
        private bool pause;

        public Tetris()
        {
            InitializeComponent();
            level = 1;
            labelLevel.Text = "Poziom: " + level.ToString();

            points = 0;
            labelPoints.Text = "Punkty: " + points.ToString();

            gameStatus = false;
            pause = false;

            timerGameTime.Interval = 1000;
            speed = false;
            this.mainScreen = new Screen(10, 18);
            this.nextFigure = new Screen(4, 4);

            this.mainScreen.Location = new System.Drawing.Point(15, 15);
            this.mainScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainScreen.Name = "Screen";
            this.mainScreen.TabIndex = 0;
            this.mainScreen.Paint += new PaintEventHandler(this.Refresh);

            this.nextFigure.Location = new System.Drawing.Point(400, 15);
            this.nextFigure.TabIndex = 0;
            this.nextFigure.Paint += new PaintEventHandler(this.Refresh);

            this.Controls.Add(this.nextFigure);
            this.Controls.Add(this.mainScreen);
            MessageBox.Show(
                "Aby rozpocząć Grę należy nacisnąć klawisz enter\n"
                + "Aby zakończyć rozgrywkę należy nacisnąć klawisz esc \n"
                + "Aby zapauzować grę wsiśnij spacje\n"
                + "Przesuwaj klocki używając strzałek <--- --->\n"
                + "Strzałka w góre - obrót klocka \n"
                + "Strzałka w dół - zmiana tempa \n"
                , "Instrukcja.!");
        }
        /// <summary>
        /// POLIMORFIZM - utworzono zmienną typu bazowego figure i przypisano jej obiekty typu potomnego LFigure, REversLFigure, 
        /// TriangleFigure, BoltFigure, ReverseBoltFigure, SquareFigure, StickFigure
        /// </summary>
        /// <returns></returns>
        private Figure GetRandomFigure()
        {
            Random random = new Random();
            FigureType figureType = (FigureType)random.Next(Enum.GetNames(typeof(FigureType)).Length); // losowanie figury
            Figure figure = null;
            switch (figureType)
            {
                case FigureType.L:
                    figure = new LFigure();
                    break;

                case FigureType.ReverseL:
                    figure = new ReverseLFigure();
                    break;

                case FigureType.Triangle:
                    figure = new TrangleFigure();
                    break;

                case FigureType.Bolt:
                    figure = new BoltFigure();
                    break;

                case FigureType.ReverseBolt:
                    figure = new ReverseBoltFigure();
                    break;

                case FigureType.Square:
                    figure = new SquareFigure();
                    break;

                case FigureType.Stick:
                    figure = new StickFigure();
                    break;
                default:
                    break;
            }

            // Rzutowanie na interfejs ICreate 
            ICreate figureCreate = (ICreate)figure;
            figureCreate.Create();
            //Zwracanie zmiennej typu bazowego figure
            return figure;
        }

        /// <summary>
        /// Ustawienia zegara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerGameTime_Tick(object sender, EventArgs e)
        {
            if (!mainScreen.Down())
            {
                if (speed)
                {
                    speed = false;
                    if (level < barriere1)
                    {
                        timerGameTime.Interval = 1000 - 50 * (level - 1);
                    }
                    else if (level < barriere2)
                    {
                        timerGameTime.Interval = 1000 - 100 * (level - 1);
                    }
                    else
                    {
                        timerGameTime.Interval = 1000 - 150 * (level - 1);
                    }
                }
                int tmp = mainScreen.Linie();
                points += (tmp*tmp);

                labelPoints.Text = "Punkty: " + points.ToString();

                if (points >= level * pointPerLevel)
                {
                    level++;
                    labelLevel.Text= "Poziom: " + level.ToString();
                    if (level < barriere1)
                    {
                        
                        timerGameTime.Interval = 1000 - 50 * (level - 1);
                    }
                    else if (level < barriere2)
                    {
                        timerGameTime.Interval = 1000 - 100 * (level - 1);
                    }
                    else
                    {
                        timerGameTime.Interval = 1000 - 150 * (level - 1);
                    }
                }
                Figure f = nextFigure.GetFigur();
                if (!mainScreen.DrawFigure(4, 0, f))
                {
                    timerGameTime.Stop();
                    timerGameTime.Interval = 1000;
                    gameStatus = false;
                    f = null;
                    mainScreen.Reset();
                    nextFigure.Reset();
                    level = 1;
                    labelLevel.Text = "Poziom: " + level.ToString();

                    points = 0;
                    labelPoints.Text = "Punkty: " + points.ToString();

                    return;
                }
                nextFigure.Reset();
                nextFigure.DrawFigure(0, 0, GetRandomFigure());
            }
        }

        /// <summary>
        /// Funkcja odpowiadająca za nawigowanie gry przez klawisze na klawiaturze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !gameStatus && !pause)
            {
                gameStatus = true;
                mainScreen.DrawFigure(4, 0, GetRandomFigure());
                nextFigure.DrawFigure(0, 0, GetRandomFigure());
                timerGameTime.Start();
            }
            //Klawisz przesuneicia w lewo
            else if (e.KeyCode == Keys.Left && gameStatus && !pause)
            {
                mainScreen.MoveLeft();
            }
            //Klawisz przesuniecia w prawo
            else if (e.KeyCode == Keys.Right && gameStatus && !pause)
            {
                mainScreen.MoveRight();
            }
            //Klawisz obrotu figury
            else if (e.KeyCode == Keys.Up && gameStatus && !pause)
            {
                mainScreen.Rotate();
            }
            //Klawisz przyspieszenia
            else if (e.KeyCode == Keys.Down && gameStatus && !pause)
            {
                if (speed)
                {
                    timerGameTime.Interval = 1000 - 100 * (level - 1);
                    speed = false;
                }
                else if (!speed)
                {
                    timerGameTime.Interval = 50;
                    speed = true;
                }
            }
            //Klawisz końca gry
            else if (e.KeyCode == Keys.Escape && gameStatus)
            {
                gameStatus = false;
                mainScreen.Reset();
                nextFigure.Reset();
                level = 1;
                points = 0;

                timerGameTime.Stop();
                timerGameTime.Interval = 1000;
            }
            //Klawisz pauzy
            else if (e.KeyCode == Keys.P && gameStatus)
            {
                if (pause)
                {
                    timerGameTime.Start();
                    pause = false;
                }
                else
                {
                    timerGameTime.Stop();
                    pause = true;
                }
            }
        }

        /// <summary>
        /// Metoda odpowiadająca za odświeżenie ekranu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh(object sender, PaintEventArgs e)
        {
            Screen p = (Screen)sender;
            p.RefreshScreen();
        }
    }
}
