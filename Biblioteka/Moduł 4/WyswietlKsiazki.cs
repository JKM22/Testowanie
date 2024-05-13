using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteka.Moduł_4
{
    public class WyswietlKsiazki
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void WyswietlListeKsiazek(ListView listView)
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
                    string query = "SELECT id_ksiazka, tytul, autor, gatunek, opis, liczba_stron, wydawnictwo, rok_wydania, cena, liczba_sztuk, status FROM ksiazka";

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
                            string gatunek = reader.GetString("gatunek");
                            string opis = reader.GetString("opis");
                            int liczbaStron = reader.GetInt32("liczba_stron");
                            string wydawnictwo = reader.GetString("wydawnictwo");
                            int rokWydania = reader.GetInt32("rok_wydania");
                            decimal cena = reader.GetDecimal("cena");
                            int liczbaSztuk = reader.GetInt32("liczba_sztuk");
                            string status = reader.GetString("status");

                            // Tworzymy nowy element ListViewItem z danymi książki
                            ListViewItem item = new ListViewItem(new string[] { id.ToString(), tytul, autor, gatunek, opis, liczbaStron.ToString(), wydawnictwo, rokWydania.ToString(), cena.ToString(), liczbaSztuk.ToString(), status });
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
        public void AktualizujStatusKsiazki(int bookId, string newStatus)
        {
            // Tworzenie połączenia z bazą danych
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    // Otwarcie połączenia
                    connection.Open();

                    // Zapytanie SQL do aktualizacji statusu książki
                    string query = "UPDATE ksiazka SET status = @newStatus WHERE id_ksiazka = @bookId";

                    // Tworzenie obiektu MySqlCommand
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@newStatus", newStatus);
                    command.Parameters.AddWithValue("@bookId", bookId);

                    // Wykonanie zapytania
                    int rowsAffected = command.ExecuteNonQuery();

                    // Sprawdzenie czy zapytanie wykonano poprawnie
                    if (rowsAffected > 0)
                    {
                        // Status książki został pomyślnie zaktualizowany
                    }
                    else
                    {
                        throw new Exception("Nie udało się zaktualizować statusu książki.");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void WyswietlListeKsiazek2(ListView listView)
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
                    string query = "SELECT id_ksiazka, tytul, autor, gatunek, wydawnictwo,status FROM ksiazka";

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
                            string gatunek = reader.GetString("gatunek");
                            string wydawnictwo = reader.GetString("wydawnictwo");
                            string status = reader.GetString("status");


                            // Tworzymy nowy element ListViewItem z danymi książki
                            ListViewItem item = new ListViewItem(new string[] { id.ToString(), tytul, autor, gatunek, wydawnictwo, status });
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
        public void WypelnijComboBoxNazwamiKolumn(ComboBox comboBoxFilter)
        {
            comboBoxFilter.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Modyfikujemy zapytanie SQL, aby zwracało tylko nazwy wybranych kolumn
                    string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ksiazka' " +
                                   "AND COLUMN_NAME IN ('autor', 'tytul', 'gatunek', 'wydawnictwo', 'status')";

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


        public void WypelnijComboBoxDane(string selectedColumn, ComboBox comboBoxDane)
        {
            comboBoxDane.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy zapytanie SQL, które pobiera unikalne wartości z wybranej kolumny
                    string query = $"SELECT DISTINCT {selectedColumn} FROM ksiazka";

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


        public void FiltrujDane(string columnName, string filterValue, ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy zapytanie SQL, które zwróci tylko te wiersze,
                    // które zawierają wybraną wartość w odpowiedniej kolumnie
                    string query = $"SELECT * FROM ksiazka WHERE {columnName} = @filterValue";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@filterValue", filterValue);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Dodajemy pasujące wiersze do listView
                            int id = reader.GetInt32("id_ksiazka");
                            string tytul = reader.GetString("tytul");
                            string autor = reader.GetString("autor");
                            string gatunek = reader.GetString("gatunek");
                            string wydawnictwo = reader.GetString("wydawnictwo");
                            string status = reader.GetString("status");

                            ListViewItem item = new ListViewItem(new string[] { id.ToString(), tytul, autor, gatunek, wydawnictwo, status });
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

        public void FiltrujStatus(string columnName, string filterValue, ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy zapytanie SQL, które zwróci tylko te wiersze,
                    // które zawierają wybraną wartość w odpowiedniej kolumnie
                    string query = $"SELECT * FROM ksiazka WHERE {columnName} = @filterValue";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@filterValue", filterValue);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {// Dodajemy książki do listView
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id_ksiazka");
                            string tytul = reader.GetString("tytul");
                            string autor = reader.GetString("autor");
                            string gatunek = reader.GetString("gatunek");
                            string opis = reader.GetString("opis");
                            int liczbaStron = reader.GetInt32("liczba_stron");
                            string wydawnictwo = reader.GetString("wydawnictwo");
                            int rokWydania = reader.GetInt32("rok_wydania");
                            decimal cena = reader.GetDecimal("cena");
                            int liczbaSztuk = reader.GetInt32("liczba_sztuk");
                            string status = reader.GetString("status");

                            // Tworzymy nowy element ListViewItem z danymi książki
                            ListViewItem item = new ListViewItem(new string[] { id.ToString(), tytul, autor, gatunek, opis, liczbaStron.ToString(), wydawnictwo, rokWydania.ToString(), cena.ToString(), liczbaSztuk.ToString(), status });
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


        public string WyswietlPelneInformacjeOKsiazce(int bookId)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy zapytanie SQL do pobrania pełnych informacji o wybranej książce
                    string query = "SELECT * FROM ksiazka WHERE id_ksiazka = @bookId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookId", bookId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Pobieramy pełne informacje o książce
                            int id = reader.GetInt32("id_ksiazka");
                            string tytul = reader.GetString("tytul");
                            string autor = reader.GetString("autor");
                            string gatunek = reader.GetString("gatunek");
                            string opis = reader.GetString("opis");
                            int liczbaStron = reader.GetInt32("liczba_stron");
                            string wydawnictwo = reader.GetString("wydawnictwo");
                            int rokWydania = reader.GetInt32("rok_wydania");
                            decimal cena = reader.GetDecimal("cena");
                            int liczbaSztuk = reader.GetInt32("liczba_sztuk");
                            string status = reader.GetString("status");

                            // Zwracamy ciąg znaków z pełnymi informacjami o książce
                            return $"ID: {id}\nTytuł: {tytul}\nAutor: {autor}\nGatunek: {gatunek}\nOpis: {opis}\nLiczba stron: {liczbaStron}\nWydawnictwo: {wydawnictwo}\nRok wydania: {rokWydania}\nCena: {cena}\nLiczba sztuk: {liczbaSztuk}\nStatus: {status}";
                        }
                        else
                        {
                            return "Nie znaleziono informacji o książce.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Wystąpił błąd podczas pobierania danych: " + ex.Message;
                }
            }
        }

        



        public void WypelnijComboBoxStatus(ComboBox comboBoxStatus)
        {
            comboBoxStatus.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy zapytanie SQL, które pobiera unikalne wartości z kolumny status
                    string query = "SELECT DISTINCT status FROM ksiazka";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxStatus.Items.Add(reader.GetString("status"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }



    }
}