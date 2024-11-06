using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
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
    public partial class ReciboCta : Form
    {
        public ReciboCta()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            btnImprimir.Visible = true;
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
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    string query = @"
                        SELECT p.idPago, p.fechaPago, p.monto, s.NombreP, s.ApellidoP
                        FROM pagosCta p
                        JOIN socio s ON p.NroSoc = s.NroSoc
                        WHERE p.idPago = @idPago";

                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@idPago", idPago);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNroRecibo.Text = reader["idPago"].ToString();
                                txtFecha.Text = Convert.ToDateTime(reader["fechaPago"]).ToString("yyyy-MM-dd");
                                txtImporte.Text = Convert.ToDecimal(reader["monto"]).ToString("F2");
                                txtNombreApellido.Text = $"{reader["NombreP"]} {reader["ApellidoP"]}";
                                txtMotivo.Text = "cuota mes de " + Convert.ToDateTime(reader["fechaPago"]).ToString("MMMM");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos del recibo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }

            }
        }
    }
}

