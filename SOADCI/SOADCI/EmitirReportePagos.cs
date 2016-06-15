using Microsoft.Reporting.WinForms;
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
    public partial class EmitirReportePagos : Form
    {
        private Presupuesto pres;

        public EmitirReportePagos()
        {
            InitializeComponent();
        }

        internal void LoadOrders(Presupuesto pre)
        {
            pres = pre;
        }

        private void EmitirReportePagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatabaseFinalDataSet.Pagos' table. You can move, or remove it, as needed.
            this.PagosTableAdapter.FillByPresupuesto(this.DatabaseFinalDataSet.Pagos,pres.Numero);
            ReportParameter o = new ReportParameter("Obra", pres.Obra.Nombre);
            ReportParameter n = new ReportParameter("Nombre", pres.Nombre);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { n, o });


            this.reportViewer1.RefreshReport();
        }
    }
}
