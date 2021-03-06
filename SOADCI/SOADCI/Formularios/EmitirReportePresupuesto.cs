﻿using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SOADCI
{
    public partial class EmitirReportePresupuesto : Form
    {
        private Presupuesto pres;
        public EmitirReportePresupuesto()
        {
            InitializeComponent();
        }

        internal void LoadOrders(Presupuesto pre)
        {
            pres = pre;
        }

        private void EmitirReportePresupuesto_Load(object sender, EventArgs e)
        {
            String fe = pres.Fecha.Date.Day + "/" + pres.Fecha.Date.Month + "/" + pres.Fecha.Date.Year;
            ReportParameter n = new ReportParameter("Nombre",pres.Nombre);
            ReportParameter f = new ReportParameter("Fecha", fe);
            ReportParameter es = new ReportParameter("Estado", pres.Estado.Nombre);
            ReportParameter t = new ReportParameter("TipoPre", pres.Tipo.Descripcion);
            ReportParameter c = new ReportParameter("Cliente", pres.Obra.Cliente.Nombre);
            ReportParameter o = new ReportParameter("Obra", pres.Obra.Nombre);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { n,f,es,t,c,o });

            this.reportViewer1.RefreshReport();
        }
    }
}
