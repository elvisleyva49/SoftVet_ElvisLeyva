using Microsoft.VisualBasic;
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

//awdawdawd hola

namespace ProyectoFinal
{
    public partial class FormLogin : Form
    {
        StreamReader lectura;

        bool existe;
        string busqueda, usuario, contraseña,texto, cadena;

        private void label9_Click(object sender, EventArgs e)
        {
            string usuario, clave;

            usuario = Interaction.InputBox("Ingrese usuario", "Usuario");
            clave = Interaction.InputBox("Ingrese clave", "Clave");
            if (usuario.Equals("admin") && clave.Equals("admin"))
            {
                FormAdmin admin = new FormAdmin();
                this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Clave Incorrectos", "Error de Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            existe = false;
            usuario = txtUsuario.Text;
            contraseña = txtPassword.Text;
            String[] campo = new string[1];
            try
            {
                lectura = File.OpenText("Ficheros\\usuarios.txt");
                cadena = lectura.ReadLine();
                while(cadena != null && existe == false)
                {
                    campo = cadena.Split(';');
                    if (campo[0].Trim().Equals(usuario) && campo[1].Trim().Equals(contraseña))
                    {
                        existe = true;
                    }
                    else
                    {
                        cadena = lectura.ReadLine();
                    }
                }
                if (existe == true)
                {
                    MessageBox.Show("Bienvenido...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MDIPrincipal principal = new MDIPrincipal();
                    this.Hide();
                    principal.Show();
                }
                
                else
                {
                    MessageBox.Show("El usuario y/o contraseña no son correctos...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lectura.Close();
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
            
            
            //string usuario, password;
            //if (txtUsuario.Text == "usuario" && txtPassword.Text == "12345")
            //{

            //}
            //else
            //{
            //    MessageBox.Show("El usuario y/o contraseña es incorrecto.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
    }
}
