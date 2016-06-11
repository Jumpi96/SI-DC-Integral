using System;
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
    public partial class FormEmitirInforme : Form
    {
        public FormEmitirInforme()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today.AddDays(-7);
            dateTimePicker2.Value = DateTime.Today;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimePicker1.Value;
            DateTime fechaHasta = dateTimePicker2.Value;
            int estado = (int)comboBox2.SelectedValue;
            int tipo;
            if ((int)comboBox1.SelectedValue != -1)
                tipo = (int)comboBox1.SelectedValue;
            else
                tipo = 0;


            if (fechaDesde <= fechaHasta)
            {
                EmitirInformePresupuestos emit = new EmitirInformePresupuestos();
                emit.LoadOrders(fechaDesde, fechaHasta, estado, tipo);
                emit.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Error: Las fechas ingresadas no son válidas.");
        }

        private void FormEmitirInforme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFinalDataSet.Estados' table. You can move, or remove it, as needed.
            
            this.estadosTableAdapter.Fill(this.databaseFinalDataSet.Estados);
            this.databaseFinalDataSet.Estados.AddEstadosRow(0, "Todos");
            comboBox2.SelectedIndex = comboBox2.FindString("Todos");


            // TODO: This line of code loads data into the 'databaseFinalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseFinalDataSet.TiposCliente);
            this.databaseFinalDataSet.TiposCliente.AddTiposClienteRow("Todos");
            comboBox1.SelectedIndex = comboBox1.FindString("Todos");

        }
    }
}
