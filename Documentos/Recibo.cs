﻿ 
using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    public partial class Recibo : Form
    {
        public string nroRecibo { get; set; }
        public string fecha { get; set; }
        public string importe { get; set; }
        public string nombreApellido { get; set; }
        public string motivo { get; set; }

        public Recibo()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
                if (PrinterSettings.InstalledPrinters.Count > 0)
                {
                    pd.Print();
                }
                else
                {
                    MessageBox.Show("No hay impresoras instaladas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
                MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la impresión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
       
            btnImprimir.Visible = true;
            this.Close();          
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        public void CompletarRecibo(int idPago)
        {
            txtNroRecibo.Text = nroRecibo;
            txtFecha.Text = fecha;
            txtImporte.Text = importe;
            txtNombreApellido.Text = nombreApellido;
            txtMotivo.Text = motivo;
        }
    }
}

