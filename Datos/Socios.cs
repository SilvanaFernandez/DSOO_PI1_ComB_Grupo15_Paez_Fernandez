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
    internal class Socios : Persona
    {
        public E_Socio soc;

        public Socios(E_Socio soc)
        {
            this.soc = soc;
        }

        public override string Nuevo()
        { 
            string salida;
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("NuevoSoc", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    //se pasan los parametros para el procedimiento
                    comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = soc.NombreP;
                    comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = soc.ApellidoP;
                    comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = soc.DniP;
                    comando.Parameters.Add("Apto", MySqlDbType.Bit).Value = soc.AptoMedico ? 1 : 0;

                    MySqlParameter ParCodigo = new MySqlParameter();
                    ParCodigo.ParameterName = "rta";
                    ParCodigo.MySqlDbType = MySqlDbType.Int32;
                    ParCodigo.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(ParCodigo);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    salida = Convert.ToString(ParCodigo.Value);

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
                catch (Exception ex)
                {
                    salida = "Error: " + ex.Message;
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
                return salida;
            }
        }

        public string RegistrarActividad(int nroSoc, int codAct)
        {
            string resultado;
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("RegistrarActividadSocio", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("p_NroSoc", nroSoc);
                    comando.Parameters.AddWithValue("p_codAct", codAct);

                    // Parámetros de salida para el precio extra
                    MySqlParameter ParExtraCosto = new MySqlParameter
                    {
                        ParameterName = "extraCosto",
                        MySqlDbType = MySqlDbType.Decimal,
                        Direction = ParameterDirection.Output
                    };
                    comando.Parameters.Add(ParExtraCosto);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    decimal extraCosto = Convert.ToDecimal(ParExtraCosto.Value);
                    resultado = extraCosto > 0
                        ? $"Se cobrará un extra de {extraCosto}."
                        : "Actividad registrada sin costo adicional.";

                    // Aquí podrías llamar a un método para ajustar el cupo si es necesario.
                    AjustarCupo(codAct);
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

        public string CancelarActividad(int nroSoc, int codAct)
        {
            string resultado;

            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("CancelarActividadSocio", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("p_NroSoc", nroSoc);
                    comando.Parameters.AddWithValue("p_codAct", codAct);

                    MySqlParameter parResultado = new MySqlParameter("resultado", MySqlDbType.VarChar);
                    parResultado.Size = 50;
                    parResultado.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(parResultado);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    resultado = parResultado.Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = "Error: " + ex.Message;
                }
                finally
                {
                    sqlCon.Close();
                }
            }

            return resultado;
        }

        private void AjustarCupo(int codAct)
        {
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                MySqlCommand comando = new MySqlCommand("UPDATE actividad SET cupoDisp = cupoDisp - 1 WHERE codAct = @codAct", sqlCon);
                comando.Parameters.AddWithValue("@codAct", codAct);

                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
 