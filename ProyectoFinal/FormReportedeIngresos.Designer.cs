namespace ProyectoFinal
{
    partial class FormReportedeIngresos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSpline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFacturas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPastel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "Gráfico de barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 120;
            this.label4.Text = "Gráfico pastel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 119;
            this.label3.Text = "Área Spline";
            // 
            // chartSpline
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSpline.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartSpline.Legends.Add(legend4);
            this.chartSpline.Location = new System.Drawing.Point(143, 315);
            this.chartSpline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartSpline.Name = "chartSpline";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            this.chartSpline.Series.Add(series4);
            this.chartSpline.Size = new System.Drawing.Size(262, 208);
            this.chartSpline.TabIndex = 118;
            this.chartSpline.Text = "chart1";
            // 
            // chartPastel
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPastel.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartPastel.Legends.Add(legend5);
            this.chartPastel.Location = new System.Drawing.Point(526, 315);
            this.chartPastel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPastel.Name = "chartPastel";
            this.chartPastel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartPastel.Series.Add(series5);
            this.chartPastel.Size = new System.Drawing.Size(239, 208);
            this.chartPastel.TabIndex = 117;
            this.chartPastel.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Total del año:";
            // 
            // txtTotalAnio
            // 
            this.txtTotalAnio.Enabled = false;
            this.txtTotalAnio.Location = new System.Drawing.Point(230, 261);
            this.txtTotalAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalAnio.Name = "txtTotalAnio";
            this.txtTotalAnio.Size = new System.Drawing.Size(103, 20);
            this.txtTotalAnio.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Ingrese el año:";
            // 
            // chartFacturas
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFacturas.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartFacturas.Legends.Add(legend6);
            this.chartFacturas.Location = new System.Drawing.Point(526, 89);
            this.chartFacturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartFacturas.Name = "chartFacturas";
            this.chartFacturas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFacturas.Series.Add(series6);
            this.chartFacturas.Size = new System.Drawing.Size(222, 192);
            this.chartFacturas.TabIndex = 111;
            this.chartFacturas.Text = "chart1";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(274, 64);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(103, 20);
            this.txtAnio.TabIndex = 113;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(137, 145);
            this.lstLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(253, 108);
            this.lstLista.TabIndex = 112;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(230, 106);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(71, 20);
            this.btnSeleccionar.TabIndex = 110;
            this.btnSeleccionar.Text = "Ver Todo";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(315, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(361, 31);
            this.label16.TabIndex = 109;
            this.label16.Text = "REPORTE DE INGRESOS";
            // 
            // FormReportedeIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 543);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartSpline);
            this.Controls.Add(this.chartPastel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartFacturas);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReportedeIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportedeIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.chartSpline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPastel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpline;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPastel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFacturas;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label16;
    }
}