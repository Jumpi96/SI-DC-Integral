namespace SOADCI
{
    partial class EmitirInformePresupuestos
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
            this.DatabaseLocalDataSet = new SOADCI.DatabaseLocalDataSet();
            this.PresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PresupuestosTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseLocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PresupuestosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOADCI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(702, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatabaseLocalDataSet
            // 
            this.DatabaseLocalDataSet.DataSetName = "DatabaseLocalDataSet";
            this.DatabaseLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PresupuestosBindingSource
            // 
            this.PresupuestosBindingSource.DataMember = "Presupuestos";
            this.PresupuestosBindingSource.DataSource = this.DatabaseLocalDataSet;
            // 
            // PresupuestosTableAdapter
            // 
            this.PresupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // EmitirInformePresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 520);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmitirInformePresupuestos";
            this.Text = "EmitirInformePresupuestos";
            this.Load += new System.EventHandler(this.EmitirInformePresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseLocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PresupuestosBindingSource;
        private DatabaseLocalDataSet DatabaseLocalDataSet;
        private DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter PresupuestosTableAdapter;
    }
}