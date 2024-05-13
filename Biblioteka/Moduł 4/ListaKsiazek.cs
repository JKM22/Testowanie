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
    public partial class ListaKsiazek : Form
    {
        private WyswietlKsiazki wyswietlKsiazki = new WyswietlKsiazki();
     

        public ListaKsiazek()
        {
            InitializeComponent();
          
            WyswietlListeKsiazek2();


            listView1.View = View.Details;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Tytuł", 150);
            listView1.Columns.Add("Autor", 100);
            listView1.Columns.Add("Gatunek", 100);
            listView1.Columns.Add("Wydawnictwo", 100);
            listView1.Columns.Add("Status", 100);

            WypelnijComboBoxNazwamiKolumn();
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;


            listView1.FullRowSelect = true; // Ustawienie FullRowSelect na true




        }
        private void WyswietlListeKsiazek2()
        {
            // Wywołaj metodę WyswietlListeKsiazek z obiektu wyswietlKsiazki,
            // przekazując listView1 jako argument
            wyswietlKsiazki.WyswietlListeKsiazek2(listView1);
        }
        private void ListaKsiazek_Load(object sender, EventArgs e)
        { 
            // Wywołaj funkcję WyswietlListeKsiazek2 z obiektu wyswietlKsiazki
            WyswietlListeKsiazek2();
        }

        private void WypelnijComboBoxNazwamiKolumn()
        {
            wyswietlKsiazki.WypelnijComboBoxNazwamiKolumn(comboBoxFilter);
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            wyswietlKsiazki.WypelnijComboBoxDane(selectedColumn, comboBoxDane);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadajBiblioteka = new ZarzadzajBiblioteka();
            zarzadajBiblioteka.Show();
            this.Hide();
        }

        private void ListaKsiazek_Load_1(object sender, EventArgs e)
        {

        }

        private void button_filtruj_Click(object sender, EventArgs e)
        {
           
                // Pobierz wybraną wartość z comboBoxDane
                string selectedValue = comboBoxDane.SelectedItem.ToString();

                // Sprawdź, która kolumna jest wybrana w comboBoxFilter
                string selectedColumn = comboBoxFilter.SelectedItem.ToString();

                // Wywołaj metodę do filtrowania danych z wyswietlKsiazki
                wyswietlKsiazki.FiltrujDane(selectedColumn, selectedValue, listView1);
            }

        private void button_odswiez_Click(object sender, EventArgs e)
        {
            // Ponownie wywołaj metodę WyswietlListeKsiazek2, aby odświeżyć listView1
            WyswietlListeKsiazek2();
            // Odśwież comboboxy
            WypelnijComboBoxNazwamiKolumn();


        }

        private void button_podglad_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy wybrano jakąś książkę w listView
            if (listView1.SelectedItems.Count > 0)
            {
                // Pobieramy identyfikator wybranej książki (zakładając, że identyfikator jest w pierwszej kolumnie)
                int selectedBookId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                // Wywołujemy metodę WyswietlPelneInformacjeOKsiazce z obiektu wyswietlKsiazki
                string pelneInformacje = wyswietlKsiazki.WyswietlPelneInformacjeOKsiazce(selectedBookId);

                // Wyświetlamy pełne informacje o wybranej książce w komunikacie MessageBox
                MessageBox.Show(pelneInformacje);
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę do podglądu.");
            }
        }

    }

}