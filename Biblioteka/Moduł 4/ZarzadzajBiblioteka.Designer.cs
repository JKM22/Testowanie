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
            this.SuspendLayout();
            // 
            // button_RejestracjaKsiazek
            // 
            this.button_RejestracjaKsiazek.Location = new System.Drawing.Point(60, 35);
            this.button_RejestracjaKsiazek.Name = "button_RejestracjaKsiazek";
            this.button_RejestracjaKsiazek.Size = new System.Drawing.Size(160, 82);
            this.button_RejestracjaKsiazek.TabIndex = 0;
            this.button_RejestracjaKsiazek.Text = "Rejestracja książek";
            this.button_RejestracjaKsiazek.UseVisualStyleBackColor = true;
            this.button_RejestracjaKsiazek.Click += new System.EventHandler(this.button_RejestracjaKsiazek_Click);
            // 
            // button_PrzegladajRejestracjaKsiazki
            // 
            this.button_PrzegladajRejestracjaKsiazki.Location = new System.Drawing.Point(60, 156);
            this.button_PrzegladajRejestracjaKsiazki.Name = "button_PrzegladajRejestracjaKsiazki";
            this.button_PrzegladajRejestracjaKsiazki.Size = new System.Drawing.Size(178, 81);
            this.button_PrzegladajRejestracjaKsiazki.TabIndex = 1;
            this.button_PrzegladajRejestracjaKsiazki.Text = "Przeglaj listę zarejestrowanych książek";
            this.button_PrzegladajRejestracjaKsiazki.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_listaKsiazek
            // 
            this.button_listaKsiazek.Location = new System.Drawing.Point(60, 269);
            this.button_listaKsiazek.Name = "button_listaKsiazek";
            this.button_listaKsiazek.Size = new System.Drawing.Size(161, 58);
            this.button_listaKsiazek.TabIndex = 3;
            this.button_listaKsiazek.Text = "Lista książek";
            this.button_listaKsiazek.UseVisualStyleBackColor = true;
            this.button_listaKsiazek.Click += new System.EventHandler(this.button_listaKsiazek_Click);
            // 
            // ZarzadzajBiblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_listaKsiazek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_PrzegladajRejestracjaKsiazki);
            this.Controls.Add(this.button_RejestracjaKsiazek);
            this.Name = "ZarzadzajBiblioteka";
            this.Text = "ZarzadzajBiblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RejestracjaKsiazek;
        private System.Windows.Forms.Button button_PrzegladajRejestracjaKsiazki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_listaKsiazek;
    }
}