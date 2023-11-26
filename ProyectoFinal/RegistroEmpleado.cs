using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Clases;

namespace ProyectoFinal
{
    public partial class RegistroEmpleado : Form
    {
        ClsEmpleado objEmpleado = new ClsEmpleado();
        string  nomemp, apeemp, dniemp, Fechnac, genero, telf, Fechini, cargo, horario;

        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        public void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            CargarFicheroEmp();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();

        }
        public void Limpieza()
        {
            cmbGenero.SelectedIndex = -1;
            cmbHorario.SelectedIndex = -1;
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtSueldo.Text = string.Empty;
        }
        int sueldo;
        public void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                nomemp = txtNombre.Text;
                apeemp = txtApellido.Text;
                dniemp = txtDni.Text;
                Fechnac = dtpFechaNacimiento.Value.Date.ToString("dd-MM-yyyy");
                Sexo();
                telf = txtTelefono.Text;
                Fechini = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
                cargo = txtCargo.Text;
                Horario();
                /* if (txtSueldo.Text != "" && txtSueldo.Text.All(char.IsDigit))
                 {*/
                sueldo = Convert.ToInt32(txtSueldo.Text);
                /*}*/
                /*else
                {
                    MessageBox.Show("Ingrese un Sueldo Correcto ", "Error");
                }*/

                objEmpleado.AgregarEmpleado(nomemp, apeemp, dniemp, Fechnac, genero, telf, Fechini, cargo, horario, sueldo);
                if (objEmpleado.agregado == true)
                {
                    Limpieza();
                    CargarFicheroEmp();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese Datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Sexo()
        {
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
        }
        private void Horario()
        {
            if (cmbHorario.SelectedIndex == 0)
            {
                horario = "08:00 am - 05:00 pm";
            }
            else if (cmbHorario.SelectedIndex == 1)
            {
                horario = "08:00 am - 12:00 pm";
            }
            else if (cmbHorario.SelectedIndex == 2)
            {
                horario = "12:00 pm - 05:00 pm";
            }
            else
            {
                horario = "--:-- --:--";
            }
        }

        public void CargarFicheroEmp()
        {
            dgvEmpleados.Rows.Clear();
            List<ClsEmpleado> empleados = objEmpleado.LeerEmpleados();

            foreach (ClsEmpleado empleado in empleados)
            {
                dgvEmpleados.Rows.Add(empleado.Codigo, empleado.nombre,
                    empleado.apellido, empleado.dni, empleado.fnacimiento,
                    empleado.sexo, empleado.telefono, empleado.Fingreso,
                    empleado.Cargo, empleado.Sueldo, empleado.Horario);
            }
        }
    }
}
