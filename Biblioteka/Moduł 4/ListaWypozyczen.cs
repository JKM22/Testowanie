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
using ComponentFactory.Krypton.Toolkit;
namespace Biblioteka.Moduł_4
{
    public partial class ListaWypozyczen : KryptonForm
    {
        private WypozyczeniaKsiazekKlasa wypozyczeniaKsiazekKlasa = new WypozyczeniaKsiazekKlasa();

        private bool isUserLoggedIn = false;
        private bool isAdmin = false;
        private int userId;
        public ListaWypozyczen()
        {
            InitializeComponent();
            ConfigureButtonAccess();

            listView2.View = View.Details;
            listView2.Columns.Add("ID", 50);
            listView2.Columns.Add("Wypożyczający", 70);
            listView2.Columns.Add("Bibliotekarz", 100);
            listView2.Columns.Add("Adres", 70);
            listView2.Columns.Add("Telefon", 70);
            listView2.Columns.Add("Autor", 100);
            listView2.Columns.Add("Tytuł", 100);
           
            listView2.Columns.Add("Data wypożyczenia", 70);
            listView2.Columns.Add("Okres wypożyczenia", 70);
            listView2.Columns.Add("Data zwrotu", 70);
            listView2.Columns.Add("Status wypożyczenia", 70);

            listView2.FullRowSelect = true;

            wypozyczeniaKsiazekKlasa.WypelnijComboBoxstatusWypozyczenia(comboBox_statusWypozyczenia);
            wypozyczeniaKsiazekKlasa.WypelnijComboBoxokresWypozyczenia(comboBox_okresWypozyczenia);
            wypozyczeniaKsiazekKlasa.WypelnijComboBoxBibliotekarz(comboBox_Bibliotekarz);
            wypozyczeniaKsiazekKlasa.WypelnijComboBoxWypozyczajacy(comboBox_Wypozyczajacy);

           
            PokazWypozyczenia();

            this.comboBox_Wypozyczajacy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Wypozyczajacy_KeyPress);
            this.comboBox_Bibliotekarz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Bibliotekarz_KeyPress);
            this.comboBox_okresWypozyczenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_okresWypozyczenia_KeyPress);
            this.comboBox_statusWypozyczenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_statusWypozyczenia_KeyPress);
        }

        

        private void comboBox_Wypozyczajacy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }

        private void comboBox_Bibliotekarz_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }


        private void comboBox_okresWypozyczenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest cyfrą
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do ComboBoxa
                e.Handled = true;
            }
        }

        private void comboBox_statusWypozyczenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest cyfrą
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }


        private bool HasPermission(string permission)
        {
            if (isAdmin) // Jeśli użytkownik jest administratorem, ma dostęp do wszystkich uprawnień
            {
                return true;
            }

            // Pobierz uprawnienia użytkownika z bazy danych
            PolaczenieBazyKlasa polaczenie = new PolaczenieBazyKlasa();
            List<string> userPermissions = polaczenie.GetPermissionsForUser(userId);

            // Sprawdź, czy użytkownik ma żądane uprawnienie
            return userPermissions.Contains(permission);
        }

        private void ConfigureButtonAccess()
        {
            // Pobierz ID zalogowanego użytkownika
            userId = PolaczenieBazyKlasa.ZalogowanyUzytkownikId;
            isUserLoggedIn = PolaczenieBazyKlasa.Zalogowany;

            // Sprawdź, czy użytkownik ma odpowiednie uprawnienia do poszczególnych przycisków
            button_Przedluz.Enabled = HasPermission("Bibliotekarz");
            button_Zwroc.Enabled = HasPermission("Bibliotekarz");


        }
        public void PokazWypozyczenia()
        {
            WypozyczeniaKsiazekKlasa wypozyczeniaKSiazekKlasa = new WypozyczeniaKsiazekKlasa();
            wypozyczeniaKsiazekKlasa.PokazWypozyczenia(listView2);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadzajBiblioteka = new ZarzadzajBiblioteka();
            zarzadzajBiblioteka.Show();
            this.Hide();
        }

        private void button_Przedluz_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy wybrano wypożyczenie
            if (listView2.SelectedItems.Count > 0)
            {
                // Pobierz ID wypożyczenia z zaznaczonego elementu listy
                int idWypozyczenia = Convert.ToInt32(listView2.SelectedItems[0].SubItems[0].Text);

                // Wyświetl komunikat z pytaniem
                DialogResult result = MessageBox.Show("Czy chcesz przedłużyć to wypożyczenie?", "Przedłużanie wypożyczenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Jeśli użytkownik wybierze "Tak", przedłuż wypożyczenie
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Wywołaj metodę PrzedluzWypozyczenie z klasy WypozyczeniaKsiazekKlasa
                        wypozyczeniaKsiazekKlasa.PrzedluzWypozyczenie(idWypozyczenia, 14);

                        // Odśwież listę wypożyczeń
                        MessageBox.Show("Pomyślnie przedłużono wypożyczenie.", "Sukces", MessageBoxButtons.OK);
                        PokazWypozyczenia();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas przedłużania wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać wypożyczenie do przedłużenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button_Zwroc_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy wybrano wypożyczenie
            if (listView2.SelectedItems.Count > 0)
            {
                // Pobierz ID wypożyczenia z zaznaczonego elementu listy
                int idWypozyczenia = Convert.ToInt32(listView2.SelectedItems[0].SubItems[0].Text);

                // Wyświetl komunikat potwierdzający zwrócenie wypożyczenia
                DialogResult result = MessageBox.Show("Czy na pewno chcesz zwrócić to wypożyczenie?", "Zwracanie wypożyczenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Jeśli użytkownik wybierze "Tak", zwróć wypożyczenie
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Wywołaj metodę ZwrocWypozyczenie z klasy WypozyczeniaKsiazekKlasa
                        wypozyczeniaKsiazekKlasa.ZwrocWypozyczenie(idWypozyczenia);

                        // Odśwież listę wypożyczeń
                        MessageBox.Show("Pomyślnie zwrócono wypożyczenie.", "Sukces", MessageBoxButtons.OK);
                        PokazWypozyczenia();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas zwracania wypożyczenia: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać wypożyczenie do zwrotu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Filtruj_Click(object sender, EventArgs e)
        {
            wypozyczeniaKsiazekKlasa.FiltrujDane2(comboBox_Wypozyczajacy, comboBox_Bibliotekarz, comboBox_okresWypozyczenia, comboBox_statusWypozyczenia, listView2);
        }

        private void button_Odswiez_Click(object sender, EventArgs e)
        {
            wypozyczeniaKsiazekKlasa.PokazWypozyczenia(listView2);

            comboBox_Wypozyczajacy.Text = "";
            comboBox_Bibliotekarz.Text = "";
            comboBox_okresWypozyczenia.Text = "";
            comboBox_statusWypozyczenia.Text = "";

        }
    }
    }



