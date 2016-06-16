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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformePresupuestos));
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseFinalDataSet = new SOADCI.DatabaseFinalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InfPresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupuestosTableAdapter = new SOADCI.DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfPresupuestosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.DatabaseFinalDataSet;
            // 
            // DatabaseFinalDataSet
            // 
            this.DatabaseFinalDataSet.DataSetName = "DatabaseFinalDataSet";
            this.DatabaseFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetInfPre";
            reportDataSource1.Value = this.presupuestosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOADCI.InfPresupuestos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(70, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(644, 561);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // InfPresupuestosBindingSource
            // 
            this.InfPresupuestosBindingSource.DataMember = "InfPresupuestos";
            this.InfPresupuestosBindingSource.DataSource = this.DatabaseFinalDataSet;
            // 
            // presupuestosTableAdapter
            // 
            this.presupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // InformePresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformePresupuestos";
            this.Padding = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.Text = "Informe de presupuestos";
            this.Load += new System.EventHandler(this.InformePresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfPresupuestosBindingSource)).EndInit();
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