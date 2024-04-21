using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Biblioteka
{
    public partial class Uprawnienia : KryptonForm
    {
        public Uprawnienia()
        {
            InitializeComponent();
        }

        private void button_NadajUprawnienia_Click(object sender, EventArgs e)
        {
            NadajUprawnienia nadajUprawnienia=new NadajUprawnienia();
            nadajUprawnienia.Show();
            this.Hide();
        }

        private void button_Wroc_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show(); 
            this.Hide();
        }

        private void button_PrzegladajUprawnienia_Click(object sender, EventArgs e)
        {
            PrzegladajUprawnienia przegladajUprawnienia =  new PrzegladajUprawnienia();
            przegladajUprawnienia.Show();
            this.Hide();
        }

        private void button_PrzegladajUzytkownikow_Click(object sender, EventArgs e)
        {
            WyszukajUprawnienie wyszukajUprawnienie = new WyszukajUprawnienie();
            wyszukajUprawnienie.Show();
            this.Hide();
                
        }

        private void Uprawnienia_Load(object sender, EventArgs e)
        {

        }
    }
}
