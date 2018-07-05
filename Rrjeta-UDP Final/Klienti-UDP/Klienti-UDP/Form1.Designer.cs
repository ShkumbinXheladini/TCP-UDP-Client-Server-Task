namespace Klienti_UDP
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
            this.lblRezultati = new System.Windows.Forms.Label();
            this.txtFunksioni = new System.Windows.Forms.TextBox();
            this.cmbFIEK = new System.Windows.Forms.ComboBox();
            this.btnDergo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFIEK
            // 
            this.lblFIEK.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIEK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFIEK.Location = new System.Drawing.Point(30, 93);
            this.lblFIEK.Name = "lblFIEK";
            this.lblFIEK.Size = new System.Drawing.Size(223, 52);
            this.lblFIEK.TabIndex = 0;
            this.lblFIEK.Text = "Fiek Protokolli";
            // 
            // lblRezultati
            // 
            this.lblRezultati.BackColor = System.Drawing.Color.Transparent;
            this.lblRezultati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRezultati.Location = new System.Drawing.Point(286, 74);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(278, 254);
            this.lblRezultati.TabIndex = 1;
            // 
            // txtFunksioni
            // 
            this.txtFunksioni.Location = new System.Drawing.Point(26, 187);
            this.txtFunksioni.Name = "txtFunksioni";
            this.txtFunksioni.Size = new System.Drawing.Size(236, 20);
            this.txtFunksioni.TabIndex = 2;
            // 
            // cmbFIEK
            // 
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
            this.cmbFIEK.TabIndex = 3;
            this.cmbFIEK.Text = "Zgjedh Funksionin";
            // 
            // btnDergo
            // 
            this.btnDergo.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDergo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDergo.Location = new System.Drawing.Point(142, 281);
            this.btnDergo.Name = "btnDergo";
            this.btnDergo.Size = new System.Drawing.Size(120, 47);
            this.btnDergo.TabIndex = 4;
            this.btnDergo.Text = "Dërgo";
            this.btnDergo.UseVisualStyleBackColor = true;
            this.btnDergo.Click += new System.EventHandler(this.btnDergo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.btnDergo);
            this.Controls.Add(this.cmbFIEK);
            this.Controls.Add(this.txtFunksioni);
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.lblFIEK);
            this.Name = "Form1";
            this.Text = "FIEK - Universiteti i Prishtinës";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFIEK;
        private System.Windows.Forms.Label lblRezultati;
        private System.Windows.Forms.TextBox txtFunksioni;
        private System.Windows.Forms.ComboBox cmbFIEK;
        private System.Windows.Forms.Button btnDergo;
    }
}

