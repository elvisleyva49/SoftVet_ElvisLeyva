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
    public partial class RegistrarPaciente : Form
    {
        ClsPaciente objPaciente = new ClsPaciente();
        string nompac, especie, raza, sexo;

        ClsCliente objCliente = new ClsCliente();
        string codigo, nomcli, dni, id;

       


        private void btnAgregarProp_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();
            this.Hide();
            registrarCliente.Show();
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecie.SelectedIndex == 0)
            {
                pictpaciente.Image = ProyectoFinal.Properties.Resources.perro;
            }else if(cmbEspecie.SelectedIndex == 1)
            {
                pictpaciente.Image = ProyectoFinal.Properties.Resources.gato;
            }
            else
            {
                pictpaciente.Image = ProyectoFinal.Properties.Resources.registrarmascota;
            }
        }

        private void RegistrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtén el DNI ingresado por el usuario
            dni = txtDocumentoBuscar.Text;

            // Verifica si el DNI está registrado en ClsClientes
            objCliente.DNIClienteRegistrado(dni);
            if (objCliente.encontrado == true)
            {
                txtCodCliente.Text = objCliente.Codigo;
                txtDocumentoCliente.Text = objCliente.ddni;
                txtNombreCliente.Text = objCliente.nombre;
                txtTelefonoCliente.Text = objCliente.telefono;
            }
            else
            {
                // El DNI no está registrado, muestra un mensaje de error
                MessageBox.Show("El DNI ingresado no está .");

            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LIMPIARPANTALLA();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string codcliente;
            codcliente = txtCodCliente.Text;

            nompac = txtNombreMascota.Text;
            if (cmbEspecie.SelectedItem == null)
            {
                cmbEspecie.SelectedIndex = -1;
            }
            else
            {
                especie = cmbEspecie.SelectedItem.ToString();
            }
            raza = txtRaza.Text;
            fecha = fecha = datePickPaciente.Value;
            if (cmbGenero.SelectedIndex == 0)
            {
                sexo = "Macho";
            }
            else if (cmbGenero.SelectedIndex == 1)
            {
                sexo = "Hembra";
            }
            else
            {
                sexo = "-----";
            }


            objPaciente.AgregarPaciente(nompac, especie, raza, sexo, fecha.ToString("dd/MM/yyyy"), codcliente);

        }

      

        public void LIMPIARPANTALLA()
        {
            txtCodCliente.Text = "";
            txtCodDueño.Text = "";
            txtDNI.Text = "";
            txtDocumentoBuscar.Text = "";
            txtDocumentoDueño.Text = "";
            txtNombreCliente.Text = "";
            txtNombreDueño.Text = "";
            txtRaza.Text = "";
            cmbEspecie.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            txtTelefonoDueño.Text = "";
            txtDocumentoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtNombreMascota.Text = "";
        }


        DateTime fecha;
        public RegistrarPaciente()
        {
            InitializeComponent();
        }


    }
}

