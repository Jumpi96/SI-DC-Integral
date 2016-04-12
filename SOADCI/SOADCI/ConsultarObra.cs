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
    public partial class ConsultarObra : Form
    {
        Obra obra;
        public ConsultarObra()
        {
            InitializeComponent();
        }

        private void ConsultarObra_Load(object sender, EventArgs e)
        {

        }

        internal void LoadOrders(Obra ob)
        {

            obra = ob;
            this.Text = "Consultar Obra - " + obra.Nombre;
            this.presupuestosTableAdapter.FillByObra(this.databaseLocalDataSet.Presupuestos,obra.Numero);

        }


    }
}
