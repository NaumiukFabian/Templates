namespace P05AplikacjaZawodnicy
{
    partial class FrmEdycjaTrenera
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
            this.txtImieTrenera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwiskoTrenera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.dtpDataUr = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImieTrenera
            // 
            this.txtImieTrenera.Location = new System.Drawing.Point(25, 48);
            this.txtImieTrenera.Name = "txtImieTrenera";
            this.txtImieTrenera.Size = new System.Drawing.Size(204, 20);
            this.txtImieTrenera.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie trenera";
            // 
            // txtNazwiskoTrenera
            // 
            this.txtNazwiskoTrenera.Location = new System.Drawing.Point(25, 91);
            this.txtNazwiskoTrenera.Name = "txtNazwiskoTrenera";
            this.txtNazwiskoTrenera.Size = new System.Drawing.Size(204, 20);
            this.txtNazwiskoTrenera.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko trenera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data urodzenia";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(82, 176);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 7;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // dtpDataUr
            // 
            this.dtpDataUr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUr.Location = new System.Drawing.Point(28, 134);
            this.dtpDataUr.Name = "dtpDataUr";
            this.dtpDataUr.Size = new System.Drawing.Size(201, 20);
            this.dtpDataUr.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(82, 234);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(82, 205);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 10;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Visible = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // FrmEdycjaTrenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 486);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDataUr);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwiskoTrenera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImieTrenera);
            this.Name = "FrmEdycjaTrenera";
            this.Text = "FrmEdycjaTrenera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImieTrenera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwiskoTrenera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DateTimePicker dtpDataUr;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
    }
}