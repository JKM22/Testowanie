using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Imię", 100);
            listView1.Columns.Add("Nazwisko", 150);
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("login", 250);
        }
        private void PopulateListView()
        {
            listView1.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM klient";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["id_klient"].ToString());
                                item.SubItems.Add(reader["k_imie"].ToString());
                                item.SubItems.Add(reader["k_nazwisko"].ToString());
                                item.SubItems.Add(reader["k_email"].ToString());
                                item.SubItems.Add(reader["k_login"].ToString());
                                item.SubItems.Add(reader["k_haslo"].ToString());

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