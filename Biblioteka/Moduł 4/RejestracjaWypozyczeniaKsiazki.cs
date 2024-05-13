using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Moduł_4
{
    public partial class RejestracjaWypozyczeniaKsiazki : Form
    {
        private WypozyczeniaKsiazekKlasa wypozyczeniaKsiazekKlasa = new WypozyczeniaKsiazekKlasa();
        public RejestracjaWypozyczeniaKsiazki()
        {
            InitializeComponent();
            textBox_okresWypozyczenia.Text = "14";

        }

        private void button_wypozycz_Click(object sender, EventArgs e)
        {
            if (CzyWszystkiePolaWypelnione())
            {
                string imie = textBox_imieWypozyczenie.Text;
                string nazwisko = textBox_nazwiskoWypozyczenie.Text;
                string adres = textBox_adresZamieszkaniaWypozyczenie.Text;
                string numerTelefonu = textBox_numerTelefonu.Text;
                int wypozyczonaKsiazkaId = Convert.ToInt32(textBox_idWypozyczonejKsiazki.Text);
                DateTime dataWypozyczenia = dateTimePicker_Wypozyczenie.Value;
                int okresWypozyczenia = Convert.ToInt32(textBox_okresWypozyczenia.Text);

                try
                {
                    // Oblicz datę zwrotu na podstawie daty wypożyczenia i okresu wypożyczenia (14 dni)
                    DateTime dataZwrotu = dataWypozyczenia.AddDays(okresWypozyczenia);

                    // Ustaw wartość DateTimePicker'a na obliczoną datę zwrotu
                    dateTimePicker2.Value = dataZwrotu;

                    // Wywołaj metodę DodajWypozyczenie z klasy WypozyczeniaKsiazekKlasa
                    wypozyczeniaKsiazekKlasa.DodajWypozyczenie(imie, nazwisko, adres, numerTelefonu, wypozyczonaKsiazkaId, dataWypozyczenia, okresWypozyczenia);

                    MessageBox.Show("Wypożyczenie zarejestrowane pomyślnie! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas zapisu do bazy danych: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
            }
        }

        private bool CzyWszystkiePolaWypelnione()
        {
            // Sprawdź, czy wszystkie pola tekstowe nie są puste
            return !string.IsNullOrWhiteSpace(textBox_imieWypozyczenie.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_nazwiskoWypozyczenie.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_adresZamieszkaniaWypozyczenie.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_numerTelefonu.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_idWypozyczonejKsiazki.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadzajBiblioteka = new ZarzadzajBiblioteka();
            zarzadzajBiblioteka.Show();
            this.Hide();
        }
    }
}

