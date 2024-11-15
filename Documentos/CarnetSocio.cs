using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class CarnetSocio : CarnetBase
    {
        public CarnetSocio()
        {
            InitializeComponent();
        }

        public string nroSoc { get; set; }

        
        private void Carnet_Load(object sender, EventArgs e)
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

                    // Obtener el NroSoc de txtNroSocio2
                    string nroSocioTexto = nroSoc;
                    if (!int.TryParse(nroSocioTexto, out int nroSocio))
                    {
                        MessageBox.Show("Número de socio no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "SELECT NombreP, ApellidoP, DocP FROM socio WHERE NroSoc = @NroSoc";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroSoc", nroSocio);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNro.Text = "SOCIO: " + nroSocioTexto;
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
 