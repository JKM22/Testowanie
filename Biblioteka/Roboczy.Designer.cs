namespace Biblioteka
{
    partial class Roboczy
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
            this.buttonGoToAddUser = new System.Windows.Forms.Button();
            this.buttonGoToModUser = new System.Windows.Forms.Button();
            this.buttonGoToSearchUser = new System.Windows.Forms.Button();
            this.buttonGoToDelUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoToAddUser
            // 
            this.buttonGoToAddUser.Location = new System.Drawing.Point(25, 25);
            this.buttonGoToAddUser.Name = "buttonGoToAddUser";
            this.buttonGoToAddUser.Size = new System.Drawing.Size(192, 40);
            this.buttonGoToAddUser.TabIndex = 0;
            this.buttonGoToAddUser.Text = "Dodawanie użytkowników";
            this.buttonGoToAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonGoToModUser
            // 
            this.buttonGoToModUser.Location = new System.Drawing.Point(25, 86);
            this.buttonGoToModUser.Name = "buttonGoToModUser";
            this.buttonGoToModUser.Size = new System.Drawing.Size(192, 41);
            this.buttonGoToModUser.TabIndex = 1;
            this.buttonGoToModUser.Text = "Modyfikacja użytkowników";
            this.buttonGoToModUser.UseVisualStyleBackColor = true;
            // 
            // buttonGoToSearchUser
            // 
            this.buttonGoToSearchUser.Location = new System.Drawing.Point(25, 150);
            this.buttonGoToSearchUser.Name = "buttonGoToSearchUser";
            this.buttonGoToSearchUser.Size = new System.Drawing.Size(192, 43);
            this.buttonGoToSearchUser.TabIndex = 2;
            this.buttonGoToSearchUser.Text = "Wyszukiwanie użytkowników";
            this.buttonGoToSearchUser.UseVisualStyleBackColor = true;
            this.buttonGoToSearchUser.Click += new System.EventHandler(this.buttonGoToSearchUser_Click);
            // 
            // buttonGoToDelUser
            // 
            this.buttonGoToDelUser.Location = new System.Drawing.Point(25, 217);
            this.buttonGoToDelUser.Name = "buttonGoToDelUser";
            this.buttonGoToDelUser.Size = new System.Drawing.Size(192, 42);
            this.buttonGoToDelUser.TabIndex = 3;
            this.buttonGoToDelUser.Text = "Usuwanie użytkowników";
            this.buttonGoToDelUser.UseVisualStyleBackColor = true;
            // 
            // Roboczy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(243, 338);
            this.Controls.Add(this.buttonGoToDelUser);
            this.Controls.Add(this.buttonGoToSearchUser);
            this.Controls.Add(this.buttonGoToModUser);
            this.Controls.Add(this.buttonGoToAddUser);
            this.Name = "Roboczy";
            this.Text = "Roboczy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToAddUser;
        private System.Windows.Forms.Button buttonGoToModUser;
        private System.Windows.Forms.Button buttonGoToSearchUser;
        private System.Windows.Forms.Button buttonGoToDelUser;
    }
}