namespace ProyectoFinal
{
    partial class FormProgramarCita
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
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(412, 615);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(76, 25);
            this.btnRetroceder.TabIndex = 1;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
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
            this.dgvTabla.Location = new System.Drawing.Point(36, 362);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(858, 236);
            this.dgvTabla.TabIndex = 21;
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
            this.ColMotivo.Width = 90;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre de";
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(161, 161);
            this.txtNomMascota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.Size = new System.Drawing.Size(108, 20);
            this.txtNomMascota.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(161, 192);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(108, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(161, 123);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(108, 20);
            this.txtApellidos.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Motivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombres:";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "Chequeo de rutina",
            "Control Nutritivo",
            "Vacunación",
            "Esterilización",
            "Seguimiento",
            "Control de comportamiento"});
            this.cmbMotivo.Location = new System.Drawing.Point(161, 223);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(108, 21);
            this.cmbMotivo.TabIndex = 20;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(161, 92);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(108, 20);
            this.txtNombres.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hora:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 258);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(158, 289);
            this.txtHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(108, 20);
            this.txtHora.TabIndex = 25;
            // 
            // calendario
            // 
            this.calendario.Enabled = false;
            this.calendario.Location = new System.Drawing.Point(477, 95);
            this.calendario.Margin = new System.Windows.Forms.Padding(7);
            this.calendario.Name = "calendario";
            this.calendario.ShowToday = false;
            this.calendario.ShowTodayCircle = false;
            this.calendario.TabIndex = 0;
            this.calendario.TrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "mascota: ";
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Location = new System.Drawing.Point(477, 266);
            this.btnRegistrarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(122, 41);
            this.btnRegistrarCita.TabIndex = 2;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnSeleccionarFecha_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(278, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 31);
            this.label9.TabIndex = 28;
            this.label9.Text = "PROGRAMAR NUEVAS CITAS";
            // 
            // FormProgramarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 609);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegistrarCita);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProgramarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormProgramarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomMascota;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Label label9;
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