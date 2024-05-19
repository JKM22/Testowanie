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

namespace Biblioteka.Moduł_4
{
    public partial class ListaWypozyczen : Form
    {
        private WypozyczeniaKsiazekKlasa wypozyczeniaKsiazekKlasa = new WypozyczeniaKsiazekKlasa();
        public ListaWypozyczen()
        {
            InitializeComponent();

            listView2.View = View.Details;
            listView2.Columns.Add("ID", 50);
            listView2.Columns.Add("Imie", 70);
            listView2.Columns.Add("Nazwisko", 70);
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
         
        }
    }
    }



