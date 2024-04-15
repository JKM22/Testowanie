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
        private int userId;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            CheckSession();
            // Sprawdzanie czy użytkownik jest zalogowany
            if (!isUserLoggedIn)
            {
                DisableAllOptions();
            }
            else
            {
                EnableOptions();
            }

        }
        private void CheckSession()
        {
            if (!PolaczenieBazyKlasa.Zalogowany) // Jeśli użytkownik nie jest zalogowany, wyloguj
            {
                LogoutUser();
            }
            else // Jeśli użytkownik jest zalogowany, zaloguj go
            {
                LoginUser(PolaczenieBazyKlasa.ZalogowanyUzytkownikId, PolaczenieBazyKlasa.ZalogowanyUzytkownikLogin);
            }
        }

        private void LoginUser(int userId, string login)
        {
            isUserLoggedIn = true;
            this.userId = userId;

            // Pobierz uprawnienia użytkownika z bazy danych
            PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
            List<string> userPermissions = polaczenie.GetPermissionsForUser(userId);

            // Sprawdź, czy użytkownik ma uprawnienia administratora
            isAdmin = userPermissions.Contains("Administrator");

            RefreshStartView();

            MessageBox.Show("Zalogowano pomyślnie!");
        }

        private void LogoutUser()
        {
            isUserLoggedIn = false;
            isAdmin = false;
            userId = 0;
            RefreshStartView();

            MessageBox.Show("Wylogowano");
        }
        private void RefreshStartView()
        {
            if (isUserLoggedIn)
            {
                EnableOptions();
            }
            else
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

        private void wyloguj_Click_1(object sender, EventArgs e)
        {
            if (isUserLoggedIn)
            {
                // Wyloguj użytkownika
                PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
                polaczenie.Wyloguj();

                LogoutUser(); // Wyloguj użytkownika
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
            if (isAdmin) // Jeśli użytkownik jest administratorem, ma dostęp do wszystkich uprawnień
            {
                return true;
            }

            // Pobierz uprawnienia użytkownika z bazy danych
            PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
            List<string> userPermissions = polaczenie.GetPermissionsForUser(userId);


            // Sprawdź, czy użytkownik ma żądane uprawnienie
            return userPermissions.Contains(permission);
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        
    }
}
