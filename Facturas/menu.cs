using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visualizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            
        }

        private void generadorEnMasaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
