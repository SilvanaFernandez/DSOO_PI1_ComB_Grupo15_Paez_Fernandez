﻿using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
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
            VerificarYActualizarEstadosSocios();
        }

        private void VerificarYActualizarEstadosSocios()
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    // Consulta para obtener los socios con el último ProxVto del día anterior
                    string queryDiaAnterior = @"SELECT s.NroSoc FROM socio s JOIN pagos p ON s.NroSoc = p.NroSoc WHERE p.ProxVto = (SELECT MAX(ProxVto) FROM pagos WHERE NroSoc = p.NroSoc) AND DATE(p.ProxVto) = CURDATE() - INTERVAL 1 DAY";

                    using (MySqlCommand cmd = new MySqlCommand(queryDiaAnterior, sqlCon))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<int> socios = new List<int>();
                            while (reader.Read())
                            {
                                socios.Add(reader.GetInt32("NroSoc"));
                            }
                            reader.Close();  // Cerramos el DataReader antes de abrir otro

                            foreach (int nroSoc in socios)
                            {
                                // Llamar al procedimiento para actualizar el estado del socio a false
                                using (MySqlCommand cmdUpdate = new MySqlCommand("CALL ActualizarEstadoSocio(@NroSocio, @NuevoEstado, @Resultado)", sqlCon))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@NroSocio", nroSoc);
                                    cmdUpdate.Parameters.AddWithValue("@NuevoEstado", false);
                                    cmdUpdate.Parameters.Add("@Resultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                                    cmdUpdate.ExecuteNonQuery();

                                    int resultado = (int)cmdUpdate.Parameters["@Resultado"].Value;
                                    if (resultado != 1)
                                    {
                                        // No se pudo actualizar el estado
                                        MessageBox.Show($"Error al actualizar el estado del socio con NroSoc {nroSoc}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }

                    // Consulta para obtener los socios con el último ProxVto de hace 5 días y activo = 0
                    string queryCincoDias = @"SELECT s.NroSoc FROM socio s JOIN pagos p ON s.NroSoc = p.NroSoc WHERE p.ProxVto = (SELECT MAX(ProxVto) FROM pagos WHERE NroSoc = p.NroSoc) AND DATE(p.ProxVto) = CURDATE() - INTERVAL 5 DAY AND s.activo = 0";

                    using (MySqlCommand cmd = new MySqlCommand(queryCincoDias, sqlCon))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<int> sociosInactivos = new List<int>();
                            while (reader.Read())
                            {
                                sociosInactivos.Add(reader.GetInt32("NroSoc"));
                            }
                            reader.Close();  // Cerramos el DataReader antes de abrir otro

                            foreach (int nroSoc in sociosInactivos)
                            {
                                // Obtener actividades del socio
                                string queryActividades = "SELECT codAct FROM ActividadesSocio WHERE NroSoc = @NroSoc";
                                using (MySqlCommand cmdActividades = new MySqlCommand(queryActividades, sqlCon))
                                {
                                    cmdActividades.Parameters.AddWithValue("@NroSoc", nroSoc);
                                    using (MySqlDataReader readerActividades = cmdActividades.ExecuteReader())
                                    {
                                        List<int> actividades = new List<int>();
                                        while (readerActividades.Read())
                                        {
                                            actividades.Add(readerActividades.GetInt32("codAct"));
                                        }
                                        readerActividades.Close();

                                        // Liberar cupoDisp de las actividades
                                        foreach (int codAct in actividades)
                                        {
                                            string queryLiberarCupo = "UPDATE actividad SET cupoDisp = cupoDisp + 1 WHERE codAct = @codAct";
                                            using (MySqlCommand cmdLiberarCupo = new MySqlCommand(queryLiberarCupo, sqlCon))
                                            {
                                                cmdLiberarCupo.Parameters.AddWithValue("@codAct", codAct);
                                                cmdLiberarCupo.ExecuteNonQuery();
                                            }
                                        }

                                        // Borrar las actividades del socio
                                        string queryBorrarActividades = "DELETE FROM ActividadesSocio WHERE NroSoc = @NroSoc";
                                        using (MySqlCommand cmdBorrarActividades = new MySqlCommand(queryBorrarActividades, sqlCon))
                                        {
                                            cmdBorrarActividades.Parameters.AddWithValue("@NroSoc", nroSoc);
                                            cmdBorrarActividades.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar y actualizar los estados de los socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = @" SELECT COUNT(*) FROM socio s JOIN pagos p ON s.NroSoc = p.NroSoc WHERE DATE(p.ProxVto) = CURDATE();";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                sqlCon.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    GrillaVtos grillaVtos = new GrillaVtos(this);
                    grillaVtos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Quedarse en el formulario principal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
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
 