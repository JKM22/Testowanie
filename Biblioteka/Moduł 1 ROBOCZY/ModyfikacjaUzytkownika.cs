using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Biblioteka
{
    public partial class ModyfikacjaUzytkownika : KryptonForm
    {
        private DodajUsunWyszukajKlasa dodajUzytkownikaKlasa;
        private ModyfikacjaUzytkownikaKlasa modyfikacjaUzytkownikaKlasa;
        private string id_uzytkownik;
        public ModyfikacjaUzytkownika(string id_uzytkownik, string imie, string nazwisko, string email, string telefon, string miejscowosc, string kodPocztowy, string ulica, string nrPosesji, string nrLokalu, string pesel, string dataUrodzenia, string plec, string login, string haslo)
        {
            InitializeComponent();

            // Inicjalizacja pól
            this.id_uzytkownik = id_uzytkownik;
            textBox_dodajimie2.Text = imie;
            textBox_dodajnazwisko.Text = nazwisko;
            textBox_dodajemail.Text = email;
            textBox_dodajtelefon.Text = telefon;
            textBox_miejscowosc.Text = miejscowosc;
            textBox_dodajkod.Text = kodPocztowy;
            textBox_dodajulice.Text = ulica;
            textBox_dodajnumerposesji.Text = nrPosesji;
            textBox_dodajnumerlokalu.Text = nrLokalu;
            textBox_dodajpesel.Text = pesel;
            dateTimePicker_dodajdata.Value = DateTime.ParseExact(dataUrodzenia, "yyyy-MM-dd", null);
            textBox_dodajlogin.Text = login;
            textBox_dodajhaslo.Text = haslo;


            // Inicjalizacja obiektów
            dodajUzytkownikaKlasa = new DodajUsunWyszukajKlasa();
            modyfikacjaUzytkownikaKlasa = new ModyfikacjaUzytkownikaKlasa();
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string imie = textBox_dodajimie2.Text;
            string nazwisko = textBox_dodajnazwisko.Text;
            string email = textBox_dodajemail.Text;
            string telefon = textBox_dodajtelefon.Text;
            string miejscowosc = textBox_miejscowosc.Text;
            string kodPocztowy = textBox_dodajkod.Text;
            string ulica = textBox_dodajulice.Text;
            string nrPosesji = textBox_dodajnumerposesji.Text;
            string nrLokalu = textBox_dodajnumerlokalu.Text;
            string pesel = textBox_dodajpesel.Text;
            string dataUrodzenia = dateTimePicker_dodajdata.Value.ToString("yyyy-MM-dd");
            string login = textBox_dodajlogin.Text;
            string haslo = textBox_dodajhaslo.Text;
            string plec = checkBox_mezczyzna.Checked ? "Mężczyzna" : "Kobieta";

            // Walidacja danych
            List<string> errors = new List<string>();

            // Walidacja PESEL
            if (!IsValidPesel(pesel, plec))
                errors.Add("Nieprawidłowy numer PESEL.");

            if (!IsValidPhoneNumber(telefon))
                errors.Add("Nieprawidłowy numer telefonu.");

            // Walidacja e-mail
            if (!IsValidEmail(email))
                errors.Add("Nieprawidłowy adres e-mail.");

            // Walidacja loginu
            if (!IsValidLogin(login))
                errors.Add("Nieprawidłowy login.");

            if (!IsValidPassword(haslo))
                errors.Add("Hasło nie spełnia warunków walidacji.");

            // Walidacja pozostałych pól
            if (!dodajUzytkownikaKlasa.WalidujDane(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, login, haslo))
                errors.Add("Proszę wypełnić wszystkie wymagane pola poprawnie.");

            if (errors.Any())
            {
                // Wyświetlenie komunikatu o błędach
                string errorMessage = string.Join(Environment.NewLine, errors);
                MessageBox.Show(errorMessage);
                return;
            }

            // Aktualizacja danych użytkownika
            try
            {
                modyfikacjaUzytkownikaKlasa.AktualizujDaneUzytkownika(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, plec, login, haslo, id_uzytkownik);
                //MessageBox.Show("Dane użytkownika zostały zaktualizowane.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zaktualizować danych użytkownika. Błąd: " + ex.Message);
            }
        }

        private bool IsValidPassword(string password)
        {
            // Sprawdzenie długości hasła
            if (password.Length < 8 || password.Length > 15)
            {
                return false;
            }

            // Sprawdzenie, czy hasło zawiera przynajmniej jedną dużą literę, małą literę, cyfrę i znak specjalny
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasUpperCase || !hasLowerCase || !hasDigit || !hasSpecialChar)
            {
                return false;
            }

            return true;
        }
        private bool IsValidPesel(string pesel, string plec)
        {
            // Sprawdzenie długości
            if (pesel.Length != 11)
                return false;

            // Sprawdzenie poprawności daty urodzenia
            int year, month, day;
            if (pesel[2] == '2' && (pesel[3] == '2' || pesel[3] == '3')) // Obsługa peseli z lat 2000+
            {
                year = 2000 + int.Parse(pesel.Substring(0, 2));
                month = int.Parse(pesel.Substring(2, 2)) - 20; // Poprawka na nowy sposób kodowania miesięcy
            }
            else
            {
                year = 1900 + int.Parse(pesel.Substring(0, 2));
                month = int.Parse(pesel.Substring(2, 2));
            }
            day = int.Parse(pesel.Substring(4, 2));

            // Sprawdzenie poprawności daty
            if (!IsValidDate(year, month, day))
                return false;

            // Sprawdzenie cyfry kontrolnej
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int checksum = 0;
            for (int i = 0; i < 10; i++)
            {
                checksum += int.Parse(pesel[i].ToString()) * weights[i];
            }
            int checksumMod = checksum % 10;
            int controlNumber = (10 - checksumMod) % 10;

            if (controlNumber != int.Parse(pesel[10].ToString()))
                return false; // Nieprawidłowa cyfra kontrolna



            int genderDigit = int.Parse(pesel[9].ToString());
            bool isFemale = genderDigit % 2 == 0;
            bool isMale = genderDigit % 2 != 0;
            Console.WriteLine(isMale);
            Console.WriteLine(isFemale);
            if ((isMale && plec != "Mężczyzna") || (isFemale && plec != "Kobieta"))
                return false; // Niezgodność płci



            return true;
        }

        private bool IsValidDate(int year, int month, int day)
        {
            if (year < 1800 || year > 2299 || month < 1 || month > 12)
                return false;

            int maxDay = DateTime.DaysInMonth(year, month);
            return day >= 1 && day <= maxDay;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Sprawdzenie czy numer telefonu ma dokładnie 9 cyfr
            if (phoneNumber.Length != 9)
                return false;

            // Sprawdzenie czy numer telefonu składa się tylko z cyfr
            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            // Numer telefonu jest poprawny
            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Sprawdzenie czy email nie jest pusty
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Sprawdzenie czy email zawiera dokładnie jeden znak '@'
            int atSignCount = email.Count(c => c == '@');
            if (atSignCount != 1)
                return false;

            // Podział emaila na część lokalną i domenę
            string[] parts = email.Split('@');
            string localPart = parts[0];
            string domainPart = parts[1];

            // Sprawdzenie czy długość emaila nie przekracza 255 znaków
            if (email.Length > 255)
                return false;

            // Sprawdzenie czy domena serwera poczty ma poprawną składnię
            string[] domainParts = domainPart.Split('.');
            if (domainParts.Length < 2)
                return false; // Brak domeny wyższego poziomu

            // Sprawdzenie czy domena serwera poczty zawiera tylko litery, cyfry, myślniki i kropki
            foreach (char c in domainPart)
            {
                if (!char.IsLetterOrDigit(c) && c != '-' && c != '.')
                    return false;
            }

            // Sprawdzenie czy część lokalna emaila nie zawiera niedozwolonych znaków
            foreach (char c in localPart)
            {
                if (!char.IsLetterOrDigit(c) && c != '.' && c != '!' && c != '#' && c != '$' && c != '%' && c != '&' && c != '\'' && c != '*' && c != '+' && c != '-' && c != '/' && c != '=' && c != '?' && c != '^' && c != '_' && c != '`' && c != '{' && c != '|' && c != '}' && c != '~')
                    return false;
            }

            // Sprawdzenie czy domena serwera poczty zawiera poprawną składnię
            if (!domainParts.All(part => part.Length > 0 && part.Length <= 63))
                return false; // Każda część domeny powinna mieć długość od 1 do 63 znaków

            // Sprawdzenie czy email spełnia wymagania
            return true;
        }

        private bool IsValidLogin(string login)
        {
            // Tutaj możesz sprawdzić unikalność loginu w systemie, np. korzystając z bazy danych
            // Jeśli login jest unikalny, zwróć true, w przeciwnym razie false
            return true;
        }

      

        private void ModyfikacjaUzytkownika_Load(object sender, EventArgs e)
        {

        }

        private void button_wroc_Click(object sender, EventArgs e)
        {
            Roboczy roboczy = new Roboczy();
            roboczy.Show();
            this.Hide();
        }
    }
}
