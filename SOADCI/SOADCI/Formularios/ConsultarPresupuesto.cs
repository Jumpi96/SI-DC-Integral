﻿using System;
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
    public partial class ConsultarPresupuesto : Form
    {
        private Presupuesto presupuesto;
        private String cadena;

        

        public ConsultarPresupuesto()
        {
            InitializeComponent();
            toolTips();

        }

        internal void LoadOrders(Presupuesto pres)
        {
            presupuesto = pres;

            this.Text = "Consultar presupuesto - "+pres.Nombre;
            textBox2.Text = pres.Numero.ToString();
            textBox3.Text = pres.Nombre;
            textBox4.Text = pres.Obra.Cliente.Nombre;
            textBox1.Text = pres.Obra.Nombre;
            textBox5.Text = pres.Fecha.Day+"/"+pres.Fecha.Month+"/"+pres.Fecha.Year;
            cadena= Globales.getInstancia().PATH + "\\" + pres.Obra.Cliente.Nombre + "\\" + pres.Obra.Nombre+"\\"+pres.Nombre;
        }

        private void toolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Directorio");
            toolTip.SetToolTip(button6, "Eliminar");
            toolTip.SetToolTip(button7, "Pagos");
            toolTip.SetToolTip(button3, "Archivos modelo");
        }

        private void ConsultarPresupuesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFinalDataSet.TiposPresupuesto' table. You can move, or remove it, as needed.
            this.tiposPresupuestoTableAdapter.Fill(this.databaseFinalDataSet.TiposPresupuesto);
            comboBox2.SelectedValue = presupuesto.Tipo.Numero;
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.databaseFinalDataSet.Estados);
            comboBox1.SelectedValue = presupuesto.Estado.Numero;
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.presupuestosTableAdapter.Fill(this.databaseFinalDataSet.Presupuestos);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", cadena);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseFinalDataSet.PresupuestosRow presupuestosRow = databaseFinalDataSet.Presupuestos.FindByNumero(presupuesto.Numero);

            presupuestosRow.Nombre = textBox3.Text;
            presupuestosRow.Estado = (int)comboBox1.SelectedValue;
            presupuestosRow.Tipo = (int)comboBox2.SelectedValue;

            try
            {
                if (presupuesto.Nombre != presupuestosRow.Nombre)
                {
                    cadena = Globales.getInstancia().PATH + "\\" + presupuesto.Obra.Cliente.Nombre + "\\" + presupuesto.Obra.Nombre + "\\" + presupuestosRow.Nombre;
                    Directory.Move(Globales.getInstancia().PATH + "\\" + presupuesto.Obra.Cliente.Nombre + "\\" + presupuesto.Obra.Nombre + "\\" + presupuesto.Nombre, cadena);
                }
                this.Validate();
                this.bindingSource1.EndEdit();
                this.presupuestosTableAdapter.Update(this.databaseFinalDataSet.Presupuestos);
                presupuesto.Nombre = presupuestosRow.Nombre;
                MessageBox.Show("El presupuesto ha sido editado.", "Modificar presupuesto");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: el presupuesto no pudo ser editado.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el presupuesto?", "Eliminar presupuesto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlarContraseña cons = new ControlarContraseña();
                cons.ShowDialog();
                if (cons.DialogResult == DialogResult.OK)
                {
                    presupuesto.BorrarPagosAsociados();
                    presupuesto.Borrar();
                    MessageBox.Show("El presupuesto ha sido eliminado.", "Eliminar presupuesto");
                    this.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConsultarPagos pagos = new ConsultarPagos();
            pagos.LoadOrders(presupuesto);
            pagos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Globales.getInstancia().ARCHIVOS);
        }
    }
}
