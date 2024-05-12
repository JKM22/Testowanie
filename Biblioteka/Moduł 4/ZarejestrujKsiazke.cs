using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Biblioteka.Moduł_4
{
    public partial class ZarejestrujKsiazke : Form
    {
        public ZarejestrujKsiazke()
        {
            InitializeComponent();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadzajBiblioteka = new ZarzadzajBiblioteka();
            zarzadzajBiblioteka.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz dane z formularza
            string tytul = textBox_Tytul.Text;
            string autor = textBox_Autor.Text;
            string gatunek = textBox_Gatunek.Text;
            int liczbaStron = (int)numericUpDown_LiczbaStron.Value;
            string wydawnictwo = textBox_Wydawnictwo.Text;
            int rokWydania = (int)numericUpDown_RokWydania.Value;
            decimal cena = numericUpDown_Cena.Value;
            int liczbaSztuk = (int)numericUpDown_LiczbaSztuk.Value;
            string opis = textBox_Opis.Text;

            if (string.IsNullOrEmpty(tytul) ||
        string.IsNullOrEmpty(autor) ||
        string.IsNullOrEmpty(gatunek) ||
        string.IsNullOrEmpty(wydawnictwo) ||
        liczbaStron <= 0 ||
        rokWydania <= 0 ||
        cena <= 0 ||
        liczbaSztuk <= 0)
            {
                MessageBox.Show("Aby zarejestrować książkę wypełnij wszystkie pola formularza",
                                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Zakończ metodę, nie wykonuj operacji na bazie danych
            }

            try
            {
                // Jeśli dane są poprawne, dodaj książkę
                ZarzadzajBibliotekaKlasa zarzadzajBibliotekaKlasa = new ZarzadzajBibliotekaKlasa();
                zarzadzajBibliotekaKlasa.DodajKsiazke(tytul, autor, gatunek, opis, liczbaStron, wydawnictwo, rokWydania, cena, liczbaSztuk);

                // Wyświetl komunikat o powodzeniu
                MessageBox.Show("Książka została pomyślnie dodana do bazy danych.", "Sukces",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcjonalnie wyczyść pola formularza po dodaniu książki
                textBox_Tytul.Text = "";
                textBox_Autor.Text = "";
                textBox_Gatunek.Text = "";
                numericUpDown_LiczbaStron.Value = 0;
                textBox_Wydawnictwo.Text = "";
                numericUpDown_RokWydania.Value = DateTime.Now.Year;
                numericUpDown_Cena.Value = 0;
                numericUpDown_LiczbaSztuk.Value = 0;
                textBox_Opis.Text = "";
            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show($"Wystąpił błąd podczas dodawania książki: {ex.Message}", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}