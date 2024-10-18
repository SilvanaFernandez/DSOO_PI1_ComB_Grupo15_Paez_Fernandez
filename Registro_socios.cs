using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe completar los datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Socio soc = new E_Socio();
                soc.NombreS = txtNombre.Text;
                soc.ApellidoS = txtApellido.Text;
                soc.DniS = Convert.ToInt32(txtDni.Text);
                Datos.Socios socios = new Datos.Socios();//instanciamos para trabajar dentro de la clase Socios
                respuesta = socios.Nuevo_Soc(soc); //en la var NroSocio se guarda el return del procedure Nuevo_Soc que se encuentra en la clase socios
                bool esnumero = int.TryParse(respuesta, out int codigo);//el método int.TryParse convierte una cadena en entero, en este caso lo hará con NroSocio, si la conversión es exitosa el valor se guarda en codigo y true en esnumero, de lo contrario se guarda false en esnumero
                if (esnumero)
                {
                    if (codigo == 1) //el socio ya existe porque hay una línea en la consulta 
                    {
                        MessageBox.Show("EL SOCIO YA ESTÁ REGISTRADO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("EL SOCIO SE REGISTRÓ EXITOSAMENTE CON EL NÚMERO DE  SOCIO:  " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
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
