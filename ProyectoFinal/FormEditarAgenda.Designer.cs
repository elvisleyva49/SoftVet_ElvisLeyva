namespace ProyectoFinal
{
    partial class FormEditarAgenda
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
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(375, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 31);
            this.label9.TabIndex = 49;
            this.label9.Text = "EDITAR CITAS";
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.Location = new System.Drawing.Point(457, 281);
            this.btnEditarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(122, 41);
            this.btnEditarCita.TabIndex = 31;
            this.btnEditarCita.Text = "Editar Cita";
            this.btnEditarCita.UseVisualStyleBackColor = true;
            this.btnEditarCita.Click += new System.EventHandler(this.btnEditarCita_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "mascota: ";
            // 
            // calendario
            // 
            this.calendario.Enabled = false;
            this.calendario.Location = new System.Drawing.Point(457, 90);
            this.calendario.Margin = new System.Windows.Forms.Padding(7);
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
            this.dgvTabla.Location = new System.Drawing.Point(19, 355);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(908, 236);
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
            this.ColNombreMascota.Width = 125;
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.MinimumWidth = 6;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 80;
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
            this.ColHora.Width = 70;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(205, 302);
            this.txtHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(108, 20);
            this.txtHora.TabIndex = 46;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(148, 688);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(76, 25);
            this.btnRetroceder.TabIndex = 30;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 271);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nombre de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hora:";
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Enabled = false;
            this.txtNomMascota.Location = new System.Drawing.Point(205, 174);
            this.txtNomMascota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.Size = new System.Drawing.Size(108, 20);
            this.txtNomMascota.TabIndex = 37;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(205, 206);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(108, 20);
            this.txtTelefono.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Telefono:";
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(205, 106);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(108, 20);
            this.txtNombres.TabIndex = 33;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(205, 137);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(108, 20);
            this.txtApellidos.TabIndex = 35;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.Enabled = false;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "Chequeo de rutina",
            "Control Nutritivo",
            "Vacunación",
            "Esterilización",
            "Seguimiento",
            "Control de comportamiento"});
            this.cmbMotivo.Location = new System.Drawing.Point(205, 236);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(108, 21);
            this.cmbMotivo.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Motivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombres:";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(205, 75);
            this.txtIdCita.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(108, 20);
            this.txtIdCita.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Id Cita:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(597, 281);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(122, 41);
            this.btnGuardarCambios.TabIndex = 52;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // FormEditarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 625);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtIdCita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditarCita);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomMascota);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditarAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarAgenda";
            this.Load += new System.EventHandler(this.FormEditarAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomMascota;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHora;
    }
}