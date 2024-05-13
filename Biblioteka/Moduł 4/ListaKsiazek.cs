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
    }

}