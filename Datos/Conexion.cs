﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            // variables usadas para la repetición de líneas de código
            bool correcto = false;
            int mensaje;

            // creamos las variables para recibir los datos desde el teclado
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (correcto != true)
            {
                // Armamos los cuadros de diálogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");

                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR = " + T_servidor + " PUERTO= " + T_puerto + " USUARIO: " + T_usuario + " CLAVE: " + T_clave, "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }

                this.baseDatos = "DSOO_PI1_ComB_Grupo15_Paez_Fernandez";
                this.servidor = T_servidor;
                this.puerto = T_puerto;
                this.usuario = T_usuario;
                this.clave = T_clave;
            }
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = $"datasource={servidor};Port={puerto};username={usuario};password={clave};Database={baseDatos};";            
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
 