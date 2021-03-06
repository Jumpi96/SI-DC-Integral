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
    public partial class ConsultarObra : Form
    {
        private Obra obra;
        private String cadena;

        private System.Windows.Forms.BindingSource obrasBindingSource;
        private DatabaseFinalDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        


        public ConsultarObra()
        {
            InitializeComponent();
            toolTips();
            obrasTableAdapter = new DatabaseFinalDataSetTableAdapters.ObrasTableAdapter();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.databaseFinalDataSet;
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();

        }

        private void toolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Directorio");
            toolTip.SetToolTip(button6, "Eliminar");
            toolTip.SetToolTip(button3, "Registrar presupuesto");
        }


        private void ConsultarObra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFinalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            // this.presupuestosTableAdapter.Fill(this.databaseFinalDataSet.Presupuestos);
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposObra' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.Fill(this.databaseFinalDataSet.Obras);

        }

        internal void LoadOrders(Obra ob)
        {

            obra = ob;
            this.Text = "Consultar obra - " + obra.Nombre;
            this.presupuestosTableAdapter.FillByObra(this.databaseFinalDataSet.Presupuestos, obra.Numero);
            cadena = Globales.getInstancia().PATH + "\\" + obra.Cliente.Nombre + "\\" + obra.Nombre;
            textBox2.Text = obra.Numero.ToString();
            textBox1.Text = obra.Cliente.Nombre;
            textBox3.Text = obra.Nombre;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", cadena);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la obra?", "Eliminar obra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControlarContraseña cons = new ControlarContraseña();
                cons.ShowDialog();
                if (cons.DialogResult == DialogResult.OK)
                {
                    DatabaseFinalDataSet.ObrasRow obrasRow = databaseFinalDataSet.Obras.FindByNumero(obra.Numero);

                    obrasRow.Delete();

                    obra.borrarPresupuestosAsociados();

                    try
                    {
                        this.Validate();
                        this.obrasBindingSource.EndEdit();
                        this.obrasTableAdapter.Update(this.databaseFinalDataSet.Obras);
                        Directory.Delete(cadena, true);
                        MessageBox.Show("La obra ha sido eliminada.");
                        this.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error: la obra no pudo ser eliminada.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseFinalDataSet.ObrasRow obrasRow = databaseFinalDataSet.Obras.FindByNumero(obra.Numero);

            obrasRow.Nombre = textBox3.Text;

            try
            {
                if (obra.Nombre != obrasRow.Nombre)
                {
                    cadena = Globales.getInstancia().PATH + "\\" + obra.Cliente.Nombre + "\\" + obrasRow.Nombre;
                    Directory.Move(Globales.getInstancia().PATH + "\\" + obra.Cliente.Nombre + "\\" + obra.Nombre, cadena);
                }
                this.Validate();
                this.obrasBindingSource.EndEdit();
                this.obrasTableAdapter.Update(this.databaseFinalDataSet.Obras);
                obra = new Obra(obra.Numero, obrasRow.Nombre, obra.Cliente, 1);
                MessageBox.Show("La obra ha sido editada.");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: la obra no pudo ser editada.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarPresupuesto regPre = new RegistrarPresupuesto();
            regPre.LoadOrders(obra);
            regPre.ShowDialog();
            this.presupuestosTableAdapter.FillByObra(this.databaseFinalDataSet.Presupuestos, obra.Numero);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0]; 

                int numero= (int)row.Cells[0].Value;
                String nombre= (String)row.Cells[1].Value;
                DateTime fecha=(DateTime)row.Cells[2].Value;
                int modPor= (int)row.Cells[4].Value;
                Estado estado = new Estado((int)row.Cells[5].Value);
                TipoPresupuesto tipo = new TipoPresupuesto((int)row.Cells[6].Value);
                
                Presupuesto presu = new Presupuesto(numero,nombre,fecha,obra,modPor,estado,tipo);
                
                ConsultarPresupuesto cons = new ConsultarPresupuesto();
                cons.LoadOrders(presu);
                cons.ShowDialog();
                this.presupuestosTableAdapter.FillByObra(this.databaseFinalDataSet.Presupuestos, obra.Numero);
                
            }
        }
    }
}
