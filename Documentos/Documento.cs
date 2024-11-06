using DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos
{
    public abstract class DocumentoBase : Form
    {
        protected Button btnImprimir;

        protected DocumentoBase()
        {
            btnImprimir = new Button();
            btnImprimir.Text = "Imprimir";
            btnImprimir.Click += btnImprimir_Click;
            Controls.Add(btnImprimir);
        }

        protected abstract void CargarDatos();

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += ImprimirForm1;
            pd.Print();

            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Principal principal = new Principal();
            principal.Show();
            this.Close();

            btnImprimir.Visible = true;
        }

        protected void ImprimirForm1(object sender, PrintPageEventArgs e)
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
    }
}
 