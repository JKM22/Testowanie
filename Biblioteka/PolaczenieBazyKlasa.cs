﻿using MySql.Data.MySqlClient;
using System;
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
        public void PopulateListView2(ListView listView)
        {
            listView.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT u_login, u_email FROM uzytkownik";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Tworzenie obiektu ListViewItem z loginem i mailem
                                ListViewItem item = new ListViewItem(reader["u_login"].ToString()); // Login jako tekst pierwszej kolumny
                                item.SubItems.Add(reader["u_email"].ToString()); // Email jako kolejna kolumna

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
        }
    }




    


