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
    public partial class InformePresupuestos : Form
    {
        private int estado;
        private int tipoCliente;
        private DateTime fechainicio;
        private DateTime fechafinal;
        public InformePresupuestos()
        {
            InitializeComponent();
        }

        internal void LoadOrders(int est, int tipo, DateTime fechai, DateTime fechaf)
        {
            estado = est;
            tipoCliente = tipo;
            fechainicio = fechai;
            fechafinal = fechaf;
        }

        private void InformePresupuestos_Load(object sender, EventArgs e)
        {
            ReportParameter fi = new ReportParameter("FechaInicio", fechainicio.ToShortDateString());
            ReportParameter ff = new ReportParameter("FechaFinal", fechafinal.ToShortDateString());

            String resto=" ";

            if(estado!=0 && tipoCliente!=0)
                resto = "- " + ((new TipoCliente(tipoCliente)).Descripcion) + " - " + ((new Estado(estado)).Nombre);
            else
                if(estado!=0)
                    resto = "- " + ((new Estado(estado)).Nombre);
                else
                    if(tipoCliente!=0)
                        resto = "- " + ((new TipoCliente(tipoCliente)).Descripcion);
            
            ReportParameter r = new ReportParameter("Resto", resto);
            
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi, ff, r });

            // TODO: This line of code loads data into the 'DatabaseFinalDataSet.Presupuestos' table. You can move, or remove it, as needed.
            this.presupuestosTableAdapter.FillByInfPre(this.DatabaseFinalDataSet.Presupuestos,estado,tipoCliente, fechainicio.ToString(),fechafinal.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
