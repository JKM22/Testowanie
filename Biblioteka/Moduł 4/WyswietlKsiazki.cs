using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

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


        public void WypelnijComboBoxAutor(ComboBox comboBoxAutor)
        {
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT autor FROM ksiazka";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string autor = reader.GetString("autor");
                            comboBoxAutor.Items.Add(autor);
                            originalItems.Add(autor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                }
            }

            comboBoxAutor.Tag = originalItems;
            bool isUserInput = true;

            comboBoxAutor.TextChanged += (sender, e) =>
            {
                if (isUserInput)
                {
                    string searchText = comboBoxAutor.Text.ToLower();
                    List<string> matchedItems = new List<string>();

                    foreach (string item in originalItems)
                    {
                        if (item.ToLower().Contains(searchText))
                        {
                            matchedItems.Add(item);
                        }
                    }

                    comboBoxAutor.Items.Clear();
                    comboBoxAutor.Items.AddRange(matchedItems.ToArray());
                    comboBoxAutor.SelectionStart = comboBoxAutor.Text.Length;
                    comboBoxAutor.SelectionLength = 0;
                    comboBoxAutor.DroppedDown = false; // Pozostaw listę rozwiniętą
                }
            };

            comboBoxAutor.MouseDown += (sender, e) =>
            {
                if (!comboBoxAutor.DroppedDown)
                {
                    comboBoxAutor.Items.Clear();
                    comboBoxAutor.Items.AddRange(((List<string>)comboBoxAutor.Tag).ToArray());
                    comboBoxAutor.DroppedDown = true;
                }
            };

            comboBoxAutor.SelectionChangeCommitted += (sender, e) =>
            {
                isUserInput = false;
                comboBoxAutor.Text = comboBoxAutor.SelectedItem.ToString();
                comboBoxAutor.SelectionStart = comboBoxAutor.Text.Length;
                comboBoxAutor.SelectionLength = 0;
                comboBoxAutor.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                isUserInput = true;
            };

            comboBoxAutor.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxAutor.SelectedIndex != -1)
                {
                    isUserInput = false;
                    comboBoxAutor.Text = comboBoxAutor.SelectedItem.ToString();
                    comboBoxAutor.SelectionStart = comboBoxAutor.Text.Length;
                    comboBoxAutor.SelectionLength = 0;
                    comboBoxAutor.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                    isUserInput = true;
                }
            };
        }


        public void WypelnijComboBoxTytul(ComboBox comboBoxTytul)
        {
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT tytul FROM ksiazka";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tytul = reader.GetString("tytul");
                            comboBoxTytul.Items.Add(tytul);
                            originalItems.Add(tytul);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                }
            }

            comboBoxTytul.Tag = originalItems;
            bool isUserInput = true;

            comboBoxTytul.TextChanged += (sender, e) =>
            {
                if (isUserInput)
                {
                    string searchText = comboBoxTytul.Text.ToLower();
                    List<string> matchedItems = new List<string>();

                    foreach (string item in originalItems)
                    {
                        if (item.ToLower().Contains(searchText))
                        {
                            matchedItems.Add(item);
                        }
                    }

                    comboBoxTytul.Items.Clear();
                    comboBoxTytul.Items.AddRange(matchedItems.ToArray());
                    comboBoxTytul.SelectionStart = comboBoxTytul.Text.Length;
                    comboBoxTytul.SelectionLength = 0;
                    comboBoxTytul.DroppedDown = false; // Pozostaw listę rozwiniętą
                }
            };

            comboBoxTytul.MouseDown += (sender, e) =>
            {
                if (!comboBoxTytul.DroppedDown)
                {
                    comboBoxTytul.Items.Clear();
                    comboBoxTytul.Items.AddRange(((List<string>)comboBoxTytul.Tag).ToArray());
                    comboBoxTytul.DroppedDown = true;
                }
            };

            comboBoxTytul.SelectionChangeCommitted += (sender, e) =>
            {
                isUserInput = false;
                comboBoxTytul.Text = comboBoxTytul.SelectedItem.ToString();
                comboBoxTytul.SelectionStart = comboBoxTytul.Text.Length;
                comboBoxTytul.SelectionLength = 0;
                comboBoxTytul.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                isUserInput = true;
            };

            comboBoxTytul.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxTytul.SelectedIndex != -1)
                {
                    isUserInput = false;
                    comboBoxTytul.Text = comboBoxTytul.SelectedItem.ToString();
                    comboBoxTytul.SelectionStart = comboBoxTytul.Text.Length;
                    comboBoxTytul.SelectionLength = 0;
                    comboBoxTytul.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                    isUserInput = true;
                }
            };
        }


        public void WypelnijComboBoxGatunek(ComboBox comboBoxGatunek)
        {
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT gatunek FROM ksiazka";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string gatunek = reader.GetString("gatunek");
                            comboBoxGatunek.Items.Add(gatunek);
                            originalItems.Add(gatunek);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                }
            }

            comboBoxGatunek.Tag = originalItems;
            bool isUserInput = true;

            comboBoxGatunek.TextChanged += (sender, e) =>
            {
                if (isUserInput)
                {
                    string searchText = comboBoxGatunek.Text.ToLower();
                    List<string> matchedItems = new List<string>();

                    foreach (string item in originalItems)
                    {
                        if (item.ToLower().Contains(searchText))
                        {
                            matchedItems.Add(item);
                        }
                    }

                    comboBoxGatunek.Items.Clear();
                    comboBoxGatunek.Items.AddRange(matchedItems.ToArray());
                    comboBoxGatunek.SelectionStart = comboBoxGatunek.Text.Length;
                    comboBoxGatunek.SelectionLength = 0;
                    comboBoxGatunek.DroppedDown = false; // Pozostaw listę rozwiniętą
                }
            };

            comboBoxGatunek.MouseDown += (sender, e) =>
            {
                if (!comboBoxGatunek.DroppedDown)
                {
                    comboBoxGatunek.Items.Clear();
                    comboBoxGatunek.Items.AddRange(((List<string>)comboBoxGatunek.Tag).ToArray());
                    comboBoxGatunek.DroppedDown = true;
                }
            };

            comboBoxGatunek.SelectionChangeCommitted += (sender, e) =>
            {
                isUserInput = false;
                comboBoxGatunek.Text = comboBoxGatunek.SelectedItem.ToString();
                comboBoxGatunek.SelectionStart = comboBoxGatunek.Text.Length;
                comboBoxGatunek.SelectionLength = 0;
                comboBoxGatunek.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                isUserInput = true;
            };

            comboBoxGatunek.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxGatunek.SelectedIndex != -1)
                {
                    isUserInput = false;
                    comboBoxGatunek.Text = comboBoxGatunek.SelectedItem.ToString();
                    comboBoxGatunek.SelectionStart = comboBoxGatunek.Text.Length;
                    comboBoxGatunek.SelectionLength = 0;
                    comboBoxGatunek.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                    isUserInput = true;
                }
            };
        }


        public void WypelnijComboBoxWydawnictwo(ComboBox comboBoxWydawnictwo)
        {
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT wydawnictwo FROM ksiazka";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string wydawnictwo = reader.GetString("wydawnictwo");
                            comboBoxWydawnictwo.Items.Add(wydawnictwo);
                            originalItems.Add(wydawnictwo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                }
            }

            comboBoxWydawnictwo.Tag = originalItems;
            bool isUserInput = true;

            comboBoxWydawnictwo.TextChanged += (sender, e) =>
            {
                if (isUserInput)
                {
                    string searchText = comboBoxWydawnictwo.Text.ToLower();
                    List<string> matchedItems = new List<string>();

                    foreach (string item in originalItems)
                    {
                        if (item.ToLower().Contains(searchText))
                        {
                            matchedItems.Add(item);
                        }
                    }

                    comboBoxWydawnictwo.Items.Clear();
                    comboBoxWydawnictwo.Items.AddRange(matchedItems.ToArray());
                    comboBoxWydawnictwo.SelectionStart = comboBoxWydawnictwo.Text.Length;
                    comboBoxWydawnictwo.SelectionLength = 0;
                    comboBoxWydawnictwo.DroppedDown = false; // Pozostaw listę rozwiniętą
                }
            };

            comboBoxWydawnictwo.MouseDown += (sender, e) =>
            {
                if (!comboBoxWydawnictwo.DroppedDown)
                {
                    comboBoxWydawnictwo.Items.Clear();
                    comboBoxWydawnictwo.Items.AddRange(((List<string>)comboBoxWydawnictwo.Tag).ToArray());
                    comboBoxWydawnictwo.DroppedDown = true;
                }
            };

            comboBoxWydawnictwo.SelectionChangeCommitted += (sender, e) =>
            {
                isUserInput = false;
                comboBoxWydawnictwo.Text = comboBoxWydawnictwo.SelectedItem.ToString();
                comboBoxWydawnictwo.SelectionStart = comboBoxWydawnictwo.Text.Length;
                comboBoxWydawnictwo.SelectionLength = 0;
                comboBoxWydawnictwo.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                isUserInput = true;
            };

            comboBoxWydawnictwo.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxWydawnictwo.SelectedIndex != -1)
                {
                    isUserInput = false;
                    comboBoxWydawnictwo.Text = comboBoxWydawnictwo.SelectedItem.ToString();
                    comboBoxWydawnictwo.SelectionStart = comboBoxWydawnictwo.Text.Length;
                    comboBoxWydawnictwo.SelectionLength = 0;
                    comboBoxWydawnictwo.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                    isUserInput = true;
                }
            };
        }

        public void PobierzDaneZBazy(string autor, string tytul, string gatunek, string wydawnictwo, string status, ListView listView)
        {
            listView.Items.Clear(); // Wyczyść elementy ListView przed dodaniem nowych

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Tworzymy podstawowe zapytanie SQL, które będzie filtrować na podstawie wypełnionych pól
                    string query = "SELECT * FROM ksiazka WHERE 1 = 1";

                    // Dodajemy warunki do zapytania SQL tylko dla niepustych wartości
                    if (!string.IsNullOrEmpty(autor))
                        query += " AND autor = @autor";

                    if (!string.IsNullOrEmpty(tytul))
                        query += " AND tytul = @tytul";

                    if (!string.IsNullOrEmpty(gatunek))
                        query += " AND gatunek = @gatunek";

                    if (!string.IsNullOrEmpty(wydawnictwo))
                        query += " AND wydawnictwo = @wydawnictwo";

                    if (!string.IsNullOrEmpty(status))
                        query += " AND status = @status";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Dodajemy parametry tylko dla tych warunków, które są używane w zapytaniu
                    if (!string.IsNullOrEmpty(autor))
                        command.Parameters.AddWithValue("@autor", autor);

                    if (!string.IsNullOrEmpty(tytul))
                        command.Parameters.AddWithValue("@tytul", tytul);

                    if (!string.IsNullOrEmpty(gatunek))
                        command.Parameters.AddWithValue("@gatunek", gatunek);

                    if (!string.IsNullOrEmpty(wydawnictwo))
                        command.Parameters.AddWithValue("@wydawnictwo", wydawnictwo);

                    if (!string.IsNullOrEmpty(status))
                        command.Parameters.AddWithValue("@status", status);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Przetwarzamy otrzymane dane i dodajemy do ListView
                        while (reader.Read())
                        {
                            // Tworzymy nowy element ListViewItem z danymi książki
                            ListViewItem item = new ListViewItem(new string[]
                            {
                                reader.GetInt32("id_ksiazka").ToString(),
                                reader.GetString("tytul"),
                                reader.GetString("autor"),
                                reader.GetString("gatunek"),
                                reader.GetString("wydawnictwo"),
                                reader.GetString("status")
                            });



                            // Nadajemy kolor tła wiersza w zależności od statusu
                            string statusKsiazki = reader.GetString("status");
                            switch (statusKsiazki)
                            {
                                case "Dostępna":
                                    item.BackColor = Color.LightGreen;
                                    break;
                                case "Niedostępna":
                                    item.BackColor = Color.LightCoral;
                                    break;
                                default:
                                   item.BackColor = Color.White; // Domyślny kolor
                                    break;
                            }
                            // Dodajemy utworzony element ListViewItem do ListView
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
        private void textBoxGatunek_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdzamy czy wprowadzony znak jest cyfrą
            if (char.IsDigit(e.KeyChar))
            {
                // Jeśli tak, zatrzymujemy jego wprowadzenie do kontrolki
                e.Handled = true;
            }
        }



    }
}