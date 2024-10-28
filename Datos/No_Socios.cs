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
        public string Nuevo_NoSoc(E_No_Socio noSoc)
        {
            string salida;
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    //sqlCon = Conexion.getInstancia().CrearConexion();//conexión única
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
    }
}