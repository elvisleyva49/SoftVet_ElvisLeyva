using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoFinal
{
    public partial class FormHistorialVacunacion : Form
    {
        ClsHistorialVacunacion objVacunas = new ClsHistorialVacunacion();
        string nomvacuna, ndosis, fecha, codMascota;
        string fechaRegistro;
        ClsPaciente objPaciente = new ClsPaciente();
        string nomemp;
        string idmascota;
        string nompac;

        string especie, raza, sexo;

        private void btnAgregarVacuna_Click_1(object sender, EventArgs e)
        {
            string codmascota;
            codmascota = txtCodMascotaBuscar.Text;

            nomvacuna = txtRegistrarVacuna.Text;
            ndosis = txtRegistrarNroDosis.Text;
            fechaRegistro = datePickPaciente.Value.Date.ToString("dd-MM-yyyy");


            objVacunas.AgregarVacuna(nomvacuna, ndosis, fechaRegistro, codmascota);

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            CargarFicheroEmp(txtCodMascotaBuscar.Text);
        }


        public FormHistorialVacunacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnAgregarVacuna.Enabled = false;
            // Obtén el DNI ingresado por el usuario
            idmascota = txtCodMascotaBuscar.Text;

            // Verifica si el DNI está registrado en ClsClientes
            objPaciente.IDPacienteRegistrado(idmascota);
            if (objPaciente.encontrado == true)
            {
                txtNombreMostrar.Text = objPaciente.nombre;
                CargarFicheroEmp(codMascota);
                btnAgregarVacuna.Enabled = true;
                
            }
            else
            {
                // El DNI no está registrado, muestra un mensaje de error

                MessageBox.Show("El Codigo del Paciente ingresado no existe .");
                btnAgregarVacuna.Enabled = false;
            }


        }
        public void CargarFicheroEmp(string codigoMascota)
        {
            dgvResultados.Rows.Clear();
            List<ClsHistorialVacunacion> vacunas = objVacunas.LeerVacunasPorCodigoMascota(codigoMascota);

            foreach (ClsHistorialVacunacion vacuna in vacunas)
            {
                dgvResultados.Rows.Add(vacuna.nombrevacuna, vacuna.nro_dosis, vacuna.fecha, vacuna.codigo);
            }
        }
    }
}
