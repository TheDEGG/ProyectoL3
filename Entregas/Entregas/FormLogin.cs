using BL.Entregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregas
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = Usuario.Text;
            contrasena = Contrasena.Text;

            var resultado = _seguridad.Acceso(usuario, contrasena);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "USUARIO")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.LightGray;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "USUARIO";
                Usuario.ForeColor = Color.Silver;
            }
        }

        private void Contrasena_Enter(object sender, EventArgs e)
        {
            if (Contrasena.Text == "CONTRASEÑA")
            {
                Contrasena.Text = "";
                Contrasena.ForeColor = Color.LightGray;
                Contrasena.UseSystemPasswordChar = true;
            }
        }

        private void Contrasena_Leave(object sender, EventArgs e)
        {
            if (Contrasena.Text == "")
            {
                Contrasena.Text = "CONTRASEÑA";
                Contrasena.ForeColor = Color.Silver;
                Contrasena.UseSystemPasswordChar = false;
            }
        }
    }
}
