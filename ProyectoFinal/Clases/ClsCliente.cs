using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsCliente
    {
        public string Codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ddni { get; set; }
        public string telefono { get; set; }
        public string sexo { get; set; }

        public bool encontrado { get; set; }
        public bool agregado { get; set; }

        // Ruta del archivo que contiene la información de los clientes
        private string filePath = ".\\Ficheros\\clientes.txt";

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
        public void AgregarCliente(string nomcli, string apecli, string dnicli,
                                   string telf, string genero)
        {

            agregado = false;
            try
            {
                if (nomcli != "" && apecli != "" && dnicli != "" && telf != "" &&
                    genero != "")
                {
                    lectura = File.OpenText(".\\Ficheros\\clientes.txt");
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
                    escribir = File.AppendText(".\\Ficheros\\clientes.txt");
                    if (existe == false)
                    {
                        existe = false;
                        id = "C" + contador;
                        escribir.WriteLine(id + ";" + nomcli + ";" + apecli + ";" + dnicli + ";" + telf +
                                            ";" + genero);
                        MessageBox.Show("El cliente se ha registrado correctamente...", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        agregado = true;
                    }
                    else
                    {
                        MessageBox.Show("¡El cliente ya existe!", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        agregado = true;
                    }
                    escribir.Close();
                }
                else
                {
                    MessageBox.Show("Faltan Completar datos... ", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DNIClienteRegistrado(string dni)
        {
            // Lee el archivo que contiene la información de los clientes
            List<string> lines = new List<string>();


            if (File.Exists(filePath))
            {
                encontrado = false;
                lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    //MessageBox.Show(parts[3]);
                    if (parts[3].Trim().Equals(dni))
                    {
                        this.Codigo = parts[0];
                        this.nombre = parts[1];
                        this.ddni = parts[3];
                        this.telefono = parts[4];

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

        public List<ClsCliente> LeerClientes()
        {
            List<ClsCliente> clientes = new List<ClsCliente>();
            using (StreamReader leer = new StreamReader(".\\Ficheros\\clientes.txt"))
            {
                string line;
                while ((line = leer.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos.Length == 6)
                    {
                        ClsCliente empleado = new ClsCliente
                        {
                            Codigo = campos[0],
                            nombre = campos[1],
                            apellido = campos[2],
                            ddni = campos[3],
                            telefono = campos[4],
                            sexo = campos[5],
                        };
                        clientes.Add(empleado);
                    }
                }
            }
            return clientes;


        }



    }


}
