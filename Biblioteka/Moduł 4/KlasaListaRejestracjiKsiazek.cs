using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

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
                                    lrk.liczba_dodanych_sztuk, 
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
                            int statusRejestracji = reader.GetInt32(reader.GetOrdinal("liczba_dodanych_sztuk"));

                            ListViewItem item = new ListViewItem(new string[] { autor, gatunek, tytul, wydawnictwo, dataRejestracji.ToString(), osobaRejestrujaca, statusRejestracji.ToString() });
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


        public void ZarejestrujKsiazke(int selectedBookId, int id_uzytkownika, int liczbaDodawanychSztuk)
        {
            try
            {
                // Utwórz nowy wpis w tabeli lista_rejestracji_ksiazek
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO lista_rejestracji_ksiazek (id_r_ksiazki, data_rejestracji, id_r_uzytkownika, liczba_dodanych_sztuk) 
                                     VALUES (@id_r_ksiazki, @data_rejestracji, @id_r_uzytkownika, @liczba_dodanych_sztuk)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_r_ksiazki", selectedBookId);
                    command.Parameters.AddWithValue("@data_rejestracji", DateTime.Now);
                    command.Parameters.AddWithValue("@id_r_uzytkownika", id_uzytkownika);
                    command.Parameters.AddWithValue("@liczba_dodanych_sztuk", liczbaDodawanychSztuk);
                    command.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show($"Wystąpił błąd podczas rejestracji książki: {ex.Message}", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void WypelnijComboBoxAutor(System.Windows.Forms.ComboBox comboBoxAutor)
        {
            comboBoxAutor.Items.Clear(); // Wyczyść elementy w comboboxie autorów
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT k.autor FROM ksiazka k
                     JOIN lista_rejestracji_ksiazek lrk ON k.id_ksiazka = lrk.id_r_ksiazki";

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
                    // Obsługa błędów połączenia lub odczytu danych
                    MessageBox.Show("Wystąpił błąd podczas odczytu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        comboBoxAutor.DroppedDown = false;
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
        }



        public void WypelnijComboBoxTytul(System.Windows.Forms.ComboBox comboBoxTytul)
        {
            comboBoxTytul.Items.Clear(); // Wyczyść elementy w comboboxie tytułów
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT k.tytul FROM ksiazka k
                     JOIN lista_rejestracji_ksiazek lrk ON k.id_ksiazka = lrk.id_r_ksiazki";

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
                    // Obsługa błędów połączenia lub odczytu danych
                    MessageBox.Show("Wystąpił błąd podczas odczytu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        comboBoxTytul.DroppedDown = false;
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

        }




        public void WypelnijComboBoxGatunek(System.Windows.Forms.ComboBox comboBoxGatunek)
        {
            comboBoxGatunek.Items.Clear(); // Wyczyść elementy w comboboxie gatunków
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT k.gatunek FROM ksiazka k
                        JOIN lista_rejestracji_ksiazek lrk ON k.id_ksiazka = lrk.id_r_ksiazki";

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
                    // Obsługa błędów połączenia lub odczytu danych
                    MessageBox.Show("Wystąpił błąd podczas odczytu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        comboBoxGatunek.DroppedDown = false;
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

        }


        public void WypelnijComboBoxWydawnictwo(System.Windows.Forms.ComboBox comboBoxWydawnictwo)
        {
            comboBoxWydawnictwo.Items.Clear(); // Wyczyść elementy w comboboxie wydawnictw
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT k.wydawnictwo FROM ksiazka k
                     JOIN lista_rejestracji_ksiazek lrk ON k.id_ksiazka = lrk.id_r_ksiazki";

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
                    // Obsługa błędów połączenia lub odczytu danych
                    MessageBox.Show("Wystąpił błąd podczas odczytu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        comboBoxWydawnictwo.DroppedDown = false;
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
        }

        public void WypelnijComboBoxOsobaRejestrujaca(System.Windows.Forms.ComboBox comboBoxOsobaRejestrujaca)
        {
            comboBoxOsobaRejestrujaca.Items.Clear(); // Wyczyść elementy w comboboxie osób rejestrujących
            List<string> originalItems = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT CONCAT(u.u_imie, ' ', u.u_nazwisko) AS OsobaRejestrujaca 
                             FROM lista_rejestracji_ksiazek lrk 
                             JOIN uzytkownik u ON lrk.id_r_uzytkownika = u.id_uzytkownik";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string osobaRejestrujaca = reader.GetString("OsobaRejestrujaca");
                            comboBoxOsobaRejestrujaca.Items.Add(osobaRejestrujaca);
                            originalItems.Add(osobaRejestrujaca);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Obsługa błędów połączenia lub odczytu danych
                    MessageBox.Show("Wystąpił błąd podczas odczytu danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                comboBoxOsobaRejestrujaca.Tag = originalItems;
                bool isUserInput = true;

                comboBoxOsobaRejestrujaca.TextChanged += (sender, e) =>
                {
                    if (isUserInput)
                    {
                        string searchText = comboBoxOsobaRejestrujaca.Text.ToLower();
                        List<string> matchedItems = new List<string>();

                        foreach (string item in originalItems)
                        {
                            if (item.ToLower().Contains(searchText))
                            {
                                matchedItems.Add(item);
                            }
                        }

                        comboBoxOsobaRejestrujaca.Items.Clear();
                        comboBoxOsobaRejestrujaca.Items.AddRange(matchedItems.ToArray());
                        comboBoxOsobaRejestrujaca.SelectionStart = comboBoxOsobaRejestrujaca.Text.Length;
                        comboBoxOsobaRejestrujaca.SelectionLength = 0;
                        comboBoxOsobaRejestrujaca.DroppedDown = false; // Pozostaw listę rozwiniętą
                    }
                };

                comboBoxOsobaRejestrujaca.MouseDown += (sender, e) =>
                {
                    if (!comboBoxOsobaRejestrujaca.DroppedDown)
                    {
                        comboBoxOsobaRejestrujaca.Items.Clear();
                        comboBoxOsobaRejestrujaca.Items.AddRange(((List<string>)comboBoxOsobaRejestrujaca.Tag).ToArray());
                        comboBoxOsobaRejestrujaca.DroppedDown = false;
                    }
                };

                comboBoxOsobaRejestrujaca.SelectionChangeCommitted += (sender, e) =>
                {
                    isUserInput = false;
                    comboBoxOsobaRejestrujaca.Text = comboBoxOsobaRejestrujaca.SelectedItem.ToString();
                    comboBoxOsobaRejestrujaca.SelectionStart = comboBoxOsobaRejestrujaca.Text.Length;
                    comboBoxOsobaRejestrujaca.SelectionLength = 0;
                    comboBoxOsobaRejestrujaca.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                    isUserInput = true;
                };

                comboBoxOsobaRejestrujaca.SelectedIndexChanged += (sender, e) =>
                {
                    if (comboBoxOsobaRejestrujaca.SelectedIndex != -1)
                    {
                        isUserInput = false;
                        comboBoxOsobaRejestrujaca.Text = comboBoxOsobaRejestrujaca.SelectedItem.ToString();
                        comboBoxOsobaRejestrujaca.SelectionStart = comboBoxOsobaRejestrujaca.Text.Length;
                        comboBoxOsobaRejestrujaca.SelectionLength = 0;
                        comboBoxOsobaRejestrujaca.DroppedDown = false; // Zamknij listę rozwijaną po wyborze
                        isUserInput = true;
                    }
                };
            }
        }

        public void FiltrujListe(System.Windows.Forms.ListView listView, System.Windows.Forms.ComboBox comboBoxAutor, System.Windows.Forms.ComboBox comboBoxTytul, System.Windows.Forms.ComboBox comboBoxGatunek, System.Windows.Forms.ComboBox comboBoxWydawnictwo, System.Windows.Forms.ComboBox comboBoxOsobaRejestrujaca, DateTimePicker dateTimePicker_od, DateTimePicker dateTimePicker_do)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    StringBuilder queryBuilder = new StringBuilder();
                    queryBuilder.Append("SELECT lrk.data_rejestracji, lrk.liczba_dodanych_sztuk, ");
                    queryBuilder.Append("k.autor, k.gatunek, k.tytul, k.wydawnictwo, ");
                    queryBuilder.Append("u.u_imie, u.u_nazwisko ");
                    queryBuilder.Append("FROM lista_rejestracji_ksiazek lrk ");
                    queryBuilder.Append("JOIN ksiazka k ON lrk.id_r_ksiazki = k.id_ksiazka ");
                    queryBuilder.Append("JOIN uzytkownik u ON lrk.id_r_uzytkownika = u.id_uzytkownik ");
                    queryBuilder.Append("WHERE ");

                    List<string> conditions = new List<string>();
                    if (comboBoxAutor.SelectedItem != null)
                    {
                        conditions.Add($"k.autor = '{comboBoxAutor.SelectedItem}'");
                    }
                    if (comboBoxTytul.SelectedItem != null)
                    {
                        conditions.Add($"k.tytul = '{comboBoxTytul.SelectedItem}'");
                    }
                    if (comboBoxGatunek.SelectedItem != null)
                    {
                        conditions.Add($"k.gatunek = '{comboBoxGatunek.SelectedItem}'");
                    }
                    if (comboBoxWydawnictwo.SelectedItem != null)
                    {
                        conditions.Add($"k.wydawnictwo = '{comboBoxWydawnictwo.SelectedItem}'");
                    }
                    if (comboBoxOsobaRejestrujaca.SelectedItem != null)
                    {
                        string[] nameParts = comboBoxOsobaRejestrujaca.SelectedItem.ToString().Split(' ');
                        string firstName = nameParts[0];
                        string lastName = nameParts[1];
                        conditions.Add($"u.u_imie = '{firstName}' AND u.u_nazwisko = '{lastName}'");
                    }
                    // Dodaj warunek na zakres dat
                    conditions.Add($"lrk.data_rejestracji BETWEEN '{dateTimePicker_od.Value.ToString("yyyy-MM-dd")}' AND '{dateTimePicker_do.Value.ToString("yyyy-MM-dd")}'");

                    queryBuilder.Append(string.Join(" AND ", conditions));

                    MySqlCommand command = new MySqlCommand(queryBuilder.ToString(), connection);
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
                            int statusRejestracji = reader.GetInt32(reader.GetOrdinal("liczba_dodanych_sztuk"));

                            ListViewItem item = new ListViewItem(new string[] { autor, gatunek, tytul, wydawnictwo, dataRejestracji.ToString(), osobaRejestrujaca, statusRejestracji.ToString() });
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
       


    }
}
