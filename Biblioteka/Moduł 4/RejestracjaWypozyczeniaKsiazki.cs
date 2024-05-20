using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteka.Moduł_4
{
    public partial class RejestracjaWypozyczeniaKsiazki : Form
    {
        private WypozyczeniaKsiazekKlasa wypozyczeniaKsiazekKlasa = new WypozyczeniaKsiazekKlasa();
        public RejestracjaWypozyczeniaKsiazki()
        {
            InitializeComponent();
            textBox_okresWypozyczenia.Text = "14";
            listView1.FullRowSelect = true;

            listView1.View = View.Details;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Autor", 85);
            listView1.Columns.Add("Tytul", 85);
            listView1.Columns.Add("Status", 85);
            WybierzKsiazke();

            this.textBox_imieWypozyczenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_imieWypozyczenie_KeyPress);
            this.textBox_nazwiskoWypozyczenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nazwiskoWypozyczenie_KeyPress);
            this.textBox_adresZamieszkaniaWypozyczenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_adresZamieszkaniaWypozyczenie_KeyPress);
            this.textBox_numerTelefonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerTelefonu_KeyPress);
            this.textBox_okresWypozyczenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_okresWypozyczenia_KeyPress);


            dateTimePicker_Wypozyczenie.MinDate = DateTime.Today;
        }

        private void textBox_imieWypozyczenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }

        private void textBox_nazwiskoWypozyczenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }

        private void textBox_adresZamieszkaniaWypozyczenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, cyfrą, spacją, przecinkiem, kropką lub klawiszem Backspace
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }

        private void textBox_numerTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest cyfrą lub klawiszem Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }

            // Sprawdź, czy liczba cyfr nie przekracza 9
            if (textBox_numerTelefonu.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli przekracza, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }


        private void textBox_okresWypozyczenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest cyfrą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }


        public void WybierzKsiazke()
        {
            WypozyczeniaKsiazekKlasa wypozyczeniaKsiazekKlasa = new WypozyczeniaKsiazekKlasa();
            wypozyczeniaKsiazekKlasa.WybierzKsiazke(listView1);
        }
        private void button_wypozycz_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy wszystkie pola są wypełnione
            if (CzyWszystkiePolaWypelnione())
            {
                // Sprawdź, czy została wybrana książka
                if (listView1.SelectedItems.Count > 0)
                {
                    // Pobierz dane z pól formularza
                    string imie = textBox_imieWypozyczenie.Text;
                    string nazwisko = textBox_nazwiskoWypozyczenie.Text;
                    string adres = textBox_adresZamieszkaniaWypozyczenie.Text;
                    string numerTelefonu = textBox_numerTelefonu.Text;
                    DateTime dataWypozyczenia = dateTimePicker_Wypozyczenie.Value;
                    int okresWypozyczenia = Convert.ToInt32(textBox_okresWypozyczenia.Text);
                    if (numerTelefonu.Length != 9)
                    {
                        MessageBox.Show("Numer telefonu musi składać się z dokładnie 9 cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Zakończ metodę, jeśli numer telefonu nie ma dokładnie 9 cyfr
                    }

                    // Pobierz wybraną książkę
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    int wypozyczonaKsiazkaId = Convert.ToInt32(selectedItem.SubItems[0].Text); // Pobierz ID książki

                    // Sprawdź status wybranej książki
                    string status = selectedItem.SubItems[3].Text; // Indeks 3 odpowiada kolumnie ze statusem

                    if (status == "Niedostępna")
                    {
                        // Wyświetl komunikat informujący użytkownika, że książka jest niedostępna
                        MessageBox.Show("Nie można wypożyczyć tej książki, ponieważ jest niedostępna.", "Komunikat",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Oblicz datę zwrotu
                        DateTime dataZwrotu = dataWypozyczenia.AddDays(okresWypozyczenia);
                        dateTimePicker2.Value = dataZwrotu;

                        try
                        {
                            // Wywołaj metodę DodajWypozyczenie z klasy WypozyczeniaKsiazekKlasa
                            wypozyczeniaKsiazekKlasa.DodajWypozyczenie(imie, nazwisko, adres, numerTelefonu, wypozyczonaKsiazkaId, dataWypozyczenia, okresWypozyczenia);

                            // Wyświetl komunikat o poprawnym zarejestrowaniu wypożyczenia
                            MessageBox.Show("Wypożyczenie zarejestrowane pomyślnie! ");
                            wypozyczeniaKsiazekKlasa.WybierzKsiazke(listView1);
                        }
                        catch (Exception ex)
                        {
                            // Wyświetl komunikat o błędzie zapisu do bazy danych
                            MessageBox.Show("Błąd podczas zapisu do bazy danych: " + ex.Message);
                        }
                    }
                }
                else
                {
                    // Wyświetl komunikat informujący użytkownika, że nie wybrano żadnej książki
                    MessageBox.Show("Proszę wybrać książkę do wypożyczenia.", "Komunikat",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Wyświetl komunikat informujący użytkownika, że nie wszystkie pola zostały wypełnione
                MessageBox.Show("Wypełnij wszystkie pola!", "Komunikat",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private bool CzyWszystkiePolaWypelnione()
        {
            // Sprawdź, czy wszystkie pola tekstowe nie są puste
            return !string.IsNullOrWhiteSpace(textBox_imieWypozyczenie.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_nazwiskoWypozyczenie.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_adresZamieszkaniaWypozyczenie.Text) &&
                   !string.IsNullOrWhiteSpace(textBox_numerTelefonu.Text);
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadzajBiblioteka = new ZarzadzajBiblioteka();
            zarzadzajBiblioteka.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wypozyczeniaKsiazekKlasa.WybierzKsiazke(listView1);

            textBox_imieWypozyczenie.Text = "";
            textBox_nazwiskoWypozyczenie.Text = "";
            textBox_adresZamieszkaniaWypozyczenie.Text = "";
            textBox_numerTelefonu.Text = "";

            dateTimePicker_Wypozyczenie.Text = "";
            dateTimePicker2.Text = "";
            textBox_okresWypozyczenia.Text = "14";
        }
    }
}

