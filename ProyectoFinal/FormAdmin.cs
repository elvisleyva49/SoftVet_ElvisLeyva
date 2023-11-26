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
    public partial class FormAdmin : Form
    {
        StreamReader lectura;
        static StreamWriter escribir;
        bool existe;
        string usuario, password;
        string codunico;
        string texto;
        String[] campo = new string[1];
        
        
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            GenerarCaptch();
        }
        public void GenerarCaptch()
        {
            Random rnd = new Random();
            string[] codigo = { "4Thz2", "D5E6f7", "890Xyz", "120Xyz", "G2H9j8" };
            int indiceAleatorio=rnd.Next(0, codigo.Length);
            string captchaAleatorio = codigo[indiceAleatorio];
            txtcaptcha.Text= captchaAleatorio;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            existe = false;
            usuario = txtRegUsuario.Text;
            password = txtRegPassword.Text;
            codunico = txtCodUnico.Text;
            string captcha = txtcaptcha.Text;
            try
            {
                if (captcha.Equals(codunico) && codunico != "")
                {
                    if (usuario != "" && password != "")
                    {
                        lectura = File.OpenText("Ficheros\\usuarios.txt");
                        texto = lectura.ReadLine();
                        while (texto != null && existe == false)
                        {
                            campo = texto.Split(';');
                            if (campo[0].Trim().Equals(usuario))
                            {
                                existe = true;
                                break;
                            }
                            texto = lectura.ReadLine();
                        }
                        lectura.Close();
                        escribir = File.AppendText("Ficheros\\usuarios.txt");

                        if (existe == false)
                        {
                            existe = false;
                            usuario = txtRegUsuario.Text;
                            password = txtRegPassword.Text;
                            escribir.WriteLine(usuario + ";" + password);
                            MessageBox.Show("El usuario se ha registrado correctamente...", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodUnico.Text = "";
                            txtRegPassword.Text = "";
                            txtRegUsuario.Text = "";
                            GenerarCaptch();
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya existe...", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        escribir.Close();
                    }
                    else
                    {
                        MessageBox.Show("Faltan Completar datos... ", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (codunico == "")
                {
                    MessageBox.Show("Ingrese el Codigo Captcha...", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("El codigo Captcha de administrador es incorrecto...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
