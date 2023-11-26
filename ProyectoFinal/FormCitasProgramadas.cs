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

namespace ProyectoFinal
{
    public partial class FormCitasProgramadas : Form
    {
        //StreamReader lectura;
        //bool existe;
        //string Nombres, Apellidos, NomMascota, Telefono, Motivo, Hora, id, fecha;

        private ManejadorCitas manejadorCitas;
        public FormCitasProgramadas()
        {
            InitializeComponent();
            manejadorCitas = new ManejadorCitas(".\\Ficheros\\citas.txt");
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calendario.SetDate(dateTimePicker1.Value.Date);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            string fechaSeleccionada = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            List<Cita> citas = manejadorCitas.LeerCitas();

            foreach (Cita cita in citas)
            {
                if (cita.Fecha.Equals(fechaSeleccionada))
                {
                    dgvTabla.Rows.Add(cita.Id, cita.Nombres, cita.Apellidos, cita.NomMascota, cita.Telefono, cita.Motivo, cita.Fecha, cita.Hora);
                }
            }
        }

        int contador;
        string texto;
        String[] campo = new string[7];

        private void FormCitasProgramadas_Load(object sender, EventArgs e)
        {
            var fechaactual = DateTime.Now;
            dateTimePicker1.MinDate = fechaactual;
            calendario.MinDate = fechaactual;
            CargarTabla();
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
    }
}
