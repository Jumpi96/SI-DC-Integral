using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOADCI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarCliente reg = new RegistrarCliente();

            reg.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarCliente con = new ConsultarCliente();
            con.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarObra regO = new RegistrarObra();
            regO.ShowDialog();
        }
    }
}
