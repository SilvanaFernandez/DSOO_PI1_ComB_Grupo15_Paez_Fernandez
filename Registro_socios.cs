using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Entidades;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class Registro_socios : Form
    {
        public Registro_socios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dniTexto = txtDni.Text;

            string patron = @"^\d{1,8}$";
            if (!Regex.IsMatch(dniTexto, patron))
            {
                //MessageBox.Show("Solo se permiten numeros de hasta 8 dígitos");
                txtDni.Clear();
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe completar los datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                int dni;
                if (!int.TryParse(txtDni.Text, out dni))
                {
                    MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                E_Socio soc = new E_Socio
                {
                    NombreP = txtNombre.Text,
                    ApellidoP = txtApellido.Text,
                    DniP = dni
                };

                try
                {
                    Socios socios = new Socios();
                    string respuesta = socios.Nuevo_Soc(soc); // Llama al procedimiento almacenado
                    MessageBox.Show("Respuesta del procedimiento: " + respuesta);

                    // Verifica si la respuesta es un número
                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        if (codigo == -1) // El socio ya existe
                        {
                            MessageBox.Show("EL SOCIO YA ESTÁ REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("EL SOCIO SE REGISTRÓ EXITOSAMENTE CON EL NÚMERO DE SOCIO: " + codigo, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                       // MessageBox.Show("Error: la respuesta no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Focus();
        }
    }
}