using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteka.Moduł_4
{
    public class KlasaListaRejestracjiKsiazek
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void WyswietlListeRejestracji(System.Windows.Forms.ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT 
                                    lrk.data_rejestracji, 
                                    lrk.status_rejestracji, 
                                    k.autor, 
                                    k.gatunek, 
                                    k.wydawnictwo,
                                    k.tytul, 
                                    u.u_imie, 
                                    u.u_nazwisko 
                                FROM 
                                    lista_rejestracji_ksiazek lrk 
                                JOIN 
                                    ksiazka k ON lrk.id_r_ksiazki = k.id_ksiazka 
                                JOIN 
                                    uzytkownik u ON lrk.id_r_uzytkownika = u.id_uzytkownik";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string autor = reader.GetString("Autor");
                            string gatunek = reader.GetString("Gatunek");
                            string tytul = reader.GetString("Tytul");
                            string wydawnictwo = reader.GetString("Wydawnictwo");
                            DateTime dataRejestracji = reader.GetDateTime("data_rejestracji");
                            string imie = reader.GetString("u_imie");
                            string nazwisko = reader.GetString("u_nazwisko");
                            string osobaRejestrujaca = $"{imie} {nazwisko}"; // Połączenie imienia i nazwiska w jedną kolumnę
                            string statusRejestracji = reader.GetString("status_rejestracji");

                            ListViewItem item = new ListViewItem(new string[] { autor, gatunek, tytul, wydawnictwo, dataRejestracji.ToString(), osobaRejestrujaca, statusRejestracji });
                            listView.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Obsługa błędów połączenia lub odczytu danych
                    MessageBox.Show("Wystąpił błąd podczas odczytu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void ZarejestrujKsiazke(int selectedBookId, int id_uzytkownika)
        {
            try
            {
                // Utwórz nowy wpis w tabeli lista_rejestracji_ksiazek
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO lista_rejestracji_ksiazek (id_r_ksiazki, data_rejestracji, id_r_uzytkownika, status_rejestracji) 
                                     VALUES (@id_r_ksiazki, @data_rejestracji, @id_r_uzytkownika, @status_rejestracji)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_r_ksiazki", selectedBookId);
                    command.Parameters.AddWithValue("@data_rejestracji", DateTime.Now);
                    command.Parameters.AddWithValue("@id_r_uzytkownika", id_uzytkownika);
                    command.Parameters.AddWithValue("@status_rejestracji", "Książka zarejestrowana");
                    command.ExecuteNonQuery();
                }

                // Wyświetl komunikat o powodzeniu
                MessageBox.Show("Książka została pomyślnie zarejestrowana.", "Sukces",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show($"Wystąpił błąd podczas rejestracji książki: {ex.Message}", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void WyrejestrujKsiazke(int selectedBookId, int id_uzytkownika)
        {
            try
            {
                // Utwórz nowy wpis w tabeli lista_rejestracji_ksiazek
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO lista_rejestracji_ksiazek (id_r_ksiazki, data_rejestracji, id_r_uzytkownika, status_rejestracji) 
                                     VALUES (@id_r_ksiazki, @data_rejestracji, @id_r_uzytkownika, @status_rejestracji)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_r_ksiazki", selectedBookId);
                    command.Parameters.AddWithValue("@data_rejestracji", DateTime.Now);
                    command.Parameters.AddWithValue("@id_r_uzytkownika", id_uzytkownika);
                    command.Parameters.AddWithValue("@status_rejestracji", "Książka wyrejestrowana");
                    command.ExecuteNonQuery();
                }

                // Wyświetl komunikat o powodzeniu
                MessageBox.Show("Książka została pomyślnie wyrejestrowana.", "Sukces",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show($"Wystąpił błąd podczas cofniecia rejestracji książki: {ex.Message}", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public void WypelnijComboBoxNazwamiKolumn(System.Windows.Forms.ComboBox comboBoxFilter)
        {
            comboBoxFilter.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Modyfikujemy zapytanie SQL, aby zwracało nazwy kolumn z wszystkich trzech tabel
                    string query = @"
            SELECT 'autor' AS COLUMN_NAME FROM ksiazka
            UNION
            SELECT 'gatunek' AS COLUMN_NAME FROM ksiazka
            UNION
            SELECT 'tytul' AS COLUMN_NAME FROM ksiazka
            UNION
            SELECT 'wydawnictwo' AS COLUMN_NAME FROM ksiazka
            UNION
            SELECT 'data_rejestracji' AS COLUMN_NAME FROM lista_rejestracji_ksiazek
            UNION
            SELECT CONCAT('osoba_rejestrujaca') AS COLUMN_NAME FROM uzytkownik
            UNION
            SELECT 'status_rejestracji' AS COLUMN_NAME FROM lista_rejestracji_ksiazek";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxFilter.Items.Add(reader.GetString("COLUMN_NAME"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania nazw kolumn: " + ex.Message);
                }
            }
        }

        public void WypelnijComboBoxDane(string selectedColumn, System.Windows.Forms.ComboBox comboBoxDane)
        {
            comboBoxDane.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy zapytanie SQL, które pobiera unikalne wartości z wybranej kolumny
                    string query = $"SELECT DISTINCT {selectedColumn} FROM {GetTableName(selectedColumn)}";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDane.Items.Add(reader.GetString(selectedColumn));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }

        // Metoda pomocnicza do pobierania nazwy tabeli na podstawie wybranej kolumny
        private string GetTableName(string selectedColumn)
        {
            switch (selectedColumn.ToLower())
            {
                case "autor":
                case "gatunek":
                case "tytul":
                case "wydawnictwo":
                    return "ksiazka";
                case "data_rejestracji":
                case "status_rejestracji":
                    return "lista_rejestracji_ksiazek";
                case "osoba_rejestrujaca":
                    return "uzytkownik";
                default:
                    throw new ArgumentException("Nieprawidłowa nazwa kolumny.");
            }
        }



        public void FiltrujDane(string columnName, string filterValue, System.Windows.Forms.ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzenie zapytania SQL z uwzględnieniem wszystkich trzech tabel i warunków filtru
                    string query = $@"SELECT 
                k.autor, 
                k.gatunek, 
                k.tytul, 
                k.wydawnictwo,
                lrk.data_rejestracji,
                CONCAT(u.u_imie, ' ', u.u_nazwisko) AS osoba_rejestrujaca,
                lrk.status_rejestracji
            FROM 
                ksiazka k
            JOIN 
                lista_rejestracji_ksiazek lrk ON k.id_ksiazka = lrk.id_r_ksiazki
            JOIN 
                uzytkownik u ON lrk.id_r_uzytkownika = u.id_uzytkownik
            WHERE 
                k.{columnName} = @filterValue";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@filterValue", filterValue);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Odczyt danych z wyników zapytania i dodanie ich do listView
                            string autor = reader.GetString(reader.GetOrdinal("autor"));
                            string gatunek = reader.GetString(reader.GetOrdinal("gatunek"));
                            string tytul = reader.GetString(reader.GetOrdinal("tytul"));
                            string wydawnictwo = reader.GetString(reader.GetOrdinal("wydawnictwo"));
                            string dataRejestracjiString = string.Empty;
                            if (!reader.IsDBNull(reader.GetOrdinal("data_rejestracji")))
                            {
                                DateTime dataRejestracji = reader.GetDateTime(reader.GetOrdinal("data_rejestracji"));
                                dataRejestracjiString = dataRejestracji.ToString("yyyy-MM-dd HH:mm:ss");
                            }

                            string osobaRejestrujaca = reader.GetString(reader.GetOrdinal("osoba_rejestrujaca"));
                            string statusRejestracji = reader.GetString(reader.GetOrdinal("status_rejestracji"));


                            ListViewItem item = new ListViewItem(new string[] { autor, gatunek, tytul, wydawnictwo, dataRejestracjiString, osobaRejestrujaca, statusRejestracji });
                            listView.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas filtrowania danych: " + ex.Message);
                }
            }
        }


    }
}