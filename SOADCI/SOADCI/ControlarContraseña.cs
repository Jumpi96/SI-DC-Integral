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
    public partial class ControlarContraseña : Form
    {
        public ControlarContraseña()
        {
            InitializeComponent();
        }


        private void ControlarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == Globales.PASS)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("La contraseña es incorrecta", "Autenticación");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
