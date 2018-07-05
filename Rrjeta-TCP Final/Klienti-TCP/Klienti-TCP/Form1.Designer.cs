namespace Klienti_TCP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFIEK = new System.Windows.Forms.Label();
            this.txtFunksioni = new System.Windows.Forms.TextBox();
            this.cmbFIEK = new System.Windows.Forms.ComboBox();
            this.btnDergo = new System.Windows.Forms.Button();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFIEK
            // 
            this.lblFIEK.BackColor = System.Drawing.Color.Transparent;
            this.lblFIEK.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIEK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFIEK.Location = new System.Drawing.Point(31, 78);
            this.lblFIEK.Name = "lblFIEK";
            this.lblFIEK.Size = new System.Drawing.Size(223, 65);
            this.lblFIEK.TabIndex = 0;
            this.lblFIEK.Text = "Protokolli FIEK";
            // 
            // txtFunksioni
            // 
            this.txtFunksioni.Location = new System.Drawing.Point(26, 187);
            this.txtFunksioni.Name = "txtFunksioni";
            this.txtFunksioni.Size = new System.Drawing.Size(236, 20);
            this.txtFunksioni.TabIndex = 1;
            // 
            // cmbFIEK
            // 
            this.cmbFIEK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFIEK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFIEK.FormattingEnabled = true;
            this.cmbFIEK.Items.AddRange(new object[] {
            "IP",
            "PORT",
            "ZANORE",
            "PRINTO",
            "HOST",
            "TIME",
            "KENO",
            "FAKTORIEL",
            "KONVERTO-CelsiusToKelvin",
            "KONVERTO-CelsiusToFahrenheit",
            "KONVERTO-KelvinToFahrenheit",
            "KONVERTO-KelvinToCelsius",
            "KONVERTO-FahrenheitToCelsius",
            "KONVERTO-FahrenheitToKelvin",
            "KONVERTO-PoundToKilogram",
            "KONVERTO-KilogramToPound",
            "HASH-SHA256",
            "KAPITALIZIMI"});
            this.cmbFIEK.Location = new System.Drawing.Point(26, 236);
            this.cmbFIEK.Name = "cmbFIEK";
            this.cmbFIEK.Size = new System.Drawing.Size(236, 21);
            this.cmbFIEK.TabIndex = 2;
            this.cmbFIEK.Text = "Zgjedhni Funksionin";
            // 
            // btnDergo
            // 
            this.btnDergo.BackColor = System.Drawing.Color.Transparent;
            this.btnDergo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDergo.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDergo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDergo.Location = new System.Drawing.Point(142, 281);
            this.btnDergo.Name = "btnDergo";
            this.btnDergo.Size = new System.Drawing.Size(120, 47);
            this.btnDergo.TabIndex = 3;
            this.btnDergo.Text = "Dërgo";
            this.btnDergo.UseVisualStyleBackColor = false;
            this.btnDergo.Click += new System.EventHandler(this.btnDergo_Click);
            // 
            // lblRezultati
            // 
            this.lblRezultati.BackColor = System.Drawing.Color.Transparent;
            this.lblRezultati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRezultati.Location = new System.Drawing.Point(286, 74);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(278, 254);
            this.lblRezultati.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.btnDergo);
            this.Controls.Add(this.cmbFIEK);
            this.Controls.Add(this.txtFunksioni);
            this.Controls.Add(this.lblFIEK);
            this.Name = "Form1";
            this.Text = "FIEK - Universiteti i Prishtinës";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFIEK;
        private System.Windows.Forms.TextBox txtFunksioni;
        private System.Windows.Forms.ComboBox cmbFIEK;
        private System.Windows.Forms.Button btnDergo;
        private System.Windows.Forms.Label lblRezultati;
    }
}

