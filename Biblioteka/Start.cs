using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka.Moduł_4;
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

            EnableOptions(); // Włącz opcje dostępne dla zalogowanego użytkownika
        }

        private void LogoutUser()
        {
            isUserLoggedIn = false;
            isAdmin = false;
            userId = 0;
            DisableAllOptions(); // Wyłącz wszystkie opcje
        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            if (!isUserLoggedIn)
            {
                this.Hide();
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
                // Wyświetlenie komunikatu z pytaniem
                DialogResult result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Sprawdzenie wyboru użytkownika
                if (result == DialogResult.Yes)
                {
                    // Wyloguj użytkownika
                    PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
                    polaczenie.Wyloguj();

                    LogoutUser(); // Wyloguj użytkownika

                    // Otwórz okno logowania i ukryj obecne okno
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide(); // Ukryj obecne okno
                }
                // Jeśli użytkownik wybrał "Nie", wyświetlamy komunikat
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Anulowano wylogowywanie.");
                }
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
            button_ZarzadzajBiblioteka.Enabled = false;

        }

        private void EnableOptions()
        {
            uzytkownicy.Enabled = true;
            uprawnienia.Enabled = true;
            wyloguj.Enabled = true;
            button_ZarzadzajBiblioteka.Enabled = true;
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
            System.Windows.Forms.Application.Exit();
        }

        private void button_ZarzadzajBiblioteka_Click(object sender, EventArgs e)
        {
           
        }

        private void button_ZarzadzajBiblioteka_Click_1(object sender, EventArgs e)
        {

            // Pobierz ID zalogowanego użytkownika
            int id_uzytkownika = PolaczenieBazyKlasa.ZalogowanyUzytkownikId;
            if (isUserLoggedIn && (HasPermission("Bibliotekarz") || HasPermission("Manager")) && !HasPermission("Administrator"))


                if (isUserLoggedIn && (HasPermission("Bibliotekarz") || HasPermission("Manager")))
                {
                    ZarzadzajBiblioteka zarzadzajBiblioteka = new ZarzadzajBiblioteka();
                    zarzadzajBiblioteka.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Nie masz odpowiednich uprawnień do zarządzania biblioteką.", "Brak uprawnień",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}

