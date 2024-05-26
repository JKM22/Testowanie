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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

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
            listView1.Columns.Add("Gatunek", 100);
            listView1.Columns.Add("Tytul", 100);
            listView1.Columns.Add("Wydawnictwo", 150);
            listView1.Columns.Add("Data rejestracji", 120);
            listView1.Columns.Add("Osoba rejestrująca", 100);
            listView1.Columns.Add("Liczba dodanych sztuk", 150);


            WyswietlListeRejestracji();
            klasaListaRejestracjiKsiazek.WypelnijComboBoxAutor(comboBox_autor);
            klasaListaRejestracjiKsiazek.WypelnijComboBoxTytul(comboBox_tytul);
            klasaListaRejestracjiKsiazek.WypelnijComboBoxGatunek(comboBox_gatunek);
            klasaListaRejestracjiKsiazek.WypelnijComboBoxWydawnictwo(comboBox_wydawnictwo);
            klasaListaRejestracjiKsiazek.WypelnijComboBoxOsobaRejestrujaca(comboBox_osoba);

            this.comboBox_tytul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_tytul_KeyPress);
            this.comboBox_wydawnictwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_wydawnictwo_KeyPress);
            this.comboBox_gatunek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_gatunek_KeyPress);
            this.comboBox_osoba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_osoba_KeyPress);
        }


        private void comboBox_tytul_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }

        private void comboBox_gatunek_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }

        private void comboBox_wydawnictwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
        }
        private void comboBox_osoba_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdź, czy wprowadzony znak jest literą, przecinkiem lub kropką, lub jest to klawisz Backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Jeśli nie jest, zablokuj jego dodanie do textboxa
                e.Handled = true;
            }
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
            KlasaListaRejestracjiKsiazek listaRejestracji = new KlasaListaRejestracjiKsiazek();
            listaRejestracji.FiltrujListe(listView1, comboBox_autor, comboBox_tytul, comboBox_gatunek, comboBox_wydawnictwo, comboBox_osoba, dateTimePicker_od, dateTimePicker_do);
        }



        private void button_odswiez_Click(object sender, EventArgs e)
        {
            KlasaListaRejestracjiKsiazek listaRejestracji = new KlasaListaRejestracjiKsiazek();
            

            listaRejestracji.WyswietlListeRejestracji(listView1);



            // Wyczyść textboxy
            comboBox_autor.Text = "";
            comboBox_tytul.Text = "";
            comboBox_wydawnictwo.Text = "";
            comboBox_osoba.Text = "";
            comboBox_gatunek.Text = "";
            dateTimePicker_od.Value = new DateTime(2024, 1, 1);
            dateTimePicker_do.Value = new DateTime(2024, 12, 31);


        }

    }
    }


