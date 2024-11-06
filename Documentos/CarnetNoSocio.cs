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

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos
{
    public partial class CarnetNoSocio : Form
    {
        public CarnetNoSocio() => InitializeComponent();

        public string nroNoSoc { get; set; }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Principal principal = new Principal();
            principal.Show();
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

        private void CarnetNoSocio_Load(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    // Obtener el NroNoSoc de txtNroSocio2
                    string nroNoSocioTexto = nroNoSoc;
                    if (!int.TryParse(nroNoSocioTexto, out int nroNoSocio))
                    {
                        MessageBox.Show("Número de no socio no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "SELECT NombreP, ApellidoP, DocP FROM noSocio WHERE NroNoSoc = @NroNoSoc";
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NroNoSoc", nroNoSocio);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNroNoSocio.Text = nroNoSocioTexto;
                                txtNombre.Text = reader["NombreP"].ToString();
                                txtApellido.Text = reader["ApellidoP"].ToString();
                                txtDni.Text = reader["DocP"].ToString();
                                txtFecha.Text = DateTime.UtcNow.ToShortDateString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos para el número de socio proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
 