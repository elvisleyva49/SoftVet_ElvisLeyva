using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    // Clase Cita
    public class Cita
    {
        public string Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NomMascota { get; set; }
        public string Telefono { get; set; }
        public string Motivo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        //Metodo Agregar Citas
        public void AgregarCitas(bool existe, int contador, string Nombres, string Apellidos, string NomMascota, string Telefono, string Motivo, string Hora, string timeh)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string texto;
            String[] campo = new string[7];
            string id;
            try
            {
                if (Nombres != "" && Apellidos != "" && NomMascota != "" && Telefono != "" && Motivo != "" && Hora != "")
                {
                    lectura = File.OpenText(".\\Ficheros\\citas.txt");
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
                        contador = contador + 1;
                    }
                    lectura.Close();
                    escribir = File.AppendText(".\\Ficheros\\citas.txt");
                    if (existe == false)
                    {
                        existe = false;
                        id = "CI0" + contador;
                        escribir.WriteLine(id + ";" + Nombres + ";" + Apellidos + ";" + NomMascota + ";" + Telefono + ";" + Motivo + ";" + timeh + ";" + Hora);
                        MessageBox.Show("La cita se ha registrado correctamente...", "Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La cita ya existe...", "Citas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    escribir.Close();
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
    public class ManejadorCitas
    {
        private string rutaArchivo;
        public ManejadorCitas(string ruta)
        {
            rutaArchivo = ruta;
        }
        public List<Cita> LeerCitas()
        {
            List<Cita> citas = new List<Cita>();
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 8)
                    {
                        Cita cita = new Cita
                        {
                            Id = campos[0],
                            Nombres = campos[1],
                            Apellidos = campos[2],
                            NomMascota = campos[3],
                            Telefono = campos[4],
                            Motivo = campos[5],
                            Fecha = campos[6],
                            Hora = campos[7]
                        };
                        citas.Add(cita);
                    }
                }
            }
            return citas;
        }
    }
}

