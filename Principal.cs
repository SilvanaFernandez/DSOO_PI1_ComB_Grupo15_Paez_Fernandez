using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        internal string rol;
        internal string usuario;

        private void Principal_Load(object sender, EventArgs e)
        {

            lblDatosDeSesion.Text = "USUARIO: " + usuario + " (" + rol + ")";
        }

        private void btnRegistroSocio_Click(object sender, EventArgs e)
        {
            Registro_socios registro = new Registro_socios(this);
            registro.Show();
            this.Hide();
        }

        private void btnRegistroNoSocios_Click(object sender, EventArgs e)
        {
            Registro_no_socios registroNS = new Registro_no_socios(this);
            registroNS.Show();
            this.Hide();
        }

        private void btnGestionCuotas_Click(object sender, EventArgs e)
        {
            Cobrar_cuota cobrar_Cuota = new Cobrar_cuota(this);
            cobrar_Cuota.Show();
            this.Hide();
        }

        private void btnCobrosAct_Click(object sender, EventArgs e)
        {
            Cobrar_por_actividad cobrar_Por_Actividad = new Cobrar_por_actividad(this);
            cobrar_Por_Actividad.Show();
            this.Hide();
        }

        private void btnReportesVtos_Click(object sender, EventArgs e)
        {
            GrillaVtos grillaVtos = new GrillaVtos(this);

            //verificamos si hay vencimientos antes de abrir la grilla
            if (grillaVtos.HayVencimientos())
            {
                grillaVtos.Show();
                this.Hide();             
            }
            else
            {
                MessageBox.Show("No hay vencimientos para hoy", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionActividadSocio_Click(object sender, EventArgs e)
        {
            Gestion_Actividades_Socio registrar_Actividad_Socio = new Gestion_Actividades_Socio(this);
            registrar_Actividad_Socio.Show();
            this.Hide();
        }
    }
}
 