namespace JustynaKozbaLab1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonChangeColor1 = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.textBoxNumber3 = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxNumber4 = new System.Windows.Forms.TextBox();
            this.textBoxNumber5 = new System.Windows.Forms.TextBox();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.buttonTimerStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(128, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Justyna Koźba";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeColor.Location = new System.Drawing.Point(502, 47);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(227, 47);
            this.buttonChangeColor.TabIndex = 1;
            this.buttonChangeColor.Text = "buttonChangeColor";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChangeColor1
            // 
            this.buttonChangeColor1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeColor1.Location = new System.Drawing.Point(502, 112);
            this.buttonChangeColor1.Name = "buttonChangeColor1";
            this.buttonChangeColor1.Size = new System.Drawing.Size(227, 39);
            this.buttonChangeColor1.TabIndex = 2;
            this.buttonChangeColor1.Text = "buttonChangeColor1";
            this.buttonChangeColor1.UseVisualStyleBackColor = true;
            this.buttonChangeColor1.Click += new System.EventHandler(this.buttonChangeColor1_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.Location = new System.Drawing.Point(502, 172);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(227, 41);
            this.textBoxNumber.TabIndex = 4;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumber1.Location = new System.Drawing.Point(502, 238);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(227, 35);
            this.textBoxNumber1.TabIndex = 5;
            this.textBoxNumber1.TextChanged += new System.EventHandler(this.textBoxNumber1_TextChanged);
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(12, 259);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(71, 26);
            this.textBoxNumber2.TabIndex = 6;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(89, 264);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(18, 20);
            this.labelPlus.TabIndex = 7;
            this.labelPlus.Text = "+";
            // 
            // textBoxNumber3
            // 
            this.textBoxNumber3.Location = new System.Drawing.Point(113, 263);
            this.textBoxNumber3.Name = "textBoxNumber3";
            this.textBoxNumber3.Size = new System.Drawing.Size(71, 26);
            this.textBoxNumber3.TabIndex = 8;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(206, 260);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 33);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "=";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxNumber4
            // 
            this.textBoxNumber4.Location = new System.Drawing.Point(306, 262);
            this.textBoxNumber4.Name = "textBoxNumber4";
            this.textBoxNumber4.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumber4.TabIndex = 10;
            this.textBoxNumber4.TextChanged += new System.EventHandler(this.textBoxNumber4_TextChanged);
            // 
            // textBoxNumber5
            // 
            this.textBoxNumber5.Location = new System.Drawing.Point(502, 352);
            this.textBoxNumber5.Name = "textBoxNumber5";
            this.textBoxNumber5.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumber5.TabIndex = 11;
            this.textBoxNumber5.TextChanged += new System.EventHandler(this.textBoxNumber5_TextChanged);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // buttonTimerStop
            // 
            this.buttonTimerStop.Location = new System.Drawing.Point(284, 346);
            this.buttonTimerStop.Name = "buttonTimerStop";
            this.buttonTimerStop.Size = new System.Drawing.Size(103, 38);
            this.buttonTimerStop.TabIndex = 12;
            this.buttonTimerStop.Text = "TimerStop";
            this.buttonTimerStop.UseVisualStyleBackColor = true;
            this.buttonTimerStop.Click += new System.EventHandler(this.buttonTimerStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 501);
            this.Controls.Add(this.buttonTimerStop);
            this.Controls.Add(this.textBoxNumber5);
            this.Controls.Add(this.textBoxNumber4);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxNumber3);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonChangeColor1);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Button buttonChangeColor1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.TextBox textBoxNumber3;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxNumber4;
        private System.Windows.Forms.TextBox textBoxNumber5;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonTimerStop;
    }
}

