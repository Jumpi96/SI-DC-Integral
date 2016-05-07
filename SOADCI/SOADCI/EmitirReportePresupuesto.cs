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
    public partial class EmitirReportePresupuesto : Form
    {
        Presupuesto pres;

        public EmitirReportePresupuesto()
        {
            InitializeComponent();
        }

        internal void LoadOrders(Presupuesto presupuesto)
        {
            pres = presupuesto;
        }

        private void EmitirReportePresupuesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseLocalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.presupuestosTableAdapter.FillReporte(this.DatabaseLocalDataSet.Presupuestos, pres.Numero);

            this.reportViewer1.RefreshReport();
        }
    }
}
