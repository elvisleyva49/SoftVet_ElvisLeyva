namespace ProyectoFinal
{
    partial class FormCitasProgramadas
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(338, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 31);
            this.label9.TabIndex = 49;
            this.label9.Text = "CITAS PROGRAMADAS";
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCitas.Location = new System.Drawing.Point(50, 90);
            this.btnVerCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(104, 36);
            this.btnVerCitas.TabIndex = 48;
            this.btnVerCitas.Text = "Ver Citas de la Fecha";
            this.btnVerCitas.UseVisualStyleBackColor = true;
            this.btnVerCitas.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // calendario
            // 
            this.calendario.Enabled = false;
            this.calendario.Location = new System.Drawing.Point(577, 73);
            this.calendario.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.calendario.Name = "calendario";
            this.calendario.ShowToday = false;
            this.calendario.ShowTodayCircle = false;
            this.calendario.TabIndex = 29;
            this.calendario.TrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNombres,
            this.ColApellidos,
            this.ColNombreMascota,
            this.ColTelefono,
            this.ColMotivo,
            this.ColFecha,
            this.ColHora});
            this.dgvTabla.Location = new System.Drawing.Point(35, 254);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(872, 277);
            this.dgvTabla.TabIndex = 43;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "IdCita";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 70;
            // 
            // ColNombres
            // 
            this.ColNombres.HeaderText = "Nombres";
            this.ColNombres.MinimumWidth = 6;
            this.ColNombres.Name = "ColNombres";
            this.ColNombres.ReadOnly = true;
            this.ColNombres.Width = 150;
            // 
            // ColApellidos
            // 
            this.ColApellidos.HeaderText = "Apellidos";
            this.ColApellidos.MinimumWidth = 6;
            this.ColApellidos.Name = "ColApellidos";
            this.ColApellidos.ReadOnly = true;
            this.ColApellidos.Width = 150;
            // 
            // ColNombreMascota
            // 
            this.ColNombreMascota.HeaderText = "Nombre de mascota";
            this.ColNombreMascota.MinimumWidth = 6;
            this.ColNombreMascota.Name = "ColNombreMascota";
            this.ColNombreMascota.ReadOnly = true;
            this.ColNombreMascota.Width = 90;
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.MinimumWidth = 6;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 75;
            // 
            // ColMotivo
            // 
            this.ColMotivo.HeaderText = "Motivo";
            this.ColMotivo.MinimumWidth = 6;
            this.ColMotivo.Name = "ColMotivo";
            this.ColMotivo.ReadOnly = true;
            this.ColMotivo.Width = 125;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 70;
            // 
            // ColHora
            // 
            this.ColHora.HeaderText = "Hora";
            this.ColHora.MinimumWidth = 6;
            this.ColHora.Name = "ColHora";
            this.ColHora.ReadOnly = true;
            this.ColHora.Width = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha:";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(185, 90);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(104, 36);
            this.btnVerTodo.TabIndex = 50;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnVerTodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVerCitas);
            this.groupBox1.Location = new System.Drawing.Point(94, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 142);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar ";
            // 
            // FormCitasProgramadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 566);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.dgvTabla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCitasProgramadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCitasProgramadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerCitas;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHora;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}