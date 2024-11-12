using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
                //MessageBox.Show("Solo se permiten numeros de hasta 8 dígitos") podría colocarse este mensaje pero termina siendo molesto;
                txtDni.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe completar los datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Validación del apto médico
            if (!chkAptoMedico.Checked)
            {
                MessageBox.Show("No se puede registrar como no socio hasta que presente el apto médico.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dni;
            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Utilidades.DniRegistradoEnOtroTipo(dni, esSocio: true))
            {
                MessageBox.Show("El DNI ya está registrado como no socio o socio.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Utilidades.DniRegistradoEnOtroTipo(dni, esSocio: false))
            {
                MessageBox.Show("El DNI ya está registrado como no socio.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            E_No_Socio noSoc = new E_No_Socio
            {
                NombreP = txtNombre.Text,
                ApellidoP = txtApellido.Text,
                DniP = dni//, AptoMedico = chkAptoMedico.Checked // Registrar el estado del apto médico
            };

            try
            {
                No_Socios noSocios = new No_Socios(noSoc);
                string respuesta = noSocios.Nuevo(); // Llama al procedimiento almacenado de la clase persona
                MessageBox.Show("Respuesta del procedimiento: " + respuesta);

                // Verifica si la respuesta es un número
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero && codigo == -1)
                {
                    // El no socio ya existe
                    MessageBox.Show("EL NO SOCIO YA ESTÁ REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);                                        
                }
                else
                {
                    try
                    {
                        Cobrar_por_actividad cobrarPorActividad = new Cobrar_por_actividad(principal)
                        {
                            NroNoSocio = codigo,
                            NombreApellido = $"{noSoc.NombreP} {noSoc.ApellidoP}",
                            Dni = dni.ToString()
                        };
                        cobrarPorActividad.ShowDialog();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al abrir Cobrar_por_actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //MessageBox.Show("EL NO SOCIO SE REGISTRÓ EXITOSAMENTE CON EL NÚMERO DE NO SOCIO: " + codigo, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            chkAptoMedico.Checked = false;
            txtNombre.Focus();
        }
    }
}
 