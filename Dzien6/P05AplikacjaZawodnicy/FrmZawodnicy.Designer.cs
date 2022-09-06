namespace P05AplikacjaZawodnicy
{
    partial class FrmZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLiczba = new System.Windows.Forms.Label();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.lbDaneMiasta = new System.Windows.Forms.ListBox();
            this.cos = new System.Windows.Forms.Label();
            this.lblSredniaTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSrTempAll = new System.Windows.Forms.Label();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.rbImie = new System.Windows.Forms.RadioButton();
            this.rbNazwisko = new System.Windows.Forms.RadioButton();
            this.rbWzrost = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWczytajTrenerow = new System.Windows.Forms.Button();
            this.btnEdycjaTrenera = new System.Windows.Forms.Button();
            this.btnDodajTrenera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 97);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(241, 303);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(13, 13);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zaimportowano rekordów:";
            // 
            // lblLiczba
            // 
            this.lblLiczba.AutoSize = true;
            this.lblLiczba.Location = new System.Drawing.Point(240, 18);
            this.lblLiczba.Name = "lblLiczba";
            this.lblLiczba.Size = new System.Drawing.Size(13, 13);
            this.lblLiczba.TabIndex = 5;
            this.lblLiczba.Text = "0";
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(42, 49);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(211, 20);
            this.txtFiltr.TabIndex = 6;
            this.txtFiltr.Text = "pol";
            // 
            // lbDaneMiasta
            // 
            this.lbDaneMiasta.FormattingEnabled = true;
            this.lbDaneMiasta.Location = new System.Drawing.Point(284, 97);
            this.lbDaneMiasta.Name = "lbDaneMiasta";
            this.lbDaneMiasta.Size = new System.Drawing.Size(239, 303);
            this.lbDaneMiasta.TabIndex = 7;
            // 
            // cos
            // 
            this.cos.AutoSize = true;
            this.cos.Location = new System.Drawing.Point(13, 438);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(197, 13);
            this.cos.TabIndex = 8;
            this.cos.Text = "Średnia temperatura miast danego kraju:";
            // 
            // lblSredniaTemp
            // 
            this.lblSredniaTemp.AutoSize = true;
            this.lblSredniaTemp.Location = new System.Drawing.Point(210, 438);
            this.lblSredniaTemp.Name = "lblSredniaTemp";
            this.lblSredniaTemp.Size = new System.Drawing.Size(13, 13);
            this.lblSredniaTemp.TabIndex = 9;
            this.lblSredniaTemp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Średnia temperatura wszystkich miast:";
            // 
            // lblSrTempAll
            // 
            this.lblSrTempAll.AutoSize = true;
            this.lblSrTempAll.Location = new System.Drawing.Point(210, 469);
            this.lblSrTempAll.Name = "lblSrTempAll";
            this.lblSrTempAll.Size = new System.Drawing.Size(13, 13);
            this.lblSrTempAll.TabIndex = 11;
            this.lblSrTempAll.Text = "0";
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(342, 49);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 12;
            this.btnSzczegoly.Text = "Szczegoly";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(439, 48);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 13;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // rbImie
            // 
            this.rbImie.AutoSize = true;
            this.rbImie.Location = new System.Drawing.Point(284, 433);
            this.rbImie.Name = "rbImie";
            this.rbImie.Size = new System.Drawing.Size(44, 17);
            this.rbImie.TabIndex = 14;
            this.rbImie.TabStop = true;
            this.rbImie.Tag = "imie";
            this.rbImie.Text = "Imie";
            this.rbImie.UseVisualStyleBackColor = true;
            // 
            // rbNazwisko
            // 
            this.rbNazwisko.AutoSize = true;
            this.rbNazwisko.Location = new System.Drawing.Point(284, 457);
            this.rbNazwisko.Name = "rbNazwisko";
            this.rbNazwisko.Size = new System.Drawing.Size(71, 17);
            this.rbNazwisko.TabIndex = 15;
            this.rbNazwisko.TabStop = true;
            this.rbNazwisko.Tag = "nazwisko";
            this.rbNazwisko.Text = "Nazwisko";
            this.rbNazwisko.UseVisualStyleBackColor = true;
            // 
            // rbWzrost
            // 
            this.rbWzrost.AutoSize = true;
            this.rbWzrost.Location = new System.Drawing.Point(284, 481);
            this.rbWzrost.Name = "rbWzrost";
            this.rbWzrost.Size = new System.Drawing.Size(58, 17);
            this.rbWzrost.TabIndex = 16;
            this.rbWzrost.TabStop = true;
            this.rbWzrost.Tag = "wzrost";
            this.rbWzrost.Text = "Wzrost";
            this.rbWzrost.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sortuj";
            // 
            // btnWczytajTrenerow
            // 
            this.btnWczytajTrenerow.Location = new System.Drawing.Point(412, 406);
            this.btnWczytajTrenerow.Name = "btnWczytajTrenerow";
            this.btnWczytajTrenerow.Size = new System.Drawing.Size(111, 23);
            this.btnWczytajTrenerow.TabIndex = 18;
            this.btnWczytajTrenerow.Text = "Wczytaj trenerów";
            this.btnWczytajTrenerow.UseVisualStyleBackColor = true;
            this.btnWczytajTrenerow.Click += new System.EventHandler(this.btnWczytajTrenerow_Click);
            // 
            // btnEdycjaTrenera
            // 
            this.btnEdycjaTrenera.Location = new System.Drawing.Point(412, 433);
            this.btnEdycjaTrenera.Name = "btnEdycjaTrenera";
            this.btnEdycjaTrenera.Size = new System.Drawing.Size(111, 23);
            this.btnEdycjaTrenera.TabIndex = 19;
            this.btnEdycjaTrenera.Text = "Edycja Trenera";
            this.btnEdycjaTrenera.UseVisualStyleBackColor = true;
            this.btnEdycjaTrenera.Click += new System.EventHandler(this.btnEdycjaTrenera_Click);
            // 
            // btnDodajTrenera
            // 
            this.btnDodajTrenera.Location = new System.Drawing.Point(412, 462);
            this.btnDodajTrenera.Name = "btnDodajTrenera";
            this.btnDodajTrenera.Size = new System.Drawing.Size(111, 23);
            this.btnDodajTrenera.TabIndex = 20;
            this.btnDodajTrenera.Text = "Dodaj trenera";
            this.btnDodajTrenera.UseVisualStyleBackColor = true;
            this.btnDodajTrenera.Click += new System.EventHandler(this.btnDodajTrenera_Click);
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 585);
            this.Controls.Add(this.btnDodajTrenera);
            this.Controls.Add(this.btnEdycjaTrenera);
            this.Controls.Add(this.btnWczytajTrenerow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbWzrost);
            this.Controls.Add(this.rbNazwisko);
            this.Controls.Add(this.rbImie);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.lblSrTempAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSredniaTemp);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.lbDaneMiasta);
            this.Controls.Add(this.txtFiltr);
            this.Controls.Add(this.lblLiczba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLiczba;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.ListBox lbDaneMiasta;
        private System.Windows.Forms.Label cos;
        private System.Windows.Forms.Label lblSredniaTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSrTempAll;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.RadioButton rbImie;
        private System.Windows.Forms.RadioButton rbNazwisko;
        private System.Windows.Forms.RadioButton rbWzrost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWczytajTrenerow;
        private System.Windows.Forms.Button btnEdycjaTrenera;
        private System.Windows.Forms.Button btnDodajTrenera;
    }
}

