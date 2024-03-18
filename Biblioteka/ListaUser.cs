using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteka
{
    public partial class ListaUser : Form
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public ListaUser()
        {
            InitializeComponent();
            SetupListView();
            PopulateListView();
        }

        private void SetupListView()
        {
            listView1.View = View.Details;

            // Dodaj kolumny dla każdego pola z bazy danych
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Imię", 100);
            listView1.Columns.Add("Nazwisko", 150);
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("Telefon", 100);
            listView1.Columns.Add("Miejscowość", 100);
            listView1.Columns.Add("Kod pocztowy", 80);
            listView1.Columns.Add("Ulica", 150);
            listView1.Columns.Add("Numer posesji", 100);
            listView1.Columns.Add("Numer lokalu", 100);
            listView1.Columns.Add("PESEL", 100);
            listView1.Columns.Add("Data urodzenia", 100);
            listView1.Columns.Add("Płeć", 80);
            listView1.Columns.Add("Login", 100);
            listView1.Columns.Add("Hasło", 150);
        }

        private void PopulateListView()
        {
            listView1.Items.Clear();

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
                                item.SubItems.Add(reader["u_data_ur"].ToString());
                                item.SubItems.Add(reader["u_plec"].ToString());
                                item.SubItems.Add(reader["u_login"].ToString());
                                item.SubItems.Add(reader["u_haslo"].ToString());

                                listView1.Items.Add(item);
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