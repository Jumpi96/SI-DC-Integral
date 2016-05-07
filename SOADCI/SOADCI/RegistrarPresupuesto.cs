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
    public partial class RegistrarPresupuesto : Form
    {
        private Obra obra;
        private Boolean clienteCorrecto;
        private Boolean obraCorrecta;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;

        public RegistrarPresupuesto()
        {
            InitializeComponent();

            presupuestosTableAdapter = new DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.databaseLocalDataSet;
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();



        }

        internal void LoadOrders(Obra ob)
        {
            obra = ob;
            comboBox1.SelectedText = obra.Cliente.Nombre;
            clienteCorrecto = true;
            comboBox2.Enabled = true;
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.FillByCliente(this.databaseLocalDataSet.Obras, obra.Cliente.Numero);
            comboBox2.Text = obra.Nombre;
            obraCorrecta = true;
            this.ActiveControl = textBox1;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarPresupuesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.databaseLocalDataSet.Estados);
            this.clientesTableAdapter.Fill(this.databaseLocalDataSet.Clientes);

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            dateTimePicker1.Value = DateTime.Now;

        }


        private void comboBox1_Leave(object sender, EventArgs e)
        {
            String ingresado = comboBox1.Text;

            DataRow[] foundRows;
            foundRows = databaseLocalDataSet.Tables["Clientes"].Select("Nombre Like '" + ingresado + "'");

            if (foundRows.Length == 0)
            {
                this.clientesTableAdapter.Fill(this.databaseLocalDataSet.Clientes);
                MessageBox.Show("El cliente ingresado no existe", "Registrar presupuesto");
                clienteCorrecto = false;
                comboBox2.Enabled = false;
            }
            else
            {
                clienteCorrecto = true;
                comboBox2.Enabled = true;
                comboBox2.Focus();
                // TODO: This line of code loads data into the 'databaseLocalDataSet.Obras' table. You can move, or remove it, as needed.
                this.obrasTableAdapter.FillByCliente(this.databaseLocalDataSet.Obras, ((SOADCI.DatabaseLocalDataSet.ClientesRow)foundRows[0]).Numero);

            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            String ingresado = comboBox2.Text;

            DataRow[] foundRows;
            foundRows = databaseLocalDataSet.Tables["Obras"].Select("Nombre Like '" + ingresado + "'");

            if (foundRows.Length == 0)
            {
                MessageBox.Show("La obra ingresada no existe", "Registrar presupuesto");
                obraCorrecta = false;
                comboBox2.Text = "";
            }
            else
            {
                obraCorrecta = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clienteCorrecto == true && obraCorrecta == true)
            {
                DatabaseLocalDataSet.PresupuestosRow newPresupuestosRow = databaseLocalDataSet.Presupuestos.NewPresupuestosRow();

                newPresupuestosRow.Nombre = textBox1.Text;
                newPresupuestosRow.Fecha = dateTimePicker1.Value;
                newPresupuestosRow.NumeroObra = (int)comboBox2.SelectedValue;
                newPresupuestosRow.ModPor = 1; // usuario
                newPresupuestosRow.Estado = (int)comboBox3.SelectedValue; // probando

                Obra temp = new Obra(newPresupuestosRow.NumeroObra);
                Directory.CreateDirectory(@Globales.PATH + "\\" + (new Cliente(temp.Cliente.Numero)).Nombre + "\\" + temp.Nombre + "\\" + newPresupuestosRow.Nombre);

                databaseLocalDataSet.Presupuestos.Rows.Add(newPresupuestosRow);

                Presupuesto nuePre = new Presupuesto(newPresupuestosRow.Numero, newPresupuestosRow.Nombre, newPresupuestosRow.Fecha, temp, newPresupuestosRow.ModPor, new Estado(newPresupuestosRow.Estado));
                nuePre.crearCarpetas();

                try
                {
                    this.Validate();
                    this.presupuestosBindingSource.EndEdit();
                    this.presupuestosTableAdapter.Update(this.databaseLocalDataSet.Presupuestos);
                    MessageBox.Show("El presupuesto ha sido registrado.", "Registrar presupuesto");
                    // nuePre.Imprimir();
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: el presupuesto no pudo ser ingresado.");
                }
            }
            else
            {
                if(clienteCorrecto==false)
                    MessageBox.Show("El cliente ingresado no existe", "Registrar presupuesto");
                else
                    MessageBox.Show("La obra ingresada no existe", "Registrar presupuesto");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
