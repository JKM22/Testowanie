using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComponentFactory.Krypton.Toolkit;

namespace Biblioteka
{
    public partial class Roboczy : KryptonForm
    {
        private PolaczenieBazyKlasa polaczenieBazy = new PolaczenieBazyKlasa();
        private DodajUsunWyszukajKlasa dodajUzytkownika = new DodajUsunWyszukajKlasa();
        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";  
        public Roboczy()
        {
            InitializeComponent();
            SetupListView();
            
            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

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

     
 
        private void button_wroc_Click(object sender, EventArgs e)
        {
           Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void buttonGoToAddUser_Click(object sender, EventArgs e)
        {
            DodajUzytkownika dodajuzytkownika = new DodajUzytkownika();
            dodajuzytkownika.Show();
            this.Hide();
          
        }

        private void Roboczy_Load(object sender, EventArgs e)
        {
            polaczenieBazy.PopulateListView(listView1);
        }

        private void buttonGoToModUser_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string idKlienta = selectedItem.SubItems[0].Text;
                string imie = selectedItem.SubItems[1].Text;
                string nazwisko = selectedItem.SubItems[2].Text;
                string email = selectedItem.SubItems[3].Text;
                string telefon = selectedItem.SubItems[4].Text;
                string miejscowosc = selectedItem.SubItems[5].Text;
                string kodPocztowy = selectedItem.SubItems[6].Text;
                string ulica = selectedItem.SubItems[7].Text;
                string nrPosesji = selectedItem.SubItems[8].Text;
                string nrLokalu = selectedItem.SubItems[9].Text;
                string pesel = selectedItem.SubItems[10].Text;
                string dataUrodzenia = selectedItem.SubItems[11].Text;
                string plec = selectedItem.SubItems[12].Text;
                string login = selectedItem.SubItems[13].Text;
                string haslo = selectedItem.SubItems[14].Text;

                ModyfikacjaUzytkownika modyfikacjaUzytkownika = new ModyfikacjaUzytkownika(idKlienta, imie, nazwisko, email, telefon, miejscowosc, kodPocztowy, ulica, nrPosesji, nrLokalu, pesel, dataUrodzenia, plec, login, haslo);
                modyfikacjaUzytkownika.Show();
                this.Hide();
            }
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

        private void buttonGoToDelUser_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć wybranego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        string id_uzytkownik = item.SubItems[0].Text;
                        dodajUzytkownika.UsunUzytkownikaZBazy(id_uzytkownik);
                        listView1.Items.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz co najmniej jednego użytkownika do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_wyszukaj_Click_1(object sender, EventArgs e)
        {

            string frazaWyszukiwania = textBox_wyszukaj.Text.Trim();

            if (string.IsNullOrEmpty(frazaWyszukiwania))
            {
                MessageBox.Show("Wprowadź frazę do wyszukania.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dodajUzytkownika.WyszukajUzytkownika(listView1, frazaWyszukiwania);
        }

        private void button_odwiez_Click(object sender, EventArgs e)
        {
            polaczenieBazy.PopulateListView(listView1);
        }
    }
}
