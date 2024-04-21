namespace Biblioteka
{
    partial class Uprawnienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uprawnienia));
            this.button_PrzegladajUprawnienia = new System.Windows.Forms.Button();
            this.button_NadajUprawnienia = new System.Windows.Forms.Button();
            this.button_PrzegladajUzytkownikow = new System.Windows.Forms.Button();
            this.button_Wroc = new System.Windows.Forms.Button();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // button_PrzegladajUprawnienia
            // 
            this.button_PrzegladajUprawnienia.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PrzegladajUprawnienia.Location = new System.Drawing.Point(27, 8);
            this.button_PrzegladajUprawnienia.Margin = new System.Windows.Forms.Padding(2);
            this.button_PrzegladajUprawnienia.Name = "button_PrzegladajUprawnienia";
            this.button_PrzegladajUprawnienia.Size = new System.Drawing.Size(163, 48);
            this.button_PrzegladajUprawnienia.TabIndex = 0;
            this.button_PrzegladajUprawnienia.Text = "PRZEGLĄDAJ UPRAWNIENIA";
            this.button_PrzegladajUprawnienia.UseVisualStyleBackColor = true;
            this.button_PrzegladajUprawnienia.Click += new System.EventHandler(this.button_PrzegladajUprawnienia_Click);
            // 
            // button_NadajUprawnienia
            // 
            this.button_NadajUprawnienia.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_NadajUprawnienia.Location = new System.Drawing.Point(27, 75);
            this.button_NadajUprawnienia.Margin = new System.Windows.Forms.Padding(2);
            this.button_NadajUprawnienia.Name = "button_NadajUprawnienia";
            this.button_NadajUprawnienia.Size = new System.Drawing.Size(163, 42);
            this.button_NadajUprawnienia.TabIndex = 1;
            this.button_NadajUprawnienia.Text = "NADAJ UPRAWNIENIA";
            this.button_NadajUprawnienia.UseVisualStyleBackColor = true;
            this.button_NadajUprawnienia.Click += new System.EventHandler(this.button_NadajUprawnienia_Click);
            // 
            // button_PrzegladajUzytkownikow
            // 
            this.button_PrzegladajUzytkownikow.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PrzegladajUzytkownikow.Location = new System.Drawing.Point(27, 134);
            this.button_PrzegladajUzytkownikow.Margin = new System.Windows.Forms.Padding(2);
            this.button_PrzegladajUzytkownikow.Name = "button_PrzegladajUzytkownikow";
            this.button_PrzegladajUzytkownikow.Size = new System.Drawing.Size(163, 64);
            this.button_PrzegladajUzytkownikow.TabIndex = 2;
            this.button_PrzegladajUzytkownikow.Text = "PRZEGLĄDAJ UŻYTKOWNIKÓW Z DANYM UPRAWNIENIEM";
            this.button_PrzegladajUzytkownikow.UseVisualStyleBackColor = true;
            this.button_PrzegladajUzytkownikow.Click += new System.EventHandler(this.button_PrzegladajUzytkownikow_Click);
            // 
            // button_Wroc
            // 
            this.button_Wroc.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Wroc.Location = new System.Drawing.Point(470, 254);
            this.button_Wroc.Margin = new System.Windows.Forms.Padding(2);
            this.button_Wroc.Name = "button_Wroc";
            this.button_Wroc.Size = new System.Drawing.Size(52, 27);
            this.button_Wroc.TabIndex = 3;
            this.button_Wroc.Text = "WRÓĆ";
            this.button_Wroc.UseVisualStyleBackColor = true;
            this.button_Wroc.Click += new System.EventHandler(this.button_Wroc_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.Image")));
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
            this.kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(190)))), ((int)(((byte)(237)))));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(145)))), ((int)(((byte)(237)))));
            // 
            // Uprawnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button_Wroc);
            this.Controls.Add(this.button_PrzegladajUzytkownikow);
            this.Controls.Add(this.button_NadajUprawnienia);
            this.Controls.Add(this.button_PrzegladajUprawnienia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uprawnienia";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Uprawnienia";
            this.Load += new System.EventHandler(this.Uprawnienia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PrzegladajUprawnienia;
        private System.Windows.Forms.Button button_NadajUprawnienia;
        private System.Windows.Forms.Button button_PrzegladajUzytkownikow;
        private System.Windows.Forms.Button button_Wroc;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}