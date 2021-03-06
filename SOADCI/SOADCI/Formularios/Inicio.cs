﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            this.presupuestosTableAdapter.FillByEnEspera(this.databaseFinalDataSet.Presupuestos);
        }

        public void pintarFilas()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime fecha = (Convert.ToDateTime(row.Cells[7].Value));
                TimeSpan periodo = DateTime.Today - fecha; 
                int dias = periodo.Days;

                if (dias >= 21)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                    if (dias >= 14)
                        row.DefaultCellStyle.BackColor = Color.Yellow;

                dataGridView1.Rows[0].Selected = false;
            }
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
            this.presupuestosTableAdapter.FillByEnEspera(this.databaseFinalDataSet.Presupuestos);
            this.Inicio_Load(new object(), new EventArgs());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFinalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            pintarFilas();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarObra regO = new RegistrarObra();
            regO.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultarObraPorTipo consu = new ConsultarObraPorTipo();
            consu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrarPresupuesto regP = new RegistrarPresupuesto();
            regP.ShowDialog();
            this.presupuestosTableAdapter.FillByEnEspera(this.databaseFinalDataSet.Presupuestos);
            this.Inicio_Load(new object(), new EventArgs());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormEmitirInforme fei = new FormEmitirInforme();
            fei.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {

                int numero = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                Presupuesto presu = new Presupuesto(numero);

                ConsultarPresupuesto cons = new ConsultarPresupuesto();
                cons.LoadOrders(presu);
                cons.ShowDialog();
                this.presupuestosTableAdapter.FillByEnEspera(this.databaseFinalDataSet.Presupuestos);
                pintarFilas();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Configuración config = new Configuración();
            config.ShowDialog();
        }
    }
}
