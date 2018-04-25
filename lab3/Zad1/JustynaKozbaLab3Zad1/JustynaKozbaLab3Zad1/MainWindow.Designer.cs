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
            this.labelSearchBookByAuthor = new System.Windows.Forms.Label();
            this.labelHeadingMain = new System.Windows.Forms.Label();
            this.buttonSearchByAuthor = new System.Windows.Forms.Button();
            this.buttonSearchPublishingHouse = new System.Windows.Forms.Button();
            this.labelSearchByPublishingHouse = new System.Windows.Forms.Label();
            this.textBoxSearchPublishingHouse = new System.Windows.Forms.TextBox();
            this.buttonSearchByTittle = new System.Windows.Forms.Button();
            this.labelSearchBookByTitle = new System.Windows.Forms.Label();
            this.textBoxSearchByTittle = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.textBoxEditBookNumber = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelEditBook = new System.Windows.Forms.Label();
            this.textBoxEditBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxEditLastName = new System.Windows.Forms.TextBox();
            this.labelEditName = new System.Windows.Forms.Label();
            this.labelEditLastName = new System.Windows.Forms.Label();
            this.labelEditAuthor = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.buttonEditAuthor = new System.Windows.Forms.Button();
            this.textBoxEditPublishingHouseEmail = new System.Windows.Forms.TextBox();
            this.labelEditPublishingHouseName = new System.Windows.Forms.Label();
            this.labelEditPublishingHouseEmail = new System.Windows.Forms.Label();
            this.labelEditPublishingHouse = new System.Windows.Forms.Label();
            this.textBoxEditPublishingHouseName = new System.Windows.Forms.TextBox();
            this.buttonEditPublishingHouse = new System.Windows.Forms.Button();
            this.buttonShowAuthors = new System.Windows.Forms.Button();
            this.buttonShowPublishingHouse = new System.Windows.Forms.Button();
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
            this.buttonShow.Location = new System.Drawing.Point(125, 707);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(269, 72);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Wyswietl wszystkie książki";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxSearchAutor
            // 
            this.textBoxSearchAutor.AllowDrop = true;
            this.textBoxSearchAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchAutor.Location = new System.Drawing.Point(986, 215);
            this.textBoxSearchAutor.Name = "textBoxSearchAutor";
            this.textBoxSearchAutor.Size = new System.Drawing.Size(191, 39);
            this.textBoxSearchAutor.TabIndex = 2;
            // 
            // labelSearchBookByAuthor
            // 
            this.labelSearchBookByAuthor.AutoSize = true;
            this.labelSearchBookByAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBookByAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchBookByAuthor.Location = new System.Drawing.Point(951, 156);
            this.labelSearchBookByAuthor.Name = "labelSearchBookByAuthor";
            this.labelSearchBookByAuthor.Size = new System.Drawing.Size(293, 28);
            this.labelSearchBookByAuthor.TabIndex = 3;
            this.labelSearchBookByAuthor.Text = "Wyszukaj książki danego autora";
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
            // buttonSearchByAuthor
            // 
            this.buttonSearchByAuthor.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchByAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchByAuthor.Location = new System.Drawing.Point(1002, 279);
            this.buttonSearchByAuthor.Name = "buttonSearchByAuthor";
            this.buttonSearchByAuthor.Size = new System.Drawing.Size(109, 47);
            this.buttonSearchByAuthor.TabIndex = 5;
            this.buttonSearchByAuthor.Text = "Szukaj";
            this.buttonSearchByAuthor.UseVisualStyleBackColor = false;
            this.buttonSearchByAuthor.Click += new System.EventHandler(this.buttonSearchByAuthor_Click);
            // 
            // buttonSearchPublishingHouse
            // 
            this.buttonSearchPublishingHouse.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchPublishingHouse.Location = new System.Drawing.Point(1638, 279);
            this.buttonSearchPublishingHouse.Name = "buttonSearchPublishingHouse";
            this.buttonSearchPublishingHouse.Size = new System.Drawing.Size(109, 47);
            this.buttonSearchPublishingHouse.TabIndex = 17;
            this.buttonSearchPublishingHouse.Text = "Szukaj";
            this.buttonSearchPublishingHouse.UseVisualStyleBackColor = true;
            this.buttonSearchPublishingHouse.Click += new System.EventHandler(this.buttonSearchPublishingHouse_Click);
            // 
            // labelSearchByPublishingHouse
            // 
            this.labelSearchByPublishingHouse.AutoSize = true;
            this.labelSearchByPublishingHouse.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchByPublishingHouse.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchByPublishingHouse.Location = new System.Drawing.Point(1633, 156);
            this.labelSearchByPublishingHouse.Name = "labelSearchByPublishingHouse";
            this.labelSearchByPublishingHouse.Size = new System.Drawing.Size(250, 28);
            this.labelSearchByPublishingHouse.TabIndex = 16;
            this.labelSearchByPublishingHouse.Text = "Wpisz szukanego wydawcę";
            // 
            // textBoxSearchPublishingHouse
            // 
            this.textBoxSearchPublishingHouse.AllowDrop = true;
            this.textBoxSearchPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchPublishingHouse.Location = new System.Drawing.Point(1638, 215);
            this.textBoxSearchPublishingHouse.Name = "textBoxSearchPublishingHouse";
            this.textBoxSearchPublishingHouse.Size = new System.Drawing.Size(191, 39);
            this.textBoxSearchPublishingHouse.TabIndex = 15;
            // 
            // buttonSearchByTittle
            // 
            this.buttonSearchByTittle.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchByTittle.Location = new System.Drawing.Point(1369, 279);
            this.buttonSearchByTittle.Name = "buttonSearchByTittle";
            this.buttonSearchByTittle.Size = new System.Drawing.Size(109, 47);
            this.buttonSearchByTittle.TabIndex = 20;
            this.buttonSearchByTittle.Text = "Szukaj";
            this.buttonSearchByTittle.UseVisualStyleBackColor = true;
            this.buttonSearchByTittle.Click += new System.EventHandler(this.buttonSearchByTittle_Click);
            // 
            // labelSearchBookByTitle
            // 
            this.labelSearchBookByTitle.AutoSize = true;
            this.labelSearchBookByTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBookByTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchBookByTitle.Location = new System.Drawing.Point(1329, 156);
            this.labelSearchBookByTitle.Name = "labelSearchBookByTitle";
            this.labelSearchBookByTitle.Size = new System.Drawing.Size(256, 28);
            this.labelSearchBookByTitle.TabIndex = 19;
            this.labelSearchBookByTitle.Text = "Wyszukaj książke po tytule ";
            // 
            // textBoxSearchByTittle
            // 
            this.textBoxSearchByTittle.AllowDrop = true;
            this.textBoxSearchByTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchByTittle.Location = new System.Drawing.Point(1349, 215);
            this.textBoxSearchByTittle.Name = "textBoxSearchByTittle";
            this.textBoxSearchByTittle.Size = new System.Drawing.Size(191, 39);
            this.textBoxSearchByTittle.TabIndex = 18;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBook.Location = new System.Drawing.Point(956, 480);
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
            this.buttonRemoveBook.Location = new System.Drawing.Point(956, 572);
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
            this.buttonEditBook.Location = new System.Drawing.Point(153, 1004);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(154, 50);
            this.buttonEditBook.TabIndex = 25;
            this.buttonEditBook.Text = "Edytuj";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // textBoxEditBookNumber
            // 
            this.textBoxEditBookNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditBookNumber.Location = new System.Drawing.Point(138, 941);
            this.textBoxEditBookNumber.Name = "textBoxEditBookNumber";
            this.textBoxEditBookNumber.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditBookNumber.TabIndex = 30;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(40, 874);
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
            this.labelNumber.Location = new System.Drawing.Point(36, 956);
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
            this.labelEditBook.Location = new System.Drawing.Point(148, 792);
            this.labelEditBook.Name = "labelEditBook";
            this.labelEditBook.Size = new System.Drawing.Size(142, 28);
            this.labelEditBook.TabIndex = 27;
            this.labelEditBook.Text = "Edytuj książkę";
            // 
            // textBoxEditBookTitle
            // 
            this.textBoxEditBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditBookTitle.Location = new System.Drawing.Point(138, 859);
            this.textBoxEditBookTitle.Name = "textBoxEditBookTitle";
            this.textBoxEditBookTitle.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditBookTitle.TabIndex = 26;
            // 
            // textBoxEditLastName
            // 
            this.textBoxEditLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditLastName.Location = new System.Drawing.Point(500, 948);
            this.textBoxEditLastName.Name = "textBoxEditLastName";
            this.textBoxEditLastName.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditLastName.TabIndex = 36;
            // 
            // labelEditName
            // 
            this.labelEditName.AutoSize = true;
            this.labelEditName.BackColor = System.Drawing.Color.Transparent;
            this.labelEditName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditName.Location = new System.Drawing.Point(433, 870);
            this.labelEditName.Name = "labelEditName";
            this.labelEditName.Size = new System.Drawing.Size(50, 28);
            this.labelEditName.TabIndex = 35;
            this.labelEditName.Text = "Imię";
            // 
            // labelEditLastName
            // 
            this.labelEditLastName.AutoSize = true;
            this.labelEditLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelEditLastName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditLastName.Location = new System.Drawing.Point(381, 950);
            this.labelEditLastName.Name = "labelEditLastName";
            this.labelEditLastName.Size = new System.Drawing.Size(102, 28);
            this.labelEditLastName.TabIndex = 34;
            this.labelEditLastName.Text = "Nazwisko";
            // 
            // labelEditAuthor
            // 
            this.labelEditAuthor.AutoSize = true;
            this.labelEditAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelEditAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditAuthor.Location = new System.Drawing.Point(510, 817);
            this.labelEditAuthor.Name = "labelEditAuthor";
            this.labelEditAuthor.Size = new System.Drawing.Size(133, 28);
            this.labelEditAuthor.TabIndex = 33;
            this.labelEditAuthor.Text = "Edytuj autora";
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditName.Location = new System.Drawing.Point(500, 866);
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditName.TabIndex = 32;
            // 
            // buttonEditAuthor
            // 
            this.buttonEditAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditAuthor.Location = new System.Drawing.Point(515, 1011);
            this.buttonEditAuthor.Name = "buttonEditAuthor";
            this.buttonEditAuthor.Size = new System.Drawing.Size(154, 50);
            this.buttonEditAuthor.TabIndex = 31;
            this.buttonEditAuthor.Text = "Edytuj";
            this.buttonEditAuthor.UseVisualStyleBackColor = true;
            this.buttonEditAuthor.Click += new System.EventHandler(this.buttonEditAuthor_Click);
            // 
            // textBoxEditPublishingHouseEmail
            // 
            this.textBoxEditPublishingHouseEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditPublishingHouseEmail.Location = new System.Drawing.Point(875, 951);
            this.textBoxEditPublishingHouseEmail.Name = "textBoxEditPublishingHouseEmail";
            this.textBoxEditPublishingHouseEmail.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditPublishingHouseEmail.TabIndex = 42;
            // 
            // labelEditPublishingHouseName
            // 
            this.labelEditPublishingHouseName.AutoSize = true;
            this.labelEditPublishingHouseName.BackColor = System.Drawing.Color.Transparent;
            this.labelEditPublishingHouseName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditPublishingHouseName.Location = new System.Drawing.Point(777, 884);
            this.labelEditPublishingHouseName.Name = "labelEditPublishingHouseName";
            this.labelEditPublishingHouseName.Size = new System.Drawing.Size(77, 28);
            this.labelEditPublishingHouseName.TabIndex = 41;
            this.labelEditPublishingHouseName.Text = "Nazwa";
            // 
            // labelEditPublishingHouseEmail
            // 
            this.labelEditPublishingHouseEmail.AutoSize = true;
            this.labelEditPublishingHouseEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEditPublishingHouseEmail.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditPublishingHouseEmail.Location = new System.Drawing.Point(773, 966);
            this.labelEditPublishingHouseEmail.Name = "labelEditPublishingHouseEmail";
            this.labelEditPublishingHouseEmail.Size = new System.Drawing.Size(64, 28);
            this.labelEditPublishingHouseEmail.TabIndex = 40;
            this.labelEditPublishingHouseEmail.Text = "e-mail";
            // 
            // labelEditPublishingHouse
            // 
            this.labelEditPublishingHouse.AutoSize = true;
            this.labelEditPublishingHouse.BackColor = System.Drawing.Color.Transparent;
            this.labelEditPublishingHouse.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEditPublishingHouse.Location = new System.Drawing.Point(870, 817);
            this.labelEditPublishingHouse.Name = "labelEditPublishingHouse";
            this.labelEditPublishingHouse.Size = new System.Drawing.Size(202, 28);
            this.labelEditPublishingHouse.TabIndex = 39;
            this.labelEditPublishingHouse.Text = "Edytuj wydawnictwo";
            // 
            // textBoxEditPublishingHouseName
            // 
            this.textBoxEditPublishingHouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEditPublishingHouseName.Location = new System.Drawing.Point(875, 869);
            this.textBoxEditPublishingHouseName.Name = "textBoxEditPublishingHouseName";
            this.textBoxEditPublishingHouseName.Size = new System.Drawing.Size(185, 35);
            this.textBoxEditPublishingHouseName.TabIndex = 38;
            // 
            // buttonEditPublishingHouse
            // 
            this.buttonEditPublishingHouse.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditPublishingHouse.Location = new System.Drawing.Point(890, 1014);
            this.buttonEditPublishingHouse.Name = "buttonEditPublishingHouse";
            this.buttonEditPublishingHouse.Size = new System.Drawing.Size(154, 50);
            this.buttonEditPublishingHouse.TabIndex = 37;
            this.buttonEditPublishingHouse.Text = "Edytuj";
            this.buttonEditPublishingHouse.UseVisualStyleBackColor = true;
            this.buttonEditPublishingHouse.Click += new System.EventHandler(this.buttonEditPublishingHouse_Click);
            // 
            // buttonShowAuthors
            // 
            this.buttonShowAuthors.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAuthors.Location = new System.Drawing.Point(475, 707);
            this.buttonShowAuthors.Name = "buttonShowAuthors";
            this.buttonShowAuthors.Size = new System.Drawing.Size(246, 72);
            this.buttonShowAuthors.TabIndex = 43;
            this.buttonShowAuthors.Text = "Wyświetl wszystkich autorów";
            this.buttonShowAuthors.UseVisualStyleBackColor = true;
            this.buttonShowAuthors.Click += new System.EventHandler(this.buttonShowAuthors_Click);
            // 
            // buttonShowPublishingHouse
            // 
            this.buttonShowPublishingHouse.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowPublishingHouse.Location = new System.Drawing.Point(854, 703);
            this.buttonShowPublishingHouse.Name = "buttonShowPublishingHouse";
            this.buttonShowPublishingHouse.Size = new System.Drawing.Size(206, 80);
            this.buttonShowPublishingHouse.TabIndex = 44;
            this.buttonShowPublishingHouse.Text = "Wyświetl wszystkie wydawnictwa ";
            this.buttonShowPublishingHouse.UseVisualStyleBackColor = true;
            this.buttonShowPublishingHouse.Click += new System.EventHandler(this.buttonShowPublishingHouse_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JustynaKozbaLab3Zad1.Properties.Resources.background_compare;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1932, 1075);
            this.Controls.Add(this.buttonShowPublishingHouse);
            this.Controls.Add(this.buttonShowAuthors);
            this.Controls.Add(this.textBoxEditPublishingHouseEmail);
            this.Controls.Add(this.labelEditPublishingHouseName);
            this.Controls.Add(this.labelEditPublishingHouseEmail);
            this.Controls.Add(this.labelEditPublishingHouse);
            this.Controls.Add(this.textBoxEditPublishingHouseName);
            this.Controls.Add(this.buttonEditPublishingHouse);
            this.Controls.Add(this.textBoxEditLastName);
            this.Controls.Add(this.labelEditName);
            this.Controls.Add(this.labelEditLastName);
            this.Controls.Add(this.labelEditAuthor);
            this.Controls.Add(this.textBoxEditName);
            this.Controls.Add(this.buttonEditAuthor);
            this.Controls.Add(this.textBoxEditBookNumber);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelEditBook);
            this.Controls.Add(this.textBoxEditBookTitle);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonSearchByTittle);
            this.Controls.Add(this.labelSearchBookByTitle);
            this.Controls.Add(this.textBoxSearchByTittle);
            this.Controls.Add(this.buttonSearchPublishingHouse);
            this.Controls.Add(this.labelSearchByPublishingHouse);
            this.Controls.Add(this.textBoxSearchPublishingHouse);
            this.Controls.Add(this.buttonSearchByAuthor);
            this.Controls.Add(this.labelHeadingMain);
            this.Controls.Add(this.labelSearchBookByAuthor);
            this.Controls.Add(this.textBoxSearchAutor);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridViewLibrary);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrary;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxSearchAutor;
        private System.Windows.Forms.Label labelSearchBookByAuthor;
        private System.Windows.Forms.Label labelHeadingMain;
        private System.Windows.Forms.Button buttonSearchByAuthor;
        private System.Windows.Forms.Button buttonSearchPublishingHouse;
        private System.Windows.Forms.Label labelSearchByPublishingHouse;
        private System.Windows.Forms.TextBox textBoxSearchPublishingHouse;
        private System.Windows.Forms.Button buttonSearchByTittle;
        private System.Windows.Forms.Label labelSearchBookByTitle;
        private System.Windows.Forms.TextBox textBoxSearchByTittle;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.TextBox textBoxEditBookNumber;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelEditBook;
        private System.Windows.Forms.TextBox textBoxEditBookTitle;
        private System.Windows.Forms.TextBox textBoxEditLastName;
        private System.Windows.Forms.Label labelEditName;
        private System.Windows.Forms.Label labelEditLastName;
        private System.Windows.Forms.Label labelEditAuthor;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.Button buttonEditAuthor;
        private System.Windows.Forms.TextBox textBoxEditPublishingHouseEmail;
        private System.Windows.Forms.Label labelEditPublishingHouseName;
        private System.Windows.Forms.Label labelEditPublishingHouseEmail;
        private System.Windows.Forms.Label labelEditPublishingHouse;
        private System.Windows.Forms.TextBox textBoxEditPublishingHouseName;
        private System.Windows.Forms.Button buttonEditPublishingHouse;
        private System.Windows.Forms.Button buttonShowAuthors;
        private System.Windows.Forms.Button buttonShowPublishingHouse;
    }
}

