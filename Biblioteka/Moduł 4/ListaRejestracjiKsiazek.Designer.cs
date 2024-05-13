namespace Biblioteka.Moduł_4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_wroc = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.comboBox_Dane = new System.Windows.Forms.ComboBox();
            this.button_filtruj = new System.Windows.Forms.Button();
            this.button_odswiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 171);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1060, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRZEGLĄDAJ REJESTRACJE KSIĄŻEK";
            // 
            // button_wroc
            // 
            this.button_wroc.Location = new System.Drawing.Point(12, 552);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(110, 37);
            this.button_wroc.TabIndex = 2;
            this.button_wroc.Text = "WRÓĆ";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.button_wroc_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(12, 114);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(162, 24);
            this.comboBoxFilter.TabIndex = 3;
            // 
            // comboBox_Dane
            // 
            this.comboBox_Dane.FormattingEnabled = true;
            this.comboBox_Dane.Location = new System.Drawing.Point(194, 114);
            this.comboBox_Dane.Name = "comboBox_Dane";
            this.comboBox_Dane.Size = new System.Drawing.Size(158, 24);
            this.comboBox_Dane.TabIndex = 4;
            // 
            // button_filtruj
            // 
            this.button_filtruj.Location = new System.Drawing.Point(371, 114);
            this.button_filtruj.Name = "button_filtruj";
            this.button_filtruj.Size = new System.Drawing.Size(117, 23);
            this.button_filtruj.TabIndex = 5;
            this.button_filtruj.Text = "FILTRUJ";
            this.button_filtruj.UseVisualStyleBackColor = true;
            this.button_filtruj.Click += new System.EventHandler(this.button_filtruj_Click);
            // 
            // button_odswiez
            // 
            this.button_odswiez.Location = new System.Drawing.Point(507, 114);
            this.button_odswiez.Name = "button_odswiez";
            this.button_odswiez.Size = new System.Drawing.Size(111, 23);
            this.button_odswiez.TabIndex = 6;
            this.button_odswiez.Text = "ODŚWIEŻ";
            this.button_odswiez.UseVisualStyleBackColor = true;
            this.button_odswiez.Click += new System.EventHandler(this.button_odswiez_Click);
            // 
            // ListaRejestracjiKsiazek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 601);
            this.Controls.Add(this.button_odswiez);
            this.Controls.Add(this.button_filtruj);
            this.Controls.Add(this.comboBox_Dane);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ListaRejestracjiKsiazek";
            this.Text = "ListaRejestracjiKsiazek";
            this.Load += new System.EventHandler(this.ListaRejestracjiKsiazek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_wroc;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ComboBox comboBox_Dane;
        private System.Windows.Forms.Button button_filtruj;
        private System.Windows.Forms.Button button_odswiez;
    }
}