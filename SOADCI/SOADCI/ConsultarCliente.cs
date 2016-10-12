using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SOADCI
{
    public partial class ConsultarCliente : Form
    {

        private Cliente elegido;
        private String cadena;
        private Boolean primeraEleccion=true;

        public ConsultarCliente()
        {
            InitializeComponent();
            toolTips();

        }

        private void toolTips() {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Directorio");
            toolTip.SetToolTip(button6, "Eliminar");
            toolTip.SetToolTip(button7, "Contactos");
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.presupuestosTableAdapter.Fill(this.databaseFinalDataSet.Presupuestos);

            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseFinalDataSet.TiposCliente);

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
                this.clientesTableAdapter.FillByTipo(this.databaseFinalDataSet.Clientes, ((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int)))));
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
                this.clientesTableAdapter.FillByNombre(this.databaseFinalDataSet.Clientes, textBox2.Text);
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (primeraEleccion == true)
            {
                comboBox2.Enabled = true;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                primeraEleccion = false;
            }

            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                TipoCliente tipo = new TipoCliente((Int32)row.Cells["Tipo"].Value);
                int numero = (Int32)row.Cells["Numero"].Value;
                String nombre = (String)row.Cells["Nombre"].Value;
                String domicilio = (String)row.Cells["Domicilio"].Value;
                String telFijo = (String)row.Cells["TelFijo"].Value;
                String telCel = (String)row.Cells["TelCel"].Value;
                String correo = (String)row.Cells["Correo"].Value;
                int modPor = (Int32)row.Cells["ModPor"].Value;


                elegido = new Cliente(numero, nombre, domicilio, telFijo, telCel, correo, tipo, modPor);


                comboBox2.Text = elegido.Tipo.Descripcion;
                textBox1.Text = elegido.Numero.ToString();
                textBox3.Text = elegido.Nombre;
                textBox4.Text = elegido.Domicilio;
                textBox5.Text = elegido.TelFijo;
                textBox6.Text = elegido.TelCel;
                textBox7.Text = elegido.Correo;

                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                cadena = Globales.getInstancia().PATH + "\\" + elegido.Nombre + '\\';

                // TODO: This line of code loads data into the 'databaseLocalDataSet.Obras' table. You can move, or remove it, as needed.
                
                this.obrasTableAdapter.FillObrasPorCliente(this.databaseFinalDataSet.Obras,elegido.Numero);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseFinalDataSet.ClientesRow clientesRow = databaseFinalDataSet.Clientes.FindByNumero(elegido.Numero);

            clientesRow.Tipo=(int)comboBox2.SelectedValue;
            clientesRow.Nombre = textBox3.Text;
            clientesRow.Domicilio = textBox4.Text;
            clientesRow.TelFijo = textBox5.Text;
            clientesRow.TelCel = textBox6.Text;
            clientesRow.Correo = textBox7.Text;

            try
            {
                if(elegido.Nombre != clientesRow.Nombre)
                {
                    cadena = Globales.getInstancia().PATH + "\\" + clientesRow.Nombre;
                    Directory.Move(Globales.getInstancia().PATH + "\\" + elegido.Nombre, cadena);
                }
                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.clientesTableAdapter.Update(this.databaseFinalDataSet.Clientes);
                elegido = new Cliente(clientesRow.Numero, clientesRow.Nombre, clientesRow.Domicilio, clientesRow.TelFijo, clientesRow.TelCel, clientesRow.Correo, new TipoCliente(clientesRow.Tipo), 1);
                MessageBox.Show("El cliente ha sido editado.");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: el cliente no pudo ser editado.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", cadena);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar cliente", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes )
            {
                ControlarContraseña cons = new ControlarContraseña();
                cons.ShowDialog();
                if (cons.DialogResult == DialogResult.OK) { 
                    DatabaseFinalDataSet.ClientesRow clientesRow = databaseFinalDataSet.Clientes.FindByNumero(elegido.Numero);

                    clientesRow.Delete();

                    elegido.borrarObrasAsociadas();
                    elegido.borrarContactosAsociados();

                    try
                    {
                        this.Validate();
                        this.clientesBindingSource.EndEdit();
                        this.clientesTableAdapter.Update(this.databaseFinalDataSet.Clientes);
                        Directory.Delete(cadena,true);
                        MessageBox.Show("El cliente ha sido eliminado.", "Eliminar cliente");
                        comboBox2.Text = "";
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        primeraEleccion = true;
                        comboBox2.Enabled = false;
                        textBox3.ReadOnly = true;
                        textBox4.ReadOnly = true;
                        textBox5.ReadOnly = true;
                        textBox6.ReadOnly = true;
                        textBox7.ReadOnly = true;
                        this.obrasTableAdapter.FillObrasPorCliente(this.databaseFinalDataSet.Obras, 0);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error: el cliente no pudo ser eliminado.");
                    }
            }
          }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConsultarContactos con = new ConsultarContactos();
            con.LoadOrders(elegido);
            con.ShowDialog();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView2.SelectedRows[0];

                Cliente cliente = new Cliente((int)(row.Cells[2].Value));
                int num = (int)row.Cells[0].Value;
                String nom = (String)row.Cells[1].Value;
                int modPor = 1; // control de usuario

                Obra obra = new Obra(num, nom, cliente,  modPor);

                ConsultarObra cons = new ConsultarObra();
                cons.LoadOrders(obra);
                cons.ShowDialog();
                this.obrasTableAdapter.FillObrasPorCliente(this.databaseFinalDataSet.Obras, cliente.Numero);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
