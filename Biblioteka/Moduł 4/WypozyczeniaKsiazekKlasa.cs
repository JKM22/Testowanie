using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Biblioteka.Moduł_4
{
    public class WypozyczeniaKsiazekKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        private int selectedBookId;



        public void DodajWypozyczenie(string imie, string nazwisko, string adres, string numerTelefonu, int ksiazkaId, DateTime dataWypozyczenia, int okresWypozyczenia)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DateTime dataZwrotu = dataWypozyczenia.AddDays(okresWypozyczenia);

                    // Zapis do tabeli wypozyczenia
                    string queryWypozyczenia = "INSERT INTO wypozyczenia (w_imie, w_nazwisko, w_adres, w_telefon, w_dataWypozyczenia, w_okresWypozyczenia, w_dataZwrotu, w_statusWypozyczenia) " +
                           "VALUES (@Imie, @Nazwisko, @Adres, @Telefon, @DataWypozyczenia, @OkresWypozyczenia, @DataZwrotu, 'Nowe')";

                    using (MySqlCommand commandWypozyczenia = new MySqlCommand(queryWypozyczenia, connection))
                    {
                        commandWypozyczenia.Parameters.AddWithValue("@Imie", imie);
                        commandWypozyczenia.Parameters.AddWithValue("@Nazwisko", nazwisko);
                        commandWypozyczenia.Parameters.AddWithValue("@Adres", adres);
                        commandWypozyczenia.Parameters.AddWithValue("@Telefon", numerTelefonu);
                        commandWypozyczenia.Parameters.AddWithValue("@DataWypozyczenia", dataWypozyczenia);
                        commandWypozyczenia.Parameters.AddWithValue("@OkresWypozyczenia", okresWypozyczenia);
                        commandWypozyczenia.Parameters.AddWithValue("@DataZwrotu", dataZwrotu);

                        commandWypozyczenia.ExecuteNonQuery();

                        // Pobierz ID nowo wstawionego wypożyczenia
                        long wypozyczenieId;
                        string getLastInsertedIdQuery = "SELECT LAST_INSERT_ID();";
                        using (MySqlCommand commandGetLastInsertedId = new MySqlCommand(getLastInsertedIdQuery, connection))
                        {
                            wypozyczenieId = Convert.ToInt32(commandGetLastInsertedId.ExecuteScalar());
                        }

                        // Zapis do tabeli biblioteka_pary_wypozyczenia
                        string queryParyWypozyczenia = "INSERT INTO pary_wypozyczenia (id_wypozyczenia, id_ksiazki) " +
                                "VALUES (@IdWypozyczenia, @IdKsiazki)";

                        using (MySqlCommand commandParyWypozyczenia = new MySqlCommand(queryParyWypozyczenia, connection))
                        {
                            commandParyWypozyczenia.Parameters.AddWithValue("@IdWypozyczenia", wypozyczenieId);
                            commandParyWypozyczenia.Parameters.AddWithValue("@IdKsiazki", ksiazkaId);

                            commandParyWypozyczenia.ExecuteNonQuery();
                        }
                        string updateQuery = "UPDATE ksiazka SET liczba_sztuk = liczba_sztuk - 1 WHERE id_ksiazka = @BookId";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@BookId", ksiazkaId);
                        updateCommand.ExecuteNonQuery();

                        string checkAvailabilityQuery = "SELECT liczba_sztuk FROM ksiazka WHERE id_ksiazka = @BookId";
                        MySqlCommand checkCommand = new MySqlCommand(checkAvailabilityQuery, connection);
                        checkCommand.Parameters.AddWithValue("@BookId", ksiazkaId);
                        int liczbaSztuk = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (liczbaSztuk == 0)
                        {
                            // Aktualizuj status książki na "Niedostępna"
                            string updateStatusQuery = "UPDATE ksiazka SET status = 'Niedostępna' WHERE id_ksiazka = @BookId";
                            MySqlCommand updateStatusCommand = new MySqlCommand(updateStatusQuery, connection);
                            updateStatusCommand.Parameters.AddWithValue("@BookId", ksiazkaId);
                            updateStatusCommand.ExecuteNonQuery();
                        }
                    }


                }
                catch (Exception ex)
                {
                    // Obsługa błędu, np. logowanie lub zgłoszenie użytkownikowi
                    Console.WriteLine("Błąd podczas zapisu do bazy danych: " + ex.Message);
                    throw; // Możesz rzucać wyjątek dalej dla obsługi w innym miejscu
                }
            }
        }


        public void WybierzKsiazke(ListView listView)
        {
            listView.Items.Clear();
            // Tworzymy połączenie z bazą danych
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    // Otwieramy połączenie
                    connection.Open();

                    // Tworzymy zapytanie SQL
                    string query = "SELECT id_ksiazka, tytul, autor, status FROM ksiazka";

                    // Tworzymy obiekt MySqlCommand
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Tworzymy obiekt MySqlDataReader do odczytu wyników zapytania
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Dodajemy książki do listView
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id_ksiazka");
                            string tytul = reader.GetString("tytul");
                            string autor = reader.GetString("autor");
                            string status = reader.GetString("status");

                            // Tworzymy nowy element ListViewItem z danymi książki
                            ListViewItem item = new ListViewItem(new string[] { id.ToString(), tytul, autor, status });

                            // Ustawiamy kolor tła wiersza w zależności od statusu książki
                            if (status == "Dostępna")
                            {
                                item.BackColor = Color.LightGreen; // Ustaw kolor zielony dla dostępnej książki
                            }
                            else if (status == "Niedostępna")
                            {
                                item.BackColor = Color.LightCoral; // Ustaw kolor czerwony dla niedostępnej książki
                            }

                            listView.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }



        public void PokazWypozyczenia(ListView listView)
        {
            listView.Items.Clear();
            // Tworzymy połączenie z bazą danych
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    // Otwieramy połączenie
                    connection.Open();

                    // Tworzymy zapytanie SQL
                    string query = "SELECT w.id_wypozyczenia, w.w_imie, w.w_nazwisko, w.w_adres, w.w_telefon, w.w_dataWypozyczenia, w.w_okresWypozyczenia, w.w_dataZwrotu, w.w_statusWypozyczenia, k.autor, k.tytul FROM wypozyczenia w JOIN pary_wypozyczenia pw ON w.id_wypozyczenia = pw.id_wypozyczenia JOIN ksiazka k ON pw.id_ksiazki = k.id_ksiazka";

                    // Tworzymy obiekt MySqlCommand
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Tworzymy obiekt MySqlDataReader do odczytu wyników zapytania
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Dodajemy wypożyczenia do listView
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id_wypozyczenia");
                            string w_imie = reader.GetString("w_imie");
                            string w_nazwisko = reader.GetString("w_nazwisko");
                            string w_adres = reader.GetString("w_adres");
                            int w_telefon = reader.GetInt32("w_telefon");
                            string autor = reader.GetString("autor");
                            string tytul = reader.GetString("tytul");
                            DateTime w_dataWypozyczenia = reader.GetDateTime("w_dataWypozyczenia");
                            int w_okresWypozyczenia = reader.GetInt32("w_okresWypozyczenia");
                            DateTime w_dataZwrotu = reader.GetDateTime("w_dataZwrotu");
                            string w_statusWypozyczenia = reader.GetString("w_statusWypozyczenia");

                            // Tworzymy nowy element ListViewItem z danymi wypożyczenia
                            ListViewItem item = new ListViewItem(new string[] { id.ToString(), w_imie, w_nazwisko, w_adres, w_telefon.ToString(), autor, tytul, w_dataWypozyczenia.ToString(), w_okresWypozyczenia.ToString(), w_dataZwrotu.ToString(), w_statusWypozyczenia });

                            listView.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }

        public void PrzedluzWypozyczenie(int idWypozyczenia, int liczbaDni)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE wypozyczenia SET w_dataZwrotu = DATE_ADD(w_dataZwrotu, INTERVAL @LiczbaDni DAY), w_okresWypozyczenia = w_okresWypozyczenia + @LiczbaDni, w_statusWypozyczenia = 'Przedłużone' WHERE id_wypozyczenia = @IdWypozyczenia";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@LiczbaDni", liczbaDni);
                    command.Parameters.AddWithValue("@IdWypozyczenia", idWypozyczenia);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Błąd podczas przedłużania wypożyczenia: " + ex.Message);
                }
            }
        }

        public void ZwrocWypozyczenie(int idWypozyczenia)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string updateWypozyczeniaQuery = "UPDATE wypozyczenia SET w_dataZwrotu = CURRENT_TIMESTAMP(), w_statusWypozyczenia = 'Zakończone' WHERE id_wypozyczenia = @IdWypozyczenia";
                    MySqlCommand updateWypozyczeniaCommand = new MySqlCommand(updateWypozyczeniaQuery, connection);
                    updateWypozyczeniaCommand.Parameters.AddWithValue("@IdWypozyczenia", idWypozyczenia);
                    updateWypozyczeniaCommand.ExecuteNonQuery();

                    // Aktualizacja liczby sztuk w tabeli ksiazka
                    string updateLiczbaSztukQuery = "UPDATE ksiazka SET liczba_sztuk = liczba_sztuk + 1 WHERE id_ksiazka = (SELECT id_ksiazka FROM wypozyczenia WHERE id_wypozyczenia = @IdWypozyczenia)";
                    MySqlCommand updateLiczbaSztukCommand = new MySqlCommand(updateLiczbaSztukQuery, connection);
                    updateLiczbaSztukCommand.Parameters.AddWithValue("@IdWypozyczenia", idWypozyczenia);
                    updateLiczbaSztukCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Błąd podczas zwracania wypożyczenia: " + ex.Message);
                }
            }
        }




        public void WypelnijComboBoxWypozyczajacy(ComboBox comboBox_Wypozyczajacy)
        {
            comboBox_Wypozyczajacy.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT CONCAT(w.w_imie, ' ', w.w_nazwisko) AS Wypozyczajacy 
                             FROM wypozyczenia w";


                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string wypozyczajacy = reader.GetString("Wypozyczajacy");
                            comboBox_Wypozyczajacy.Items.Add(wypozyczajacy);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }

        public void WypelnijComboBoxBibliotekarz(ComboBox comboBox_Bibliotekarz)
        {
            comboBox_Bibliotekarz.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT CONCAT(u.u_imie, ' ', u.u_nazwisko) AS Bibliotekarz 
                             FROM lista_rejestracji_ksiazek lrk 
                             JOIN uzytkownik u ON lrk.id_r_uzytkownika = u.id_uzytkownik";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bibliotekarz = reader.GetString("Bibliotekarz");
                            comboBox_Bibliotekarz.Items.Add(bibliotekarz);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }



        public void WypelnijComboBoxokresWypozyczenia(ComboBox comboBox_okresWypozyczenia)
        {
            comboBox_okresWypozyczenia.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT w_okresWypozyczenia FROM wypozyczenia";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int okresWypozyczenia = reader.GetInt32("w_okresWypozyczenia");
                            comboBox_okresWypozyczenia.Items.Add(okresWypozyczenia);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }




        public void WypelnijComboBoxstatusWypozyczenia(ComboBox comboBox_statusWypozyczenia)
        {
            comboBox_statusWypozyczenia.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();


                    string query = "SELECT DISTINCT w_statusWypozyczenia FROM wypozyczenia";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox_statusWypozyczenia.Items.Add(reader.GetString("w_statusWypozyczenia"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }


        public void FiltrujListe2(ListView listView, ComboBox comboBox_Wypozyczajacy, ComboBox comboBox_Bibliotekarz, ComboBox comboBox_okresWypozyczenia, ComboBox comboBox_statusWypozyczenia)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
            }
        }

    }
}



