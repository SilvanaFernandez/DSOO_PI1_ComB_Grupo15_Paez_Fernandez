﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    internal class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        /// <summary>
        /// 
        /// </summary>
        private Conexion() 
        {
            this.baseDatos = "Proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MySqlConnection CrearConexion() 
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                    ";port=" + this.puerto + ";username=" + this.usuario + ";password=" +
                    this.clave + ";Database=" + this.baseDatos;
            }
            catch (Exception ex) 
            {
                cadena = null;
                throw ;
            }
            return cadena;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Conexion getInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
