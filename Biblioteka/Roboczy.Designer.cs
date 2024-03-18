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
            this.button_wyszukaj = new System.Windows.Forms.Button();
            this.buttonGoToDelUser = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_wroc = new System.Windows.Forms.Button();
            this.textBox_wyszukaj = new System.Windows.Forms.TextBox();
            this.button_odwiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoToAddUser
            // 
            this.buttonGoToAddUser.Location = new System.Drawing.Point(12, 24);
            this.buttonGoToAddUser.Name = "buttonGoToAddUser";
            this.buttonGoToAddUser.Size = new System.Drawing.Size(192, 40);
            this.buttonGoToAddUser.TabIndex = 0;
            this.buttonGoToAddUser.Text = "DODAJ UŻYTKOWNIKA";
            this.buttonGoToAddUser.UseVisualStyleBackColor = true;
            this.buttonGoToAddUser.Click += new System.EventHandler(this.buttonGoToAddUser_Click);
            // 
            // buttonGoToModUser
            // 
            this.buttonGoToModUser.Location = new System.Drawing.Point(12, 70);
            this.buttonGoToModUser.Name = "buttonGoToModUser";
            this.buttonGoToModUser.Size = new System.Drawing.Size(192, 41);
            this.buttonGoToModUser.TabIndex = 1;
            this.buttonGoToModUser.Text = "MODYFIKUJ DANE";
            this.buttonGoToModUser.UseVisualStyleBackColor = true;
            this.buttonGoToModUser.Click += new System.EventHandler(this.buttonGoToModUser_Click);
            // 
            // button_wyszukaj
            // 
            this.button_wyszukaj.Location = new System.Drawing.Point(804, 24);
            this.button_wyszukaj.Name = "button_wyszukaj";
            this.button_wyszukaj.Size = new System.Drawing.Size(130, 25);
            this.button_wyszukaj.TabIndex = 2;
            this.button_wyszukaj.Text = "WYSZUKAJ";
            this.button_wyszukaj.UseVisualStyleBackColor = true;
            this.button_wyszukaj.Click += new System.EventHandler(this.button_wyszukaj_Click_1);
            // 
            // buttonGoToDelUser
            // 
            this.buttonGoToDelUser.Location = new System.Drawing.Point(12, 117);
            this.buttonGoToDelUser.Name = "buttonGoToDelUser";
            this.buttonGoToDelUser.Size = new System.Drawing.Size(192, 42);
            this.buttonGoToDelUser.TabIndex = 3;
            this.buttonGoToDelUser.Text = "USUŃ UŻYTKOWNIKA";
            this.buttonGoToDelUser.UseVisualStyleBackColor = true;
            this.buttonGoToDelUser.Click += new System.EventHandler(this.buttonGoToDelUser_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 165);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(919, 313);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button_wroc
            // 
            this.button_wroc.Location = new System.Drawing.Point(13, 504);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(191, 36);
            this.button_wroc.TabIndex = 5;
            this.button_wroc.Text = "WRÓĆ";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.button_wroc_Click);
            // 
            // textBox_wyszukaj
            // 
            this.textBox_wyszukaj.Location = new System.Drawing.Point(612, 27);
            this.textBox_wyszukaj.Name = "textBox_wyszukaj";
            this.textBox_wyszukaj.Size = new System.Drawing.Size(186, 20);
            this.textBox_wyszukaj.TabIndex = 6;
            // 
            // button_odwiez
            // 
            this.button_odwiez.Location = new System.Drawing.Point(804, 55);
            this.button_odwiez.Name = "button_odwiez";
            this.button_odwiez.Size = new System.Drawing.Size(130, 23);
            this.button_odwiez.TabIndex = 7;
            this.button_odwiez.Text = "ODŚWIEŻ";
            this.button_odwiez.UseVisualStyleBackColor = true;
            this.button_odwiez.Click += new System.EventHandler(this.button_odwiez_Click);
            // 
            // Roboczy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(946, 552);
            this.Controls.Add(this.button_odwiez);
            this.Controls.Add(this.textBox_wyszukaj);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonGoToDelUser);
            this.Controls.Add(this.button_wyszukaj);
            this.Controls.Add(this.buttonGoToModUser);
            this.Controls.Add(this.buttonGoToAddUser);
            this.Name = "Roboczy";
            this.Text = "Roboczy";
            this.Load += new System.EventHandler(this.Roboczy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToAddUser;
        private System.Windows.Forms.Button buttonGoToModUser;
        private System.Windows.Forms.Button button_wyszukaj;
        private System.Windows.Forms.Button buttonGoToDelUser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_wroc;
        private System.Windows.Forms.TextBox textBox_wyszukaj;
        private System.Windows.Forms.Button button_odwiez;
    }
}