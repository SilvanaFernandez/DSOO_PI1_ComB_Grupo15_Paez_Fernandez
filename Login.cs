using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            dtLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if(dtLogin.Rows.Count>0)
            {
                MessageBox.Show("Ingreso exitoso del usuario: " + txtUsuario.Text, "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Principal principal = new Principal();

                principal.rol = Convert.ToString(dtLogin.Rows[0][0]);
                principal.usuario = Convert.ToString(txtUsuario.Text);

                principal.Show();

                this.Hide();

                principal.FormClosed += (sender, e) => this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
