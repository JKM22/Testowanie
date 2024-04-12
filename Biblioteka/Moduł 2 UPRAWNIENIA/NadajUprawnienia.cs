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
using MySql.Data.MySqlClient;

namespace Biblioteka
{
    public partial class NadajUprawnienia : Form
    {
        private PolaczenieBazyKlasa polaczenieBazy = new PolaczenieBazyKlasa();
        private DodajUsunWyszukajKlasa dodajUzytkownika = new DodajUsunWyszukajKlasa();
        private UprawnieniaKlasa uprawnieniaKlasa = new UprawnieniaKlasa();
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        public NadajUprawnienia()
        {
            InitializeComponent();
            SetupListView1();
            SetupListView2();
            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;
            polaczenieBazy.PopulateListViewFrom2(listView1);
            uprawnieniaKlasa.WyswietlUprawnienia(listView2); // Wyświetlenie uprawnień w listView2
            WyswietlUprawnienia();
            listView1.MouseClick += listView1_MouseClick;
        }

        private void SetupListView1()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            // Usuń wszystkie kolumny, które nie są potrzebne
            listView1.Columns.Clear();

            // Dodaj kolumny
            listView1.Columns.Add("id", 25);
            listView1.Columns.Add("login", 100);
            listView1.Columns.Add("email", 150);
            listView1.Columns.Add("UPRAWNIENIA", 400);
        }
        private void SetupListView2()
        {
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView2.MultiSelect = false;


            listView2.Columns.Add("Lp.", 35);
            listView2.Columns.Add("Uprawnienia", 230);
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            // Usuń wszystkie kolumny, które nie są potrzebne
            listView1.Columns.Clear();

            // Dodaj kolumny login i email
            listView1.Columns.Add("id", 25); // Ustaw szerokość kolumny login
            listView1.Columns.Add("login", 100); // Ustaw szerokość kolumny login
            listView1.Columns.Add("email", 200); // Ustaw szerokość kolumny email
            listView1.Columns.Add("uprawnienia", 400); // Ustaw szerokość kolumny email
        }



