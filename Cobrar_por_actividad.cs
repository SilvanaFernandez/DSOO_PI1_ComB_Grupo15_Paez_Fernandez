using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
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
    public partial class Cobrar_por_actividad : Form
    {
        public Cobrar_por_actividad()
        {
            InitializeComponent();
        }

        private void Cobrar_por_actividad_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void btnRegEmitirRecibo_Click(object sender, EventArgs e)
        {
         
        }
    }
}
