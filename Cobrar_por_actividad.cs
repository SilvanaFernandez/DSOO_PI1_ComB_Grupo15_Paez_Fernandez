using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos;
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
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT nombreA FROM actividad";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cboActividad.Items.Add(reader["nombreA"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
            cboActividad.SelectedIndexChanged += new EventHandler(cboActividad_SelectedIndexChanged);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroNoSocio.Text = "";
            txtNombreApellido.Text = "";
            cboActividad.Text = "";
            txtImporte.Text = "";
            txtFecha.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void txtNroNoSocio_TextChanged(object sender, EventArgs e)
        {
            string nroNoSocioTexto = txtNroNoSocio.Text; if (!int.TryParse(nroNoSocioTexto, out int nroNoSocio))
            {
                // Si no es un número válido, limpiar campos
                txtNombreApellido.Text = "";
                txtDni.Text = "";
                cboActividad.Text = "";
                txtImporte.Text = "";
                txtFecha.Text = "";
                txtCupoDisp.Text = "";
                return;
            }
            // Consultar la base de datos para obtener el nombre, apellido y DNI del no socio
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    // Consultar el nombre, apellido y DNI del no socio
                    string querySocio = "SELECT NombreP, ApellidoP, DocP FROM noSocio WHERE NroNoSoc = @NroNoSoc";
                    using (MySqlCommand cmd = new MySqlCommand(querySocio, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroNoSoc", nroNoSocio);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombreApellido.Text = $"{reader["NombreP"]}{" "}{reader["ApellidoP"]}";
                                txtDni.Text = reader["DocP"].ToString();
                                // Establecer la fecha actual y el próximo vencimiento
                                DateTime fechaActual = DateTime.Now;
                                txtFecha.Text = fechaActual.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                txtNombreApellido.Text = "No encontrado";
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

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string actividadSeleccionada = cboActividad.SelectedItem.ToString(); using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    // Consultar el costo de la actividad y el cupo disponible
                    string queryActividad = "SELECT costoDia, cupoDisp FROM actividad WHERE nombreA = @nombreA";
                    using (MySqlCommand cmd = new MySqlCommand(queryActividad, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@nombreA", actividadSeleccionada);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtImporte.Text = reader["costoDia"].ToString(); txtCupoDisp.Text = reader["cupoDisp"].ToString();
                            }
                            else
                            {
                                txtImporte.Text = "No encontrado"; txtCupoDisp.Text = "";
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

        private void btnCarnetNoSocio_Click(object sender, EventArgs e)
        {
            CarnetNoSocio carnet = new CarnetNoSocio
            {
                nroNoSoc = txtNroNoSocio.Text,
            };
            carnet.Show();
            this.Hide();
        }

        private void btnRegEmitirRecibo_Click(object sender, EventArgs e)
        {
            string nroNoSocioTexto = txtNroNoSocio.Text; string actividadTexto = cboActividad.SelectedItem.ToString();
            string importeTexto = txtImporte.Text;
            string fechaTexto = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            // Fecha actual
            string motivo = "Actividad por día: " + actividadTexto;
            if (!int.TryParse(nroNoSocioTexto, out int nroNoSocio) || !decimal.TryParse(importeTexto, out decimal importe))
            {
                MessageBox.Show("Por favor, asegúrese de que todos los datos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    string query = "CALL RegistrarPagoActividad(@NroNoSoc, @NombreA, @Monto, @FechaPago)";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroNoSoc", nroNoSocio);
                        cmd.Parameters.AddWithValue("@NombreA", actividadTexto);
                        cmd.Parameters.AddWithValue("@Monto", importe);
                        cmd.Parameters.AddWithValue("@FechaPago", fechaTexto);
                        cmd.ExecuteNonQuery();
                    }
                    // Obtener el idPago del último pago registrado
                    string queryIdPago = "SELECT LAST_INSERT_ID()";
                    using (MySqlCommand cmd = new MySqlCommand(queryIdPago, sqlCon))
                    {
                        int idPago = Convert.ToInt32(cmd.ExecuteScalar());
                        // Abrir el formulario de recibo y completar con los datos
                        ReciboAct recibo = new ReciboAct
                        {
                            nroRecibo = idPago.ToString(),
                            fecha = fechaTexto,
                            importe = importeTexto,
                            nombreApellido = txtNombreApellido.Text,
                            motivo = motivo
                        };
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
    }
}
 