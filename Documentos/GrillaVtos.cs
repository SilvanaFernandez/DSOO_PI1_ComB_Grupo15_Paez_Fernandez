using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Printing;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos
{
    public partial class GrillaVtos : Form
    {
        private Principal principal;
        public GrillaVtos(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void GrillaVtos_Load(object sender, EventArgs e)
        {
            CargarGrillaVtos();
        }

        private void CargarGrillaVtos()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = @" SELECT s.NroSoc, s.NombreP, s.ApellidoP, s.DocP, p.ProxVto FROM socio s JOIN pagosCta p ON s.NroSoc = p.NroSoc WHERE DATE(p.ProxVto) = CURDATE() ORDER BY s.NroSoc;";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvVtos.Rows.Add();
                        int nroSoc = reader.GetInt32(0);
                        dtgvVtos.Rows[renglon].Cells[0].Value = reader.GetInt32(0).ToString(); // NroSoc
                        dtgvVtos.Rows[renglon].Cells[1].Value = reader.GetString(1); // Nombre
                        dtgvVtos.Rows[renglon].Cells[2].Value = reader.GetString(2); // Apellido
                        dtgvVtos.Rows[renglon].Cells[3].Value = reader.GetString(3); // Dni
                        dtgvVtos.Rows[renglon].Cells[4].Value = reader.GetDateTime(4).ToString("yyyy-MM-dd"); // ProxVto

                        // Llamar al procedimiento para actualizar el estado del socio
                        ActualizarEstadoSocio(nroSoc, false); // Cambia a estado no activo
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadoSocio(int nroSocio, bool nuevoEstado)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open(); string query = "CALL ActualizarEstadoSocio(@NroSocio, @NuevoEstado, @Resultado)";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroSocio", nroSocio); cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado); cmd.Parameters.Add("@Resultado", MySqlDbType.Int32).Direction = ParameterDirection.Output; cmd.ExecuteNonQuery();
                        int resultado = (int)cmd.Parameters["@Resultado"].Value;
                        if (resultado == 1)
                        {
                            // Estado actualizado con éxito
                        }
                        else
                        {
                            // No se pudo actualizar el estado
                            MessageBox.Show("Error al actualizar el estado del socio: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado del socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            btnVolver.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Principal principal = new Principal();
            principal.Show();
            this.Close();

            btnImprimir.Visible = true;
            btnVolver.Visible = false;

        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        public bool HayVencimientos()
        {
            bool hayDatos = false;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    string query = @"SELECT COUNT(*) FROM socio s JOIN pagosCta p ON s.NroSoc = p.NroSoc WHERE DATE(p.ProxVto) = CURDATE();";
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    sqlCon.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    //Si es que tenemos aunque sea un registro, retornaremos true
                    hayDatos = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar los vencimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return hayDatos;
            }   
        }
    }
}