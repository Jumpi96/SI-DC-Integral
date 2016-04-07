﻿using System;
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
    public partial class ConsultarCliente : Form
    {

        private Cliente elegido;
        private String cadena;
        public ConsultarCliente()
        {
            InitializeComponent();


        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {   
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseLocalDataSet.TiposCliente);

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy(this.databaseLocalDataSet.Clientes, ((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy2(this.databaseLocalDataSet.Clientes, textBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizarCliente(int Numero)
        {
            
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                textBox8.Text = ((Int32)row.Cells["Tipo"].Value).ToString();
                textBox1.Text = ((Int32)row.Cells["Numero"].Value).ToString();
                textBox3.Text = (String)row.Cells["Nombre"].Value;
                textBox4.Text = (String)row.Cells["Domicilio"].Value;
                textBox5.Text = (String)row.Cells["TelFijo"].Value;
                textBox6.Text = (String)row.Cells["TelCel"].Value;
                textBox7.Text = (String)row.Cells["Correo"].Value;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                int tipo = (Int32)row.Cells["Tipo"].Value;
                int numero = (Int32)row.Cells["Numero"].Value;
                String nombre = (String)row.Cells["Nombre"].Value;
                String domicilio = (String)row.Cells["Domicilio"].Value;
                String telFijo = (String)row.Cells["TelFijo"].Value;
                String telCel = (String)row.Cells["TelCel"].Value;
                String correo = (String)row.Cells["Correo"].Value;
                int modPor = (Int32)row.Cells["ModPor"].Value;


                elegido = new Cliente(numero,nombre,domicilio,telFijo,telCel,correo,tipo,modPor);


                textBox8.Text = elegido.Tipo.ToString();
                textBox1.Text = elegido.Numero.ToString();
                textBox3.Text = elegido.Nombre;
                textBox4.Text = elegido.Domicilio;
                textBox5.Text = elegido.TelFijo;
                textBox6.Text = elegido.TelCel;
                textBox7.Text = elegido.Correo;

                button5.Enabled=true;
                cadena = Globales.PATH + "\\" + elegido.Nombre + "\\";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // EDITAR
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(cadena); //PROBLEMA CON ETA MIERDA
        }
    }
}
