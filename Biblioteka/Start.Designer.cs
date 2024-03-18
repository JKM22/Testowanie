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
            this.label1 = new System.Windows.Forms.Label();
            this.button_logowanie = new System.Windows.Forms.Button();
            this.button_zamknij = new System.Windows.Forms.Button();
            this.button_przegladaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
            // 
            // button_logowanie
            // 
            this.button_logowanie.Location = new System.Drawing.Point(786, 106);
            this.button_logowanie.Name = "button_logowanie";
            this.button_logowanie.Size = new System.Drawing.Size(159, 48);
            this.button_logowanie.TabIndex = 2;
            this.button_logowanie.Text = "ZALOGUJ SIĘ";
            this.button_logowanie.UseVisualStyleBackColor = true;
            this.button_logowanie.Click += new System.EventHandler(this.button_logowanie_Click);
            // 
            // button_zamknij
            // 
            this.button_zamknij.Location = new System.Drawing.Point(12, 423);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(159, 50);
            this.button_zamknij.TabIndex = 3;
            this.button_zamknij.Text = "ZAMKNIJ APLIKACJE";
            this.button_zamknij.UseVisualStyleBackColor = true;
            // 
            // button_przegladaj
            // 
            this.button_przegladaj.Location = new System.Drawing.Point(12, 172);
            this.button_przegladaj.Name = "button_przegladaj";
            this.button_przegladaj.Size = new System.Drawing.Size(159, 52);
            this.button_przegladaj.TabIndex = 4;
            this.button_przegladaj.Text = "PRZEGLĄDAJ KSIĄŻKI";
            this.button_przegladaj.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "ROBOCZY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(957, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_przegladaj);
            this.Controls.Add(this.button_zamknij);
            this.Controls.Add(this.button_logowanie);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_logowanie;
        private System.Windows.Forms.Button button_zamknij;
        private System.Windows.Forms.Button button_przegladaj;
        private System.Windows.Forms.Button button2;
    }
}

