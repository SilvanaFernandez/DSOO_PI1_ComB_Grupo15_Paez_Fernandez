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
        public string Nuevo_Soc(E_Socio soc)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();//conexión única
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
            }
            catch (Exception ex)
            {
                salida = ex.Message;
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
