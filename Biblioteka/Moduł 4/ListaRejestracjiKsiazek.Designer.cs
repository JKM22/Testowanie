﻿namespace Biblioteka.Moduł_4
{
    partial class ListaRejestracjiKsiazek
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaRejestracjiKsiazek));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_wroc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_autor = new System.Windows.Forms.ComboBox();
            this.comboBox_gatunek = new System.Windows.Forms.ComboBox();
            this.comboBox_tytul = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_wydawnictwo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_od = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_osoba = new System.Windows.Forms.ComboBox();
            this.button_odswiez = new System.Windows.Forms.Button();
            this.button_filtruj = new System.Windows.Forms.Button();
            this.dateTimePicker_do = new System.Windows.Forms.DateTimePicker();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 163);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 281);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRZEGLĄDAJ REJESTRACJE KSIĄŻEK";
            // 
            // button_wroc
            // 
            this.button_wroc.Location = new System.Drawing.Point(643, 448);
            this.button_wroc.Margin = new System.Windows.Forms.Padding(2);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(82, 30);
            this.button_wroc.TabIndex = 2;
            this.button_wroc.Text = "WRÓĆ";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.button_wroc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AUTOR:";
            // 
            // comboBox_autor
            // 
            this.comboBox_autor.FormattingEnabled = true;
            this.comboBox_autor.Location = new System.Drawing.Point(123, 58);
            this.comboBox_autor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_autor.Name = "comboBox_autor";
            this.comboBox_autor.Size = new System.Drawing.Size(136, 21);
            this.comboBox_autor.TabIndex = 8;
            // 
            // comboBox_gatunek
            // 
            this.comboBox_gatunek.FormattingEnabled = true;
            this.comboBox_gatunek.Location = new System.Drawing.Point(123, 106);
            this.comboBox_gatunek.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_gatunek.Name = "comboBox_gatunek";
            this.comboBox_gatunek.Size = new System.Drawing.Size(136, 21);
            this.comboBox_gatunek.TabIndex = 9;
            // 
            // comboBox_tytul
            // 
            this.comboBox_tytul.FormattingEnabled = true;
            this.comboBox_tytul.Location = new System.Drawing.Point(123, 82);
            this.comboBox_tytul.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_tytul.Name = "comboBox_tytul";
            this.comboBox_tytul.Size = new System.Drawing.Size(136, 21);
            this.comboBox_tytul.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TYTUŁ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "GATUNEK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "WYDAWNICTWO:";
            // 
            // comboBox_wydawnictwo
            // 
            this.comboBox_wydawnictwo.FormattingEnabled = true;
            this.comboBox_wydawnictwo.Location = new System.Drawing.Point(123, 131);
            this.comboBox_wydawnictwo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_wydawnictwo.Name = "comboBox_wydawnictwo";
            this.comboBox_wydawnictwo.Size = new System.Drawing.Size(136, 21);
            this.comboBox_wydawnictwo.TabIndex = 14;
            // 
            // dateTimePicker_od
            // 
            this.dateTimePicker_od.Location = new System.Drawing.Point(426, 55);
            this.dateTimePicker_od.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_od.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_od.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_od.Name = "dateTimePicker_od";
            this.dateTimePicker_od.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker_od.TabIndex = 16;
            this.dateTimePicker_od.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ZAKRES DAT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "OSOBA REJESTRUJĄCA:";
            // 
            // comboBox_osoba
            // 
            this.comboBox_osoba.FormattingEnabled = true;
            this.comboBox_osoba.Location = new System.Drawing.Point(426, 82);
            this.comboBox_osoba.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_osoba.Name = "comboBox_osoba";
            this.comboBox_osoba.Size = new System.Drawing.Size(152, 21);
            this.comboBox_osoba.TabIndex = 21;
            // 
            // button_odswiez
            // 
            this.button_odswiez.Location = new System.Drawing.Point(642, 133);
            this.button_odswiez.Margin = new System.Windows.Forms.Padding(2);
            this.button_odswiez.Name = "button_odswiez";
            this.button_odswiez.Size = new System.Drawing.Size(83, 19);
            this.button_odswiez.TabIndex = 6;
            this.button_odswiez.Text = "ODŚWIEŻ";
            this.button_odswiez.UseVisualStyleBackColor = true;
            this.button_odswiez.Click += new System.EventHandler(this.button_odswiez_Click);
            // 
            // button_filtruj
            // 
            this.button_filtruj.Location = new System.Drawing.Point(553, 133);
            this.button_filtruj.Margin = new System.Windows.Forms.Padding(2);
            this.button_filtruj.Name = "button_filtruj";
            this.button_filtruj.Size = new System.Drawing.Size(85, 19);
            this.button_filtruj.TabIndex = 5;
            this.button_filtruj.Text = "FILTRUJ";
            this.button_filtruj.UseVisualStyleBackColor = true;
            this.button_filtruj.Click += new System.EventHandler(this.button_filtruj_Click);
            // 
            // dateTimePicker_do
            // 
            this.dateTimePicker_do.Location = new System.Drawing.Point(601, 55);
            this.dateTimePicker_do.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_do.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_do.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_do.Name = "dateTimePicker_do";
            this.dateTimePicker_do.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker_do.TabIndex = 22;
            this.dateTimePicker_do.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette1.ButtonStyles.ButtonCommand.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonPalette1.ButtonStyles.ButtonCommand.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // ListaRejestracjiKsiazek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(798, 488);
            this.Controls.Add(this.dateTimePicker_do);
            this.Controls.Add(this.comboBox_osoba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_od);
            this.Controls.Add(this.comboBox_wydawnictwo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_tytul);
            this.Controls.Add(this.comboBox_gatunek);
            this.Controls.Add(this.comboBox_autor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_odswiez);
            this.Controls.Add(this.button_filtruj);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaRejestracjiKsiazek";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "+";
            this.Load += new System.EventHandler(this.ListaRejestracjiKsiazek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_wroc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_autor;
        private System.Windows.Forms.ComboBox comboBox_gatunek;
        private System.Windows.Forms.ComboBox comboBox_tytul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_wydawnictwo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_od;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_osoba;
        private System.Windows.Forms.Button button_odswiez;
        private System.Windows.Forms.Button button_filtruj;
        private System.Windows.Forms.DateTimePicker dateTimePicker_do;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}