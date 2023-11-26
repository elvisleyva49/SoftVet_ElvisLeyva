using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Stock { get; set; }
        public string PrecioUnitario { get; set; }
        //Metodo 
        public void AgregarPagos(bool existe, int contador, string Paciente, string Condicion, string Propietario, string DNI, string timeh, string total, string valorTotal)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string texto;
            String[] campo = new string[8];
            string id;

            try
            {
                if (Paciente != "" && Condicion != "" && Propietario != "" && DNI != "" && timeh != "")
                {
                    lectura = File.OpenText(".\\Ficheros\\facturas.txt");
                    texto = lectura.ReadLine();
                    while (texto != null && existe == false)
                    {
                        campo = texto.Split(';');
                        if (campo[0].Trim().Equals(contador))
                        {
                            existe = true;
                            break;
                        }
                        texto = lectura.ReadLine();
                        //contador = contador + 1;
                    }
                    lectura.Close();
                    escribir = File.AppendText(".\\Ficheros\\facturas.txt");
                    if (existe == false)
                    {
                        existe = false;
                        id = "FAC" + contador;
                        escribir.WriteLine(id + ";" + Paciente + ";" + Condicion + ";" + Propietario + ";" + DNI + ";" + ";" + timeh + ";" + total + ";" + valorTotal);
                        MessageBox.Show("Ingrese los datos del Producto", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("La cita ya existe...", "Citas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    escribir.Close();
                    contador = contador + 1;
                    contador++;
                }
                else
                {
                    MessageBox.Show("Faltan Completar datos... ", "Citas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Clase ManejadorCitas
    public class ManejadorProductos
    {
        private string rutaArchivo;
        public ManejadorProductos(string ruta)
        {
            rutaArchivo = ruta;
        }
        public List<Producto> LeerProducto()
        {
            List<Producto> productos = new List<Producto>();
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 8)
                    {
                        Producto producto = new Producto
                        {
                            Id = campos[0],
                            Nombre = campos[1],
                            Stock = campos[2],
                            PrecioUnitario = campos[3],
                        };
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
    }

}