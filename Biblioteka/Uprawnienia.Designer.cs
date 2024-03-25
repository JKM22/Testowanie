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
            this.button_PrzegladajUprawnienia = new System.Windows.Forms.Button();
            this.button_NadajUprawnienia = new System.Windows.Forms.Button();
            this.button_PrzegladajUzytkownikow = new System.Windows.Forms.Button();
            this.button_Wroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_PrzegladajUprawnienia
            // 
            this.button_PrzegladajUprawnienia.Location = new System.Drawing.Point(41, 12);
            this.button_PrzegladajUprawnienia.Name = "button_PrzegladajUprawnienia";
            this.button_PrzegladajUprawnienia.Size = new System.Drawing.Size(180, 74);
            this.button_PrzegladajUprawnienia.TabIndex = 0;
            this.button_PrzegladajUprawnienia.Text = "PRZEGLĄDAJ UPRAWNIENIA";
            this.button_PrzegladajUprawnienia.UseVisualStyleBackColor = true;
            this.button_PrzegladajUprawnienia.Click += new System.EventHandler(this.button_PrzegladajUprawnienia_Click);
            // 
            // button_NadajUprawnienia
            // 
            this.button_NadajUprawnienia.Location = new System.Drawing.Point(41, 116);
            this.button_NadajUprawnienia.Name = "button_NadajUprawnienia";
            this.button_NadajUprawnienia.Size = new System.Drawing.Size(180, 65);
            this.button_NadajUprawnienia.TabIndex = 1;
            this.button_NadajUprawnienia.Text = "NADAJ UPRAWNIENIA";
            this.button_NadajUprawnienia.UseVisualStyleBackColor = true;
            this.button_NadajUprawnienia.Click += new System.EventHandler(this.button_NadajUprawnienia_Click);
            // 
            // button_PrzegladajUzytkownikow
            // 
            this.button_PrzegladajUzytkownikow.Location = new System.Drawing.Point(50, 206);
            this.button_PrzegladajUzytkownikow.Name = "button_PrzegladajUzytkownikow";
            this.button_PrzegladajUzytkownikow.Size = new System.Drawing.Size(171, 98);
            this.button_PrzegladajUzytkownikow.TabIndex = 2;
            this.button_PrzegladajUzytkownikow.Text = "PRZEGLĄDAJ UŻYTKOWNIKÓW Z DANYM UPRAWNIENIEM";
            this.button_PrzegladajUzytkownikow.UseVisualStyleBackColor = true;
            this.button_PrzegladajUzytkownikow.Click += new System.EventHandler(this.button_PrzegladajUzytkownikow_Click);
            // 
            // button_Wroc
            // 
            this.button_Wroc.Location = new System.Drawing.Point(682, 328);
            this.button_Wroc.Name = "button_Wroc";
            this.button_Wroc.Size = new System.Drawing.Size(78, 41);
            this.button_Wroc.TabIndex = 3;
            this.button_Wroc.Text = "WRÓĆ";
            this.button_Wroc.UseVisualStyleBackColor = true;
            this.button_Wroc.Click += new System.EventHandler(this.button_Wroc_Click);
            // 
            // Uprawnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Wroc);
            this.Controls.Add(this.button_PrzegladajUzytkownikow);
            this.Controls.Add(this.button_NadajUprawnienia);
            this.Controls.Add(this.button_PrzegladajUprawnienia);
            this.Name = "Uprawnienia";
            this.Text = "Uprawnienia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PrzegladajUprawnienia;
        private System.Windows.Forms.Button button_NadajUprawnienia;
        private System.Windows.Forms.Button button_PrzegladajUzytkownikow;
        private System.Windows.Forms.Button button_Wroc;
    }
}