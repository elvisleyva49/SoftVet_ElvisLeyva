using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsHistorialVacunacion
    {
        private List<ClsHistorialVacunacion> listaDeTodasLasVacunas;
        public string codigo { get; set; }
        public string nombrevacuna { get; set; }
        public string nro_dosis { get; set; }
        public string fecha { get; set; }

        public bool encontrado { get; set; }

        public bool agregado { get; set; }


        //string codigo, nomemp, apeemp, dniemp, Fechnac, genero, telf, Fechini, cargo, horario;
        //int sueldo;

        StreamReader lectura;
        StreamWriter escribir;

        string texto;
        bool existe = false;
        String[] campo = new string[12];
        string id;
        int contador = 1;

        //Metodos
        public void AgregarVacuna(string nomvacuna, string ndosis, string fecha, string codMascota)
        {

            agregado = false;
            try
            {
                if (nomvacuna != "" && ndosis != "" && fecha != "" && codMascota != "")
                {
                    lectura = File.OpenText(".\\Ficheros\\vacunas.txt");
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
                    escribir = File.AppendText(".\\Ficheros\\vacunas.txt");
                    if (existe == false)
                    {
                        existe = false;
                        id = "" + contador;
                        escribir.WriteLine(nomvacuna + ";" + ndosis + ";" + fecha + ";" + codMascota);
                        MessageBox.Show("La vacuna se ha registrado correctamente...", "Historial de Vacuna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        agregado = true;
                    }
                    else
                    {
                        MessageBox.Show("La vacuna ya existe!", "Historial de Vacuna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        agregado = true;
                    }
                    escribir.Close();
                }
                else
                {
                    MessageBox.Show("Faltan Completar datos... ", "Historial de Vacuna", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public List<ClsHistorialVacunacion> LeerVacunas()
        {
            List<ClsHistorialVacunacion> vacunas = new List<ClsHistorialVacunacion>();
            using (StreamReader leer = new StreamReader(".\\Ficheros\\vacunas.txt"))
            {
                string line;
                while ((line = leer.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 3)
                    {
                        ClsHistorialVacunacion vacuna = new ClsHistorialVacunacion
                        {
                            nombrevacuna = campos[0],
                            nro_dosis = campos[1],
                            fecha = campos[2],
                        };
                        vacunas.Add(vacuna);
                    }
                }
            }
            return vacunas;
        }
        public List<ClsHistorialVacunacion> LeerVacunasPorCodigoMascota(string codigoMascota)
        {
            List<ClsHistorialVacunacion> vacunasPorCodigo = new List<ClsHistorialVacunacion>();
            using (StreamReader leer = new StreamReader(".\\Ficheros\\vacunas.txt"))
            {
                string line;
                while ((line = leer.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 4 && campos[3] == codigoMascota)
                    {
                        ClsHistorialVacunacion vacuna = new ClsHistorialVacunacion
                        {
                            nombrevacuna = campos[0],
                            nro_dosis = campos[1],
                            fecha = campos[2],
                            codigo = campos[3]
                        };
                        vacunasPorCodigo.Add(vacuna);
                    }
                }
            }
            return vacunasPorCodigo;
        }


    }


}
