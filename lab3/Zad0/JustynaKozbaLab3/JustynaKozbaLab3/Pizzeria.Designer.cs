namespace JustynaKozbaLab3
{
    partial class Pizzeria
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
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonShow1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(11, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(340, 55);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Justyna Koźba";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowTemplate.Height = 28;
            this.dataGridViewTable.Size = new System.Drawing.Size(517, 311);
            this.dataGridViewTable.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(544, 82);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(103, 42);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(547, 168);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 25);
            this.textBoxPrice.TabIndex = 3;
            // 
            // buttonShow1
            // 
            this.buttonShow1.Location = new System.Drawing.Point(544, 217);
            this.buttonShow1.Name = "buttonShow1";
            this.buttonShow1.Size = new System.Drawing.Size(124, 35);
            this.buttonShow1.TabIndex = 4;
            this.buttonShow1.Text = "Show";
            this.buttonShow1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 405);
            this.Controls.Add(this.buttonShow1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonShow1;
    }
}

