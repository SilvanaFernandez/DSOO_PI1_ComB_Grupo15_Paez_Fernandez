using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos
{
    internal class No_Socios : Persona
    {
        private E_No_Socio noSoc;

        public No_Socios(E_No_Socio noSoc)
        {
            this.noSoc = noSoc;
        }

        public override string Nuevo()
        {
            string salida;
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("NuevoNoSoc", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    //se pasan los parametros para el procedimiento
                    comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = noSoc.NombreP;
                    comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = noSoc.ApellidoP;
                    comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = noSoc.DniP;

                    MySqlParameter ParCodigo = new MySqlParameter();
                    ParCodigo.ParameterName = "rta";
                    ParCodigo.MySqlDbType = MySqlDbType.Int32;
                    ParCodigo.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(ParCodigo);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    salida = Convert.ToString(ParCodigo.Value);

                    // Obtener el valor del parámetro de salida
                    if (ParCodigo.Value != DBNull.Value)
                    {
                        int resultado = Convert.ToInt32(ParCodigo.Value);
                        if (resultado == -1)
                        {
                            salida = "El no socio ya existe.";
                        }
                        else
                        {
                            salida = "No socio creado con éxito. Número de no socio: " + resultado;
                        }
                    }
                    else
                    {
                        salida = "Error: No se pudo obtener el número de no socio.";
                    }
                }
                catch (Exception ex)
                {
                    salida = "Error: " + ex.Message;
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    { sqlCon.Close(); };
                }
                return salida;
            }
        }
        public string RegistrarActividadNoSocio(int nroNoSoc, int codAct)
        {
            string resultado;
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("RegistrarActividadNoSocio", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("p_NroNoSoc", nroNoSoc);
                    comando.Parameters.AddWithValue("p_codAct", codAct);

                    // Parámetro de salida para el costo de la actividad
                    MySqlParameter ParCostoActividad = new MySqlParameter();
                    ParCostoActividad.ParameterName = "costoActividad";
                    ParCostoActividad.MySqlDbType = MySqlDbType.Decimal;
                    ParCostoActividad.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(ParCostoActividad);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    decimal costoActividad = Convert.ToDecimal(ParCostoActividad.Value);
                    resultado = $"Actividad registrada. Costo a pagar: {costoActividad}.";
                }
                catch (Exception ex)
                {
                    resultado = "Error: " + ex.Message;
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
            return resultado;
        }
    }
}
 