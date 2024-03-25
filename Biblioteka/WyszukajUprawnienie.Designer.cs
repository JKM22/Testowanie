namespace Biblioteka
{
    partial class WyszukajUprawnienie
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Wyszukaj = new System.Windows.Forms.Button();
            this.button_Wroc = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Użytkownik zalogowany",
            "Użytkownik niezalogowany"});
            this.comboBox1.Location = new System.Drawing.Point(12, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Wybierz uprawnienie";
            // 
            // button_Wyszukaj
            // 
            this.button_Wyszukaj.Location = new System.Drawing.Point(254, 70);
            this.button_Wyszukaj.Name = "button_Wyszukaj";
            this.button_Wyszukaj.Size = new System.Drawing.Size(116, 35);
            this.button_Wyszukaj.TabIndex = 3;
            this.button_Wyszukaj.Text = "WYSZUKAJ";
            this.button_Wyszukaj.UseVisualStyleBackColor = true;
            this.button_Wyszukaj.Click += new System.EventHandler(this.button_Wyszukaj_Click);
            // 
            // button_Wroc
            // 
            this.button_Wroc.Location = new System.Drawing.Point(675, 390);
            this.button_Wroc.Name = "button_Wroc";
            this.button_Wroc.Size = new System.Drawing.Size(113, 48);
            this.button_Wroc.TabIndex = 4;
            this.button_Wroc.Text = "WRÓĆ";
            this.button_Wroc.UseVisualStyleBackColor = true;
            this.button_Wroc.Click += new System.EventHandler(this.button_Wroc_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(123, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(491, 173);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // WyszukajUprawnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Wroc);
            this.Controls.Add(this.button_Wyszukaj);
            this.Controls.Add(this.comboBox1);
            this.Name = "WyszukajUprawnienie";
            this.Text = "WyszukajUprawnienie";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Wyszukaj;
        private System.Windows.Forms.Button button_Wroc;
        private System.Windows.Forms.ListView listView1;
    }
}