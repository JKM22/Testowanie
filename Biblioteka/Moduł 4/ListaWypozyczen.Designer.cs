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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaWypozyczen));
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(25, 136);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(766, 222);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FILTRUJ KATEGORIE";
            // 
            // button_Przedluz
            // 
            this.button_Przedluz.Location = new System.Drawing.Point(552, 48);
            this.button_Przedluz.Margin = new System.Windows.Forms.Padding(2);
            this.button_Przedluz.Name = "button_Przedluz";
            this.button_Przedluz.Size = new System.Drawing.Size(105, 27);
            this.button_Przedluz.TabIndex = 3;
            this.button_Przedluz.Text = "Przedłuż";
            this.button_Przedluz.UseVisualStyleBackColor = true;
            this.button_Przedluz.Click += new System.EventHandler(this.button_Przedluz_Click);
            // 
            // button_Zwroc
            // 
            this.button_Zwroc.Location = new System.Drawing.Point(661, 48);
            this.button_Zwroc.Margin = new System.Windows.Forms.Padding(2);
            this.button_Zwroc.Name = "button_Zwroc";
            this.button_Zwroc.Size = new System.Drawing.Size(100, 27);
            this.button_Zwroc.TabIndex = 4;
            this.button_Zwroc.Text = "Zwróć";
            this.button_Zwroc.UseVisualStyleBackColor = true;
            this.button_Zwroc.Click += new System.EventHandler(this.button_Zwroc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wypożyczający";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bibliotekarz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Okres wypożyczenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status wypożyczenia";
            // 
            // comboBox_Wypozyczajacy
            // 
            this.comboBox_Wypozyczajacy.FormattingEnabled = true;
            this.comboBox_Wypozyczajacy.Location = new System.Drawing.Point(107, 51);
            this.comboBox_Wypozyczajacy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Wypozyczajacy.Name = "comboBox_Wypozyczajacy";
            this.comboBox_Wypozyczajacy.Size = new System.Drawing.Size(146, 21);
            this.comboBox_Wypozyczajacy.TabIndex = 9;
            // 
            // comboBox_Bibliotekarz
            // 
            this.comboBox_Bibliotekarz.FormattingEnabled = true;
            this.comboBox_Bibliotekarz.Location = new System.Drawing.Point(107, 77);
            this.comboBox_Bibliotekarz.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Bibliotekarz.Name = "comboBox_Bibliotekarz";
            this.comboBox_Bibliotekarz.Size = new System.Drawing.Size(146, 21);
            this.comboBox_Bibliotekarz.TabIndex = 10;
            // 
            // comboBox_okresWypozyczenia
            // 
            this.comboBox_okresWypozyczenia.FormattingEnabled = true;
            this.comboBox_okresWypozyczenia.Location = new System.Drawing.Point(375, 51);
            this.comboBox_okresWypozyczenia.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_okresWypozyczenia.Name = "comboBox_okresWypozyczenia";
            this.comboBox_okresWypozyczenia.Size = new System.Drawing.Size(133, 21);
            this.comboBox_okresWypozyczenia.TabIndex = 11;
            // 
            // comboBox_statusWypozyczenia
            // 
            this.comboBox_statusWypozyczenia.FormattingEnabled = true;
            this.comboBox_statusWypozyczenia.Location = new System.Drawing.Point(375, 76);
            this.comboBox_statusWypozyczenia.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_statusWypozyczenia.Name = "comboBox_statusWypozyczenia";
            this.comboBox_statusWypozyczenia.Size = new System.Drawing.Size(133, 21);
            this.comboBox_statusWypozyczenia.TabIndex = 12;
            // 
            // button_Filtruj
            // 
            this.button_Filtruj.Location = new System.Drawing.Point(376, 103);
            this.button_Filtruj.Margin = new System.Windows.Forms.Padding(2);
            this.button_Filtruj.Name = "button_Filtruj";
            this.button_Filtruj.Size = new System.Drawing.Size(65, 27);
            this.button_Filtruj.TabIndex = 13;
            this.button_Filtruj.Text = "Filtruj";
            this.button_Filtruj.UseVisualStyleBackColor = true;
            this.button_Filtruj.Click += new System.EventHandler(this.button_Filtruj_Click);
            // 
            // button_Odswiez
            // 
            this.button_Odswiez.Location = new System.Drawing.Point(445, 102);
            this.button_Odswiez.Margin = new System.Windows.Forms.Padding(2);
            this.button_Odswiez.Name = "button_Odswiez";
            this.button_Odswiez.Size = new System.Drawing.Size(63, 28);
            this.button_Odswiez.TabIndex = 14;
            this.button_Odswiez.Text = "Odśwież";
            this.button_Odswiez.UseVisualStyleBackColor = true;
            this.button_Odswiez.Click += new System.EventHandler(this.button_Odswiez_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "dni";
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
            // ListaWypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(802, 408);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaWypozyczen";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
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
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}