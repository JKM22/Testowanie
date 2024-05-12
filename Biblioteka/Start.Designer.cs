namespace Biblioteka
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.zaloguj = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.uzytkownicy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.uprawnienia = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.zamknij = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.wyloguj = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button_ZarzadzajBiblioteka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
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
            // zaloguj
            // 
            this.zaloguj.Location = new System.Drawing.Point(994, 166);
            this.zaloguj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Palette = this.kryptonPalette1;
            this.zaloguj.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.zaloguj.Size = new System.Drawing.Size(238, 74);
            this.zaloguj.TabIndex = 6;
            this.zaloguj.Values.Text = "ZALOGUJ SIĘ";
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // uzytkownicy
            // 
            this.uzytkownicy.Location = new System.Drawing.Point(994, 263);
            this.uzytkownicy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uzytkownicy.Name = "uzytkownicy";
            this.uzytkownicy.Palette = this.kryptonPalette1;
            this.uzytkownicy.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.uzytkownicy.Size = new System.Drawing.Size(238, 74);
            this.uzytkownicy.TabIndex = 7;
            this.uzytkownicy.Values.Text = "UŻYTKOWNICY";
            this.uzytkownicy.Click += new System.EventHandler(this.uzytkownicy_Click);
            // 
            // uprawnienia
            // 
            this.uprawnienia.Location = new System.Drawing.Point(994, 360);
            this.uprawnienia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uprawnienia.Name = "uprawnienia";
            this.uprawnienia.Palette = this.kryptonPalette1;
            this.uprawnienia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.uprawnienia.Size = new System.Drawing.Size(238, 74);
            this.uprawnienia.TabIndex = 8;
            this.uprawnienia.Values.Text = "UPRAWNIENIA";
            this.uprawnienia.Click += new System.EventHandler(this.uprawnienia_Click);
            // 
            // zamknij
            // 
            this.zamknij.Location = new System.Drawing.Point(994, 617);
            this.zamknij.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zamknij.Name = "zamknij";
            this.zamknij.Palette = this.kryptonPalette1;
            this.zamknij.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.zamknij.Size = new System.Drawing.Size(238, 74);
            this.zamknij.TabIndex = 9;
            this.zamknij.Values.Text = "ZAMKNIJ APLIKACJĘ";
            this.zamknij.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // wyloguj
            // 
            this.wyloguj.Location = new System.Drawing.Point(994, 65);
            this.wyloguj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wyloguj.Name = "wyloguj";
            this.wyloguj.Palette = this.kryptonPalette1;
            this.wyloguj.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.wyloguj.Size = new System.Drawing.Size(238, 74);
            this.wyloguj.TabIndex = 10;
            this.wyloguj.Values.Text = "WYLOGUJ";
            this.wyloguj.Click += new System.EventHandler(this.wyloguj_Click_1);
            // 
            // button_ZarzadzajBiblioteka
            // 
            this.button_ZarzadzajBiblioteka.Location = new System.Drawing.Point(111, 176);
            this.button_ZarzadzajBiblioteka.Name = "button_ZarzadzajBiblioteka";
            this.button_ZarzadzajBiblioteka.Size = new System.Drawing.Size(175, 71);
            this.button_ZarzadzajBiblioteka.TabIndex = 11;
            this.button_ZarzadzajBiblioteka.Text = "Zarządzaj biblioteką";
            this.button_ZarzadzajBiblioteka.UseVisualStyleBackColor = true;
            this.button_ZarzadzajBiblioteka.Click += new System.EventHandler(this.button_ZarzadzajBiblioteka_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1251, 709);
            this.Controls.Add(this.button_ZarzadzajBiblioteka);
            this.Controls.Add(this.wyloguj);
            this.Controls.Add(this.zamknij);
            this.Controls.Add(this.uprawnienia);
            this.Controls.Add(this.uzytkownicy);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton zaloguj;
        private ComponentFactory.Krypton.Toolkit.KryptonButton uzytkownicy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton uprawnienia;
        private ComponentFactory.Krypton.Toolkit.KryptonButton zamknij;
        private ComponentFactory.Krypton.Toolkit.KryptonButton wyloguj;
        private System.Windows.Forms.Button button_ZarzadzajBiblioteka;
    }
}

