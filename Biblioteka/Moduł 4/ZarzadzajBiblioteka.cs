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
    public partial class ZarzadzajBiblioteka : Form
    {
        public ZarzadzajBiblioteka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void button_RejestracjaKsiazek_Click(object sender, EventArgs e)
        {
            ZarejestrujKsiazke zarejestrujKsiazke = new ZarejestrujKsiazke();
            zarejestrujKsiazke.Show();
            this.Hide();
        }

        private void button_listaKsiazek_Click(object sender, EventArgs e)
        {
            ListaKsiazek listaKsiazek = new ListaKsiazek();
            listaKsiazek.Show();    
            this.Hide();    
        }

        private void button_PrzegladajRejestracjaKsiazki_Click(object sender, EventArgs e)
        {
            ListaRejestracjiKsiazek listaRejestracjiKsiazki_ = new ListaRejestracjiKsiazek();
            listaRejestracjiKsiazki_.Show();
            this.Hide();
        }
    }
}
