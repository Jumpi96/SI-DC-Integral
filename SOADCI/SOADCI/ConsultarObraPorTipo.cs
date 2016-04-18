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
            // TODO: This line of code loads data into the 'databaseLocalDataSet.Obras' table. You can move, or remove it, as needed.
            this.obrasTableAdapter.Fill(this.databaseLocalDataSet.Obras);
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposCliente' table. You can move, or remove it, as needed.
            this.tiposClienteTableAdapter.Fill(this.databaseLocalDataSet.TiposCliente);
            // TODO: This line of code loads data into the 'databaseLocalDataSet.TiposObra' table. You can move, or remove it, as needed.
            this.tiposObraTableAdapter.Fill(this.databaseLocalDataSet.TiposObra);

        }
    }
}
