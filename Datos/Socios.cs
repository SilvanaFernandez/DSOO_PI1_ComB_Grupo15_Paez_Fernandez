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
            if (Utilidades.DniRegistradoEnOtroTipo(soc.DniP, true)) // Verifica si el DNI está en No_Socios
            {
                return "Error: El DNI ya está registrado como No Socio.";
            }
            using (MySqlConnection sqlCon = ObtenerConexion())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand("NuevoSoc", sqlCon);
                    comando.CommandType = CommandType.StoredProcedure;
                    //se pasan los parametros para el procedimiento de la BD
                    comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = soc.NombreP;
                    comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = soc.ApellidoP;
                    comando.Parameters.Add("Doc", MySqlDbType.VarChar).Value = soc.DniP;
                    comando.Parameters.Add("Apto", MySqlDbType.Bit).Value = soc.AptoMedico ? 1 : 0;

                    MySqlParameter Parametro = new MySqlParameter();
                    Parametro.ParameterName = "rta";
                    Parametro.MySqlDbType = MySqlDbType.Int32;
                    Parametro.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(Parametro);

                    sqlCon.Open();
                    comando.ExecuteNonQuery();

                    salida = Convert.ToString(Parametro.Value);
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
    }
}
 