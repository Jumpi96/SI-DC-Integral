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
    public partial class ConsultarContactos : Form
    {
        private Cliente cliente;
        private Contacto contacto;

        public ConsultarContactos()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }
        private void toolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button4, "Eliminar contacto");
            toolTip.SetToolTip(button2, "Registrar contacto");
        }
        private void ConsultarContactos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Contactos' table. You can move, or remove it, as needed.
            this.contactosTableAdapter.FillContactosPorCliente(this.databaseFinalDataSet.Contactos,cliente.Numero);

        }

        internal void LoadOrders(Cliente cli)
        {
            cliente = cli;
            this.Text = "Contactos - " + cli.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            { 
                int numero= (int)(listBox1.SelectedItem as DataRowView)["Numero"];
                String nombre=(listBox1.SelectedItem as DataRowView)["Nombre"].ToString();
                String descripcion= (listBox1.SelectedItem as DataRowView)["Descripcion"].ToString();
                Cliente cliente = new Cliente((int)(listBox1.SelectedItem as DataRowView)["NumeroCliente"]);
                String telefono = (listBox1.SelectedItem as DataRowView)["Telefono"].ToString();
                String correo = (listBox1.SelectedItem as DataRowView)["Correo"].ToString(); ;
                int modPor = 1;

                contacto = new Contacto(numero,nombre, descripcion, cliente, telefono, correo, modPor);

                textBox1.Text = nombre;
                textBox2.Text = descripcion;
                textBox3.Text = telefono;
                textBox4.Text = correo;
            }

            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir Form Registrar contacto
            RegistrarContacto reg = new RegistrarContacto();
            reg.LoadOrders(cliente);
            reg.ShowDialog();
            this.contactosTableAdapter.FillContactosPorCliente(this.databaseFinalDataSet.Contactos, cliente.Numero);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el contacto?", "Eliminar contacto",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatabaseFinalDataSet.ContactosRow contactosRow = databaseFinalDataSet.Contactos.FindByNumero(contacto.Numero);
                contactosRow.Delete();

                try
                {
                    this.Validate();
                    this.contactosBindingSource.EndEdit();
                    this.contactosTableAdapter.Update(this.databaseFinalDataSet.Contactos);
                    MessageBox.Show("El contacto ha sido eliminado.");
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    this.contactosTableAdapter.FillContactosPorCliente(this.databaseFinalDataSet.Contactos, cliente.Numero);
                    button3.Enabled = false;
                    button4.Enabled = false;

                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: el contacto no pudo ser eliminado.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseFinalDataSet.ContactosRow contactosRow = databaseFinalDataSet.Contactos.FindByNumero(contacto.Numero);

            String nom = textBox1.Text;
            String des = textBox2.Text;
            String tel = textBox3.Text;
            String cor = textBox4.Text;

            contactosRow.Nombre = nom;
            contactosRow.Descripcion = des;
            contactosRow.Telefono = tel;
            contactosRow.Correo = cor;

            try
            {
                this.Validate();
                this.contactosBindingSource.EndEdit();
                this.contactosTableAdapter.Update(this.databaseFinalDataSet.Contactos);
                contacto = new Contacto(contactosRow.Numero, contactosRow.Nombre, contactosRow.Descripcion, new Cliente(contactosRow.NumeroCliente), contactosRow.Telefono,  contactosRow.Correo, 1);
                MessageBox.Show("El contacto ha sido editado.");
                this.contactosTableAdapter.FillContactosPorCliente(this.databaseFinalDataSet.Contactos, cliente.Numero);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: el contacto no pudo ser editado.");
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
