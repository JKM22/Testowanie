namespace Biblioteka
{
    partial class Menu
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
            this.buttonGoToBooks = new System.Windows.Forms.Button();
            this.buttonGoToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoToBooks
            // 
            this.buttonGoToBooks.Location = new System.Drawing.Point(29, 25);
            this.buttonGoToBooks.Name = "buttonGoToBooks";
            this.buttonGoToBooks.Size = new System.Drawing.Size(106, 37);
            this.buttonGoToBooks.TabIndex = 0;
            this.buttonGoToBooks.Text = "Przeglądaj książki";
            this.buttonGoToBooks.UseVisualStyleBackColor = true;
            // 
            // buttonGoToLogin
            // 
            this.buttonGoToLogin.Location = new System.Drawing.Point(29, 95);
            this.buttonGoToLogin.Name = "buttonGoToLogin";
            this.buttonGoToLogin.Size = new System.Drawing.Size(106, 37);
            this.buttonGoToLogin.TabIndex = 1;
            this.buttonGoToLogin.Text = "Logowanie";
            this.buttonGoToLogin.UseVisualStyleBackColor = true;
            this.buttonGoToLogin.Click += new System.EventHandler(this.buttonGoToLogin_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoToLogin);
            this.Controls.Add(this.buttonGoToBooks);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToBooks;
        private System.Windows.Forms.Button buttonGoToLogin;
    }
}