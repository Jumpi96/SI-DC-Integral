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
    public partial class RegistrarObra : Form
    {
        private Boolean nombreCorrecto;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private DatabaseFinalDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;



        public RegistrarObra()
        {
            InitializeComponent();
            obrasTableAdapter = new DatabaseFinalDataSetTableAdapters.ObrasTableAdapter();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.databaseFinalDataSet;
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
        }
   

        private void RegistrarObra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.databaseFinalDataSet.Clientes);

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            String ingresado = comboBox1.Text;

            DataRow[] foundRows;
            foundRows = databaseFinalDataSet.Tables["Clientes"].Select("Nombre Like '"+ingresado+"'");

            if (foundRows.Length == 0)
            {
                this.clientesTableAdapter.Fill(this.databaseFinalDataSet.Clientes);
                MessageBox.Show("El cliente ingresado no existe");
                nombreCorrecto = false;
            }
            else
            {
                nombreCorrecto = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreCorrecto == true)
            {
                DatabaseFinalDataSet.ObrasRow newObrasRow = databaseFinalDataSet.Obras.NewObrasRow();

                newObrasRow.Nombre = textBox2.Text;
                newObrasRow.NumeroCliente = (int)comboBox1.SelectedValue;
                newObrasRow.ModPor = 1; // Usuario

                Directory.CreateDirectory(Globales.getInstancia().PATH + "\\" + (new Cliente(newObrasRow.NumeroCliente)).Nombre + "\\" + newObrasRow.Nombre);

                databaseFinalDataSet.Obras.Rows.Add(newObrasRow);

                try
                {
                    this.Validate();
                    this.obrasBindingSource.EndEdit();
                    this.obrasTableAdapter.Update(this.databaseFinalDataSet.Obras);
                    MessageBox.Show("La obra ha sido registrada.");
                    this.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: la obra no pudo ser ingresado.");
                }
            }
            else
            {
                MessageBox.Show("El cliente ingresado no existe");
            }
        }


    }
}
