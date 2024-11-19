using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos
{
    public partial class CarnetNoSocio : CarnetBase
    {
        private Principal principal;
        public CarnetNoSocio(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        public string nroNoSoc { get; set; }


        private void CarnetNoSocio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected override void CargarDatos()
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    // Obtener el NroNoSoc de txtNroSocio
                    string nroNoSocioTexto = nroNoSoc;
                    if (!int.TryParse(nroNoSocioTexto, out int nroNoSocio))
                    {
                        MessageBox.Show("Número de no socio no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "SELECT NombreP, ApellidoP, DocP FROM noSocio WHERE NroNoSoc = @NroNoSoc";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroNoSoc", nroNoSocio);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNro.Text = "NO SOCIO: " + nroNoSocioTexto;
                                txtNombre.Text = reader["NombreP"].ToString();
                                txtApellido.Text = reader["ApellidoP"].ToString();
                                txtDni.Text = reader["DocP"].ToString();
                                txtFecha.Text = DateTime.UtcNow.ToShortDateString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos para el número de socio proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();

                    }
                }
            }
        }
    }
}
 