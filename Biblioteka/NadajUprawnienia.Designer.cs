namespace Biblioteka
{
    partial class NadajUprawnienia
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
            this.button_Wroc = new System.Windows.Forms.Button();
            this.button_DodajUprawnienie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(115, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(634, 276);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button_Wroc
            // 
            this.button_Wroc.Location = new System.Drawing.Point(784, 388);
            this.button_Wroc.Name = "button_Wroc";
            this.button_Wroc.Size = new System.Drawing.Size(114, 50);
            this.button_Wroc.TabIndex = 1;
            this.button_Wroc.Text = "WRÓĆ";
            this.button_Wroc.UseVisualStyleBackColor = true;
            this.button_Wroc.Click += new System.EventHandler(this.button_Wroc_Click);
            // 
            // button_DodajUprawnienie
            // 
            this.button_DodajUprawnienie.Location = new System.Drawing.Point(128, 35);
            this.button_DodajUprawnienie.Name = "button_DodajUprawnienie";
            this.button_DodajUprawnienie.Size = new System.Drawing.Size(319, 49);
            this.button_DodajUprawnienie.TabIndex = 2;
            this.button_DodajUprawnienie.Text = "DODAJ UPRAWNIENIE";
            this.button_DodajUprawnienie.UseVisualStyleBackColor = true;
            this.button_DodajUprawnienie.Click += new System.EventHandler(this.button_DodajUprawnienie_Click);
            // 
            // NadajUprawnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.button_DodajUprawnienie);
            this.Controls.Add(this.button_Wroc);
            this.Controls.Add(this.listView1);
            this.Name = "NadajUprawnienia";
            this.Text = "NadajUprawnienia";
            this.Load += new System.EventHandler(this.NadajUprawnienia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_Wroc;
        private System.Windows.Forms.Button button_DodajUprawnienie;
    }
}