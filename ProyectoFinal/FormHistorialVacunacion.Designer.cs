namespace ProyectoFinal
{
    partial class FormHistorialVacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialVacunacion));
            this.datePickPaciente = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarVacuna = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegistrarVacuna = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ColVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaVacunacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRegistrarNroDosis = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodMascotaBuscar = new System.Windows.Forms.TextBox();
            this.txtNombreMostrar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datePickPaciente
            // 
            this.datePickPaciente.Location = new System.Drawing.Point(100, 99);
            this.datePickPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickPaciente.Name = "datePickPaciente";
            this.datePickPaciente.Size = new System.Drawing.Size(199, 20);
            this.datePickPaciente.TabIndex = 49;
            // 
            // btnAgregarVacuna
            // 
            this.btnAgregarVacuna.Enabled = false;
            this.btnAgregarVacuna.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVacuna.Location = new System.Drawing.Point(222, 34);
            this.btnAgregarVacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarVacuna.Name = "btnAgregarVacuna";
            this.btnAgregarVacuna.Size = new System.Drawing.Size(77, 54);
            this.btnAgregarVacuna.TabIndex = 40;
            this.btnAgregarVacuna.Text = "Agregar";
            this.btnAgregarVacuna.UseVisualStyleBackColor = true;
            this.btnAgregarVacuna.Click += new System.EventHandler(this.btnAgregarVacuna_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fecha Vacuna:";
            // 
            // txtRegistrarVacuna
            // 
            this.txtRegistrarVacuna.Location = new System.Drawing.Point(79, 36);
            this.txtRegistrarVacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistrarVacuna.Name = "txtRegistrarVacuna";
            this.txtRegistrarVacuna.Size = new System.Drawing.Size(129, 20);
            this.txtRegistrarVacuna.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 280);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 19);
            this.label14.TabIndex = 39;
            this.label14.Text = "Vacunaciones: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nro. Dosis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vacuna: ";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColVacuna,
            this.ColNDosis,
            this.ColFechaVacunacion,
            this.ColCodMascota});
            this.dgvResultados.Location = new System.Drawing.Point(56, 305);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(486, 154);
            this.dgvResultados.TabIndex = 47;
            // 
            // ColVacuna
            // 
            this.ColVacuna.HeaderText = "Vacuna";
            this.ColVacuna.MinimumWidth = 6;
            this.ColVacuna.Name = "ColVacuna";
            this.ColVacuna.Width = 125;
            // 
            // ColNDosis
            // 
            this.ColNDosis.HeaderText = "Nro Dosis";
            this.ColNDosis.MinimumWidth = 6;
            this.ColNDosis.Name = "ColNDosis";
            this.ColNDosis.Width = 50;
            // 
            // ColFechaVacunacion
            // 
            this.ColFechaVacunacion.HeaderText = "Fecha de Vacuna";
            this.ColFechaVacunacion.MinimumWidth = 6;
            this.ColFechaVacunacion.Name = "ColFechaVacunacion";
            this.ColFechaVacunacion.Width = 125;
            // 
            // ColCodMascota
            // 
            this.ColCodMascota.HeaderText = "Cod. Mascota";
            this.ColCodMascota.MinimumWidth = 6;
            this.ColCodMascota.Name = "ColCodMascota";
            this.ColCodMascota.Width = 125;
            // 
            // txtRegistrarNroDosis
            // 
            this.txtRegistrarNroDosis.Location = new System.Drawing.Point(86, 68);
            this.txtRegistrarNroDosis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegistrarNroDosis.Name = "txtRegistrarNroDosis";
            this.txtRegistrarNroDosis.Size = new System.Drawing.Size(122, 20);
            this.txtRegistrarNroDosis.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMostrar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtCodMascotaBuscar);
            this.groupBox3.Controls.Add(this.txtNombreMostrar);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(60, 104);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(358, 145);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Propietario";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(260, 70);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(73, 30);
            this.btnMostrar.TabIndex = 28;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(260, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 31);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 14);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ingrese Codigo Mascota: ";
            // 
            // txtCodMascotaBuscar
            // 
            this.txtCodMascotaBuscar.Location = new System.Drawing.Point(155, 36);
            this.txtCodMascotaBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodMascotaBuscar.Name = "txtCodMascotaBuscar";
            this.txtCodMascotaBuscar.Size = new System.Drawing.Size(56, 20);
            this.txtCodMascotaBuscar.TabIndex = 25;
            // 
            // txtNombreMostrar
            // 
            this.txtNombreMostrar.Enabled = false;
            this.txtNombreMostrar.Location = new System.Drawing.Point(82, 80);
            this.txtNombreMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreMostrar.Name = "txtNombreMostrar";
            this.txtNombreMostrar.Size = new System.Drawing.Size(129, 20);
            this.txtNombreMostrar.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(321, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Historial de Vacunación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarVacuna);
            this.groupBox1.Controls.Add(this.datePickPaciente);
            this.groupBox1.Controls.Add(this.txtRegistrarNroDosis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRegistrarVacuna);
            this.groupBox1.Location = new System.Drawing.Point(560, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 154);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Vacuna";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(594, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // FormHistorialVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 543);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHistorialVacunacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickPaciente;
        private System.Windows.Forms.Button btnAgregarVacuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegistrarVacuna;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNDosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaVacunacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodMascota;
        private System.Windows.Forms.TextBox txtRegistrarNroDosis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodMascotaBuscar;
        private System.Windows.Forms.TextBox txtNombreMostrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}