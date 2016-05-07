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
    public partial class EmitirInformePresupuestos : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public EmitirInformePresupuestos()
        {
            InitializeComponent();
        }

        private void EmitirInformePresupuestos_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DatabaseLocalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.PresupuestosTableAdapter.FillByFecha(this.DatabaseLocalDataSet.Presupuestos,fechaInicio.ToString(),fechaFin.ToString());

            this.reportViewer1.RefreshReport();
        }

        internal void LoadOrders(DateTime fechaDesde,DateTime fechaHasta)
        {
            fechaInicio = fechaDesde;
            fechaFin = fechaHasta;   
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
