namespace SOADCI
{
    partial class EmitirReportePagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirReportePagos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatabaseFinalDataSet = new SOADCI.DatabaseFinalDataSet();
            this.PagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagosTableAdapter = new SOADCI.DatabaseFinalDataSetTableAdapters.PagosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPagos";
            reportDataSource1.Value = this.PagosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOADCI.InformePagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(100, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(584, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatabaseFinalDataSet
            // 
            this.DatabaseFinalDataSet.DataSetName = "DatabaseFinalDataSet";
            this.DatabaseFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagosBindingSource
            // 
            this.PagosBindingSource.DataMember = "Pagos";
            this.PagosBindingSource.DataSource = this.DatabaseFinalDataSet;
            // 
            // PagosTableAdapter
            // 
            this.PagosTableAdapter.ClearBeforeFill = true;
            // 
            // EmitirReportePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmitirReportePagos";
            this.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.Text = "Reporte de pagos";
            this.Load += new System.EventHandler(this.EmitirReportePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagosBindingSource;
        private DatabaseFinalDataSet DatabaseFinalDataSet;
        private DatabaseFinalDataSetTableAdapters.PagosTableAdapter PagosTableAdapter;
    }
}