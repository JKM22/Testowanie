namespace Biblioteka.Moduł_4
{
    partial class ZarzadzajBiblioteka
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
            this.button_RejestracjaKsiazek = new System.Windows.Forms.Button();
            this.button_PrzegladajRejestracjaKsiazki = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_listaKsiazek = new System.Windows.Forms.Button();
            this.button_rejestracjaWtpozyczenia = new System.Windows.Forms.Button();
            this.button_listaWypozyczen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_RejestracjaKsiazek
            // 
            this.button_RejestracjaKsiazek.Location = new System.Drawing.Point(11, 10);
            this.button_RejestracjaKsiazek.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_RejestracjaKsiazek.Name = "button_RejestracjaKsiazek";
            this.button_RejestracjaKsiazek.Size = new System.Drawing.Size(156, 53);
            this.button_RejestracjaKsiazek.TabIndex = 0;
            this.button_RejestracjaKsiazek.Text = "Rejestracja książek";
            this.button_RejestracjaKsiazek.UseVisualStyleBackColor = true;
            this.button_RejestracjaKsiazek.Click += new System.EventHandler(this.button_RejestracjaKsiazek_Click);
            // 
            // button_PrzegladajRejestracjaKsiazki
            // 
            this.button_PrzegladajRejestracjaKsiazki.Location = new System.Drawing.Point(11, 143);
            this.button_PrzegladajRejestracjaKsiazki.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_PrzegladajRejestracjaKsiazki.Name = "button_PrzegladajRejestracjaKsiazki";
            this.button_PrzegladajRejestracjaKsiazki.Size = new System.Drawing.Size(156, 52);
            this.button_PrzegladajRejestracjaKsiazki.TabIndex = 1;
            this.button_PrzegladajRejestracjaKsiazki.Text = "Lista zarejestrowanych książek";
            this.button_PrzegladajRejestracjaKsiazki.UseVisualStyleBackColor = true;
            this.button_PrzegladajRejestracjaKsiazki.Click += new System.EventHandler(this.button_PrzegladajRejestracjaKsiazki_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_listaKsiazek
            // 
            this.button_listaKsiazek.Location = new System.Drawing.Point(11, 76);
            this.button_listaKsiazek.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_listaKsiazek.Name = "button_listaKsiazek";
            this.button_listaKsiazek.Size = new System.Drawing.Size(155, 53);
            this.button_listaKsiazek.TabIndex = 3;
            this.button_listaKsiazek.Text = "Lista książek";
            this.button_listaKsiazek.UseVisualStyleBackColor = true;
            this.button_listaKsiazek.Click += new System.EventHandler(this.button_listaKsiazek_Click);
            // 
            // button_rejestracjaWtpozyczenia
            // 
            this.button_rejestracjaWtpozyczenia.Location = new System.Drawing.Point(185, 11);
            this.button_rejestracjaWtpozyczenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rejestracjaWtpozyczenia.Name = "button_rejestracjaWtpozyczenia";
            this.button_rejestracjaWtpozyczenia.Size = new System.Drawing.Size(154, 55);
            this.button_rejestracjaWtpozyczenia.TabIndex = 4;
            this.button_rejestracjaWtpozyczenia.Text = "Rejestracja wypożyczenia";
            this.button_rejestracjaWtpozyczenia.UseVisualStyleBackColor = true;
            this.button_rejestracjaWtpozyczenia.Click += new System.EventHandler(this.button_rejestracjaWtpozyczenia_Click);
            // 
            // button_listaWypozyczen
            // 
            this.button_listaWypozyczen.Location = new System.Drawing.Point(185, 76);
            this.button_listaWypozyczen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_listaWypozyczen.Name = "button_listaWypozyczen";
            this.button_listaWypozyczen.Size = new System.Drawing.Size(155, 52);
            this.button_listaWypozyczen.TabIndex = 5;
            this.button_listaWypozyczen.Text = "Lista wypożyczeń";
            this.button_listaWypozyczen.UseVisualStyleBackColor = true;
            this.button_listaWypozyczen.Click += new System.EventHandler(this.button_listaWypozyczen_Click);
            // 
            // ZarzadzajBiblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 349);
            this.Controls.Add(this.button_listaWypozyczen);
            this.Controls.Add(this.button_rejestracjaWtpozyczenia);
            this.Controls.Add(this.button_listaKsiazek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_PrzegladajRejestracjaKsiazki);
            this.Controls.Add(this.button_RejestracjaKsiazek);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ZarzadzajBiblioteka";
            this.Text = "ZarzadzajBiblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RejestracjaKsiazek;
        private System.Windows.Forms.Button button_PrzegladajRejestracjaKsiazki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_listaKsiazek;
        private System.Windows.Forms.Button button_rejestracjaWtpozyczenia;
        private System.Windows.Forms.Button button_listaWypozyczen;
    }
}