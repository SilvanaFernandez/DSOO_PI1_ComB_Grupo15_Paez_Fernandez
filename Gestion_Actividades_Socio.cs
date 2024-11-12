using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class Gestion_Actividades_Socio : Form
    {
        private Principal principal;
        private string nombreActividad;
        public int NroSocio { get; set; }
        public string NombreApellido { get; set; }
        public string Dni { get; set; }
        public Gestion_Actividades_Socio(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
            this.Load += Registrar_Actividad_Socio_Load;
            txtNroSocio.TextChanged += TxtNroSocio_TextChanged;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
        }

        private void TxtNroSocio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNroSocio.Text, out int nroSocio))
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        sqlCon.Open();
                        // Obtener el nombre, apellido y dni del socio
                        string querySocio = "SELECT NombreP, ApellidoP, DocP FROM socio WHERE NroSoc = @NroSoc";
                        MySqlCommand cmdSocio = new MySqlCommand(querySocio, sqlCon);
                        cmdSocio.Parameters.AddWithValue("@NroSoc", nroSocio);
                        MySqlDataReader readerSocio = cmdSocio.ExecuteReader();

                        if (readerSocio.Read())
                        {
                            txtNombreApellido.Text = $"{readerSocio["NombreP"]} {readerSocio["ApellidoP"]}";
                            txtDni.Text = readerSocio["DocP"].ToString();
                        }
                        else
                        {
                            txtNombreApellido.Text = "";
                            txtDni.Text = "";
                        }
                        readerSocio.Close();

                        // Obtener las actividades a las que el socio está registrado usando el procedimiento almacenado
                        MySqlCommand cmdActividades = new MySqlCommand("ObtenerActividadesSocio", sqlCon);
                        cmdActividades.CommandType = CommandType.StoredProcedure;
                        cmdActividades.Parameters.AddWithValue("p_NroSoc", nroSocio);
                        MySqlDataReader readerActividades = cmdActividades.ExecuteReader();

                        List<int> actividadesRegistradas = new List<int>();
                        while (readerActividades.Read())
                        {
                            actividadesRegistradas.Add(Convert.ToInt32(readerActividades["codAct"]));
                        }
                        readerActividades.Close();

                        // Tildar las actividades y calcular el total de la cuota
                        decimal totalCuota = 8000; int actividadesCount = 0;

                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            string item = checkedListBox1.Items[i].ToString();
                            string[] parts = item.Split('-');
                            string nombreActividad = parts[0].Trim();

                            // Obtener codAct de la actividad
                            string queryCodAct = "SELECT codAct, costoMensual FROM actividad WHERE nombreA = @nombreA";
                            MySqlCommand cmdCodAct = new MySqlCommand(queryCodAct, sqlCon);
                            cmdCodAct.Parameters.AddWithValue("@nombreA", nombreActividad);
                            MySqlDataReader readerCodAct = cmdCodAct.ExecuteReader();
                            if (readerCodAct.Read())
                            {
                                int codAct = Convert.ToInt32(readerCodAct["codAct"]);
                                decimal costoMensual = Convert.ToDecimal(readerCodAct["costoMensual"]);
                                if (actividadesRegistradas.Contains(codAct))
                                {
                                    checkedListBox1.SetItemChecked(i, true);
                                    totalCuota += costoMensual;
                                    actividadesCount++;
                                }
                            }
                            readerCodAct.Close();
                        }

                        // Aplicar descuento si corresponde
                        if (actividadesCount > 0)
                        {
                            if (actividadesCount == 2)
                            {
                                totalCuota *= 0.90m;// 10% de descuento
                            }
                            else if (actividadesCount == 3)
                            {
                                totalCuota *= 0.80m; // 20% de descuento
                            }
                            else if (actividadesCount >= 4)
                            {
                                totalCuota *= 0.70m; // 30% de descuento
                            }
                        }
                        txtTotalCuota.Text = totalCuota.ToString("F2");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                txtNombreApellido.Text = "";
                txtDni.Text = "";
                txtTotalCuota.Text = "8000";
                foreach (int index in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(index, false);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroSocio.Text = "";
            txtNombreApellido.Text = "";
            txtDni.Text = "";
            txtTotalCuota.Text = "";
            checkedListBox1.Items.Clear();
            CargarActividades();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => CalcularTotalCuota()));
        }

        private void Registrar_Actividad_Socio_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void CargarActividades()
        {
            checkedListBox1.Items.Clear();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT distinct nombreA, costoMensual, cupoTotal, cupoDisp FROM actividad";
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string actividad = $"{reader["nombreA"]} - Costo Mensual: {reader["costoMensual"]} - Cupo Total: {reader["cupoTotal"]} - Cupo Disponible: {reader["cupoDisp"]}";
                        checkedListBox1.Items.Add(actividad);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTotalCuota_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCuota();
        }

        private void CalcularTotalCuota()
        {
            int selectedCount = checkedListBox1.CheckedItems.Count;
            if (selectedCount == 0)
            {
                txtTotalCuota.Text = "0";
            }
            else
            {
                decimal total = 0;
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string[] parts = item.ToString().Split('-');
                    string costoString = parts[1].Trim().Replace("Costo Mensual: ", "");
                    decimal costo = decimal.Parse(costoString);
                    total += costo;
                }
                if (selectedCount == 1)
                {
                    txtTotalCuota.Text = total.ToString("F2");
                }
                else if (selectedCount == 2)
                {
                    total *= 0.90m; // 10% de descuento
                    txtTotalCuota.Text = total.ToString("F2");
                }
                else if (selectedCount == 3)
                {
                    total *= 0.80m; // 20% de descuento
                    txtTotalCuota.Text = total.ToString("F2");
                }
                else if (selectedCount >= 4)
                {
                    total *= 0.70m; // 30% de descuento
                    txtTotalCuota.Text = total.ToString("F2");
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNroSocio.Text, out int nroSocio))
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        sqlCon.Open();
                        List<string> actividadesInscritas = new List<string>();
                        List<string> actividadesParaAgregarNombres = new List<string>();

                        // Obtener las actividades en las que el socio ya está inscrito
                        string queryActividadesRegistradas = "SELECT codAct FROM ActividadesSocio WHERE NroSoc = @NroSoc";
                        MySqlCommand cmdActividadesRegistradas = new MySqlCommand(queryActividadesRegistradas, sqlCon);
                        cmdActividadesRegistradas.Parameters.AddWithValue("@NroSoc", nroSocio);
                        MySqlDataReader readerActividadesRegistradas = cmdActividadesRegistradas.ExecuteReader();

                        List<int> actividadesRegistradas = new List<int>();
                        while (readerActividadesRegistradas.Read())
                        {
                            actividadesRegistradas.Add(Convert.ToInt32(readerActividadesRegistradas["codAct"]));
                        }
                        readerActividadesRegistradas.Close();

                        // Marcar las actividades que se deben agregar o dar de baja
                        List<int> actividadesParaAgregar = new List<int>();
                        List<int> actividadesParaDarDeBaja = actividadesRegistradas.ToList();

                        foreach (var item in checkedListBox1.CheckedItems)
                        {
                            string[] parts = item.ToString().Split('-');
                            string nombreActividad = parts[0].Trim();

                            // Obtener codAct de la actividad
                            string queryCodAct = "SELECT codAct FROM actividad WHERE nombreA = @nombreA";
                            MySqlCommand cmdCodAct = new MySqlCommand(queryCodAct, sqlCon);
                            cmdCodAct.Parameters.AddWithValue("@nombreA", nombreActividad);
                            int codAct = Convert.ToInt32(cmdCodAct.ExecuteScalar());

                            if (!actividadesRegistradas.Contains(codAct))
                            {
                                actividadesParaAgregar.Add(codAct);
                                actividadesParaAgregarNombres.Add(nombreActividad);
                            }
                            else
                            {
                                actividadesParaDarDeBaja.Remove(codAct);
                            }
                        }

                        // Registrar actividades y ajustar cupos
                        foreach (int codAct in actividadesParaAgregar)
                        {
                            string queryCupo = "SELECT cupoDisp FROM actividad WHERE codAct = @codAct";
                            MySqlCommand cmdCupo = new MySqlCommand(queryCupo, sqlCon);
                            cmdCupo.Parameters.AddWithValue("@codAct", codAct);
                            int cupoDisp = Convert.ToInt32(cmdCupo.ExecuteScalar());

                            if (cupoDisp > 0)
                            {
                                // Registrar la actividad del socio
                                MySqlCommand cmdRegistrar = new MySqlCommand("RegistrarActividadSocio", sqlCon);
                                cmdRegistrar.CommandType = CommandType.StoredProcedure;
                                cmdRegistrar.Parameters.AddWithValue("p_NroSoc", nroSocio);
                                cmdRegistrar.Parameters.AddWithValue("p_codAct", codAct);

                                MySqlParameter parExtraCosto = new MySqlParameter
                                {
                                    ParameterName = "extraCosto",
                                    MySqlDbType = MySqlDbType.Decimal,
                                    Direction = ParameterDirection.Output
                                };

                                MySqlParameter parResultado = new MySqlParameter
                                {
                                    ParameterName = "resultado",
                                    MySqlDbType = MySqlDbType.VarChar,
                                    Size = 50,
                                    Direction = ParameterDirection.Output
                                };

                                cmdRegistrar.Parameters.Add(parExtraCosto);
                                cmdRegistrar.Parameters.Add(parResultado);

                                cmdRegistrar.ExecuteNonQuery();

                                actividadesInscritas.Add(nombreActividad);
                            }
                            else
                            {
                                MessageBox.Show($"No hay cupo disponible para la actividad: {nombreActividad}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Descontar una unidad de cupoDisp
                            string queryDescontarCupo = "UPDATE actividad SET cupoDisp = cupoDisp - 1 WHERE codAct = @codAct";
                            MySqlCommand cmdDescontarCupo = new MySqlCommand(queryDescontarCupo, sqlCon);
                            cmdDescontarCupo.Parameters.AddWithValue("@codAct", codAct);
                            cmdDescontarCupo.ExecuteNonQuery();
                        }

                        // Dar de baja actividades y ajustar cupos
                        foreach (int codAct in actividadesParaDarDeBaja)
                        {
                            // Dar de baja la actividad del socio
                            string queryDarDeBaja = "DELETE FROM ActividadesSocio WHERE NroSoc = @NroSoc AND codAct = @codAct";
                            MySqlCommand cmdDarDeBaja = new MySqlCommand(queryDarDeBaja, sqlCon);
                            cmdDarDeBaja.Parameters.AddWithValue("@NroSoc", nroSocio);
                            cmdDarDeBaja.Parameters.AddWithValue("@codAct", codAct);
                            cmdDarDeBaja.ExecuteNonQuery();

                            // Sumar una unidad a cupoDisp
                            string querySumarCupo = "UPDATE actividad SET cupoDisp = cupoDisp + 1 WHERE codAct = @codAct";
                            MySqlCommand cmdSumarCupo = new MySqlCommand(querySumarCupo, sqlCon);
                            cmdSumarCupo.Parameters.AddWithValue("@codAct", codAct);
                            cmdSumarCupo.ExecuteNonQuery();
                        }

                        // Calcular el total de la cuota
                        CalcularTotalCuota();
                        decimal totalCuota = decimal.Parse(txtTotalCuota.Text);

                        string actividades = string.Join(", ", actividadesInscritas);
                        MessageBox.Show($"Inscripción actualizada en las actividades: {actividades}\nMonto Total: {totalCuota}", "Inscripción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Gestion_cuota cobrarCuota = new Gestion_cuota(principal)
                        {
                            NroSocio = nroSocio,
                            NombreApellido = $"{txtNombreApellido.Text}", Dni = txtDni.ToString()
                        };
                        cobrarCuota.ShowDialog();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de socio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
} 