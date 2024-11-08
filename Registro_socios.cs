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
        private Principal principal;
        public Registro_socios(Principal principal)
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
                    DniP = dni,
                    AptoMedico = chkAptoMedico.Checked
                };

                
                try
                {
                    Socios socios = new Socios(soc);
                    string respuesta = socios.Nuevo(); // Llama al procedimiento almacenado

                    // Verifica si la respuesta es un número
                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        if(codigo == -2)
                        {
                            MessageBox.Show("No se puede registrar como socio, el apto médico no está aprobado.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if(codigo == -1) // El socio ya existe
                        {
                            MessageBox.Show("EL SOCIO YA ESTÁ REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {                            
                            MessageBox.Show("EL SOCIO SE REGISTRÓ EXITOSAMENTE CON EL NÚMERO DE SOCIO: " + codigo, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Gestion_Actividades_Socio gestionActividadesSocio = new Gestion_Actividades_Socio(principal)
                            {
                                NroSocio = codigo,
                                NombreApellido = $"{soc.NombreP} {soc.ApellidoP}", 
                                Dni=dni.ToString()
                            };
                            gestionActividadesSocio.ShowDialog();
                            this.Hide();
                            // Abrir el formulario Cobrar_cuota y pasar los datos
                            /*Cobrar_cuota cobrarCuota = new Cobrar_cuota(principal)
                            {
                                NroSocio = codigo,
                                NombreApellido = $"{soc.NombreP} {soc.ApellidoP}",
                                Dni = dni.ToString()
                            };
                            cobrarCuota.ShowDialog();
                            this.Hide();*/
                            // Asignar el número de socio al campo txtNroSocio2 del formulario Cobrar_cuota
                            //cobrarCuota.Controls["txtNroSocio2"].Text = codigo.ToString();
                            gestionActividadesSocio.Controls["txtNroSocio"].Text = codigo.ToString();
                        }
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
            chkAptoMedico.Checked = false;
            txtNombre.Focus();
        }
    }
}
 