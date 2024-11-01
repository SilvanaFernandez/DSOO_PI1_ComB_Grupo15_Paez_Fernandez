using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Permissions;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class Cobrar_cuota : Form
    {
        private Principal principal;
        public Cobrar_cuota(Principal principal)
        {
            InitializeComponent();
            txtNroSocio2.TextChanged += txtNroSocio2_TextChanged;
            this.principal = principal;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroSocio1.Text = "";
            txtNroSocio2.Text = "";
            txtNombreApellido1.Text = "";
            txtNombreApellido2.Text = "";
            txtEstado.Text = "";
            txtFechaUltPago.Text = "";
            txtImporte.Text = "";
            txtFecha.Text = "";
            txtProxVto.Text = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void txtNroSocio1_TextChanged(object sender, EventArgs e)
        {
            string nroSocioTexto = txtNroSocio1.Text;
            if (!int.TryParse(nroSocioTexto, out int nroSocio))
            {
                // Si no es un número válido, limpiar campos
                txtEstado.Text = "";
                txtFechaUltPago.Text = "";
                txtNombreApellido1.Text = "";
                return;
            }

            // Consultar la base de datos
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    // Consultar estado del socio y nombre y apellido
                    string querySocio = "SELECT Activo, CONCAT(NombreP, ' ', ApellidoP) AS NombreApellido FROM socio WHERE NroSoc = @NroSoc";
                    using (MySqlCommand cmd = new MySqlCommand(querySocio, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroSoc", nroSocio);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool activo = reader.GetBoolean("Activo");
                                txtEstado.Text = activo ? "Activo" : "No Activo";
                                txtNombreApellido1.Text = reader.GetString("NombreApellido");
                            }
                            else
                            {
                                txtEstado.Text = "No encontrado";
                                txtNombreApellido1.Text = "No encontrado";
                            }
                        }
                    }

                    // Consultar la fecha del último pago
                    string queryPago = "SELECT MAX(fechaPago) FROM pagosCta WHERE NroSoc = @NroSoc";
                    using (MySqlCommand cmd = new MySqlCommand(queryPago, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroSoc", nroSocio);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            DateTime fechaUltPago = Convert.ToDateTime(result);
                            txtFechaUltPago.Text = fechaUltPago.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            txtFechaUltPago.Text = "No hay pagos";
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

        private void txtNroSocio2_TextChanged(object sender, EventArgs e)
        {
            string nroSocioTexto = txtNroSocio2.Text;
            if (!int.TryParse(nroSocioTexto, out int nroSocio))
            {
                // Si no es un número válido, limpiar campos
                txtImporte.Text = "";
                txtFecha.Text = "";
                txtProxVto.Text = "";
                txtNombreApellido2.Text = "";
                txtDni.Text = "";
                return;
            }

            // Establecer el importe fijo
            decimal importe = 35000;
            txtImporte.Text = importe.ToString("F2");

            // Establecer la fecha actual y el próximo vencimiento
            DateTime fechaActual = DateTime.Now;
            DateTime proximoVencimiento = fechaActual.AddMonths(1);
            txtFecha.Text = fechaActual.ToString("yyyy-MM-dd");
            txtProxVto.Text = proximoVencimiento.ToString("yyyy-MM-dd");

            // Consultar la base de datos para obtener el nombre, apellido y DNI del socio
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    // Consultar el nombre, apellido y DNI del socio
                    string querySocio = "SELECT NombreP, ApellidoP, DocP FROM socio WHERE NroSoc = @NroSoc";
                    using (MySqlCommand cmd = new MySqlCommand(querySocio, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroSoc", nroSocio);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombreApellido2.Text = $"{reader["NombreP"]} {reader["ApellidoP"]}";
                                txtDni.Text = reader["DocP"].ToString();
                            }
                            else
                            {
                                txtNombreApellido2.Text = "No encontrado";
                                txtDni.Text = "";
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

        private void btnRegEmitirRecibo_Click(object sender, EventArgs e)
        {
            string nroSocioTexto = txtNroSocio2.Text;
            string importeTexto = txtImporte.Text;
            string fechaTexto = txtFecha.Text;
            string proxVtoTexto = txtProxVto.Text;

            if (!int.TryParse(nroSocioTexto, out int nroSocio) || !decimal.TryParse(importeTexto, out decimal importe) || !DateTime.TryParse(fechaTexto, out DateTime fechaPago) || !DateTime.TryParse(proxVtoTexto, out DateTime proxVto))
            {
                MessageBox.Show("Por favor, asegúrese de que todos los datos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    string query = "CALL RegistrarPago(@NroSoc, @Monto, @FechaPago, @ProxVto)";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {

                        cmd.Parameters.AddWithValue("@NroSoc", nroSocio);
                        cmd.Parameters.AddWithValue("@Monto", importe);
                        cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
                        cmd.Parameters.AddWithValue("@ProxVto", proxVto);

                        cmd.ExecuteNonQuery();
                    }

                    // Obtener el idPago del último pago registrado
                    string queryIdPago = "SELECT LAST_INSERT_ID()";
                    using (MySqlCommand cmd = new MySqlCommand(queryIdPago, sqlCon))
                    {
                        int idPago = Convert.ToInt32(cmd.ExecuteScalar());

                        // Abrir el formulario de recibo y completar con los datos
                        ReciboCta recibo = new ReciboCta();
                        recibo.CompletarRecibo(idPago);
                        recibo.Show();
                    }

                    MessageBox.Show("Pago registrado y recibo emitido con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCarnetSocio_Click(object sender, EventArgs e)
        {
            CarnetSocio carnet = new CarnetSocio
            {
                nroSoc = txtNroSocio2.Text,
            };
            carnet.Show();
            this.Hide();
        }
    }
}
