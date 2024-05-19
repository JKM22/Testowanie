namespace Biblioteka.Moduł_4
{
    partial class ListaWypozyczen
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Przedluz = new System.Windows.Forms.Button();
            this.button_Zwroc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Wypozyczajacy = new System.Windows.Forms.ComboBox();
            this.comboBox_Bibliotekarz = new System.Windows.Forms.ComboBox();
            this.comboBox_okresWypozyczenia = new System.Windows.Forms.ComboBox();
            this.comboBox_statusWypozyczenia = new System.Windows.Forms.ComboBox();
            this.button_Filtruj = new System.Windows.Forms.Button();
            this.button_Odswiez = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(37, 210);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(984, 339);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILTRUJ KATEGORIE";
            // 
            // button_Przedluz
            // 
            this.button_Przedluz.Location = new System.Drawing.Point(712, 24);
            this.button_Przedluz.Name = "button_Przedluz";
            this.button_Przedluz.Size = new System.Drawing.Size(113, 53);
            this.button_Przedluz.TabIndex = 3;
            this.button_Przedluz.Text = "Przedłuż";
            this.button_Przedluz.UseVisualStyleBackColor = true;
            this.button_Przedluz.Click += new System.EventHandler(this.button_Przedluz_Click);
            // 
            // button_Zwroc
            // 
            this.button_Zwroc.Location = new System.Drawing.Point(849, 22);
            this.button_Zwroc.Name = "button_Zwroc";
            this.button_Zwroc.Size = new System.Drawing.Size(111, 57);
            this.button_Zwroc.TabIndex = 4;
            this.button_Zwroc.Text = "Zwróć";
            this.button_Zwroc.UseVisualStyleBackColor = true;
            this.button_Zwroc.Click += new System.EventHandler(this.button_Zwroc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wypożyczający";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bibliotekarz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Okres wypożyczenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status wypożyczenia";
            // 
            // comboBox_Wypozyczajacy
            // 
            this.comboBox_Wypozyczajacy.FormattingEnabled = true;
            this.comboBox_Wypozyczajacy.Location = new System.Drawing.Point(202, 78);
            this.comboBox_Wypozyczajacy.Name = "comboBox_Wypozyczajacy";
            this.comboBox_Wypozyczajacy.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Wypozyczajacy.TabIndex = 9;
            // 
            // comboBox_Bibliotekarz
            // 
            this.comboBox_Bibliotekarz.FormattingEnabled = true;
            this.comboBox_Bibliotekarz.Location = new System.Drawing.Point(202, 119);
            this.comboBox_Bibliotekarz.Name = "comboBox_Bibliotekarz";
            this.comboBox_Bibliotekarz.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Bibliotekarz.TabIndex = 10;
            // 
            // comboBox_okresWypozyczenia
            // 
            this.comboBox_okresWypozyczenia.FormattingEnabled = true;
            this.comboBox_okresWypozyczenia.Location = new System.Drawing.Point(548, 77);
            this.comboBox_okresWypozyczenia.Name = "comboBox_okresWypozyczenia";
            this.comboBox_okresWypozyczenia.Size = new System.Drawing.Size(121, 28);
            this.comboBox_okresWypozyczenia.TabIndex = 11;
            // 
            // comboBox_statusWypozyczenia
            // 
            this.comboBox_statusWypozyczenia.FormattingEnabled = true;
            this.comboBox_statusWypozyczenia.Location = new System.Drawing.Point(548, 119);
            this.comboBox_statusWypozyczenia.Name = "comboBox_statusWypozyczenia";
            this.comboBox_statusWypozyczenia.Size = new System.Drawing.Size(121, 28);
            this.comboBox_statusWypozyczenia.TabIndex = 12;
            // 
            // button_Filtruj
            // 
            this.button_Filtruj.Location = new System.Drawing.Point(411, 163);
            this.button_Filtruj.Name = "button_Filtruj";
            this.button_Filtruj.Size = new System.Drawing.Size(97, 42);
            this.button_Filtruj.TabIndex = 13;
            this.button_Filtruj.Text = "Filtruj";
            this.button_Filtruj.UseVisualStyleBackColor = true;
            this.button_Filtruj.Click += new System.EventHandler(this.button_Filtruj_Click);
            // 
            // button_Odswiez
            // 
            this.button_Odswiez.Location = new System.Drawing.Point(525, 162);
            this.button_Odswiez.Name = "button_Odswiez";
            this.button_Odswiez.Size = new System.Drawing.Size(94, 43);
            this.button_Odswiez.TabIndex = 14;
            this.button_Odswiez.Text = "Odśwież";
            this.button_Odswiez.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "dni";
            // 
            // ListaWypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 627);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Odswiez);
            this.Controls.Add(this.button_Filtruj);
            this.Controls.Add(this.comboBox_statusWypozyczenia);
            this.Controls.Add(this.comboBox_okresWypozyczenia);
            this.Controls.Add(this.comboBox_Bibliotekarz);
            this.Controls.Add(this.comboBox_Wypozyczajacy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Zwroc);
            this.Controls.Add(this.button_Przedluz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Name = "ListaWypozyczen";
            this.Text = "ListaWypozyczen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Przedluz;
        private System.Windows.Forms.Button button_Zwroc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Wypozyczajacy;
        private System.Windows.Forms.ComboBox comboBox_Bibliotekarz;
        private System.Windows.Forms.ComboBox comboBox_okresWypozyczenia;
        private System.Windows.Forms.ComboBox comboBox_statusWypozyczenia;
        private System.Windows.Forms.Button button_Filtruj;
        private System.Windows.Forms.Button button_Odswiez;
        private System.Windows.Forms.Label label6;
    }
}