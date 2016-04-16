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
    public partial class RegistrarPresupuesto : Form
    {
        private Obra obra;
        private Boolean clienteCorrecto;
        private Boolean obraCorrecta;

        public RegistrarPresupuesto()
        {
            InitializeComponent();

        }

        internal void LoadOrders(Obra ob)
        {
            obra = ob;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarPresupuesto_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.databaseLocalDataSet.Clientes);

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

        }


        private void comboBox1_Leave(object sender, EventArgs e)
        {
            String ingresado = comboBox1.Text;

            DataRow[] foundRows;
            foundRows = databaseLocalDataSet.Tables["Clientes"].Select("Nombre Like '" + ingresado + "'");

            if (foundRows.Length == 0)
            {
                this.clientesTableAdapter.Fill(this.databaseLocalDataSet.Clientes);
                MessageBox.Show("El cliente ingresado no existe");
                clienteCorrecto = false;
                comboBox2.Enabled = false;
            }
            else
            {
                clienteCorrecto = true;
                comboBox2.Enabled = true;
                // TODO: This line of code loads data into the 'databaseLocalDataSet.Obras' table. You can move, or remove it, as needed.
                this.obrasTableAdapter.Fill(this.databaseLocalDataSet.Obras); // query nueva

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clienteCorrecto == true && obraCorrecta == true)
            {
               // Cargar todas las cosas
            }
            else
            {
                if(clienteCorrecto==false)
                    MessageBox.Show("El cliente ingresado no existe");
                else
                    MessageBox.Show("La obra ingresada no existe");
            }
        }
    }
}
