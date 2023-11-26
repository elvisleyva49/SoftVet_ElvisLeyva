using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsPaciente
    {
        public string Codigo { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public string sexo { get; set; }
        public string fecha { get; set; }


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
        public bool encontrado { get; set; }


        private string filePath = ".\\Ficheros\\pacientes.txt";

        //Metodos
        public void AgregarPaciente(string nompac, string especie, string raza,
                                   string sexo, string fecha, string codcliente)
        {

            agregado = false;
            try
            {
                if (nompac != "" && especie != "" && raza != "" && sexo != "" &&
                    fecha != "" && codcliente != "")
                {
                    lectura = File.OpenText(".\\Ficheros\\pacientes.txt");
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
                    escribir = File.AppendText(".\\Ficheros\\pacientes.txt");
                    if (existe == false)
                    {
                        existe = false;
                        id = "P" + contador;
                        escribir.WriteLine(id + ";" + nompac + ";" + especie + ";" + raza +
                                            ";" + sexo + ";" + fecha + ";" + codcliente);
                        MessageBox.Show("El paciente se ha registrado correctamente...", "Registro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        agregado = true;
                    }
                    else
                    {
                        MessageBox.Show("¡El paciente ya existe!", "Registro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        agregado = true;
                    }
                    escribir.Close();
                }
                else
                {
                    MessageBox.Show("Faltan Completar datos... ", "Registro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void IDPacienteRegistrado(string Codigo)
        {
            // Lee el archivo que contiene la información de los clientes
            List<string> lines = new List<string>();

            encontrado = false;
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Trim().Equals(Codigo))
                    {
                        this.Codigo = parts[0];
                        this.nombre = parts[1];

                        // Se encontró un cliente con el DNI especificado
                        encontrado = true;
                    }

                }
            }
            else
            {
                // El archivo de clientes no existe, debes manejar esta situación adecuadamente
                MessageBox.Show("El archivo no se encontro");
            }

        }

        public List<ClsPaciente> LeerPacientes()
        {
            List<ClsPaciente> pacientes = new List<ClsPaciente>();
            using (StreamReader leer = new StreamReader(".\\Ficheros\\pacientes.txt"))
            {
                string line;
                while ((line = leer.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 6)
                    {
                        ClsPaciente paciente = new ClsPaciente
                        {
                            Codigo = campos[0],
                            nombre = campos[1],
                            especie = campos[2],
                            raza = campos[3],
                            sexo = campos[4],
                            fecha = campos[5],
                        };
                        pacientes.Add(paciente);
                    }
                }
            }
            return pacientes;


        }
    }
}
