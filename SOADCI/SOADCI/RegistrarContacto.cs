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
    public partial class RegistrarContacto : Form
    {
        private Cliente cliente;
        private DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
        private DatabaseLocalDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;
        private System.Windows.Forms.BindingSource contactosBindingSource;


        public RegistrarContacto()
        {
            InitializeComponent();
        }

        private void RegistrarContacto_Load(object sender, EventArgs e)
        {
            
        }

        internal void LoadOrders(Cliente cli)
        {
            cliente = cli;
            this.Text = "Contactos - " + cli.Nombre;

            databaseLocalDataSet = new DatabaseLocalDataSet();
            contactosTableAdapter = new DatabaseLocalDataSetTableAdapters.ContactosTableAdapter();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            this.contactosBindingSource.DataMember = "Contactos";
            this.contactosBindingSource.DataSource = this.databaseLocalDataSet;
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseLocalDataSet.ContactosRow ContactosRow = databaseLocalDataSet.Contactos.NewContactosRow();


            ContactosRow.Nombre = textBox1.Text;
            ContactosRow.Descripcion = textBox2.Text;
            ContactosRow.Telefono = textBox3.Text;
            ContactosRow.Correo = textBox4.Text;
            ContactosRow.NumeroCliente = cliente.Numero;
            ContactosRow.ModPor = 1; // Usuario

            if (ContactosRow.Nombre == "")
                MessageBox.Show("Ingrese un nombre para el contacto.");
            else
            {

                databaseLocalDataSet.Contactos.Rows.Add(ContactosRow);

                try
                {
                    this.Validate();
                    this.contactosBindingSource.EndEdit();
                    this.contactosTableAdapter.Update(this.databaseLocalDataSet.Contactos);
                    MessageBox.Show("El contacto ha sido registrado.");
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: el contacto no pudo ser ingresado.");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}