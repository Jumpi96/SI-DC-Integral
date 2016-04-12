namespace SOADCI
{
    partial class ConsultarObra
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
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLocalDataSet = new SOADCI.DatabaseLocalDataSet();
            this.presupuestosTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.databaseLocalDataSet;
            // 
            // databaseLocalDataSet
            // 
            this.databaseLocalDataSet.DataSetName = "DatabaseLocalDataSet";
            this.databaseLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presupuestosTableAdapter
            // 
            this.presupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numeroObraDataGridViewTextBoxColumn,
            this.modPorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.presupuestosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(527, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroObraDataGridViewTextBoxColumn
            // 
            this.numeroObraDataGridViewTextBoxColumn.DataPropertyName = "NumeroObra";
            this.numeroObraDataGridViewTextBoxColumn.HeaderText = "NumeroObra";
            this.numeroObraDataGridViewTextBoxColumn.Name = "numeroObraDataGridViewTextBoxColumn";
            this.numeroObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroObraDataGridViewTextBoxColumn.Visible = false;
            // 
            // modPorDataGridViewTextBoxColumn
            // 
            this.modPorDataGridViewTextBoxColumn.DataPropertyName = "ModPor";
            this.modPorDataGridViewTextBoxColumn.HeaderText = "ModPor";
            this.modPorDataGridViewTextBoxColumn.Name = "modPorDataGridViewTextBoxColumn";
            this.modPorDataGridViewTextBoxColumn.ReadOnly = true;
            this.modPorDataGridViewTextBoxColumn.Visible = false;
            // 
            // ConsultarObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 327);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarObra";
            this.Text = "Consultar Obra";
            this.Load += new System.EventHandler(this.ConsultarObra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DatabaseLocalDataSet databaseLocalDataSet;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modPorDataGridViewTextBoxColumn;
    }
}