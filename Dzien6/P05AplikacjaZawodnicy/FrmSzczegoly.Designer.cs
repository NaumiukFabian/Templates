namespace P05AplikacjaZawodnicy
{
    partial class FrmSzczegoly
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numWzrost = new System.Windows.Forms.NumericUpDown();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.nullableDateTimePicer1 = new P05AplikacjaZawodnicy.NullableDateTimePicer();
            this.ndtpDataUr = new P05AplikacjaZawodnicy.NullableDateTimePicer();
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(63, 55);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(63, 101);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(63, 150);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(100, 20);
            this.txtKraj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wzrost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Waga";
            // 
            // numWzrost
            // 
            this.numWzrost.Location = new System.Drawing.Point(63, 259);
            this.numWzrost.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numWzrost.Name = "numWzrost";
            this.numWzrost.Size = new System.Drawing.Size(100, 20);
            this.numWzrost.TabIndex = 13;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(63, 316);
            this.numWaga.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(100, 20);
            this.numWaga.TabIndex = 14;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(73, 444);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 15;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(73, 473);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 16;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Visible = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // txtMiasto
            // 
            this.txtMiasto.Location = new System.Drawing.Point(63, 368);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(100, 20);
            this.txtMiasto.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Miasto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aktualna Temperatura:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(104, 408);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(13, 13);
            this.lblTemperatura.TabIndex = 20;
            this.lblTemperatura.Text = "?";
            // 
            // nullableDateTimePicer1
            // 
            this.nullableDateTimePicer1.Location = new System.Drawing.Point(319, 61);
            this.nullableDateTimePicer1.Name = "nullableDateTimePicer1";
            this.nullableDateTimePicer1.Size = new System.Drawing.Size(350, 20);
            this.nullableDateTimePicer1.TabIndex = 22;
            // 
            // ndtpDataUr
            // 
            this.ndtpDataUr.Location = new System.Drawing.Point(63, 208);
            this.ndtpDataUr.Name = "ndtpDataUr";
            this.ndtpDataUr.Size = new System.Drawing.Size(100, 20);
            this.ndtpDataUr.TabIndex = 23;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 597);
            this.Controls.Add(this.ndtpDataUr);
            this.Controls.Add(this.nullableDateTimePicer1);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.numWaga);
            this.Controls.Add(this.numWzrost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.label1);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.numWzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWzrost;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTemperatura;
        private NullableDateTimePicer nullableDateTimePicer1;
        private NullableDateTimePicer ndtpDataUr;
    }
}