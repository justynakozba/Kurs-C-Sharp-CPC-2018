namespace JustynaKozbaLab3Zad1
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAddNumber = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelAddBook = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAddNumber
            // 
            this.textBoxAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddNumber.Location = new System.Drawing.Point(197, 194);
            this.textBoxAddNumber.Name = "textBoxAddNumber";
            this.textBoxAddNumber.Size = new System.Drawing.Size(185, 35);
            this.textBoxAddNumber.TabIndex = 19;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(99, 127);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 28);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Tytuł";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(95, 209);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(63, 28);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "ISBN";
            // 
            // labelAddBook
            // 
            this.labelAddBook.AutoSize = true;
            this.labelAddBook.BackColor = System.Drawing.Color.Transparent;
            this.labelAddBook.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddBook.Location = new System.Drawing.Point(207, 43);
            this.labelAddBook.Name = "labelAddBook";
            this.labelAddBook.Size = new System.Drawing.Size(156, 34);
            this.labelAddBook.TabIndex = 16;
            this.labelAddBook.Text = "Dodaj książkę";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBook.Location = new System.Drawing.Point(233, 270);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(109, 47);
            this.buttonAddBook.TabIndex = 15;
            this.buttonAddBook.Text = "Dodaj";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddTitle.Location = new System.Drawing.Point(197, 112);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(185, 35);
            this.textBoxAddTitle.TabIndex = 14;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JustynaKozbaLab3Zad1.Properties.Resources.background_compare;
            this.ClientSize = new System.Drawing.Size(484, 399);
            this.Controls.Add(this.textBoxAddNumber);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelAddBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxAddTitle);
            this.Name = "AddBook";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAddNumber;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelAddBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxAddTitle;
    }
}