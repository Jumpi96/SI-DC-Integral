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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();


        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {   
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseLocalDataSet.TiposCliente);

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy(this.databaseLocalDataSet.Clientes, ((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy2(this.databaseLocalDataSet.Clientes, textBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
