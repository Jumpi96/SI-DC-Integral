namespace SOADCI
{
    partial class EmitirReportePresupuesto
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
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseLocalDataSet = new SOADCI.DatabaseLocalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.TableTableAdapter();
            this.presupuestosTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseLocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.DatabaseLocalDataSet;
            // 
            // DatabaseLocalDataSet
            // 
            this.DatabaseLocalDataSet.DataSetName = "DatabaseLocalDataSet";
            this.DatabaseLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.presupuestosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOADCI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(189, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // TableBindingSource
            // 
            this.TableBindingSource.DataMember = "Table";
            this.TableBindingSource.DataSource = this.DatabaseLocalDataSet;
            // 
            // TableTableAdapter
            // 
            this.TableTableAdapter.ClearBeforeFill = true;
            // 
            // presupuestosTableAdapter
            // 
            this.presupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // EmitirReportePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 467);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "EmitirReportePresupuesto";
            this.Text = "EmitirReportePresupuesto";
            this.Load += new System.EventHandler(this.EmitirReportePresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseLocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableBindingSource;
        private DatabaseLocalDataSet DatabaseLocalDataSet;
        private DatabaseLocalDataSetTableAdapters.TableTableAdapter TableTableAdapter;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
    }
}