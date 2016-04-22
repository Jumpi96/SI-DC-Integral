namespace SOADCI
{
    partial class ConsultarObraPorTipo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLocalDataSet = new SOADCI.DatabaseLocalDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tiposClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposObraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposObraTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.TiposObraTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tiposClienteTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.TiposClienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.obrasTableAdapter = new SOADCI.DatabaseLocalDataSetTableAdapters.ObrasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposObraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numeroClienteDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.modPorDataGridViewTextBoxColumn,
            this.Nombre});
            this.dataGridView1.DataSource = this.obrasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(273, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(256, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroClienteDataGridViewTextBoxColumn
            // 
            this.numeroClienteDataGridViewTextBoxColumn.DataPropertyName = "NumeroCliente";
            this.numeroClienteDataGridViewTextBoxColumn.HeaderText = "NumeroCliente";
            this.numeroClienteDataGridViewTextBoxColumn.Name = "numeroClienteDataGridViewTextBoxColumn";
            this.numeroClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // modPorDataGridViewTextBoxColumn
            // 
            this.modPorDataGridViewTextBoxColumn.DataPropertyName = "ModPor";
            this.modPorDataGridViewTextBoxColumn.HeaderText = "ModPor";
            this.modPorDataGridViewTextBoxColumn.Name = "modPorDataGridViewTextBoxColumn";
            this.modPorDataGridViewTextBoxColumn.ReadOnly = true;
            this.modPorDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre1";
            this.Nombre.HeaderText = "Cliente";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // obrasBindingSource
            // 
            this.obrasBindingSource.DataMember = "Obras";
            this.obrasBindingSource.DataSource = this.databaseLocalDataSet;
            // 
            // databaseLocalDataSet
            // 
            this.databaseLocalDataSet.DataSetName = "DatabaseLocalDataSet";
            this.databaseLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiposClienteBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Numero";
            // 
            // tiposClienteBindingSource
            // 
            this.tiposClienteBindingSource.DataMember = "TiposCliente";
            this.tiposClienteBindingSource.DataSource = this.databaseLocalDataSet;
            // 
            // tiposObraBindingSource
            // 
            this.tiposObraBindingSource.DataMember = "TiposObra";
            this.tiposObraBindingSource.DataSource = this.databaseLocalDataSet;
            // 
            // tiposObraTableAdapter
            // 
            this.tiposObraTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tiposObraBindingSource;
            this.comboBox2.DisplayMember = "Descripcion";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de obra";
            // 
            // tiposClienteTableAdapter
            // 
            this.tiposClienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // obrasTableAdapter
            // 
            this.obrasTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultarObraPorTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 186);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarObraPorTipo";
            this.Text = "Consultar obras";
            this.Load += new System.EventHandler(this.ConsultarObraPorTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposObraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DatabaseLocalDataSet databaseLocalDataSet;
        private System.Windows.Forms.BindingSource tiposObraBindingSource;
        private DatabaseLocalDataSetTableAdapters.TiposObraTableAdapter tiposObraTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tiposClienteBindingSource;
        private DatabaseLocalDataSetTableAdapters.TiposClienteTableAdapter tiposClienteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource obrasBindingSource;
        private DatabaseLocalDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modPorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}