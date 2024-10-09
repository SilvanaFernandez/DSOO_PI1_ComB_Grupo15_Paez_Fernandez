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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registroSocioBTN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Registro_socios registroSocios = new Registro_socios();
            registroSocios.Show();
            registroSocios.FormClosed += (sender, e) => this.Close();this.Hide();
        }

        private void gestionCuotasBTN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Cobrar_cuota gestionCobros = new Cobrar_cuota();
            gestionCobros.Show();
            gestionCobros.FormClosed += (sender, e) => this.Close();

        }

        private void registroNoSociosBTN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Registro_no_socios registroNoSocios = new Registro_no_socios();
            registroNoSocios.Show();
            registroNoSocios.FormClosed += (sender, e) => this.Close();
        }

        private void gestionCobrosBTN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Cobrar_por_actividad gestionCobrosPorDia = new Cobrar_por_actividad();
            gestionCobrosPorDia.Show();
            gestionCobrosPorDia.FormClosed += (sender, e) => this.Close();
        }


        
        private void reportesVtosBTN_Click(object sender, EventArgs e)
        {
            //this.Hide();
            /*
            Cobrar_cuota gestionCobros = new Cobrar_cuota();
            gestionCobros.Show();
            gestionCobros.FormClosed += (sender, e) => this.Close();
            */
        }
    }
}
