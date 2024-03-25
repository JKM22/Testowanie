using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteka
{

    public class UprawnieniaKlasa
    {
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";

        public void WyswietlUprawnienia(ListView listView)
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
                    string query = "SELECT id_uprawnienia, uprawnienia FROM uprawnienia";

                    // Tworzymy obiekt MySqlCommand
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Tworzymy obiekt MySqlDataReader do odczytu wyników zapytania
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Dodajemy uprawnienia do listView
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id_uprawnienia"); // Pobranie ID jako int
                            string uprawnienie = reader.GetString("uprawnienia");

                            // Tworzymy nowy element ListViewItem z ID i uprawnieniem
                            ListViewItem item = new ListViewItem(new[] { id.ToString(), uprawnienie });
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
    }
}


