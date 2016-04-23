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
    public partial class RegistrarPago : Form
    {
        private Presupuesto presupuesto;

        public RegistrarPago()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void RegistrarPago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Pagos' table. You can move, or remove it, as needed.
            this.pagosTableAdapter.Fill(this.databaseLocalDataSet.Pagos);

        }

        internal void LoadOrders(Presupuesto pre)
        {
            presupuesto = pre;
            this.Text = "Registrar pago - " + pre.Nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {

                DatabaseLocalDataSet.PagosRow PagosRow = databaseLocalDataSet.Pagos.NewPagosRow();


                PagosRow.Fecha = dateTimePicker1.Value;
                PagosRow.Monto = Convert.ToDecimal(textBox2.Text);
                PagosRow.NumeroPresupuesto = presupuesto.Numero;
                PagosRow.ModPor = 1; // Usuario


                databaseLocalDataSet.Pagos.Rows.Add(PagosRow);

                try
                {
                    this.Validate();
                    this.bindingSource1.EndEdit();
                    this.pagosTableAdapter.Update(this.databaseLocalDataSet.Pagos);
                    MessageBox.Show("El pago ha sido registrado.");
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: el pago no pudo ser ingresado.");
                }
            }
            else
                MessageBox.Show("Ingrese un monto válido.", "Registrar pago");

        }
    }
}
