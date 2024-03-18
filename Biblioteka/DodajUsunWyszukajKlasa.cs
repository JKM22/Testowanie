using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteka
{
    public class DodajUsunWyszukajKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void DodajUzytkownika(string imie, string nazwisko, string email, string telefon, string miejscowosc, string kodPocztowy, string ulica, string nrPosesji, string nrLokalu, string pesel, string dataUrodzenia, string plec, string login, string haslo)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO uzytkownik (u_imie, u_nazwisko, u_email, u_telefon, u_miejscowosc, u_kod, u_ulica, u_nr_posesji, u_nr_lokalu, u_pesel, u_data_ur, u_plec, u_login, u_haslo) VALUES (@imie, @nazwisko, @email, @telefon, @miejscowosc, @kod, @ulica, @nr_posesji, @nr_lokalu, @pesel, @data_ur, @plec, @login, @haslo)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", imie);
                        command.Parameters.AddWithValue("@nazwisko", nazwisko);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@miejscowosc", miejscowosc);
                        command.Parameters.AddWithValue("@kod", kodPocztowy);
                        command.Parameters.AddWithValue("@ulica", ulica);
                        command.Parameters.AddWithValue("@nr_posesji", nrPosesji);
                        command.Parameters.AddWithValue("@nr_lokalu", nrLokalu);
                        command.Parameters.AddWithValue("@pesel", pesel);
                        command.Parameters.AddWithValue("@data_ur", dataUrodzenia);
                        command.Parameters.AddWithValue("@plec", plec);
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@haslo", haslo);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Obsługa błędów
                }
            }
        }

        public bool WalidujDane(string imie, string nazwisko, string email, string telefon, string miejscowosc, string kodPocztowy, string ulica, string nrPosesji, string nrLokalu, string pesel, string dataUrodzenia, string login, string haslo)
        {
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(miejscowosc) || string.IsNullOrWhiteSpace(kodPocztowy) ||
                string.IsNullOrWhiteSpace(ulica) || string.IsNullOrWhiteSpace(pesel) || string.IsNullOrWhiteSpace(dataUrodzenia) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo))
            {
                return false;
            }

            if (telefon.Length != 9)
            {
                return false;
            }

            if (kodPocztowy.Length < 5 || kodPocztowy.Length > 10)
            {
                return false;
            }

            if (pesel.Length != 11)
            {
                return false;
            }
            DateTime urodzenie;
            if (!DateTime.TryParse(dataUrodzenia, out urodzenie))
            {
                return false; // Nieprawidłowy format daty
            }

            if (urodzenie > DateTime.Now)
            {
                return false; // Data urodzenia jest na przyszłość
            }

            return true;
        }

        public bool UsunUzytkownikaZBazy(string id_uzytkownik)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM uzytkownik WHERE id_uzytkownik = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id_uzytkownik);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Użytkownik został pomyślnie usunięty z bazy danych!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono użytkownika o podanym identyfikatorze w bazie danych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania użytkownika. Error: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void WyszukajUzytkownika(ListView listView, string frazaWyszukiwania)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM uzytkownik WHERE u_imie LIKE @fraza OR u_nazwisko LIKE @fraza OR u_email LIKE @fraza OR u_telefon LIKE @fraza OR u_miejscowosc LIKE @fraza OR u_kod LIKE @fraza OR u_ulica LIKE @fraza OR u_nr_posesji LIKE @fraza OR u_nr_lokalu LIKE @fraza OR u_pesel LIKE @fraza OR u_data_ur LIKE @fraza OR u_plec LIKE @fraza OR u_login LIKE @fraza";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fraza", $"%{frazaWyszukiwania}%");


                        using (MySqlDataReader reader = command.ExecuteReader())

                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Brak użytkowników pasujących do wyszukiwanej frazy.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return; // Zakończ funkcję, nie ma danych do wyświetlenia
                            }
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["id_uzytkownik"].ToString());

                                // Dodaj wartości dla każdego pola z bazy danych
                                item.SubItems.Add(reader["u_imie"].ToString());
                                item.SubItems.Add(reader["u_nazwisko"].ToString());
                                item.SubItems.Add(reader["u_email"].ToString());
                                item.SubItems.Add(reader["u_telefon"].ToString());
                                item.SubItems.Add(reader["u_miejscowosc"].ToString());
                                item.SubItems.Add(reader["u_kod"].ToString());
                                item.SubItems.Add(reader["u_ulica"].ToString());
                                item.SubItems.Add(reader["u_nr_posesji"].ToString());
                                item.SubItems.Add(reader["u_nr_lokalu"].ToString());
                                item.SubItems.Add(reader["u_pesel"].ToString());
                                item.SubItems.Add(((DateTime)reader["u_data_ur"]).ToString("yyyy-MM-dd"));
                                item.SubItems.Add(reader["u_plec"].ToString());
                                item.SubItems.Add(reader["u_login"].ToString());
                                item.SubItems.Add(reader["u_haslo"].ToString());

                                listView.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
