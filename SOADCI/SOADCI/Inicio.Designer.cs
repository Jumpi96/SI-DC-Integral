namespace SOADCI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillEnEsperaToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillEnEsperaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.presupuestosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseFinalDataSet = new SOADCI.DatabaseFinalDataSet();
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presupuestosTableAdapter = new SOADCI.DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter();
            this.presupuestosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObraNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillEnEsperaToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Registrar obra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Registrar presupuesto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Consultar obra";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 286);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Informe de presupuestos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SOADCI.Properties.Resources.linedpaperpencil32;
            this.pictureBox3.Location = new System.Drawing.Point(51, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SOADCI.Properties.Resources.home32;
            this.pictureBox2.Location = new System.Drawing.Point(51, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SOADCI.Properties.Resources.user32;
            this.pictureBox1.Location = new System.Drawing.Point(51, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "SOA DC Integral - v. 1.1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.NumeroObra,
            this.ObraNombre,
            this.ClienteNombre,
            this.Estado,
            this.EstadoNombre,
            this.ModPor});
            this.dataGridView1.DataSource = this.presupuestosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(289, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(452, 198);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // fillEnEsperaToolStrip
            // 
            this.fillEnEsperaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillEnEsperaToolStripButton});
            this.fillEnEsperaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillEnEsperaToolStrip.Name = "fillEnEsperaToolStrip";
            this.fillEnEsperaToolStrip.Size = new System.Drawing.Size(784, 25);
            this.fillEnEsperaToolStrip.TabIndex = 12;
            this.fillEnEsperaToolStrip.Text = "fillEnEsperaToolStrip";
            // 
            // fillEnEsperaToolStripButton
            // 
            this.fillEnEsperaToolStripButton.Name = "fillEnEsperaToolStripButton";
            this.fillEnEsperaToolStripButton.Size = new System.Drawing.Size(23, 22);
            // 
            // presupuestosBindingSource2
            // 
            this.presupuestosBindingSource2.DataMember = "Presupuestos";
            this.presupuestosBindingSource2.DataSource = this.databaseFinalDataSet;
            // 
            // databaseFinalDataSet
            // 
            this.databaseFinalDataSet.DataSetName = "DatabaseFinalDataSet";
            this.databaseFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.databaseFinalDataSet;
            // 
            // presupuestosTableAdapter
            // 
            this.presupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // presupuestosBindingSource1
            // 
            this.presupuestosBindingSource1.DataMember = "Presupuestos";
            this.presupuestosBindingSource1.DataSource = this.databaseFinalDataSet;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NumeroObra
            // 
            this.NumeroObra.DataPropertyName = "NumeroObra";
            this.NumeroObra.HeaderText = "NumeroObra";
            this.NumeroObra.Name = "NumeroObra";
            this.NumeroObra.ReadOnly = true;
            this.NumeroObra.Visible = false;
            // 
            // ObraNombre
            // 
            this.ObraNombre.DataPropertyName = "ObraNombre";
            this.ObraNombre.HeaderText = "Obra";
            this.ObraNombre.Name = "ObraNombre";
            this.ObraNombre.ReadOnly = true;
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.DataPropertyName = "ClienteNombre";
            this.ClienteNombre.HeaderText = "Cliente";
            this.ClienteNombre.Name = "ClienteNombre";
            this.ClienteNombre.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // EstadoNombre
            // 
            this.EstadoNombre.DataPropertyName = "EstadoNombre";
            this.EstadoNombre.HeaderText = "Estado";
            this.EstadoNombre.Name = "EstadoNombre";
            this.EstadoNombre.ReadOnly = true;
            this.EstadoNombre.Visible = false;
            // 
            // ModPor
            // 
            this.ModPor.DataPropertyName = "ModPor";
            this.ModPor.HeaderText = "ModPor";
            this.ModPor.Name = "ModPor";
            this.ModPor.ReadOnly = true;
            this.ModPor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Presupuestos a revisar";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillEnEsperaToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Inicio";
            this.Text = "Sistema de Ordenamiento de Archivos - SOA DC Integral";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillEnEsperaToolStrip.ResumeLayout(false);
            this.fillEnEsperaToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private DatabaseFinalDataSet databaseFinalDataSet;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
        private System.Windows.Forms.BindingSource presupuestosBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource presupuestosBindingSource2;
        private System.Windows.Forms.ToolStrip fillEnEsperaToolStrip;
        private System.Windows.Forms.ToolStripButton fillEnEsperaToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObraNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModPor;
        private System.Windows.Forms.Label label1;
    }
}

