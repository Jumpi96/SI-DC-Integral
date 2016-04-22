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
            this.PresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatabaseLocalDataSet = new SOADCI.DatabaseLocalDataSet();
            this.PresupuestosTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            this.TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseLocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PresupuestosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOADCI.InformePresupuestos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(150, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(708, 595);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PresupuestosBindingSource
            // 
            this.PresupuestosBindingSource.DataMember = "Presupuestos";
            this.PresupuestosBindingSource.DataSource = this.DatabaseLocalDataSet;
            // 
            // DatabaseLocalDataSet
            // 
            this.DatabaseLocalDataSet.DataSetName = "DatabaseLocalDataSet";
            this.DatabaseLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PresupuestosTableAdapter
            // 
            this.PresupuestosTableAdapter.ClearBeforeFill = true;
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
            // EmitirInformePresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmitirInformePresupuestos";
            this.Padding = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.Text = "EmitirInformePresupuestos";
            this.Load += new System.EventHandler(this.EmitirInformePresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseLocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PresupuestosBindingSource;
        private DatabaseLocalDataSet DatabaseLocalDataSet;
        private DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter PresupuestosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableBindingSource;
        private DatabaseLocalDataSetTableAdapters.TableTableAdapter TableTableAdapter;
    }
}