using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteka
{
    public partial class WyszukajUprawnienie : Form
    {
        private UprawnieniaKlasa uprawnieniaKlasa = new UprawnieniaKlasa();
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        private List<string> wybraneUprawnienia = new List<string>();
        public WyszukajUprawnienie()
        {
            InitializeComponent();

        }

        private void button_Wroc_Click(object sender, EventArgs e)
        {
            Uprawnienia uprawnienia = new Uprawnienia();
            uprawnienia.Show();
            this.Hide();
        }



        private void button_Wyszukaj_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Musisz wybrać uprawnienie przed wyszukaniem.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedPermission = comboBox1.SelectedItem.ToString();
            wybraneUprawnienia.Clear(); // Usunięcie poprzednich wybranych opcji
            wybraneUprawnienia.Add(selectedPermission);

            WyswietlWynikiWListView();
        }

        private void WyswietlWynikiWListView()
        {
            listView1.Items.Clear();
            listView1.Columns.Add("Login", 100);
            listView1.Columns.Add("Email", 200);


            foreach (string uprawnienia in wybraneUprawnienia)
            {
                string queryUsers = $@"
            SELECT u.u_email, u.u_login
            FROM uzytkownik u
            JOIN uprawnienia up ON u.id_uzytkownik_uprawnienia = up.id_uprawnienia
            WHERE up.uprawnienia = '{uprawnienia}'
        ";

                bool isAnyResultFound = false; // Flaga informująca, czy znaleziono wyniki dla danego uprawnienia

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(queryUsers, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Tworzenie pojedynczego elementu ListViewItem z dwoma podelementami
                                    ListViewItem item = new ListViewItem(reader["u_login"].ToString());
                                    item.SubItems.Add(reader["u_email"].ToString());

                                    // Dodanie pojedynczego elementu do ListView
                                    listView1.Items.Add(item);
                                    isAnyResultFound = true; // Ustaw flagę na true, gdy znajdzie wyniki
                                }
                            }
                        }

                        if (!isAnyResultFound)
                        {
                            MessageBox.Show("Brak wyników dla uprawnienia: " + uprawnienia, "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
