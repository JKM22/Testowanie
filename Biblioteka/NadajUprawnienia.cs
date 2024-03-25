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
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        public NadajUprawnienia()
        {
            InitializeComponent();
            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;
            SetupListView();
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            // Usuń wszystkie kolumny, które nie są potrzebne
            listView1.Columns.Clear();

            // Dodaj kolumny login i email
            listView1.Columns.Add("login", 100); // Ustaw szerokość kolumny login
            listView1.Columns.Add("email", 200); // Ustaw szerokość kolumny email
           
        }

        private void NadajUprawnienia_Load(object sender, EventArgs e)
        {
            polaczenieBazy.PopulateListView2(listView1);
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

        private void button_Wroc_Click(object sender, EventArgs e)
        {
            Uprawnienia uprawnienia= new Uprawnienia();
            uprawnienia.Show();
            this.Hide();
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Pobierz indeks klikniętego elementu
            int index = listView1.FocusedItem.Index;

            // Użyj indeksu do pobrania konkretnego użytkownika z listy
            ListViewItem selectedItem = listView1.Items[index];
            string login = selectedItem.SubItems[0].Text;
            string email = selectedItem.SubItems[1].Text;

            // Tutaj możesz wywołać odpowiednią metodę lub działanie
            // na kliknięciu przycisku "Dodaj Uprawnienia"
            
        }

        private void button_DodajUprawnienie_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz użytkownika, któremu chcesz nadać uprawnienie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Przerwij działanie metody
            }

            // Pobierz indeks klikniętego elementu
            int index = listView1.FocusedItem.Index;

            // Użyj indeksu do pobrania konkretnego użytkownika z listy
            ListViewItem selectedItem = listView1.Items[index];
            string login = selectedItem.SubItems[0].Text;
            string email = selectedItem.SubItems[1].Text;

            // Tutaj możesz dodać kod do dodawania uprawnienia dla wybranego użytkownika
           
            DodajUprawnienia dodajUprawnienia = new DodajUprawnienia();
            dodajUprawnienia.Show();
            this.Hide();
        }
    }
}
