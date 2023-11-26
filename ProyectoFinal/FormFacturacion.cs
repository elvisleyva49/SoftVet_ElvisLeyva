using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormFacturacion : Form
    {
        bool existe;
        string Paciente, Condicion, Propietario, DNI, timeh, total;
        int contador;
        int contadorFilas = 0;
        int contadorFacturas;

        private ManejadorProductos manejadorProductos;

        Producto objGenerar = new Producto();

        private void btnAñadirCita_Click(object sender, EventArgs e)
        {
            txtCantidad.Enabled = false;
            // Obtener la información de los TextBox
            string idProducto = txtIdProducto.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text.Trim());
            int cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
            decimal valorTotal = precioUnitario * cantidad;

            // Calcular el nuevo valor del stock
            int stockActual = Convert.ToInt32(txtStock.Text.Trim());
            int nuevoStock = stockActual - cantidad;

            // Calcular el valor total del producto
            decimal valorTotalProducto = precioUnitario * cantidad;

            // Actualizar el archivo de productos
            string[] lineas = File.ReadAllLines(".\\Ficheros\\productos.txt");
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(';');
                if (campos[0].Trim() == idProducto)
                {
                    campos[2] = nuevoStock.ToString();
                    lineas[i] = string.Join(";", campos);
                    break;
                }
            }
            File.WriteAllLines(".\\Ficheros\\productos.txt", lineas);

            // Crear una nueva fila en el DataGridView
            dgvProductos.Rows.Insert(0, idProducto, nombre, cantidad, precioUnitario, valorTotalProducto);

            // Calcular el total y mostrarlo en txtTotal
            decimal total = dgvProductos.Rows.Cast<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells["ColValorSubTotal"].Value, CultureInfo.InvariantCulture));
            txtSubTotal.Text = valorTotalProducto.ToString();    
            txtTotal.Text = total.ToString();

            // Limpiar los TextBox y deshabilitar el botón Añadir
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtPrecioUnitario.Clear();
            txtCantidad.Clear();
            txtNombre.Enabled = true;
            btnAñadirCita.Enabled = false;
        }

        public FormFacturacion()
        {
            InitializeComponent();
            this.FormClosing += FormFacturacion_FormClosing;
            manejadorProductos = new ManejadorProductos(".\\Ficheros\\productos.txt");

            if (File.Exists("contadorFacturas.txt"))
            {
                contadorFacturas = Convert.ToInt32(File.ReadAllText("contadorFacturas.txt"));
            }
            else
            {
                contador = 1;
            }
            contador = contadorFacturas;
            txtIdProducto.Enabled = false;
            txtStock.Enabled = false;
            txtSubTotal.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecioUnitario.Enabled = false;
            txtCantidad.Enabled = false;

            dateTimePicker1.Enabled = true;
            txtCondicion.Enabled = true;
            txtPaciente.Enabled = true;
            txtPropietario.Enabled = true;
            txtDNI.Enabled = true;
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            txtStock.Clear();
            txtSubTotal.Clear();
            txtNombre.Enabled = false;
            txtPropietario.Enabled = true;
            txtPaciente.Enabled = true;
            txtDNI.Enabled = true;
            txtCondicion.Enabled = true;
            dateTimePicker1.Enabled = true;
            using (StreamWriter writer = new StreamWriter(".\\Ficheros\\FacturasGeneradas\\FAC" + contador + ".txt"))
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    string linea = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value));
                    writer.WriteLine(linea);
                }
            }

            string total = txtTotal.Text;

            List<string> lineas = File.ReadAllLines(".\\Ficheros\\facturas.txt").ToList();

            string fecha = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");

            string nuevaLinea = $"FAC{contador};{Paciente};{Condicion};{Propietario};{DNI};{fecha};{total}";

            lineas.Add(nuevaLinea);

            File.WriteAllLines(".\\Ficheros\\facturas.txt", lineas);
            contador++;
            contadorFilas = 0;

            dgvProductos.Rows.Clear();
            txtTotal.Clear();

            File.WriteAllText("contadorFacturas.txt", contador.ToString());
            // Eliminar las líneas sin valorTotal
            string rutaArchivoFacturas = ".\\Ficheros\\facturas.txt";
            string[] lineasFacturas = File.ReadAllLines(rutaArchivoFacturas);
            List<string> lineasConValorTotal = lineasFacturas.Where(linea => !linea.EndsWith(";;")).ToList();
            File.WriteAllLines(rutaArchivoFacturas, lineasConValorTotal);
        }

        private void FormFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("contadorFacturas.txt", contador.ToString());
        }

        private void FormFacturacion_Load_1(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null &&
                !string.IsNullOrWhiteSpace(txtCondicion.Text) &&
                !string.IsNullOrWhiteSpace(txtPaciente.Text) &&
                !string.IsNullOrWhiteSpace(txtPropietario.Text) &&
                !string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                txtPropietario.Enabled = false;
                txtPaciente.Enabled = false;
                txtDNI.Enabled = false;
                txtCondicion.Enabled = false;
                dateTimePicker1.Enabled = false;

                existe = false;
                //contador = 1;
                Paciente = txtPaciente.Text;
                Condicion = txtCondicion.Text;
                Propietario = txtPropietario.Text;
                DNI = txtDNI.Text;
                total = txtSubTotal.Text;
                timeh = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                objGenerar.AgregarPagos(existe, contador, Paciente, Condicion, Propietario, DNI, timeh, total, txtTotal.Text);

                txtNombre.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string NomProductoBuscado = txtNombre.Text.Trim();
            bool NomProductoEncontrado = false;

            // Leer el archivo y buscar si la ID existe
            using (StreamReader sr = new StreamReader(".\\Ficheros\\productos.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos[1].Trim() == NomProductoBuscado)
                    {
                        NomProductoEncontrado = true;

                        // Mostrar información en los TextBox
                        txtIdProducto.Text = campos[0].Trim();
                        txtStock.Text = campos[2].Trim();
                        txtPrecioUnitario.Text = campos[3].Trim();
                        break;
                    }
                }
            }

            if (NomProductoEncontrado)
            {
                // Habilitar los TextBox
                txtIdProducto.Enabled = false;
                txtStock.Enabled = false;
                txtSubTotal.Enabled = false;
                txtCantidad.Enabled = true;
                txtPrecioUnitario.Enabled = false;
                btnAñadirCita.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error: No se ha encontrado el nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<Producto> productos = manejadorProductos.LeerProducto();

            foreach (Producto producto in productos)
            {
                dgvProductos.Rows.Add(producto.Id, producto.Nombre, producto.Stock, producto.PrecioUnitario);
            }
        }

        private void cmbTipoAtencion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {

        }
    }
}