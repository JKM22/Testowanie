using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Biblioteka
{
    public partial class DodajUzytkownika : KryptonForm
    {
        public DodajUzytkownika()
        {
            InitializeComponent();
        }
        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public void button_dodaj_Click(object sender, EventArgs e)
        {
            string imie = textBox_dodajimie.Text;
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
            string haslo = CalculateMD5Hash(textBox_dodajhaslo.Text); // Haszowanie hasła


            string plec = "";
            if (checkBox_kobieta.Checked)
            {
                plec = "Kobieta";
            }
            else if (checkBox_mezczyzna.Checked)
            {
                plec = "Mężczyzna";
            }
            

            DodajUsunWyszukajKlasa dodajUzytkownikaKlasa = new DodajUsunWyszukajKlasa();

            if (!IsValidPesel(pesel, plec))
            {
                MessageBox.Show("Nieprawidłowy numer PESEL.");
                return;
            }

            // Walidacja e-mail
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Nieprawidłowy adres e-mail.");
                return;
            }

            // Walidacja loginu
            if (!IsValidLogin(login))
            {
                MessageBox.Show("Nieprawidłowy login.");
                return;
            }

            // Walidacja pozostałych pól
            if (!dodajUzytkownikaKlasa.WalidujDane(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, nrPosesji, pesel, dataUrodzenia, login, haslo))
            {
                MessageBox.Show("Proszę wypełnić wszystkie wymagane pola poprawnie.");
                return;
            }
            try
            {
                dodajUzytkownikaKlasa.DodajUzytkownika(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, plec, login, haslo);
                MessageBox.Show("Użytkownik został dodany do bazy danych.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się dodać użytkownika do bazy danych. Błąd: " + ex.Message);
            }
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
            bool isMale = !isFemale;
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


        private void checkBox_kobieta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kobieta.Checked)
            {
                checkBox_mezczyzna.Checked = false;
            }
        }

        private void checkBox_mezczyzna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mezczyzna.Checked)
            {
                checkBox_kobieta.Checked = false;
            }
        }

        private void button_wroc_Click(object sender, EventArgs e)
        {
            Roboczy roboczy = new Roboczy();
            roboczy.Show();
            this.Hide();
        }

     

        private void DodajUzytkownika_Load(object sender, EventArgs e)
        {

        }

        private void button_anuluj_Click_1(object sender, EventArgs e)
        {
            textBox_dodajimie.Clear();
            textBox_dodajnazwisko.Clear();
            textBox_dodajemail.Clear();
            textBox_dodajtelefon.Clear();
            textBox_miejscowosc.Clear();
            textBox_dodajkod.Clear();
            textBox_dodajulice.Clear();
            textBox_dodajnumerposesji.Clear();
            textBox_dodajnumerlokalu.Clear();
            textBox_dodajpesel.Clear();
            dateTimePicker_dodajdata.Value = DateTime.Now;
            textBox_dodajlogin.Clear();
            textBox_dodajhaslo.Clear();

            checkBox_kobieta.Checked = false;
            checkBox_mezczyzna.Checked = false;

        }

    }
    }

