using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormRegistrodePagos : Form
    {
        public FormRegistrodePagos()
        {
            InitializeComponent();
        }

        private void FormRegistrodePagos_Load(object sender, EventArgs e)
        {
            // Leer las líneas del archivo "facturas" para cargarlas en el DataGridView
            string[] lineas = System.IO.File.ReadAllLines("Ficheros\\facturas.txt");

            foreach (string linea in lineas)
            {
                // Separar los campos
                string[] campos = linea.Split(';');

                if (campos.Length >= 7)
                {
                    dgvFacturas.Rows.Add(campos);
                }
            }
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0)
            {
                string idFactura = dgvFacturas.SelectedRows[0].Cells[0].Value.ToString(); // Obtener el ID de la factura seleccionada

                // Leer las líneas del archivo correspondiente a la factura seleccionada
                string[] lineasDetalles = System.IO.File.ReadAllLines($"Ficheros\\FacturasGeneradas\\{idFactura}.txt");

                dgvDetalles.Rows.Clear(); // Limpiar el DataGridView de detalles

                foreach (string linea in lineasDetalles)
                {
                    // Separar los campos
                    string[] campos = linea.Split(';');

                    if (campos.Length >= 5)
                    {
                        dgvDetalles.Rows.Add(campos);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

            // Leer las líneas del archivo "facturas"
            string[] lineas = System.IO.File.ReadAllLines("Ficheros\\facturas.txt");

            dgvFacturas.Rows.Clear(); // Limpiar el DataGridView de facturas

            foreach (string linea in lineas)
            {
                // Separar los campos
                string[] campos = linea.Split(';');

                if (campos.Length >= 7) 
                {
                    // Convertir la fecha de la factura a un objeto DateTime
                    DateTime fechaFactura;
                    if (DateTime.TryParseExact(campos[5], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaFactura))
                    {
                        // Comparar la fecha de la factura con la fecha seleccionada
                        if (fechaFactura.Date == fechaSeleccionada)
                        {
                            dgvFacturas.Rows.Add(campos);
                        }
                    }
                }
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            dgvFacturas.Rows.Clear();
            // Leer las líneas del archivo "facturas"
            string[] lineas = System.IO.File.ReadAllLines("Ficheros\\facturas.txt");

            foreach (string linea in lineas)
            {
                // Separar los campos
                string[] campos = linea.Split(';');

                if (campos.Length >= 7)
                {
                    dgvFacturas.Rows.Add(campos);
                }
            }
        }

        
    }
}
