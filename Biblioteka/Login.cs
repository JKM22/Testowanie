using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Biblioteka
{
    public partial class Login : KryptonForm
    {
        public bool LoginSuccessful { get; private set; }
        public bool IsAdmin { get; private set; }

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

        private void textBoxLoginLog_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            // Tutaj dodaj logikę sprawdzającą poprawność danych logowania
            // Na potrzeby demonstracji ustawiamy login zawsze jako udany
            LoginSuccessful = true;

            // Tutaj dodaj logikę sprawdzającą czy zalogowany użytkownik jest administratorem
            // Ustawiamy isAdmin na true dla demonstracji
            IsAdmin = true;

            if (LoginSuccessful)
            {
                MessageBox.Show("Zalogowano pomyślnie!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło. Spróbuj ponownie.");
            }
        }
    }
}
