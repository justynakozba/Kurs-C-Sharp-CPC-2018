namespace JustynaKozbaLab3Zad1
{
    partial class MainWindow
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
            this.dataGridViewLibrary = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxSearchAutor = new System.Windows.Forms.TextBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelHeadingMain = new System.Windows.Forms.Label();
            this.buttonSearchByTypeOfBook = new System.Windows.Forms.Button();
            this.buttonSearchPublishingHouse = new System.Windows.Forms.Button();
            this.labelSearchByAuthor = new System.Windows.Forms.Label();
            this.textBoxSearchPublishingHouse = new System.Windows.Forms.TextBox();
            this.buttonSearchByTittle = new System.Windows.Forms.Button();
            this.labelSearchBookByName = new System.Windows.Forms.Label();
            this.textBoxSearchByTittle = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.textBoxEditNumber = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelEditBook = new System.Windows.Forms.Label();
            this.textBoxEditTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibrary
            // 
            this.dataGridViewLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrary.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewLibrary.Name = "dataGridViewLibrary";
            this.dataGridViewLibrary.RowTemplate.Height = 28;
            this.dataGridViewLibrary.Size = new System.Drawing.Size(901, 565);
            this.dataGridViewLibrary.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShow.Location = new System.Drawing.Point(956, 592);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(288, 74);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Wyswietl wszystkie książki";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxSearchAutor
            // 
            this.textBoxSearchAutor.AllowDrop = true;
            this.textBoxSearchAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchAutor.Location = new System.Drawing.Point(983, 206);
            this.textBoxSearchAutor.Name = "textBoxSearchAutor";
            this.textBoxSearchAutor.Size = new System.Drawing.Size(191, 39);
            this.textBoxSearchAutor.TabIndex = 2;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeading.Location = new System.Drawing.Point(951, 156);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(293, 28);
            this.labelHeading.TabIndex = 3;
            this.labelHeading.Text = "Wyszukaj książki danego autora";
            // 
            // labelHeadingMain
            // 
            this.labelHeadingMain.AutoSize = true;
            this.labelHeadingMain.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadingMain.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeadingMain.ForeColor = System.Drawing.Color.Red;
            this.labelHeadingMain.Location = new System.Drawing.Point(290, 17);
            this.labelHeadingMain.Name = "labelHeadingMain";
            this.labelHeadingMain.Size = new System.Drawing.Size(309, 85);
            this.labelHeadingMain.TabIndex = 4;
            this.labelHeadingMain.Text = "Biblioteka";
            // 
            // buttonSearchByTypeOfBook
            // 
            this.buttonSearchByTypeOfBook.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchByTypeOfBook.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchByTypeOfBook.Location = new System.Drawing.Point(1002, 279);
            this.buttonSearchByTypeOfBook.Name = "buttonSearchByTypeOfBook";
            this.buttonSearchByTypeOfBook.Size = new System.Drawing.Size(109, 47);
            this.buttonSearchByTypeOfBook.TabIndex = 5;
            this.buttonSearchByTypeOfBook.Text = "Szukaj";
            this.buttonSearchByTypeOfBook.UseVisualStyleBackColor = false;
            this.buttonSearchByTypeOfBook.Click += new System.EventHandler(this.buttonSearchByAuthor_Click);
            // 
            // buttonSearchPublishingHouse
            // 
            this.buttonSearchPublishingHouse.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchPublishingHouse.Location = new System.Drawing.Point(1595, 279);
            this.buttonSearchPublishingHouse.Name = "buttonSearchPublishingHouse";
            this.buttonSearchPublishingHouse.Size = new System.Drawing.Size(109, 47);
            this.buttonSearchPublishingHouse.TabIndex = 17;
            this.buttonSearchPublishingHouse.Text = "Szukaj";
            this.buttonSearchPublishingHouse.UseVisualStyleBackColor = true;
            this.buttonSearchPublishingHouse.Click += new System.EventHandler(this.buttonSearchPublishingHouse_Click);
            // 
            // labelSearchByAuthor
            // 
            this.labelSearchByAuthor.AutoSize = true;
            this.labelSearchByAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchByAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchByAuthor.Location = new System.Drawing.Point(1548, 156);
            this.labelSearchByAuthor.Name = "labelSearchByAuthor";
            this.labelSearchByAuthor.Size = new System.Drawing.Size(225, 28);
            this.labelSearchByAuthor.TabIndex = 16;
            this.labelSearchByAuthor.Text = "Wpisz szukanego autora";
            // 
            // textBoxSearchPublishingHouse
            // 
            this.textBoxSearchPublishingHouse.AllowDrop = true;
            this.textBoxSearchPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchPublishingHouse.Location = new System.Drawing.Point(1553, 206);
            this.textBoxSearchPublishingHouse.Name = "textBoxSearchPublishingHouse";
            this.textBoxSearchPublishingHouse.Size = new System.Drawing.Size(191, 39);
            this.textBoxSearchPublishingHouse.TabIndex = 15;
            // 
            // buttonSearchByTittle
            // 
            this.buttonSearchByTittle.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchByTittle.Location = new System.Drawing.Point(1317, 279);
            this.buttonSearchByTittle.Name = "buttonSearchByTittle";
            this.buttonSearchByTittle.Size = new System.Drawing.Size(109, 47);
            this.buttonSearchByTittle.TabIndex = 20;
            this.buttonSearchByTittle.Text = "Szukaj";
            this.buttonSearchByTittle.UseVisualStyleBackColor = true;
            this.buttonSearchByTittle.Click += new System.EventHandler(this.buttonSearchByTittle_Click);
            // 
            // labelSearchBookByName
            // 
            this.labelSearchBookByName.AutoSize = true;
            this.labelSearchBookByName.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBookByName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchBookByName.Location = new System.Drawing.Point(1303, 156);
            this.labelSearchBookByName.Name = "labelSearchBookByName";
            this.labelSearchBookByName.Size = new System.Drawing.Size(169, 28);
            this.labelSearchBookByName.TabIndex = 19;
            this.labelSearchBookByName.Text = "Wyszukaj ksiązke";
            // 
            // textBoxSearchByTittle
            // 
            this.textBoxSearchByTittle.AllowDrop = true;
            this.textBoxSearchByTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchByTittle.Location = new System.Drawing.Point(1292, 206);
            this.textBoxSearchByTittle.Name = "textBoxSearchByTittle";
            this.textBoxSearchByTittle.Size = new System.Drawing.Size(191, 39);
            this.textBoxSearchByTittle.TabIndex = 18;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBook.Location = new System.Drawing.Point(956, 715);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(288, 69);
            this.buttonAddBook.TabIndex = 21;
            this.buttonAddBook.Text = "Dodaj nową książkę";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveBook.Location = new System.Drawing.Point(956, 477);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(288, 70);
            this.buttonRemoveBook.TabIndex = 24;
            this.buttonRemoveBook.Text = "Usuń książkę";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditBook.Location = new System.Drawing.Point(1507, 592);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(154, 74);
            this.buttonEditBook.TabIndex = 25;
            this.buttonEditBook.Text = "Edytuj";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // textBoxEditNumber
            // 
            this.textBoxEditNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditNumber.Location = new System.Drawing.Point(1492, 529);
            this.textBoxEditNumber.Name = "textBoxEditNumber";
            this.textBoxEditNumber.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditNumber.TabIndex = 30;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(1394, 462);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 28);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "Tytuł";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(1390, 544);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(63, 28);
            this.labelNumber.TabIndex = 28;
            this.labelNumber.Text = "ISBN";
            // 
            // labelEditBook
            // 
            this.labelEditBook.AutoSize = true;
            this.labelEditBook.BackColor = System.Drawing.Color.Transparent;
            this.labelEditBook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditBook.Location = new System.Drawing.Point(1502, 380);
            this.labelEditBook.Name = "labelEditBook";
            this.labelEditBook.Size = new System.Drawing.Size(142, 28);
            this.labelEditBook.TabIndex = 27;
            this.labelEditBook.Text = "Edytuj książkę";
            // 
            // textBoxEditTitle
            // 
            this.textBoxEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditTitle.Location = new System.Drawing.Point(1492, 447);
            this.textBoxEditTitle.Name = "textBoxEditTitle";
            this.textBoxEditTitle.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditTitle.TabIndex = 26;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JustynaKozbaLab3Zad1.Properties.Resources.background_compare;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1932, 1075);
            this.Controls.Add(this.textBoxEditNumber);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelEditBook);
            this.Controls.Add(this.textBoxEditTitle);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonSearchByTittle);
            this.Controls.Add(this.labelSearchBookByName);
            this.Controls.Add(this.textBoxSearchByTittle);
            this.Controls.Add(this.buttonSearchPublishingHouse);
            this.Controls.Add(this.labelSearchByAuthor);
            this.Controls.Add(this.textBoxSearchPublishingHouse);
            this.Controls.Add(this.buttonSearchByTypeOfBook);
            this.Controls.Add(this.labelHeadingMain);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.textBoxSearchAutor);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridViewLibrary);
            this.Name = "Search";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrary;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxSearchAutor;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelHeadingMain;
        private System.Windows.Forms.Button buttonSearchByTypeOfBook;
        private System.Windows.Forms.Button buttonSearchPublishingHouse;
        private System.Windows.Forms.Label labelSearchByAuthor;
        private System.Windows.Forms.TextBox textBoxSearchPublishingHouse;
        private System.Windows.Forms.Button buttonSearchByTittle;
        private System.Windows.Forms.Label labelSearchBookByName;
        private System.Windows.Forms.TextBox textBoxSearchByTittle;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.TextBox textBoxEditNumber;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelEditBook;
        private System.Windows.Forms.TextBox textBoxEditTitle;
    }
}

