namespace ProyectoFinal
{
    partial class FormReporteIngresos
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
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResumenIngresos = new System.Windows.Forms.DataGridView();
            this.colmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReporteCompleto = new System.Windows.Forms.Button();
            this.btnReporteIngresado = new System.Windows.Forms.Button();
            this.btnResumenIngresos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(682, 204);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIngresos.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Total Ingresos";
            // 
            // dgvResumenIngresos
            // 
            this.dgvResumenIngresos.AllowUserToAddRows = false;
            this.dgvResumenIngresos.AllowUserToDeleteRows = false;
            this.dgvResumenIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmes,
            this.colMonto});
            this.dgvResumenIngresos.Location = new System.Drawing.Point(595, 93);
            this.dgvResumenIngresos.Name = "dgvResumenIngresos";
            this.dgvResumenIngresos.ReadOnly = true;
            this.dgvResumenIngresos.Size = new System.Drawing.Size(245, 105);
            this.dgvResumenIngresos.TabIndex = 46;
            // 
            // colmes
            // 
            this.colmes.HeaderText = "Mes";
            this.colmes.Name = "colmes";
            this.colmes.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(501, 248);
            this.dataGridView1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ingresar Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ingresar dia de Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "REPORTE DE INGRESOS";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(595, 242);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(364, 257);
            this.chart1.TabIndex = 49;
            this.chart1.Text = "chart1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(394, 161);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnReporteCompleto
            // 
            this.btnReporteCompleto.Location = new System.Drawing.Point(394, 97);
            this.btnReporteCompleto.Name = "btnReporteCompleto";
            this.btnReporteCompleto.Size = new System.Drawing.Size(144, 23);
            this.btnReporteCompleto.TabIndex = 51;
            this.btnReporteCompleto.Text = "Generar Reporte Completo";
            this.btnReporteCompleto.UseVisualStyleBackColor = true;
            // 
            // btnReporteIngresado
            // 
            this.btnReporteIngresado.Location = new System.Drawing.Point(394, 130);
            this.btnReporteIngresado.Name = "btnReporteIngresado";
            this.btnReporteIngresado.Size = new System.Drawing.Size(144, 25);
            this.btnReporteIngresado.TabIndex = 50;
            this.btnReporteIngresado.Text = "Generar Reporte Ingresado";
            this.btnReporteIngresado.UseVisualStyleBackColor = true;
            // 
            // btnResumenIngresos
            // 
            this.btnResumenIngresos.Location = new System.Drawing.Point(595, 63);
            this.btnResumenIngresos.Name = "btnResumenIngresos";
            this.btnResumenIngresos.Size = new System.Drawing.Size(104, 24);
            this.btnResumenIngresos.TabIndex = 53;
            this.btnResumenIngresos.Text = "Generar Resumen";
            this.btnResumenIngresos.UseVisualStyleBackColor = true;
            // 
            // FormReporteIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 586);
            this.ControlBox = false;
            this.Controls.Add(this.btnResumenIngresos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnReporteCompleto);
            this.Controls.Add(this.btnReporteIngresado);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtTotalIngresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvResumenIngresos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteIngresos";
            this.Load += new System.EventHandler(this.FormReporteIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvResumenIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnReporteCompleto;
        private System.Windows.Forms.Button btnReporteIngresado;
        private System.Windows.Forms.Button btnResumenIngresos;
    }
}