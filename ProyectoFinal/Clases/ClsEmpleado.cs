using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace ProyectoFinal.Clases
{
    public class ClsEmpleado
    {
        public string Codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string fnacimiento { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string Fingreso { get; set; }
        public string Cargo { get; set; }
        public string Horario { get; set; }
        public int Sueldo { get; set; }


        public bool agregado { get; set; }


        string codigo, nomemp, apeemp, dniemp, Fechnac, genero, telf, Fechini, cargo, horario;
        int sueldo;

        StreamReader lectura;
        StreamWriter escribir;

        string texto;
        bool existe = false;
        String[] campo = new string[12];
        string id;
        int contador = 1;

        //Metodos
        public void AgregarEmpleado(string nomemp, string apeemp, string dniemp,
                                   string Fechnac, string genero, string telf, string Fechini,
                                   string cargo, string horario, int sueldo)
        {

            agregado = false;
            try
            {
                if (nomemp != "" && apeemp != "" && dniemp != "" && Fechnac != "" &&
                    genero != "" && telf != "" && Fechini != "" && cargo != "" && horario != null && sueldo > 0)
                {

                    lectura = File.OpenText(".\\Ficheros\\empleados.txt");
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
                    escribir = File.AppendText(".\\Ficheros\\empleados.txt");
                    if (existe == false)
                    {
                        existe = false;
                        id = "EMP" + contador;
                        escribir.WriteLine(id + ";" + nomemp + ";" + apeemp + ";" + dniemp + ";" + Fechnac +
                                            ";" + genero + ";" + telf + ";" + Fechini + ";" + cargo + ";" + horario + ";" + sueldo);
                        MessageBox.Show("El empleado se ha registrado correctamente...", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        agregado = true;
                    }
                    else
                    {
                        MessageBox.Show("¡El empleado ya existe!", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        agregado = true;
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

        public List<ClsEmpleado> LeerEmpleados()
        {
            List<ClsEmpleado> empleados = new List<ClsEmpleado>();
            using (StreamReader leer = new StreamReader(".\\Ficheros\\empleados.txt"))
            {
                string line;
                while ((line = leer.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 11)
                    {
                        ClsEmpleado empleado = new ClsEmpleado
                        {
                            Codigo = campos[0],
                            nombre = campos[1],
                            apellido = campos[2],
                            dni = campos[3],
                            fnacimiento = campos[4],
                            sexo = campos[5],
                            telefono = campos[6],
                            Fingreso = campos[7],
                            Cargo = campos[8],
                            Horario = campos[9],
                            Sueldo = Convert.ToInt32(campos[10])
                        };
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }



    }


}