namespace SOADCI
{
    partial class InformePresupuestos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatabaseFinalDataSet = new SOADCI.DatabaseFinalDataSet();
            this.InfPresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupuestosTableAdapter = new SOADCI.DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfPresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetInfPre";
            reportDataSource1.Value = this.presupuestosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOADCI.InfPresupuestos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 452);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DatabaseFinalDataSet
            // 
            this.DatabaseFinalDataSet.DataSetName = "DatabaseFinalDataSet";
            this.DatabaseFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfPresupuestosBindingSource
            // 
            this.InfPresupuestosBindingSource.DataMember = "InfPresupuestos";
            this.InfPresupuestosBindingSource.DataSource = this.DatabaseFinalDataSet;
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.DatabaseFinalDataSet;
            // 
            // presupuestosTableAdapter
            // 
            this.presupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // InformePresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformePresupuestos";
            this.Text = "InformePresupuestos";
            this.Load += new System.EventHandler(this.InformePresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfPresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InfPresupuestosBindingSource;
        private DatabaseFinalDataSet DatabaseFinalDataSet;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
    }
}