﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonGoToRegistration_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_wroc_Click(object sender, EventArgs e)
        {
           
                Start start = new Start();
                start.Show();
                this.Hide();
            
        }
    }
}
