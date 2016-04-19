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
    public partial class ConsultarPagos : Form
    {
        private Presupuesto presupuesto;
        private Pago pago;

        public ConsultarPagos()
        {
            InitializeComponent();
            
        }

        internal void LoadOrders(Presupuesto pres)
        {
            presupuesto = pres;
            this.Text = "Pagos - " + presupuesto.Nombre;
        }

        private void ConsultarPagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Pagos' table. You can move, or remove it, as needed.
            this.pagosTableAdapter.FillByPresupuesto(this.databaseLocalDataSet.Pagos, presupuesto.Numero);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int numero = (int)(listBox1.SelectedItem as DataRowView)["Numero"];
                DateTime fecha = (DateTime)(listBox1.SelectedItem as DataRowView)["Fecha"];
                float monto = (float)Convert.ToDecimal((listBox1.SelectedItem as DataRowView)["Monto"]);
                int modPor = (int)(listBox1.SelectedItem as DataRowView)["ModPor"];

                pago = new Pago(numero,fecha,monto,presupuesto,modPor);

                textBox1.Text = pago.Fecha.Day+"/"+pago.Fecha.Month+"/"+pago.Fecha.Year;
                textBox2.Text = pago.Monto.ToString();
            }

            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseLocalDataSet.PagosRow pagosRow = databaseLocalDataSet.Pagos.FindByNumero(pago.Numero);

            pagosRow.Monto = Convert.ToDecimal(textBox2.Text); // controlar esto

            try
            {
                this.Validate();
                this.pagosBindingSource.EndEdit();
                this.pagosTableAdapter.Update(this.databaseLocalDataSet.Pagos);
                pago.Monto = (float)pagosRow.Monto;
                MessageBox.Show("El pago ha sido editado.");
                this.pagosTableAdapter.FillByPresupuesto(this.databaseLocalDataSet.Pagos, presupuesto.Numero);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: el pago no pudo ser editado.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarPago regPago = new RegistrarPago();
            regPago.LoadOrders(presupuesto);
            regPago.ShowDialog();
            this.pagosTableAdapter.FillByPresupuesto(this.databaseLocalDataSet.Pagos, presupuesto.Numero);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pago.Borrar();
            MessageBox.Show("El pago ha sido eliminado.");
            this.pagosTableAdapter.FillByPresupuesto(this.databaseLocalDataSet.Pagos, presupuesto.Numero);
        }
    }
}
