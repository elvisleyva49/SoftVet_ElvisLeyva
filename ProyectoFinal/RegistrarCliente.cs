using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoFinal
{
    public partial class RegistrarCliente : Form
    {
        ClsCliente objCliente = new ClsCliente();
        string /*codigo,*/ nomcli, apecli, dnicli, telf, genero;

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            nomcli = txtNombre.Text;
            apecli = txtApellido.Text;
            dnicli = txtDocumento.Text;
            telf = txtTelefono.Text;
            if (cmbGenero.SelectedIndex == 0)
            {
                genero = "Masculino";
            }
            else if (cmbGenero.SelectedIndex == 1)
            {
                genero = "Femenino";
            }
            else
            {
                genero = "-----";
            }


            objCliente.AgregarCliente(nomcli, apecli, dnicli, telf, genero);
            if (objCliente.agregado == true)
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cmbGenero.SelectedIndex = -1;
        }


        public RegistrarCliente()
        {
            InitializeComponent();
        }

    }
}
