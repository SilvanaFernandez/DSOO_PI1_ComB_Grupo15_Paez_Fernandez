using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class Registro_no_socios : Form
    {
        private Principal principal;
        public Registro_no_socios(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
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

                E_No_Socio noSoc = new E_No_Socio
                {
                    NombreP = txtNombre.Text,
                    ApellidoP = txtApellido.Text,
                    DniP = dni
                };

                try
                {
                    No_Socios noSocios = new No_Socios();
                    string respuesta = noSocios.Nuevo_NoSoc(noSoc); // Llama al procedimiento almacenado
                    MessageBox.Show("Respuesta del procedimiento: " + respuesta);

                    // Verifica si la respuesta es un número
                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        if (codigo == -1) // El no socio ya existe
                        {
                            MessageBox.Show("EL NO SOCIO YA ESTÁ REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("EL NO SOCIO SE REGISTRÓ EXITOSAMENTE CON EL NÚMERO DE NO SOCIO: " + codigo, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Focus();
        }
    }
}