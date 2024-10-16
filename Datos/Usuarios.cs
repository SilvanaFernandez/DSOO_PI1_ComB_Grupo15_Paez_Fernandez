using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.CodeDom;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos
{
    internal class Usuarios
    {        
        public DataTable Log_Usu(string L_usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();//conexión única
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);//se instancia con el nombre del procedimiento y y la conexion

                comando.CommandType = CommandType.StoredProcedure;//aqui se especifica que debe usar un procedimineto

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                dt.Load(resultado);
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
