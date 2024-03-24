using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button_dodaj_Click(object sender, EventArgs e)
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
            if (!dodajUzytkownikaKlasa.WalidujDane(imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, login, haslo))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola poprawnie.");
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

