namespace JustynaKozbaLab4Zad1
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
            this.dataGridViewInvoicesData = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonShowInvoices = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowCustomer = new System.Windows.Forms.Button();
            this.buttonShowOrders = new System.Windows.Forms.Button();
            this.buttonAddToFile = new System.Windows.Forms.Button();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.textBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicesData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoicesData
            // 
            this.dataGridViewInvoicesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoicesData.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewInvoicesData.Name = "dataGridViewInvoicesData";
            this.dataGridViewInvoicesData.RowTemplate.Height = 28;
            this.dataGridViewInvoicesData.Size = new System.Drawing.Size(496, 333);
            this.dataGridViewInvoicesData.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(529, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(525, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Imię";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(525, 172);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(124, 20);
            this.labelProductName.TabIndex = 4;
            this.labelProductName.Text = "Nazwa produktu";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(529, 123);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(525, 100);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Nazwisko";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(529, 195);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 26);
            this.textBoxProductName.TabIndex = 5;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(525, 238);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(42, 20);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Ilość";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(529, 261);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 26);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(525, 311);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 20);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Cena";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(529, 334);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrice.TabIndex = 9;
            // 
            // buttonShowInvoices
            // 
            this.buttonShowInvoices.Location = new System.Drawing.Point(341, 12);
            this.buttonShowInvoices.Name = "buttonShowInvoices";
            this.buttonShowInvoices.Size = new System.Drawing.Size(120, 59);
            this.buttonShowInvoices.TabIndex = 11;
            this.buttonShowInvoices.Text = "Wyświetl faktury";
            this.buttonShowInvoices.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(699, 378);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 60);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Dodaj dane do bazy";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowCustomer
            // 
            this.buttonShowCustomer.Location = new System.Drawing.Point(207, 12);
            this.buttonShowCustomer.Name = "buttonShowCustomer";
            this.buttonShowCustomer.Size = new System.Drawing.Size(116, 59);
            this.buttonShowCustomer.TabIndex = 13;
            this.buttonShowCustomer.Text = "Wyświetl klientów";
            this.buttonShowCustomer.UseVisualStyleBackColor = true;
            this.buttonShowCustomer.Click += new System.EventHandler(this.buttonShowCustomer_Click);
            // 
            // buttonShowOrders
            // 
            this.buttonShowOrders.Location = new System.Drawing.Point(80, 12);
            this.buttonShowOrders.Name = "buttonShowOrders";
            this.buttonShowOrders.Size = new System.Drawing.Size(111, 59);
            this.buttonShowOrders.TabIndex = 14;
            this.buttonShowOrders.Text = "Wyświetl zamówienia";
            this.buttonShowOrders.UseVisualStyleBackColor = true;
            this.buttonShowOrders.Click += new System.EventHandler(this.buttonShowOrders_Click);
            // 
            // buttonAddToFile
            // 
            this.buttonAddToFile.Location = new System.Drawing.Point(699, 15);
            this.buttonAddToFile.Name = "buttonAddToFile";
            this.buttonAddToFile.Size = new System.Drawing.Size(148, 59);
            this.buttonAddToFile.TabIndex = 15;
            this.buttonAddToFile.Text = "Dodaj do pliku";
            this.buttonAddToFile.UseVisualStyleBackColor = true;
            this.buttonAddToFile.Click += new System.EventHandler(this.buttonAddToFile_Click);
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(525, 390);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(108, 20);
            this.labelInvoiceNumber.TabIndex = 17;
            this.labelInvoiceNumber.Text = "Numer faktury";
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(529, 413);
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(100, 26);
            this.textBoxInvoiceNumber.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.labelInvoiceNumber);
            this.Controls.Add(this.textBoxInvoiceNumber);
            this.Controls.Add(this.buttonAddToFile);
            this.Controls.Add(this.buttonShowOrders);
            this.Controls.Add(this.buttonShowCustomer);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonShowInvoices);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewInvoicesData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoicesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoicesData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonShowInvoices;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowCustomer;
        private System.Windows.Forms.Button buttonShowOrders;
        private System.Windows.Forms.Button buttonAddToFile;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.TextBox textBoxInvoiceNumber;
    }
}

