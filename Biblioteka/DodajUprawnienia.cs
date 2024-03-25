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
    public partial class DodajUprawnienia : Form
    {
        private PolaczenieBazyKlasa polaczenieBazy = new PolaczenieBazyKlasa();
        private UprawnieniaKlasa uprawnieniaKlasa = new UprawnieniaKlasa();
        private int selectedPermissionId;

        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        public DodajUprawnienia()
        {

            InitializeComponent();
            SetupListViewColumns();
            WyswietlUprawnienia();
            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;


        }
        public void WyswietlUprawnienia()
        {
            // Wywołanie metody WyswietlUprawnienia z klasy UprawnieniaKlasa
            uprawnieniaKlasa.WyswietlUprawnienia(listView1);
        }

        private void SetupListViewColumns()
        {
            listView1.Columns.Add("Lp.", 50);
            listView1.Columns.Add("Uprawnienia", 230);
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

        }
        private void button_Wroc_Click(object sender, EventArgs e)
        {
            Uprawnienia uprawnienia = new Uprawnienia();
            uprawnienia.Show();
            this.Hide();
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

        private void button_Zatwierdz_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika przed zatwierdzeniem.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pobieramy ID użytkownika z wybranego wiersza
            int selectedUserId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text); // Załóżmy, że ID użytkownika jest w pierwszej kolumnie

            // Pobieramy ID wybranego uprawnienia
            ListViewItem selectedPermission = listView1.SelectedItems[0];
            string selectedPermissionName = selectedPermission.SubItems[1].Text; // Nazwa wybranego uprawnienia

            int permissionId = 0;

            // Pobieramy ID wybranego uprawnienia z bazy danych
            string permissionIdQuery = $"SELECT id_uprawnienia FROM uprawnienia WHERE uprawnienia = '{selectedPermissionName}'";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(permissionIdQuery, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            permissionId = Convert.ToInt32(result);
                        }
                    }

                    // Przypisujemy ID uprawnienia do użytkownika
                    string query = $"UPDATE uzytkownik SET id_uzytkownik_uprawnienia = {permissionId} WHERE id_uzytkownik = {selectedUserId}";

                    bool success = polaczenieBazy.WykonajZapytanie(query);

                    if (success)
                    {
                        MessageBox.Show("Pomyślnie przypisano uprawnienie do użytkownika.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas przypisywania uprawnienia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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