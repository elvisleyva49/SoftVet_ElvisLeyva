namespace ProyectoFinal
{
    partial class FormReportePacientesAtendidos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtTotalPacientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResumenPacientes = new System.Windows.Forms.DataGridView();
            this.colmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPacientesAtendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnResumen = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReporteCompleto = new System.Windows.Forms.Button();
            this.btnReporteIngresado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPacientes
            // 
            this.txtTotalPacientes.Location = new System.Drawing.Point(871, 245);
            this.txtTotalPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPacientes.Name = "txtTotalPacientes";
            this.txtTotalPacientes.Size = new System.Drawing.Size(132, 22);
            this.txtTotalPacientes.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total Pacientes";
            // 
            // dgvResumenPacientes
            // 
            this.dgvResumenPacientes.AllowUserToAddRows = false;
            this.dgvResumenPacientes.AllowUserToDeleteRows = false;
            this.dgvResumenPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmes,
            this.colPacientesAtendidos});
            this.dgvResumenPacientes.Location = new System.Drawing.Point(757, 114);
            this.dgvResumenPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResumenPacientes.Name = "dgvResumenPacientes";
            this.dgvResumenPacientes.ReadOnly = true;
            this.dgvResumenPacientes.RowHeadersWidth = 51;
            this.dgvResumenPacientes.Size = new System.Drawing.Size(328, 111);
            this.dgvResumenPacientes.TabIndex = 41;
            // 
            // colmes
            // 
            this.colmes.HeaderText = "Mes";
            this.colmes.MinimumWidth = 6;
            this.colmes.Name = "colmes";
            this.colmes.ReadOnly = true;
            this.colmes.Width = 125;
            // 
            // colPacientesAtendidos
            // 
            this.colPacientesAtendidos.HeaderText = "Pacientes Atendidos";
            this.colPacientesAtendidos.MinimumWidth = 6;
            this.colPacientesAtendidos.Name = "colPacientesAtendidos";
            this.colPacientesAtendidos.ReadOnly = true;
            this.colPacientesAtendidos.Width = 125;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(216, 167);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(757, 79);
            this.btnResumen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(137, 28);
            this.btnResumen.TabIndex = 36;
            this.btnResumen.Text = "Generar Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(72, 234);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.Size = new System.Drawing.Size(631, 373);
            this.dgvReporte.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ingresar Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ingresar dia de Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(431, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "REPORTE PACIENTES ATENDIDOS";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(755, 277);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(464, 330);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(511, 181);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnReporteCompleto
            // 
            this.btnReporteCompleto.Location = new System.Drawing.Point(511, 102);
            this.btnReporteCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporteCompleto.Name = "btnReporteCompleto";
            this.btnReporteCompleto.Size = new System.Drawing.Size(192, 28);
            this.btnReporteCompleto.TabIndex = 54;
            this.btnReporteCompleto.Text = "Generar Reporte Completo";
            this.btnReporteCompleto.UseVisualStyleBackColor = true;
            this.btnReporteCompleto.Click += new System.EventHandler(this.btnReporteCompleto_Click);
            // 
            // btnReporteIngresado
            // 
            this.btnReporteIngresado.Location = new System.Drawing.Point(511, 143);
            this.btnReporteIngresado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporteIngresado.Name = "btnReporteIngresado";
            this.btnReporteIngresado.Size = new System.Drawing.Size(192, 31);
            this.btnReporteIngresado.TabIndex = 53;
            this.btnReporteIngresado.Text = "Generar Reporte Ingresado";
            this.btnReporteIngresado.UseVisualStyleBackColor = true;
            // 
            // FormReportePacientesAtendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnReporteCompleto);
            this.Controls.Add(this.btnReporteIngresado);
            this.Controls.Add(this.txtTotalPacientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvResumenPacientes);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReportePacientesAtendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPacientesAtendidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPacientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvResumenPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPacientesAtendidos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnReporteCompleto;
        private System.Windows.Forms.Button btnReporteIngresado;
    }
}