        private void NadajUprawnienia_Load(object sender, EventArgs e)
        {
            polaczenieBazy.PopulateListViewFrom2(listView1);
        }
        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item != e.Item)
                {
                    item.Selected = false;
                }
            }
        }
        public void WyswietlUprawnienia()
        {
            // Wywołanie metody WyswietlUprawnienia z klasy UprawnieniaKlasa
            uprawnieniaKlasa.WyswietlUprawnienia(listView1);
        }
        private void button_Wroc_Click(object sender, EventArgs e)
        {
            Uprawnienia uprawnienia = new Uprawnienia();
            uprawnienia.Show();
            this.Hide();
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            ListViewItem selectedItem = listView1.Items[index];
            int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
            string login = selectedItem.SubItems[1].Text; // Poprawiony indeks na 1
            string email = selectedItem.SubItems[2].Text;
            string uprawnienia = selectedItem.SubItems[3].Text;

                    textBox_usun.Text = login;


            // Pobierz uprawnienia z wybranego wiersza
            string permissions = selectedItem.SubItems[3].Text;

            // Podziel uprawnienia na oddzielne uprawnienia
            string[] permissionArray = permissions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Wyczyść listView3
            listView3.Items.Clear();

            // Dodaj uprawnienia do listView3
            foreach (string permission in permissionArray)
            {
                listView3.Items.Add(permission.Trim()); // Usuń białe znaki z uprawnienia
            }

        }






        private void button_DodajUprawnienie_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika, któremu chcesz nadać uprawnienie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Przerwij działanie metody
            }


            int index = listView1.FocusedItem.Index;


            ListViewItem selectedItem = listView1.Items[index];
            string login = selectedItem.SubItems[0].Text;
            string email = selectedItem.SubItems[1].Text;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Zatwierdz_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika oraz uprawnienie, które chcesz przypisać użytkownikowi.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz ID wybranego użytkownika z listView1
            int selectedUserId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);

            // Pobierz nazwę wybranego uprawnienia z listView2
            string selectedPermissionName = listView2.SelectedItems[0].SubItems[1].Text;

            // Sprawdź, czy użytkownik już ma to uprawnienie
            if (UserHasPermission(selectedUserId, selectedPermissionName))
            {
                MessageBox.Show("Ten użytkownik już posiada wybrane uprawnienie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz ID wybranego uprawnienia z bazy danych
            string permissionIdQuery = $"SELECT id_uprawnienia FROM uprawnienia WHERE uprawnienia = '{selectedPermissionName}'";

            int permissionId = 0;

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Pobierz ID wybranego uprawnienia
                    using (MySqlCommand command = new MySqlCommand(permissionIdQuery, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            permissionId = Convert.ToInt32(result);
                        }
                    }

                    // Przypisz ID pary uprawnienia do użytkownika
                    string assignPermissionQuery = $"INSERT INTO pary_uprawnienia (id_uzytkownik, id_uprawnienia) VALUES ({selectedUserId}, {permissionId})";

                    using (MySqlCommand command = new MySqlCommand(assignPermissionQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pomyślnie przypisano uprawnienie do użytkownika.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Odśwież listę użytkowników w listView1
                            RefreshUserPermissionsListView(selectedUserId);

                            RefreshPermissionsListView3(selectedUserId);
                        }
                        else
                        {
                            MessageBox.Show("Wystąpił błąd podczas przypisywania uprawnienia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool UserHasPermission(int userId, string permissionName)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = $"SELECT COUNT(*) FROM pary_uprawnienia WHERE id_uzytkownik = {userId} AND id_uprawnienia IN (SELECT id_uprawnienia FROM uprawnienia WHERE uprawnienia = '{permissionName}')";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void RefreshUserPermissionsListView(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = $"SELECT uprawnienia FROM uprawnienia WHERE id_uprawnienia IN (SELECT id_uprawnienia FROM pary_uprawnienia WHERE id_uzytkownik = {userId})";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> permissionsList = new List<string>();
                        while (reader.Read())
                        {
                            string permission = reader.GetString("uprawnienia");
                            permissionsList.Add(permission);
                        }

                        // Połącz uprawnienia użytkownika, oddzielając je przecinkiem
                        string userPermissions = string.Join(", ", permissionsList);

                        // Wstaw uprawnienia do ListView dla wybranego użytkownika
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (Convert.ToInt32(item.SubItems[0].Text) == userId)
                            {
                                item.SubItems[3].Text = userPermissions;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika oraz uprawnienie, które chcesz usunąć.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobierz ID wybranego użytkownika z listView1
            int selectedUserId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);

            // Pobierz nazwę wybranego uprawnienia z listView3
            string selectedPermissionName = listView3.SelectedItems[0].Text;

            // Pobierz ID wybranego uprawnienia z bazy danych
            int permissionId = GetPermissionId(selectedPermissionName);

            if (permissionId == -1)
            {
                MessageBox.Show("Nie można znaleźć identyfikatora uprawnienia w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usuń uprawnienie z bazy danych
            if (!RemovePermissionFromDatabase(selectedUserId, permissionId))
            {
                MessageBox.Show("Wystąpił problem podczas usuwania uprawnienia z bazy danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Odśwież listę uprawnień dla użytkownika w listView1
            RefreshUserPermissionsListView(selectedUserId);
        }

        private int GetPermissionId(string permissionName)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = $"SELECT id_uprawnienia FROM uprawnienia WHERE uprawnienia = '{permissionName}'";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Zwróć -1, jeśli nie można znaleźć identyfikatora uprawnienia
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        private bool RemovePermissionFromDatabase(int userId, int permissionId)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string deletePermissionQuery = $"DELETE FROM pary_uprawnienia WHERE id_uzytkownik = {userId} AND id_uprawnienia = {permissionId}";
                MySqlCommand command = new MySqlCommand(deletePermissionQuery, connection);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Po usunięciu uprawnienia z bazy danych, odśwież listView3
                        RefreshPermissionsListView3(userId);
                    }
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void RefreshPermissionsListView3(int userId)
        {
            // Wyczyść listView3
            listView3.Items.Clear();

            // Pobierz uprawnienia dla danego użytkownika z bazy danych
            List<string> userPermissions = GetUserPermissions(userId);

            // Dodaj uprawnienia do listView3
            foreach (string permission in userPermissions)
            {
                listView3.Items.Add(permission.Trim()); // Usuń białe znaki z uprawnienia
            }
        }

        private List<string> GetUserPermissions(int userId)
        {
            List<string> permissionsList = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = $"SELECT uprawnienia FROM uprawnienia WHERE id_uprawnienia IN (SELECT id_uprawnienia FROM pary_uprawnienia WHERE id_uzytkownik = {userId})";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string permission = reader.GetString("uprawnienia");
                            permissionsList.Add(permission);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return permissionsList;
        }


    }


}
