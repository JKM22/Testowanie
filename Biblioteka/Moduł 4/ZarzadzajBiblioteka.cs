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
namespace Biblioteka.Moduł_4
{
    public partial class ZarzadzajBiblioteka : KryptonForm
    {
        private bool isUserLoggedIn = false;
        private bool isAdmin = false;
        private int userId;

        public ZarzadzajBiblioteka()
        {
            InitializeComponent();
            ConfigureButtonAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
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

        private void ConfigureButtonAccess()
        {
            // Pobierz ID zalogowanego użytkownika
            userId = PolaczenieBazyKlasa.ZalogowanyUzytkownikId;
            isUserLoggedIn = PolaczenieBazyKlasa.Zalogowany;

            // Sprawdź, czy użytkownik ma odpowiednie uprawnienia do poszczególnych przycisków
            button_RejestracjaKsiazek.Enabled = HasPermission("Bibliotekarz");
            button_listaKsiazek.Enabled = HasPermission("Bibliotekarz") || HasPermission("Manager");
            button_PrzegladajRejestracjaKsiazki.Enabled = HasPermission("Manager");
            button_rejestracjaWtpozyczenia.Enabled = HasPermission("Bibliotekarz");
            button_listaWypozyczen.Enabled= HasPermission("Bibliotekarz") || HasPermission("Manager");
        }

        private void button_RejestracjaKsiazek_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && HasPermission("Bibliotekarz"))
            {
                ZarejestrujKsiazke zarejestrujKsiazke = new ZarejestrujKsiazke();
                zarejestrujKsiazke.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz odpowiednich uprawnień do rejestracji książek.", "Brak uprawnień",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_listaKsiazek_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && (HasPermission("Bibliotekarz") || HasPermission("Manager")))
            {
                ListaKsiazek listaKsiazek = new ListaKsiazek();
                listaKsiazek.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz odpowiednich uprawnień do przeglądania listy książek.", "Brak uprawnień",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_PrzegladajRejestracjaKsiazki_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && HasPermission("Manager"))
            {
                ListaRejestracjiKsiazek listaRejestracjiKsiazki_ = new ListaRejestracjiKsiazek();
                listaRejestracjiKsiazki_.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz odpowiednich uprawnień do przeglądania rejestracji książek.", "Brak uprawnień",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_rejestracjaWtpozyczenia_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && HasPermission("Bibliotekarz"))
            {
                RejestracjaWypozyczeniaKsiazki rejestracjaWypozyczeniaKsiazki = new RejestracjaWypozyczeniaKsiazki();
                rejestracjaWypozyczeniaKsiazki.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz odpowiednich uprawnień do przeglądania rejestracji wyzpożyczeń.", "Brak uprawnień",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_listaWypozyczen_Click(object sender, EventArgs e)
        {
            if (isUserLoggedIn && (HasPermission("Bibliotekarz") || HasPermission("Manager")))
            {
                ListaWypozyczen listaWypozyczen = new ListaWypozyczen();
                listaWypozyczen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie masz odpowiednich uprawnień do przeglądania listy rejestracji wyzpożyczeń.", "Brak uprawnień",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
