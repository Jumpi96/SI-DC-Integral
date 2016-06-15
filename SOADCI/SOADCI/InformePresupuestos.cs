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
    public partial class InformePresupuestos : Form
    {
        private int estado;
        private int tipoObra;
        private DateTime fechainicio;
        private DateTime fechafinal;
        public InformePresupuestos()
        {
            InitializeComponent();
        }

        internal void LoadOrders(int est, int tipo, DateTime fechai, DateTime fechaf)
        {
            estado = est;
            tipoObra = tipo;
            fechainicio = fechai;
            fechafinal = fechaf;
        }

        private void InformePresupuestos_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DatabaseFinalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.presupuestosTableAdapter.FillByInfPre(this.DatabaseFinalDataSet.Presupuestos,tipoObra,estado,fechainicio.ToString(),fechafinal.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
