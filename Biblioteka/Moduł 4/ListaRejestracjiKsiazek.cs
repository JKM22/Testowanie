using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.Moduł_4
{
    public partial class ListaRejestracjiKsiazek : Form
    {
        
        private KlasaListaRejestracjiKsiazek klasaListaRejestracjiKsiazek = new KlasaListaRejestracjiKsiazek();
        public ListaRejestracjiKsiazek()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Autor", 120);
            listView1.Columns.Add("Gatunek", 60);
            listView1.Columns.Add("Tytul", 100);
            listView1.Columns.Add("Wydawnictwo", 150);
            listView1.Columns.Add("Data rejestracji", 120);
            listView1.Columns.Add("Osoba rejestrująca", 100);
            listView1.Columns.Add("Status rejestracji", 130);

            WyswietlListeRejestracji();

            WypelnijComboBoxNazwamiKolumn();





            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            KlasaListaRejestracjiKsiazek klasaListaRejestracjiKsiazek = new KlasaListaRejestracjiKsiazek();
            klasaListaRejestracjiKsiazek.WypelnijComboBoxDane(selectedColumn, comboBox_Dane);
        }
        private void WypelnijComboBoxNazwamiKolumn()
        {
            comboBoxFilter.Items.Clear(); 

            KlasaListaRejestracjiKsiazek klasaListaRejestracjiKsiazek = new KlasaListaRejestracjiKsiazek();
            klasaListaRejestracjiKsiazek.WypelnijComboBoxNazwamiKolumn(comboBoxFilter);
        }


        private void ListaRejestracjiKsiazek_Load(object sender, EventArgs e)
        {

        }

        public void WyswietlListeRejestracji()
        {
            KlasaListaRejestracjiKsiazek klasaListaRejestracjiKsiazek = new KlasaListaRejestracjiKsiazek();
            klasaListaRejestracjiKsiazek.WyswietlListeRejestracji(listView1);
        }

        private void button_wroc_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadajBiblioteka = new ZarzadzajBiblioteka();
            zarzadajBiblioteka.Show();
            this.Hide();
        }

        private void button_filtruj_Click(object sender, EventArgs e)
        {

            // Sprawdź, czy wybrano jakiekolwiek wartości w obu comboboxach
            if (comboBox_Dane.SelectedItem == null || comboBoxFilter.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać kolumnę i wartość do filtrowania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Zakończ metodę, jeśli którakolwiek z wartości nie jest wybrana
            }

            // Pobierz wybraną wartość z comboBoxDane
            string selectedValue = comboBox_Dane.SelectedItem.ToString();

            // Pobierz wybraną kolumnę z comboBoxFilter
            string selectedColumn = comboBoxFilter.SelectedItem.ToString();

            // Wywołaj metodę do filtrowania danych z wyswietlKsiazki
            klasaListaRejestracjiKsiazek.FiltrujDane(selectedColumn, selectedValue, listView1);
        }

        private void button_odswiez_Click(object sender, EventArgs e)
        {
            // Ponownie wywołaj metodę WyswietlListeKsiazek2, aby odświeżyć listView1
            WyswietlListeRejestracji();
            // Odśwież comboboxy
            WypelnijComboBoxNazwamiKolumn(); // Dodaj tę linię
            comboBox_Dane.SelectedIndex = -1;
            comboBoxFilter.SelectedIndex = -1;
        }
    }
   }

