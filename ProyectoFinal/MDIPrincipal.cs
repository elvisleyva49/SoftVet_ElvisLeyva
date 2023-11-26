using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
namespace ProyectoFinal
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void toolStripLabel3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void registroDePagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRegistrodePagos RegistroDPagos = new FormRegistrodePagos();
            RegistroDPagos.MdiParent = this;
            RegistroDPagos.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RegistroDPagos)
                {
                    formHijo.Close();
                }
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void programarNuevasCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProgramarCita ProgramarCita = new FormProgramarCita();
            ProgramarCita.MdiParent = this;
            ProgramarCita.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != ProgramarCita)
                {
                    formHijo.Close();
                }
            }
        }

        private void citasProgramadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCitasProgramadas citasProgramadas = new FormCitasProgramadas();
            citasProgramadas.MdiParent = this;
            citasProgramadas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != citasProgramadas)
                {
                    formHijo.Close();
                }
            }
        }

        private void programarNuevasCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProgramarCita ProgramarCita = new FormProgramarCita();
            ProgramarCita.MdiParent = this;
            ProgramarCita.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != ProgramarCita)
                {
                    formHijo.Close();
                }
            }
        }

        private void cambiosEnLaAgendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEditarAgenda EditarAgenda = new FormEditarAgenda();
            EditarAgenda.MdiParent = this;
            EditarAgenda.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != EditarAgenda)
                {
                    formHijo.Close();
                }
            }
        }

        private void citasProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCitasProgramadas citasProgramadas = new FormCitasProgramadas();
            citasProgramadas.MdiParent = this;
            citasProgramadas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != citasProgramadas)
                {
                    formHijo.Close();
                }
            }
        }

        private void cambiosEnLaAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarAgenda EditarAgenda = new FormEditarAgenda();
            EditarAgenda.MdiParent = this;
            EditarAgenda.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != EditarAgenda)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeEmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroEmpleado registraremp = new RegistroEmpleado();
            registraremp.MdiParent = this;
            registraremp.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registraremp)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleado registraremp = new RegistroEmpleado();
            registraremp.MdiParent = this;
            registraremp.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registraremp)
                {
                    formHijo.Close();
                }
            }
        }

        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarcliente = new RegistrarCliente();
            registrarcliente.MdiParent = this;
            registrarcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registrarcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarcliente = new RegistrarCliente();
            registrarcliente.MdiParent = this;
            registrarcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registrarcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeIngresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReportedeIngresos reporteIngreso = new FormReportedeIngresos();
            reporteIngreso.MdiParent = this;
            reporteIngreso.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != reporteIngreso)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportedeIngresos reporteIngreso = new FormReportedeIngresos();
            reporteIngreso.MdiParent = this;
            reporteIngreso.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != reporteIngreso)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeGastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReporteGastos reporteGastos = new FormReporteGastos();
            reporteGastos.MdiParent = this;
            reporteGastos.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != reporteGastos)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteGastos reporteGastos = new FormReporteGastos();
            reporteGastos.MdiParent = this;
            reporteGastos.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != reporteGastos)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDePacientesAtendidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReportePacientesAtendidos RpacientesAtendidos = new FormReportePacientesAtendidos();
            RpacientesAtendidos.MdiParent = this;
            RpacientesAtendidos.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RpacientesAtendidos)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDePacientesAtendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportePacientesAtendidos RpacientesAtendidos = new FormReportePacientesAtendidos();
            RpacientesAtendidos.MdiParent = this;
            RpacientesAtendidos.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RpacientesAtendidos)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeHorarioDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteHorarioPersonal RPersonal = new FormReporteHorarioPersonal();
            RPersonal.MdiParent = this;
            RPersonal.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RPersonal)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeHorariosDelPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteHorarioPersonal RPersonal = new FormReporteHorarioPersonal();
            RPersonal.MdiParent = this;
            RPersonal.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RPersonal)
                {
                    formHijo.Close();
                }
            }
        }

        private void actualizarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarRegistroEmpleado ActualizarPersonal = new ActualizarRegistroEmpleado();
            ActualizarPersonal.MdiParent = this;
            ActualizarPersonal.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != ActualizarPersonal)
                {
                    formHijo.Close();
                }
            }
        }

        private void actualizarRegistroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarRegistroEmpleado ActualizarPersonal = new ActualizarRegistroEmpleado();
            ActualizarPersonal.MdiParent = this;
            ActualizarPersonal.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != ActualizarPersonal)
                {
                    formHijo.Close();
                }
            }
        }

        private void accesoAHistoriasClinicasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHistorialVacunacion Historiales = new FormHistorialVacunacion();
            Historiales.MdiParent = this;
            Historiales.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Historiales)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPaciente RegistroPacientes = new RegistrarPaciente();
            RegistroPacientes.MdiParent = this;
            RegistroPacientes.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RegistroPacientes)
                {
                    formHijo.Close();
                }
            }
        }

        private void accesoAHistoriasClinicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialVacunacion Historiales = new FormHistorialVacunacion();
            Historiales.MdiParent = this;
            Historiales.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Historiales)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPaciente RegistroPacientes = new RegistrarPaciente();
            RegistroPacientes.MdiParent = this;
            RegistroPacientes.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RegistroPacientes)
                {
                    formHijo.Close();
                }
            }
        }

        private void facturacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFacturacion FormularioFacturacion = new FormFacturacion();
            FormularioFacturacion.MdiParent = this;
            FormularioFacturacion.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != FormularioFacturacion)
                {
                    formHijo.Close();
                }
            }
        }

        

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturacion FormularioFacturacion = new FormFacturacion();
            FormularioFacturacion.MdiParent = this;
            FormularioFacturacion.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != FormularioFacturacion)
                {
                    formHijo.Close();
                }
            }
        }

        private void horariosDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario,clave;

            usuario= Interaction.InputBox("Ingrese usuario", "Usuario");
            clave= Interaction.InputBox("Ingrese clave", "Clave");
            if (usuario.Equals("admin")&&clave.Equals("admin"))
            {
                FormAdmin admin= new FormAdmin();
                this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Clave Incorrectos", "Error de Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
