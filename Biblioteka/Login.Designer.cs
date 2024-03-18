namespace Biblioteka
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoginPass = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGoToRegistration = new System.Windows.Forms.Button();
            this.button_wroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // textBoxLoginLog
            // 
            this.textBoxLoginLog.Location = new System.Drawing.Point(72, 51);
            this.textBoxLoginLog.Name = "textBoxLoginLog";
            this.textBoxLoginLog.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginLog.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "hasło";
            // 
            // textBoxLoginPass
            // 
            this.textBoxLoginPass.Location = new System.Drawing.Point(72, 91);
            this.textBoxLoginPass.Name = "textBoxLoginPass";
            this.textBoxLoginPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginPass.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(72, 138);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(89, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonGoToRegistration
            // 
            this.buttonGoToRegistration.Location = new System.Drawing.Point(72, 167);
            this.buttonGoToRegistration.Name = "buttonGoToRegistration";
            this.buttonGoToRegistration.Size = new System.Drawing.Size(89, 34);
            this.buttonGoToRegistration.TabIndex = 5;
            this.buttonGoToRegistration.Text = "Zarejestruj się";
            this.buttonGoToRegistration.UseVisualStyleBackColor = true;
            this.buttonGoToRegistration.Click += new System.EventHandler(this.buttonGoToRegistration_Click);
            // 
            // button_wroc
            // 
            this.button_wroc.Location = new System.Drawing.Point(12, 265);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(75, 23);
            this.button_wroc.TabIndex = 6;
            this.button_wroc.Text = "WRÓĆ";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.button_wroc_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(246, 349);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.buttonGoToRegistration);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxLoginPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLoginLog);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLoginPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonGoToRegistration;
        private System.Windows.Forms.Button button_wroc;
    }
}