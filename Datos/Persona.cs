using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos
{
    public abstract class Persona
    {
        // Método estático para obtener la conexión
        protected static MySqlConnection ObtenerConexion()
        {
            return Conexion.getInstancia().CrearConexion();
        }

        // Método para verificar si el DNI está registrado en otro tipo
        public static bool DniRegistradoEnOtroTipo(int dni, bool esSocio)
        {
            bool registrado = false;
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    string query = esSocio ?
                        "SELECT COUNT(*) FROM noSocio WHERE DocP = @Dni" :
                        "SELECT COUNT(*) FROM Socio WHERE DocP = @Dni";

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@Dni", dni);

                    sqlCon.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    registrado = count > 0;
                }
                catch (Exception ex)
                {
                    // Manejo de errores, según sea necesario
                    Console.WriteLine("Error en la verificación de DNI: " + ex.Message);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
            return registrado;
        }

        // Método abstracto para ser implementado por las clases derivadas
        public abstract string Nuevo();
    }
}
