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
    internal class Socios
    {
        private string connectionString = "Server=localhost;port=3306;Database=DSOO_PI1_ComB_Grupo15_Paez_Fernandez;Uid=root";
        /*public string nuevo_Soc(E_Socio socio)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("nuevoSoc", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("Nom", socio.NombreS);
                    cmd.Parameters.AddWithValue("Ape", socio.ApellidoS);
                    cmd.Parameters.AddWithValue("Doc", socio.DniS);

                    MySqlParameter ParCodigo = new MySqlParameter();
                    ParCodigo.ParameterName = "rta";
                    ParCodigo.MySqlDbType = MySqlDbType.Int32;
                    ParCodigo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(ParCodigo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return "socio creado exitosamente";
                    }
                    else
                    {
                        return "error al crear el socio";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }*/

            
        public string Nuevo_Soc(E_Socio soc)
        { 
            string salida;
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
            //MySqlConnection sqlCon = new MySqlConnection();
                try
                {
                    //sqlCon = Conexion.getInstancia().CrearConexion();//conexión única
                    MySqlCommand comando = new MySqlCommand("NuevoSoc", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    //se pasan los parametros para el procedimiento
                    comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = soc.NombreS;
                    comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = soc.ApellidoS;
                    comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = soc.DniS;
                        
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
                            salida = "El socio ya existe.";
                        }
                        else
                        {
                            salida = "Socio creado con éxito. Número de socio: " + resultado;
                        }
                    }
                    else
                    {
                        salida = "Error: No se pudo obtener el número de socio.";
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
