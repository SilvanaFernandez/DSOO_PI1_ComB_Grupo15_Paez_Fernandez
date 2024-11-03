using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos
{
    public abstract class Persona
    {
        //Método estático para obtener la conexión
        protected static MySqlConnection ObtenerConexion()
        {
            return Conexion.getInstancia().CrearConexion();
        }
            
        // Método abstracto para ser implementado por las clases derivadas
        public abstract string Nuevo();
    }
}
 