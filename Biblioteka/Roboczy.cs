using System;
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
    public partial class Roboczy : Form
    {
        public Roboczy()
        {
            InitializeComponent();
        }

        private void buttonGoToSearchUser_Click(object sender, EventArgs e)
        {
            ListaUser listaForm = new ListaUser();
            listaForm.Show();
        }
    }
}
