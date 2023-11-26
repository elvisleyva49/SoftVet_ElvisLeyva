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
using ProyectoFinal.Clases;

namespace ProyectoFinal
{
    public partial class FormProgramarCita : Form
    {
        //StreamReader lectura;
        //static StreamWriter escribir;
        bool existe;
        string Nombres, Apellidos, NomMascota, Telefono, Motivo, Hora, id, timeh;
        int contador;
        Cita objCita = new Cita();
        private ManejadorCitas manejadorCitas;
        public FormProgramarCita()
        {
            InitializeComponent();
            manejadorCitas = new ManejadorCitas(".\\Ficheros\\citas.txt");
        }

        public void CargarTabla()
        {
            dgvTabla.Rows.Clear();
            List<Cita> citas = manejadorCitas.LeerCitas();

            foreach (Cita cita in citas)
            {
                dgvTabla.Rows.Add(cita.Id, cita.Nombres, cita.Apellidos, cita.NomMascota, cita.Telefono, cita.Motivo, cita.Fecha, cita.Hora);
            }
        }

        public void LimpiarDatos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtNomMascota.Text = "";
            txtTelefono.Text = "";
            txtHora.Text = "";
            cmbMotivo.SelectedIndex = -1;
        }

        private void FormProgramarCita_Load(object sender, EventArgs e)
        {
            var fechaactual = DateTime.Now;
            dateTimePicker1.MinDate = fechaactual;
            calendario.MinDate = fechaactual;
            CargarTabla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calendario.SetDate(dateTimePicker1.Value.Date);
        }

        private void btnSeleccionarFecha_Click(object sender, EventArgs e)
        {
            existe = false;
            contador = 1;
            Nombres = txtNombres.Text;
            Apellidos = txtApellidos.Text;
            NomMascota = txtNomMascota.Text;
            Telefono = txtTelefono.Text;
            if (cmbMotivo.SelectedItem == null)
            {
                Motivo = "Vacunacion";
            }
            else
            {
                Motivo = cmbMotivo.SelectedItem.ToString();
            }
            
            Hora = txtHora.Text;
            timeh = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            objCita.AgregarCitas(existe, contador, Nombres, Apellidos, NomMascota, Telefono, Motivo, Hora, timeh);
            CargarTabla();
            LimpiarDatos();
        }
    }
}
