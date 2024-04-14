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
    public partial class Start : KryptonForm
    {
        private bool isUserLoggedIn = false;
        private bool isAdmin = false;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            // Sprawdzanie czy użytkownik jest zalogowany
            if (!isUserLoggedIn)
            {
                DisableAllOptions();
            }
        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            if (!isUserLoggedIn)
            {
                Login login = new Login();
                login.ShowDialog();

                if (login.LoginSuccessful)
                {
                    isUserLoggedIn = true;
                    isAdmin = login.IsAdmin;
                    EnableOptions();
                }
            }
            else
            {
                MessageBox.Show("Jesteś już zalogowany!");
            }
        }

        private void uzytkownicy_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && (isAdmin || HasPermission("Modyfikacja użytkownika")))
            {
                Roboczy roboczy = new Roboczy();
                roboczy.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz wystarczających uprawnień!");
            }
        }

        private void uprawnienia_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && (isAdmin || HasPermission("Zmień uprawnienia")))
            {
                Uprawnienia uprawnienia = new Uprawnienia();
                uprawnienia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz wystarczających uprawnień!");
            }
        }

        private void wyloguj_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                isUserLoggedIn = false;
                isAdmin = false;
                DisableAllOptions();
            }
            else
            {
                MessageBox.Show("Nie jesteś zalogowany!");
            }
        }

        private void DisableAllOptions()
        {
            uzytkownicy.Enabled = false;
            uprawnienia.Enabled = false;
            wyloguj.Enabled = false;
        }

        private void EnableOptions()
        {
            uzytkownicy.Enabled = true;
            uprawnienia.Enabled = true;
            wyloguj.Enabled = true;
        }

        private bool HasPermission(string permission)
        {
            // Sprawdzenie czy użytkownik ma konkretne uprawnienie
            // Tymczasowo zwraca true dla demonstracji
            return true;
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
