namespace Biblioteka
{
    partial class Roboczy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roboczy));
            this.buttonGoToAddUser = new System.Windows.Forms.Button();
            this.buttonGoToModUser = new System.Windows.Forms.Button();
            this.button_wyszukaj = new System.Windows.Forms.Button();
            this.buttonGoToDelUser = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_wroc = new System.Windows.Forms.Button();
            this.textBox_wyszukaj = new System.Windows.Forms.TextBox();
            this.button_odwiez = new System.Windows.Forms.Button();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGoToAddUser
            // 
            this.buttonGoToAddUser.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoToAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGoToAddUser.Location = new System.Drawing.Point(14, 12);
            this.buttonGoToAddUser.Name = "buttonGoToAddUser";
            this.buttonGoToAddUser.Size = new System.Drawing.Size(151, 31);
            this.buttonGoToAddUser.TabIndex = 0;
            this.buttonGoToAddUser.Text = "DODAJ UŻYTKOWNIKA";
            this.buttonGoToAddUser.UseVisualStyleBackColor = true;
            this.buttonGoToAddUser.Click += new System.EventHandler(this.buttonGoToAddUser_Click);
            // 
            // buttonGoToModUser
            // 
            this.buttonGoToModUser.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoToModUser.Location = new System.Drawing.Point(171, 12);
            this.buttonGoToModUser.Name = "buttonGoToModUser";
            this.buttonGoToModUser.Size = new System.Drawing.Size(151, 31);
            this.buttonGoToModUser.TabIndex = 1;
            this.buttonGoToModUser.Text = "MODYFIKUJ DANE";
            this.buttonGoToModUser.UseVisualStyleBackColor = true;
            this.buttonGoToModUser.Click += new System.EventHandler(this.buttonGoToModUser_Click);
            // 
            // button_wyszukaj
            // 
            this.button_wyszukaj.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyszukaj.Location = new System.Drawing.Point(1020, 19);
            this.button_wyszukaj.Name = "button_wyszukaj";
            this.button_wyszukaj.Size = new System.Drawing.Size(85, 20);
            this.button_wyszukaj.TabIndex = 2;
            this.button_wyszukaj.Text = "WYSZUKAJ";
            this.button_wyszukaj.UseVisualStyleBackColor = true;
            this.button_wyszukaj.Click += new System.EventHandler(this.button_wyszukaj_Click_1);
            // 
            // buttonGoToDelUser
            // 
            this.buttonGoToDelUser.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoToDelUser.Location = new System.Drawing.Point(328, 12);
            this.buttonGoToDelUser.Name = "buttonGoToDelUser";
            this.buttonGoToDelUser.Size = new System.Drawing.Size(151, 31);
            this.buttonGoToDelUser.TabIndex = 3;
            this.buttonGoToDelUser.Text = "USUŃ UŻYTKOWNIKA";
            this.buttonGoToDelUser.UseVisualStyleBackColor = true;
            this.buttonGoToDelUser.Click += new System.EventHandler(this.buttonGoToDelUser_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1196, 462);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button_wroc
            // 
            this.button_wroc.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wroc.Location = new System.Drawing.Point(1118, 529);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(78, 22);
            this.button_wroc.TabIndex = 5;
            this.button_wroc.Text = "WRÓĆ";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.button_wroc_Click);
            // 
            // textBox_wyszukaj
            // 
            this.textBox_wyszukaj.Location = new System.Drawing.Point(833, 19);
            this.textBox_wyszukaj.Name = "textBox_wyszukaj";
            this.textBox_wyszukaj.Size = new System.Drawing.Size(181, 20);
            this.textBox_wyszukaj.TabIndex = 6;
            // 
            // button_odwiez
            // 
            this.button_odwiez.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_odwiez.Location = new System.Drawing.Point(1111, 19);
            this.button_odwiez.Name = "button_odwiez";
            this.button_odwiez.Size = new System.Drawing.Size(85, 19);
            this.button_odwiez.TabIndex = 7;
            this.button_odwiez.Text = "ODŚWIEŻ";
            this.button_odwiez.UseVisualStyleBackColor = true;
            this.button_odwiez.Click += new System.EventHandler(this.button_odwiez_Click);
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.button_odwiez);
            this.kryptonPanel1.Controls.Add(this.buttonGoToAddUser);
            this.kryptonPanel1.Controls.Add(this.button_wyszukaj);
            this.kryptonPanel1.Controls.Add(this.textBox_wyszukaj);
            this.kryptonPanel1.Controls.Add(this.buttonGoToModUser);
            this.kryptonPanel1.Controls.Add(this.buttonGoToDelUser);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Palette = this.kryptonPalette1;
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(1208, 55);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // Roboczy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1208, 557);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.listView1);
            this.MinimizeBox = false;
            this.Name = "Roboczy";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roboczy";
            this.Load += new System.EventHandler(this.Roboczy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToAddUser;
        private System.Windows.Forms.Button buttonGoToModUser;
        private System.Windows.Forms.Button button_wyszukaj;
        private System.Windows.Forms.Button buttonGoToDelUser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_wroc;
        private System.Windows.Forms.TextBox textBox_wyszukaj;
        private System.Windows.Forms.Button button_odwiez;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}