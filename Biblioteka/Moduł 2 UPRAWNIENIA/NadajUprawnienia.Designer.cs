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
            this.button_Wroc = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Zatwierdz = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_usun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Wroc
            // 
            this.button_Wroc.Location = new System.Drawing.Point(867, 374);
            this.button_Wroc.Margin = new System.Windows.Forms.Padding(2);
            this.button_Wroc.Name = "button_Wroc";
            this.button_Wroc.Size = new System.Drawing.Size(76, 32);
            this.button_Wroc.TabIndex = 1;
            this.button_Wroc.Text = "WRÓĆ";
            this.button_Wroc.UseVisualStyleBackColor = true;
            this.button_Wroc.Click += new System.EventHandler(this.button_Wroc_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 206);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(600, 43);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(351, 206);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(594, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "UPRAWNIENIA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Zatwierdz
            // 
            this.button_Zatwierdz.Location = new System.Drawing.Point(600, 253);
            this.button_Zatwierdz.Margin = new System.Windows.Forms.Padding(2);
            this.button_Zatwierdz.Name = "button_Zatwierdz";
            this.button_Zatwierdz.Size = new System.Drawing.Size(351, 27);
            this.button_Zatwierdz.TabIndex = 6;
            this.button_Zatwierdz.Text = "DODAJ UPRAWNIENIE";
            this.button_Zatwierdz.UseVisualStyleBackColor = true;
            this.button_Zatwierdz.Click += new System.EventHandler(this.button_Zatwierdz_Click);
            // 
            // button_usun
            // 
            this.button_usun.Location = new System.Drawing.Point(444, 379);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(151, 27);
            this.button_usun.TabIndex = 7;
            this.button_usun.Text = "USUŃ UPRAWNIENIE";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(4, 309);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(434, 97);
            this.listView3.TabIndex = 8;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "UPRAWNIENIA UŻYTKOWNIKA";
            // 
            // textBox_usun
            // 
            this.textBox_usun.Location = new System.Drawing.Point(264, 286);
            this.textBox_usun.Name = "textBox_usun";
            this.textBox_usun.Size = new System.Drawing.Size(174, 20);
            this.textBox_usun.TabIndex = 11;
            // 
            // NadajUprawnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 417);
            this.Controls.Add(this.textBox_usun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.button_Zatwierdz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Wroc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NadajUprawnienia";
            this.Text = "NadajUprawnienia";
            this.Load += new System.EventHandler(this.NadajUprawnienia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Wroc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Zatwierdz;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_usun;
    }
}