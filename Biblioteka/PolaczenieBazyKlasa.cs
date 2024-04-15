﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteka
{
    internal class PolaczenieBazyKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void PopulateListView(ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM uzytkownik";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {


                                // Dodaj wartości dla każdego pola z bazy danych
                                ListViewItem item = new ListViewItem(reader["id_uzytkownik"].ToString());
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
        public void PopulateListViewFrom2(ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT u.id_uzytkownik, u.u_login, u.u_email, 
                            GROUP_CONCAT(IFNULL(p.uprawnienia, 'Brak uprawnień') SEPARATOR ', ') AS uprawnienia
                            FROM uzytkownik u
                            LEFT JOIN pary_uprawnienia pu ON u.id_uzytkownik = pu.id_uzytkownik
                            LEFT JOIN uprawnienia p ON pu.id_uprawnienia = p.id_uprawnienia
                            GROUP BY u.id_uzytkownik";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Tworzenie obiektu ListViewItem z loginem, mailem i uprawnieniem
                                ListViewItem item = new ListViewItem(reader["id_uzytkownik"].ToString()); // Identyfikator jako tekst pierwszej kolumny
                                item.SubItems.Add(reader["u_login"].ToString()); // Login jako kolejna kolumna
                                item.SubItems.Add(reader["u_email"].ToString()); // Email jako kolejna kolumna
                                item.SubItems.Add(reader["uprawnienia"].ToString()); // Uprawnienia jako kolejna kolumna
                                listView.Items.Add(item); // Dodanie obiektu ListViewItem do listy
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



        public bool WykonajZapytanie(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Zwróć true jeśli coś zostało zmienione w bazie danych
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message);
                    return false;
                }
            }
        }


       
        private static string zalogowanyUzytkownikLogin;
        private static string zalogowanyUzytkownikHaslo;
        private static int zalogowanyUzytkownikId;


        public static string ZalogowanyUzytkownikLogin
        {
            get { return zalogowanyUzytkownikLogin; }
            set { zalogowanyUzytkownikLogin = value; }
        }

        public static int ZalogowanyUzytkownikId
        {
            get { return zalogowanyUzytkownikId; }
            set { zalogowanyUzytkownikId = value; }
        }

        public static bool Zalogowany
        {
            get { return !string.IsNullOrEmpty(zalogowanyUzytkownikLogin); }
        }

        public void UstawZalogowanegoUzytkownika(int id, string login, string haslo)
        {
            zalogowanyUzytkownikId = id;
            zalogowanyUzytkownikLogin = login;
            zalogowanyUzytkownikHaslo = haslo;
        }


        private static Dictionary<string, (int attempts, DateTime lastAttempt)> loginAttempts = new Dictionary<string, (int, DateTime)>();
        private const int MaxLoginAttempts = 3;
        private static TimeSpan LockoutDuration = TimeSpan.FromMinutes(5);

        public bool SprawdzDaneLogowania(string login, string haslo)
        {
            // Sprawdź, czy login ma ograniczenie na liczbę prób logowania
            if (loginAttempts.ContainsKey(login))
            {
                var attempt = loginAttempts[login];
                if (attempt.attempts >= MaxLoginAttempts && DateTime.Now - attempt.lastAttempt < LockoutDuration)
                {
                    MessageBox.Show("Konto zostało zablokowane na 5 minut. Spróbuj ponownie później.");
                    return false;
                }
                else if (DateTime.Now - attempt.lastAttempt >= LockoutDuration)
                {
                    // Jeśli upłynął czas blokady, zresetuj liczbę prób
                    loginAttempts[login] = (0, DateTime.Now);
                }
            }
            else
            {
                // Jeśli login nie istnieje w słowniku, dodaj go z pierwszą próbą
                loginAttempts.Add(login, (1, DateTime.Now));
            }

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id_uzytkownik FROM uzytkownik WHERE u_login = @Login AND u_haslo = @Haslo";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Haslo", haslo);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);
                            UstawZalogowanegoUzytkownika(id, login, haslo);
                            // Zresetuj liczbę prób po poprawnym zalogowaniu
                            loginAttempts[login] = (0, DateTime.Now);
                            return true;
                        }
                        else
                        {
                            // Inkrementuj liczbę prób po nieudanym logowaniu
                            loginAttempts[login] = (loginAttempts[login].attempts + 1, DateTime.Now);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas sprawdzania danych logowania: " + ex.Message);
                    return false;
                }
            }
        }


        public bool CzyUzytkownikZalogowany()
        {
            return !string.IsNullOrEmpty(zalogowanyUzytkownikLogin);
        }

        public bool CzyLoginPoprawny(string login)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM uzytkownik WHERE u_login = @Login";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd podczas sprawdzania loginu: " + ex.Message);
                    return false;
                }
            }
        }
        public (bool, bool) Zaloguj(string login, string haslo)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id_uzytkownik FROM uzytkownik WHERE u_login = @Login AND u_haslo = @Haslo";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Haslo", haslo);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);
                            UstawZalogowanegoUzytkownika(id, login, haslo);

                            // Sprawdzamy uprawnienia użytkownika
                            bool isAdmin = CzyUzytkownikMaUprawnienie(id, "Administrator");
                            bool isLoggedUser = CzyUzytkownikMaUprawnienie(id, "Użytkownik zalogowany");

                            return (true, isAdmin);
                        }
                        else
                        {
                            return (false, false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas logowania: " + ex.Message);
                    return (false, false);
                }
            }
        }
        private bool CzyUzytkownikMaUprawnienie(int idUzytkownika, string uprawnienie)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT COUNT(*) FROM pary_uprawnienia pu
                             JOIN uprawnienia u ON pu.id_uprawnienia = u.id_uprawnienia
                             WHERE pu.id_uzytkownik = @IdUzytkownika AND u.uprawnienia = @Uprawnienie";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUzytkownika", idUzytkownika);
                        command.Parameters.AddWithValue("@Uprawnienie", uprawnienie);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas sprawdzania uprawnień: " + ex.Message);
                    return false;
                }
            }
        }

        public void Wyloguj()
        {
            zalogowanyUzytkownikLogin = null;
            zalogowanyUzytkownikHaslo = null;

            MessageBox.Show("Wylogowano");

        }

        public List<string> GetPermissionsForUser(int userId)
        {
            List<string> permissions = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT p.uprawnienia 
                             FROM uprawnienia p 
                             JOIN pary_uprawnienia pu ON p.id_uprawnienia = pu.id_uprawnienia 
                             WHERE pu.id_uzytkownik = @UserID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", ZalogowanyUzytkownikId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                permissions.Add(reader["uprawnienia"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania uprawnień użytkownika: " + ex.Message);
                }
            }

            return permissions;
        }


        public bool UserExists(string email, string login)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM uzytkownik WHERE u_email = @Email AND u_login = @Login";


                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Login", login);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas sprawdzania użytkownika w bazie danych: " + ex.Message);
                    return false;
                }
            }
        }


        public bool UpdatePassword(string email, string newPassword)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE uzytkownik SET u_haslo = @NewPassword WHERE u_email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas aktualizacji hasła w bazie danych: " + ex.Message);
                    return false;
                }
            }
        }


    }
}






