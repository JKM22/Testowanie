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
        private int selectedBookId; // Deklaracja zmiennej selectedBookId
        private WyswietlKsiazki wyswietlKsiazki = new WyswietlKsiazki();

        public ZarejestrujKsiazke()
        {
            InitializeComponent();
            listView1.FullRowSelect = true; // Ustawienie FullRowSelect na true
            WyswietlListeKsiazek();
            WypelnijComboBoxStatus();
            button_edytuj.Enabled = false;


        }


        public void WyswietlListeKsiazek()
        {
            // Wywołanie metody WyswietlUprawnienia z klasy UprawnieniaKlasa
            wyswietlKsiazki.WyswietlListeKsiazek(listView1);
        }

        public void WypelnijComboBoxStatus()
        {
            wyswietlKsiazki.WypelnijComboBoxStatus(comboBox_status);
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

                WyswietlListeKsiazek();
            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show($"Wystąpił błąd podczas dodawania książki: {ex.Message}", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown_RokWydania_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Sprawdź, czy jakikolwiek wiersz jest zaznaczony
            if (listView1.SelectedItems.Count > 0)
            {
                button1.Enabled = false;
                // Pobierz pierwszy zaznaczony wiersz
                ListViewItem selectedRow = listView1.SelectedItems[0];
                selectedBookId = int.Parse(selectedRow.SubItems[0].Text);

                // Pobierz wartości kolumn zaznaczonego wiersza
                string tytul = selectedRow.SubItems[1].Text;
                string autor = selectedRow.SubItems[2].Text;
                string gatunek = selectedRow.SubItems[3].Text;
                string opis = selectedRow.SubItems[4].Text;
                string liczbaStron = selectedRow.SubItems[5].Text;
                string wydawnictwo = selectedRow.SubItems[6].Text;
                string rokWydania = selectedRow.SubItems[7].Text;
                string cena = selectedRow.SubItems[8].Text;
                string liczbaSztuk = selectedRow.SubItems[9].Text;

                // Wpisz pobrane wartości do textboxów
                textBox_Tytul.Text = tytul;
                textBox_Autor.Text = autor;
                textBox_Gatunek.Text = gatunek;
                textBox_Opis.Text = opis;
                numericUpDown_LiczbaStron.Value = int.Parse(liczbaStron);
                textBox_Wydawnictwo.Text = wydawnictwo;
                numericUpDown_RokWydania.Value = int.Parse(rokWydania);
                numericUpDown_Cena.Value = decimal.Parse(cena);
                numericUpDown_LiczbaSztuk.Value = int.Parse(liczbaSztuk);

                // Aktywuj przycisk "Edytuj"
                button_edytuj.Enabled = true;
            }
            else
            {
                button1.Enabled = true;

                button_edytuj.Enabled = false;

                // Wyczyść textboxy
                textBox_Tytul.Text = "";
                textBox_Autor.Text = "";
                textBox_Gatunek.Text = "";
                textBox_Opis.Text = "";
                numericUpDown_LiczbaStron.Value = 0;
                textBox_Wydawnictwo.Text = "";
                numericUpDown_RokWydania.Value = DateTime.Now.Year;
                numericUpDown_Cena.Value = 0;
                numericUpDown_LiczbaSztuk.Value = 0;

            }
        }



        private void ZarejestrujKsiazke_Load(object sender, EventArgs e)
        {
            // Ustaw widok kontrolki ListView na Details
            listView1.View = View.Details;

            // Dodaj kolumny do kontrolki ListView
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Tytuł", 150);
            listView1.Columns.Add("Autor", 100);
            listView1.Columns.Add("Gatunek", 100);
            listView1.Columns.Add("Opis", 200); // Dodaj kolumnę opisu
            listView1.Columns.Add("Liczba Stron", 80);
            listView1.Columns.Add("Wydawnictwo", 100);
            listView1.Columns.Add("Rok Wydania", 80);
            listView1.Columns.Add("Cena", 80);
            listView1.Columns.Add("Liczba Sztuk", 80);
            listView1.Columns.Add("Status", 100);

            // Wyświetl listę książek
            WyswietlListeKsiazek();
        }





        private void button_zarejestujksiazke_Click(object sender, EventArgs e)
        {
            // Upewnij się, że użytkownik wybrał książkę
            if (listView1.SelectedItems.Count > 0)
            {
                // Pobierz ID wybranej książki
                int selectedBookId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                try
                {
                    // Sprawdź, czy książka ma status "Dostępna"
                    string status = listView1.SelectedItems[0].SubItems[10].Text;
                    if (status == "Dostępna")
                    {
                        MessageBox.Show("Wybrana książka jest już zarejestrowana i ma status 'Dostępna'.", "Błąd",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Przerwij dalsze działanie metody
                    }

                    // Pobierz liczbę sztuk książki
                    int liczbaSztuk = int.Parse(listView1.SelectedItems[0].SubItems[9].Text);
                    if (liczbaSztuk == 0)
                    {
                        MessageBox.Show("Nie można ustawić statusu na 'Dostępna', ponieważ liczba sztuk wynosi 0.", "Błąd",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Przerwij dalsze działanie metody
                    }

                    // Zarejestruj książkę
                    int id_uzytkownika = 1; // Przykładowe ID zalogowanego użytkownika
                    KlasaListaRejestracjiKsiazek rejestracjaKsiazek = new KlasaListaRejestracjiKsiazek();
                    rejestracjaKsiazek.ZarejestrujKsiazke(selectedBookId, id_uzytkownika);

                    // Zmiana statusu książki na "Dostępna"
                    WyswietlKsiazki wyswietlKsiazki = new WyswietlKsiazki();
                    wyswietlKsiazki.AktualizujStatusKsiazki(selectedBookId, "Dostępna");

                    // Wyświetl komunikat o powodzeniu
                    MessageBox.Show("Status książki został pomyślnie zmieniony na 'Dostępna'.", "Sukces",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Odśwież listę książek
                    wyswietlKsiazki.WyswietlListeKsiazek(listView1);
                }
                catch (Exception ex)
                {
                    // Wyświetl komunikat o błędzie
                    MessageBox.Show($"Wystąpił błąd podczas rejestracji książki: {ex.Message}", "Błąd",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę, aby zmienić jej status.", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button_wyszukajstatus_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy wybrano jakąkolwiek wartość w comboboxie
            if (comboBox_status.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać status książki.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Zakończ metodę, jeśli nic nie jest wybrane
            }

            // Pobierz wybraną wartość z comboBox_status
            string selectedStatus = comboBox_status.SelectedItem.ToString();

        }

        private void button_odswiezstatus_Click(object sender, EventArgs e)
        {
            // Wywołaj metodę do odświeżenia listy książek
            WyswietlListeKsiazek();

            // Wyzeruj wybór w comboboxie
            comboBox_status.SelectedIndex = -1;

        }

        private void button_cofnijrejestracje_Click(object sender, EventArgs e)
        {

            // Upewnij się, że użytkownik wybrał książkę
            if (listView1.SelectedItems.Count > 0)
            {
                // Pobierz ID wybranej książki
                int selectedBookId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                try
                {

                    string status = listView1.SelectedItems[0].SubItems[10].Text;

                    // Sprawdź, czy książka ma status "Dostępna"
                    if (status == "Niedostępna")
                    {
                        MessageBox.Show("Wybrana książka jest już wyrejestrowana i ma status 'Niedostępna'.", "Błąd",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Przerwij dalsze działanie metody
                    }
                    // Zarejestruj książkę
                    int id_uzytkownika = 1; // Przykładowe ID zalogowanego użytkownika
                    KlasaListaRejestracjiKsiazek rejestracjaKsiazek = new KlasaListaRejestracjiKsiazek();
                    rejestracjaKsiazek.WyrejestrujKsiazke(selectedBookId, id_uzytkownika);


                    // Zmiana statusu książki na "Dostępna"
                    wyswietlKsiazki.AktualizujStatusKsiazki(selectedBookId, "Niedostępna");

                    // Wyświetl komunikat o powodzeniu
                    MessageBox.Show("Status książki został pomyślnie zmieniony na 'Niedostępna'.", "Sukces",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Odśwież listę książek
                    WyswietlListeKsiazek();
                }
                catch (Exception ex)
                {
                    // Wyświetl komunikat o błędzie
                    MessageBox.Show($"Wystąpił błąd podczas zmiany statusu książki: {ex.Message}", "Błąd",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę, aby zmienić jej status.", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            if (selectedBookId != 0)
            {
                ZarzadzajBibliotekaKlasa zarzadzajBiblioteka = new ZarzadzajBibliotekaKlasa();
                zarzadzajBiblioteka.EdytujKsiazke(selectedBookId, textBox_Tytul.Text, textBox_Autor.Text, textBox_Gatunek.Text,
                    textBox_Opis.Text, (int)numericUpDown_LiczbaStron.Value, textBox_Wydawnictwo.Text, (int)numericUpDown_RokWydania.Value,
                    numericUpDown_Cena.Value, (int)numericUpDown_LiczbaSztuk.Value);
                WyswietlListeKsiazek(); // Dodano odświeżenie listy książek po edycji

                // Wyczyść wartości textboxów po edycji
                textBox_Tytul.Text = "";
                textBox_Autor.Text = "";
                textBox_Gatunek.Text = "";
                textBox_Opis.Text = "";
                numericUpDown_LiczbaStron.Value = 0;
                textBox_Wydawnictwo.Text = "";
                numericUpDown_RokWydania.Value = DateTime.Now.Year;
                numericUpDown_Cena.Value = 0;
                numericUpDown_LiczbaSztuk.Value = 0;

                MessageBox.Show("Książka została pomyślnie zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę do zaktualizowania.");
            }
        }

    }
}