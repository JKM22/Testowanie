using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

          


            listView1.FullRowSelect = true; // Ustawienie FullRowSelect na true
            wyswietlKsiazki.WypelnijComboBoxAutor(comboBox_autor);
            wyswietlKsiazki.WypelnijComboBoxTytul(comboBox_tytul);
            wyswietlKsiazki.WypelnijComboBoxGatunek(comboBox_gatunek);
            wyswietlKsiazki.WypelnijComboBoxWydawnictwo(comboBox_wydawnictwo);
            wyswietlKsiazki.WypelnijComboBoxStatus(comboBox_status);

            button_filtruj.Click += button_filtruj_Click;




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

     

        

     


        private void button1_Click(object sender, EventArgs e)
        {
            ZarzadzajBiblioteka zarzadajBiblioteka = new ZarzadzajBiblioteka();
            zarzadajBiblioteka.Show();
            this.Hide();
        }

      

        private void button_odswiez_Click(object sender, EventArgs e)
        {
            wyswietlKsiazki.WyswietlListeKsiazek2(listView1);

            // Wyczyść textboxy
            comboBox_autor.Text = "";
            comboBox_tytul.Text = "";
            comboBox_wydawnictwo.Text = "";
            comboBox_status.Text = "";
            comboBox_gatunek.Text = "";
          


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

        private void button_filtruj_Click(object sender, EventArgs e)
        {
            // Pobierz wybrane wartości z ComboBoxów
            string autor = comboBox_autor.SelectedItem?.ToString();
            string tytul = comboBox_tytul.SelectedItem?.ToString();
            string gatunek = comboBox_gatunek.SelectedItem?.ToString();
            string wydawnictwo = comboBox_wydawnictwo.SelectedItem?.ToString();
            string status = comboBox_status.SelectedItem?.ToString();

            // Wywołaj metodę PobierzDaneZBazy z odpowiednimi parametrami i przekaż ListView
            wyswietlKsiazki.PobierzDaneZBazy(autor, tytul, gatunek, wydawnictwo, status, listView1);
        }

        private void ListaKsiazek_Load_1(object sender, EventArgs e)
        {

        }
    }
}
