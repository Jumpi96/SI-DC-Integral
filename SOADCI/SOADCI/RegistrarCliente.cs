using System;
using System.IO;
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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DatabaseFinalDataSet.ClientesRow newClientesRow = databaseFinalDataSet.Clientes.NewClientesRow();
            

            newClientesRow.Nombre = textBox1.Text;
            newClientesRow.Domicilio = textBox2.Text;
            newClientesRow.TelFijo = textBox3.Text;
            newClientesRow.TelCel = textBox4.Text;
            newClientesRow.Tipo = (int)comboBox1.SelectedValue;
            newClientesRow.Correo = textBox5.Text;
            newClientesRow.ModPor = 1; // Usuario

            if (newClientesRow.Nombre == "")
                MessageBox.Show("Ingrese un nombre para el cliente.");
            else
            {
                Directory.CreateDirectory(@Globales.PATH+"\\"+newClientesRow.Nombre);


                databaseFinalDataSet.Clientes.Rows.Add(newClientesRow);

                try
                {
                    this.Validate();
                    this.clientesBindingSource.EndEdit();
                    this.clientesTableAdapter.Update(this.databaseFinalDataSet.Clientes);
                    MessageBox.Show("El cliente ha sido registrado.");
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: el cliente no pudo ser ingresado.");
                }
            }


            
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseFinalDataSet.TiposCliente);
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposObra' table. You can move, or remove it, as needed.
            this.tiposObraTableAdapter.Fill(this.databaseFinalDataSet.TiposObra);
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.databaseFinalDataSet.Clientes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
