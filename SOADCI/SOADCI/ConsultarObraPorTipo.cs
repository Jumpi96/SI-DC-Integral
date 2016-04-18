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
    public partial class ConsultarObraPorTipo : Form
    {
        public ConsultarObraPorTipo()
        {
            InitializeComponent();
        }

        private void ConsultarObraPorTipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseLocalDataSet.TiposCliente);
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposObra' table. You can move, or remove it, as needed.
            this.tiposObraTableAdapter.Fill(this.databaseLocalDataSet.TiposObra);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                Cliente cliente = new Cliente((int)(row.Cells[2].Value));
                int num = (int)row.Cells[0].Value;
                String nom = (String)row.Cells[1].Value;
                TipoObra tip = new TipoObra((int)row.Cells[3].Value);
                int modPor = (int)row.Cells[4].Value;

                Obra obra = new Obra(num, nom, cliente, tip, modPor);

                ConsultarObra cons = new ConsultarObra();
                cons.LoadOrders(obra);
                cons.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.obrasTableAdapter.FillObrasPorTipoCliente(this.databaseLocalDataSet.Obras, (int)comboBox1.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.obrasTableAdapter.FillObrasPorTipoObra(this.databaseLocalDataSet.Obras, (int)comboBox2.SelectedValue);
        }
    }
}
