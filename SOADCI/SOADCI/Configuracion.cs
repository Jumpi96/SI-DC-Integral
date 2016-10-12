using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOADCI
{
    public partial class Configuración : Form
    {
        public Configuración()
        {
            InitializeComponent();

            this.txtRaiz.Text = Globales.getInstancia().PATH;
            this.txtModelo.Text = Globales.getInstancia().ARCHIVOS;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pass = Globales.getInstancia().PASS;

            if (txtActual.Text=="" && txtNueva.Text=="")
            {
                if (MessageBox.Show("La carpeta no moverá los archivos que contiene. ¿Está seguro de querer cambiarlo?", "Mover carpeta de archivos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControlarContraseña cons = new ControlarContraseña();
                    cons.ShowDialog();
                    if (cons.DialogResult == DialogResult.OK)
                    {
                        if (txtRaiz.Text != Globales.getInstancia().PATH)
                        {
                            Globales.getInstancia().PATH = txtRaiz.Text;

                        }
                        Globales.getInstancia().ARCHIVOS = txtModelo.Text;
                        this.Close();
                    }
                }
            }
            else
                if(txtActual.Text.Equals(pass))
                {
                    Globales.getInstancia().PASS = txtNueva.Text;
                    if (txtRaiz.Text != Globales.getInstancia().PATH)
                    {
                        Directory.Move(Globales.getInstancia().PATH, txtRaiz.Text);
                        Globales.getInstancia().PATH = txtRaiz.Text;
                    }
                    Globales.getInstancia().ARCHIVOS = txtModelo.Text;
                    this.Close();
            }
                else
                    MessageBox.Show("Las contraseñas no son correctas", "Configuracion");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            txtRaiz.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Configuración_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            txtModelo.Text = folderBrowserDialog1.SelectedPath;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
