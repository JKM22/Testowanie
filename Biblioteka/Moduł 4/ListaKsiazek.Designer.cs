namespace Biblioteka.Moduł_4
{
    partial class ListaKsiazek
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxDane = new System.Windows.Forms.ComboBox();
            this.button_filtruj = new System.Windows.Forms.Button();
            this.button_odswiez = new System.Windows.Forms.Button();
            this.button_podglad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 299);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(2, 46);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(165, 24);
            this.comboBoxFilter.TabIndex = 2;
            // 
            // comboBoxDane
            // 
            this.comboBoxDane.FormattingEnabled = true;
            this.comboBoxDane.Location = new System.Drawing.Point(173, 46);
            this.comboBoxDane.Name = "comboBoxDane";
            this.comboBoxDane.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDane.TabIndex = 3;
            // 
            // button_filtruj
            // 
            this.button_filtruj.Location = new System.Drawing.Point(339, 47);
            this.button_filtruj.Name = "button_filtruj";
            this.button_filtruj.Size = new System.Drawing.Size(144, 23);
            this.button_filtruj.TabIndex = 4;
            this.button_filtruj.Text = "FILTRUJ";
            this.button_filtruj.UseVisualStyleBackColor = true;
            this.button_filtruj.Click += new System.EventHandler(this.button_filtruj_Click);
            // 
            // button_odswiez
            // 
            this.button_odswiez.Location = new System.Drawing.Point(489, 46);
            this.button_odswiez.Name = "button_odswiez";
            this.button_odswiez.Size = new System.Drawing.Size(133, 23);
            this.button_odswiez.TabIndex = 5;
            this.button_odswiez.Text = "ODŚWIEŻ";
            this.button_odswiez.UseVisualStyleBackColor = true;
            this.button_odswiez.Click += new System.EventHandler(this.button_odswiez_Click);
            // 
            // button_podglad
            // 
            this.button_podglad.Location = new System.Drawing.Point(628, 46);
            this.button_podglad.Name = "button_podglad";
            this.button_podglad.Size = new System.Drawing.Size(251, 23);
            this.button_podglad.TabIndex = 6;
            this.button_podglad.Text = "PODGLĄD KSIĄŻKI";
            this.button_podglad.UseVisualStyleBackColor = true;
            this.button_podglad.Click += new System.EventHandler(this.button_podglad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "FILTRUJ KATEGORIE";
            // 
            // ListaKsiazek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_podglad);
            this.Controls.Add(this.button_odswiez);
            this.Controls.Add(this.button_filtruj);
            this.Controls.Add(this.comboBoxDane);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListaKsiazek";
            this.Text = "ListaKsiazek";
            this.Load += new System.EventHandler(this.ListaKsiazek_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxDane;
        private System.Windows.Forms.Button button_filtruj;
        private System.Windows.Forms.Button button_odswiez;
        private System.Windows.Forms.Button button_podglad;
        private System.Windows.Forms.Label label1;
    }
}