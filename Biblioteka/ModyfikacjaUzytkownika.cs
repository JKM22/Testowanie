using System;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class ModyfikacjaUzytkownika : Form
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        private DodajUsunWyszukajKlasa dodajUzytkownikaKlasa;
        private ModyfikacjaUzytkownikaKlasa modyfikacjaUzytkownikaKlasa;
        private string id_uzytkownik; // Zmieniamy nazwę pola

        public ModyfikacjaUzytkownika(string id_uzytkownik, string imie, string nazwisko, string email, string telefon, string miejscowosc, string kodPocztowy, string ulica, string nrPosesji, string nrLokalu, string pesel, string dataUrodzenia, string plec, string login, string haslo)
        {
            InitializeComponent();

            this.id_uzytkownik = id_uzytkownik; // Zmieniamy nazwę pola

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
            if (plec == "Mężczyzna")
            {
                checkBox_mezczyzna.Checked = true;
                checkBox_kobieta.Checked = false;
            }
            else if (plec == "Kobieta")
            {
                checkBox_mezczyzna.Checked = false;
                checkBox_kobieta.Checked = true;
            }
            else
            {
                checkBox_mezczyzna.Checked = false;
                checkBox_kobieta.Checked = false;
            }

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

            string plec = "";
            if (checkBox_mezczyzna.Checked)
            {
                plec = "Mężczyzna";
            }
            else if (checkBox_kobieta.Checked)
            {
                plec = "Kobieta";
            }

            if (!dodajUzytkownikaKlasa.WalidujDane(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, login, haslo))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola poprawnie.");
                return;
            }

            modyfikacjaUzytkownikaKlasa.AktualizujDaneUzytkownika(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, plec, login, haslo, id_uzytkownik);
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
