namespace ProyectoFinal
{
    partial class FormRegistrodePagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrodePagos));
            this.label16 = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.ColIdFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(276, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(450, 31);
            this.label16.TabIndex = 88;
            this.label16.Text = "REGISTROS DE FACTURACION";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdFac,
            this.ColPaciente,
            this.ColMetodo,
            this.ColPropietario,
            this.ColDNI,
            this.ColFechaFac,
            this.ColMontoTotal});
            this.dgvFacturas.Location = new System.Drawing.Point(11, 246);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(416, 274);
            this.dgvFacturas.TabIndex = 89;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);
            // 
            // ColIdFac
            // 
            this.ColIdFac.HeaderText = "Id Factura";
            this.ColIdFac.MinimumWidth = 6;
            this.ColIdFac.Name = "ColIdFac";
            this.ColIdFac.Width = 125;
            // 
            // ColPaciente
            // 
            this.ColPaciente.HeaderText = "Paciente";
            this.ColPaciente.MinimumWidth = 6;
            this.ColPaciente.Name = "ColPaciente";
            this.ColPaciente.Width = 125;
            // 
            // ColMetodo
            // 
            this.ColMetodo.HeaderText = "Metodo de pago";
            this.ColMetodo.MinimumWidth = 6;
            this.ColMetodo.Name = "ColMetodo";
            this.ColMetodo.Width = 125;
            // 
            // ColPropietario
            // 
            this.ColPropietario.HeaderText = "Propietario";
            this.ColPropietario.MinimumWidth = 6;
            this.ColPropietario.Name = "ColPropietario";
            this.ColPropietario.Width = 125;
            // 
            // ColDNI
            // 
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.MinimumWidth = 6;
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.Width = 125;
            // 
            // ColFechaFac
            // 
            this.ColFechaFac.HeaderText = "Fecha de Facturación";
            this.ColFechaFac.MinimumWidth = 6;
            this.ColFechaFac.Name = "ColFechaFac";
            this.ColFechaFac.Width = 125;
            // 
            // ColMontoTotal
            // 
            this.ColMontoTotal.HeaderText = "Total";
            this.ColMontoTotal.MinimumWidth = 6;
            this.ColMontoTotal.Name = "ColMontoTotal";
            this.ColMontoTotal.Width = 125;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdProducto,
            this.ColNombrePro,
            this.ColCantidad,
            this.ColPrecioUnitario,
            this.ColSubTotal});
            this.dgvDetalles.Location = new System.Drawing.Point(446, 246);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(469, 274);
            this.dgvDetalles.TabIndex = 90;
            // 
            // ColIdProducto
            // 
            this.ColIdProducto.HeaderText = "Id Producto";
            this.ColIdProducto.MinimumWidth = 6;
            this.ColIdProducto.Name = "ColIdProducto";
            this.ColIdProducto.Width = 125;
            // 
            // ColNombrePro
            // 
            this.ColNombrePro.HeaderText = "Nombre de Producto";
            this.ColNombrePro.MinimumWidth = 6;
            this.ColNombrePro.Name = "ColNombrePro";
            this.ColNombrePro.Width = 125;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad Comprada";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 125;
            // 
            // ColPrecioUnitario
            // 
            this.ColPrecioUnitario.HeaderText = "Precio Unitario";
            this.ColPrecioUnitario.MinimumWidth = 6;
            this.ColPrecioUnitario.Name = "ColPrecioUnitario";
            this.ColPrecioUnitario.Width = 125;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.MinimumWidth = 6;
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 91;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(60, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 36);
            this.btnBuscar.TabIndex = 92;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(172, 64);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(75, 36);
            this.btnVerTodo.TabIndex = 93;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Fecha :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnVerTodo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 108);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Registros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(625, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 159);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrodePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 582);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistrodePagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrodePagos";
            this.Load += new System.EventHandler(this.FormRegistrodePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}