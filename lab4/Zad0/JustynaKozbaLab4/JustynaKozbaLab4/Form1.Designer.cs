namespace JustynaKozbaLab4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.buttonAddGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(35, 66);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.RowTemplate.Height = 28;
            this.dataGridViewGames.Size = new System.Drawing.Size(417, 205);
            this.dataGridViewGames.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(468, 66);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 35);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(486, 136);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(486, 188);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(100, 26);
            this.textBoxProducer.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(507, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nazwa";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(504, 165);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(82, 20);
            this.labelProducer.TabIndex = 5;
            this.labelProducer.Text = "Producent";
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Location = new System.Drawing.Point(468, 234);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(118, 58);
            this.buttonAddGame.TabIndex = 6;
            this.buttonAddGame.Text = "Dodaj grę";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(681, 397);
            this.Controls.Add(this.buttonAddGame);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewGames);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGames;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Button buttonAddGame;
    }
}

