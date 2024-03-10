namespace Biblioteka
{
    partial class Registration
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
            this.textBoxRegistrationLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRegistrationPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegistrationPass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegistrationName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRegistrationSur = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRegistrate = new System.Windows.Forms.Button();
            this.buttonGoToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "login";
            // 
            // textBoxRegistrationLog
            // 
            this.textBoxRegistrationLog.Location = new System.Drawing.Point(108, 19);
            this.textBoxRegistrationLog.Name = "textBoxRegistrationLog";
            this.textBoxRegistrationLog.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationLog.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "hasło";
            // 
            // textBoxRegistrationPass
            // 
            this.textBoxRegistrationPass.Location = new System.Drawing.Point(108, 54);
            this.textBoxRegistrationPass.Name = "textBoxRegistrationPass";
            this.textBoxRegistrationPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "powtórz hasło";
            // 
            // textBoxRegistrationPass2
            // 
            this.textBoxRegistrationPass2.Location = new System.Drawing.Point(108, 87);
            this.textBoxRegistrationPass2.Name = "textBoxRegistrationPass2";
            this.textBoxRegistrationPass2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationPass2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "imię";
            // 
            // textBoxRegistrationName
            // 
            this.textBoxRegistrationName.Location = new System.Drawing.Point(108, 123);
            this.textBoxRegistrationName.Name = "textBoxRegistrationName";
            this.textBoxRegistrationName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "nazwisko";
            // 
            // textBoxRegistrationSur
            // 
            this.textBoxRegistrationSur.Location = new System.Drawing.Point(108, 157);
            this.textBoxRegistrationSur.Name = "textBoxRegistrationSur";
            this.textBoxRegistrationSur.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationSur.TabIndex = 10;
            // 
            // textBoxRegistrationMail
            // 
            this.textBoxRegistrationMail.Location = new System.Drawing.Point(108, 193);
            this.textBoxRegistrationMail.Name = "textBoxRegistrationMail";
            this.textBoxRegistrationMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationMail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "e-mail";
            // 
            // buttonRegistrate
            // 
            this.buttonRegistrate.Location = new System.Drawing.Point(133, 229);
            this.buttonRegistrate.Name = "buttonRegistrate";
            this.buttonRegistrate.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrate.TabIndex = 13;
            this.buttonRegistrate.Text = "Zarejestruj";
            this.buttonRegistrate.UseVisualStyleBackColor = true;
            // 
            // buttonGoToLogin
            // 
            this.buttonGoToLogin.Location = new System.Drawing.Point(165, 306);
            this.buttonGoToLogin.Name = "buttonGoToLogin";
            this.buttonGoToLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToLogin.TabIndex = 14;
            this.buttonGoToLogin.Text = "Zaloguj się";
            this.buttonGoToLogin.UseVisualStyleBackColor = true;
            this.buttonGoToLogin.Click += new System.EventHandler(this.buttonGoToLogin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(252, 341);
            this.Controls.Add(this.buttonGoToLogin);
            this.Controls.Add(this.buttonRegistrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRegistrationMail);
            this.Controls.Add(this.textBoxRegistrationSur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRegistrationName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRegistrationPass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRegistrationPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRegistrationLog);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegistrationLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRegistrationPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegistrationPass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegistrationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRegistrationSur;
        private System.Windows.Forms.TextBox textBoxRegistrationMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRegistrate;
        private System.Windows.Forms.Button buttonGoToLogin;
    }
}