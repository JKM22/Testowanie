namespace Biblioteka
{
    partial class DodajUprawnienia
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
            this.button_Wroc = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_Zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Wroc
            // 
            this.button_Wroc.Location = new System.Drawing.Point(651, 376);
            this.button_Wroc.Name = "button_Wroc";
            this.button_Wroc.Size = new System.Drawing.Size(137, 53);
            this.button_Wroc.TabIndex = 0;
            this.button_Wroc.Text = "Wróć";
            this.button_Wroc.UseVisualStyleBackColor = true;
            this.button_Wroc.Click += new System.EventHandler(this.button_Wroc_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(81, 102);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(525, 221);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button_Zatwierdz
            // 
            this.button_Zatwierdz.Location = new System.Drawing.Point(651, 316);
            this.button_Zatwierdz.Name = "button_Zatwierdz";
            this.button_Zatwierdz.Size = new System.Drawing.Size(137, 41);
            this.button_Zatwierdz.TabIndex = 2;
            this.button_Zatwierdz.Text = "ZATWIERDŹ";
            this.button_Zatwierdz.UseVisualStyleBackColor = true;
            this.button_Zatwierdz.Click += new System.EventHandler(this.button_Zatwierdz_Click);
            // 
            // DodajUprawnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Zatwierdz);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Wroc);
            this.Name = "DodajUprawnienia";
            this.Text = "DodajUprawnienia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Wroc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_Zatwierdz;
    }
}