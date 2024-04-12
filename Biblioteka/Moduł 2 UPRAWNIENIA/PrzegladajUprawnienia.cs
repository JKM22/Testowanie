using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class PrzegladajUprawnienia : Form
    {
        private PolaczenieBazyKlasa polaczenieBazy = new PolaczenieBazyKlasa();
        private UprawnieniaKlasa uprawnieniaKlasa = new UprawnieniaKlasa();

        private const string ConnectionString = "Server=localhost;Database=biblioteka;Uid=root;Pwd=;";
        public PrzegladajUprawnienia()
        {
            InitializeComponent();
            SetupListViewColumns();
            WyswietlUprawnienia();


        }
        public void WyswietlUprawnienia()
        {
            // Wywołanie metody WyswietlUprawnienia z klasy UprawnieniaKlasa
            uprawnieniaKlasa.WyswietlUprawnienia(listView1);
        }

        private void SetupListViewColumns()
        {
            listView1.Columns.Add("Lp.", 50);
            listView1.Columns.Add("Uprawnienia", 230);
        }
        private void button_Wroc_Click(object sender, EventArgs e)
        {
            Uprawnienia uprawnienia = new Uprawnienia();
            uprawnienia.Show();
            this.Hide();
        }

        private void PrzegladajUprawnienia_Load(object sender, EventArgs e)
        {

        }
    }
}
