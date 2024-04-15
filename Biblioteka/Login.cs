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
            PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
            string login = textBoxLoginLog.Text;
            string haslo = textBoxLoginPass.Text;

            if (polaczenie.SprawdzDaneLogowania(login, haslo))
            {
                // Zalogowano pomyślnie
                PolaczenieBazyKlasa.ZalogowanyUzytkownikId = PolaczenieBazyKlasa.ZalogowanyUzytkownikId;
                PolaczenieBazyKlasa.ZalogowanyUzytkownikLogin = login;

                LoginSuccessful = true;
                MessageBox.Show("Zalogowano pomyślnie!");
                IsAdmin = true;
                this.Close();
            }
            else
            {
                if (!polaczenie.CzyLoginPoprawny(login))
                {
                    // Błędny login
                    MessageBox.Show("Błędny login!");
                }
                else
                {
                    // Błędne hasło
                    MessageBox.Show("Błędne hasło!");
                }
            }
        }

    }
}
