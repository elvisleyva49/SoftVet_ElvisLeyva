using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal
{
    public partial class FormReportedeIngresos : Form
    {
        public FormReportedeIngresos()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                // Obtener el año ingresado
                int anio = Convert.ToInt32(txtAnio.Text);

                // Leer todas las líneas del archivo de facturas y convertirlas a una lista de strings
                List<string> lineas = File.ReadAllLines("Ficheros\\facturas.txt").ToList();

                // Crear un diccionario para almacenar los ingresos por mes (mes e ingreso)
                Dictionary<int, decimal> ingresosPorMes = new Dictionary<int, decimal>();

                foreach (string linea in lineas)
                {
                    // Separa los campos de la línea en ;
                    string[] campos = linea.Split(';');
                    if (campos.Length >= 6)
                    {
                        // Separa el campo de la fecha con /
                        // Extrae el mes y el año
                        string[] fecha = campos[5].Split('/');
                        int mes = Convert.ToInt32(fecha[1]);
                        int anioFactura = Convert.ToInt32(fecha[2]);

                        // Si la factura pertenece al año seleccionado
                        if (anio == anioFactura)
                        {
                            // Define al campo 6 como monto
                            decimal monto = Convert.ToDecimal(campos[6]);

                            // Si el diccionario ingresosPorMes contiene una clave igual a mes
                            if (ingresosPorMes.ContainsKey(mes))
                            {
                                ingresosPorMes[mes] += monto;
                            }
                            else
                            {
                                ingresosPorMes[mes] = monto;
                            }
                        }
                    }
                }

                // Limpiar lista
                lstLista.Items.Clear();

                // Ordenar el diccionario por mes
                var mesesOrdenados = ingresosPorMes.OrderBy(x => x.Key);

                foreach (var entrada in mesesOrdenados)
                {
                    // Obtener el nombre del mes en mayúsculas
                    string mesNombre = new DateTime(anio, entrada.Key, 1).ToString("MMMM").ToUpper();

                    // Agregar el mes y el ingreso a la ListBox
                    lstLista.Items.Add($"{mesNombre}: {entrada.Value}");
                }

                // Limpiar las series del gráfico y agregar una nueva serie
                chartFacturas.Series.Clear();
                chartFacturas.Series.Add("Reporte Anual");

                foreach (var entrada in mesesOrdenados)
                {
                    // Crea un nuevo date time
                    // anio = año, entrada = mes
                    string mesNombre = new DateTime(anio, entrada.Key, 1).ToString("MMMM").ToUpper();

                    // Agregar datos
                    chartFacturas.Series["Reporte Anual"].Points.AddXY(mesNombre, entrada.Value);
                }

                // Sumar todos los valores de la colección ingresosPorMes
                decimal totalAnio = ingresosPorMes.Sum(x => x.Value);
                txtTotalAnio.Text = totalAnio.ToString();

                chartPastel.Series.Clear();
                chartPastel.Series.Add("Reporte Anual");

                // Configurar el gráfico de pastel
                chartPastel.Series["Reporte Anual"].ChartType = SeriesChartType.Pie;

                foreach (var entrada in mesesOrdenados)
                {
                    string mesNombre = new DateTime(anio, entrada.Key, 1).ToString("MMMM").ToUpper();

                    // Agregar datos al gráfico de pastel
                    chartPastel.Series["Reporte Anual"].Points.AddXY(mesNombre, entrada.Value);
                }

                chartSpline.Series.Clear();
                chartSpline.Series.Add("Reporte Anual");

                foreach (var entrada in mesesOrdenados)
                {
                    string mesNombre = new DateTime(anio, entrada.Key, 1).ToString("MMMM").ToUpper();

                    // Agregar datos al gráfico de SplineArea
                    chartSpline.Series["Reporte Anual"].Points.AddXY(mesNombre, entrada.Value);
                }

                // Configurar el gráfico de SplineArea
                chartSpline.Series["Reporte Anual"].ChartType = SeriesChartType.SplineArea;

                // Ocultar las etiquetas de los ejes X y Y
                chartSpline.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

                // Desactivar las líneas de la cuadrícula
                chartSpline.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartSpline.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese el año del reporte que desea generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
