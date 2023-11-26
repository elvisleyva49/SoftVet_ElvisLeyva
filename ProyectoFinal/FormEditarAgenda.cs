using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ProyectoFinal
{
    public partial class FormEditarAgenda : Form
    {
        StreamReader lectura;
        static StreamWriter escribir;
        bool existe;
        string Nombres, Apellidos, NomMascota, Telefono, Motivo, Hora, id;

        private ManejadorCitas manejadorCitas;
        public FormEditarAgenda()
        {
            InitializeComponent();
            manejadorCitas = new ManejadorCitas(".\\Ficheros\\citas.txt");
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            string idCitaBuscada = txtIdCita.Text.Trim();
            bool idCitaEncontrada = false;

            // Aquí leer el archivo y buscar si la ID existe
            using (StreamReader sr = new StreamReader(".\\Ficheros\\citas.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] campos = line.Split(';');
                    if (campos[0].Trim() == idCitaBuscada)
                    {
                        idCitaEncontrada = true;
                        break;
                    }
                }
            }

            if (idCitaEncontrada)
            {
                txtApellidos.Enabled = true;
                txtHora.Enabled = true;
                txtNombres.Enabled = true;
                txtNomMascota.Enabled = true;
                txtTelefono.Enabled = true;
                cmbMotivo.Enabled = true;
                txtIdCita.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error: No se ha encontrado el idCita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BloquearDatos()
        {
            txtApellidos.Enabled = false;
            txtHora.Enabled = false;
            txtNombres.Enabled = false;
            txtNomMascota.Enabled = false;
            txtTelefono.Enabled = false;
            cmbMotivo.Enabled = false;
            txtIdCita.Enabled = true;
            dateTimePicker1.Enabled = false;
        }

        public void LimpiarDatos()
        {
            txtIdCita.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtNomMascota.Text = "";
            txtTelefono.Text = "";
            txtHora.Text = "";
            cmbMotivo.SelectedIndex = -1;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            
            string fechaedit = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string nuevosDatos = $"{txtIdCita.Text};{txtNombres.Text};{txtApellidos.Text};{txtNomMascota.Text};{txtTelefono.Text};{cmbMotivo.SelectedItem};{fechaedit};{txtHora.Text}";

            // Leer el contenido actual del archivo
            List<string> lineas = new List<string>();
            using (StreamReader reader = new StreamReader(".\\Ficheros\\citas.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    lineas.Add(linea);
                }
            }

            // Buscar la línea correspondiente con el ID de cita y reemplazar con los nuevos datos
            for (int i = 0; i < lineas.Count; i++)
            {
                string[] campos = lineas[i].Split(';');
                if (campos[0].Trim() == txtIdCita.Text.Trim())
                {
                    lineas[i] = nuevosDatos;
                    break;
                }
            }

            // Escribir las líneas actualizadas de vuelta al archivo
            using (StreamWriter writer = new StreamWriter(".\\Ficheros\\citas.txt"))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
            }
            CargarTabla();
            LimpiarDatos();
            BloquearDatos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calendario.SetDate(dateTimePicker1.Value.Date);
        }

        int contador;
        public void CargarTabla()
        {
            dgvTabla.Rows.Clear();
            List<Cita> citas = manejadorCitas.LeerCitas();

            foreach (Cita cita in citas)
            {
                dgvTabla.Rows.Add(cita.Id, cita.Nombres, cita.Apellidos, cita.NomMascota, cita.Telefono, cita.Motivo, cita.Fecha, cita.Hora);
            }
        }
        private void FormEditarAgenda_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
