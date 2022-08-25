using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCP_.CATALOGOS;

namespace SCP_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo. ¡Que tenga Buen Día!");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CATALOGOS.CLIENTES.Form_Cliente f = new CATALOGOS.CLIENTES.Form_Cliente();
            f.Show();
            this.Hide();
        }
    }
}
