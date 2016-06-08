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

            if (fechaDesde <= fechaHasta)
            {
                /* EmitirInformePresupuestos emit = new EmitirInformePresupuestos();
                emit.LoadOrders(fechaDesde, fechaHasta);
                emit.ShowDialog(); */
                this.Close();
            }
            else
                MessageBox.Show("Error: Las fechas ingresadas no son válidas.");
        }

            
    }
}
