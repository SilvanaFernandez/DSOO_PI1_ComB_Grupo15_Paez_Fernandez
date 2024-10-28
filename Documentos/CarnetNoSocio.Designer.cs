namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos
{
    partial class CarnetNoSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarnetNoSocio));
            btnImprimir = new Button();
            pnlDatos = new Panel();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            txtFecha = new TextBox();
            txtDni = new TextBox();
            lblDni = new Label();
            lblFechaAlta = new Label();
            lblNombre = new Label();
            txtNroNoSocio = new TextBox();
            picLogo = new PictureBox();
            lblNroNoSocio = new Label();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(436, 340);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.FromArgb(128, 255, 128);
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(txtFecha);
            pnlDatos.Controls.Add(txtDni);
            pnlDatos.Controls.Add(lblDni);
            pnlDatos.Controls.Add(lblFechaAlta);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(txtNroNoSocio);
            pnlDatos.Controls.Add(picLogo);
            pnlDatos.Controls.Add(lblNroNoSocio);
            pnlDatos.Location = new Point(237, 145);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(327, 174);
            pnlDatos.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(128, 255, 128);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(196, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 16);
            txtNombre.TabIndex = 12;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(138, 78);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(128, 255, 128);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.ForeColor = SystemColors.ActiveCaptionText;
            txtApellido.Location = new Point(196, 77);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(114, 16);
            txtApellido.TabIndex = 10;
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(128, 255, 128);
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.ForeColor = SystemColors.ActiveCaptionText;
            txtFecha.Location = new Point(198, 141);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(95, 16);
            txtFecha.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(128, 255, 128);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.ForeColor = SystemColors.ActiveCaptionText;
            txtDni.Location = new Point(167, 110);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(126, 16);
            txtDni.TabIndex = 8;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(138, 111);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI:";
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaAlta.Location = new Point(138, 142);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(60, 13);
            lblFechaAlta.TabIndex = 5;
            lblFechaAlta.Text = "Fecha alta:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(138, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNroNoSocio
            // 
            txtNroNoSocio.BackColor = Color.FromArgb(128, 255, 128);
            txtNroNoSocio.BorderStyle = BorderStyle.None;
            txtNroNoSocio.ForeColor = SystemColors.ActiveCaptionText;
            txtNroNoSocio.Location = new Point(181, 11);
            txtNroNoSocio.Name = "txtNroNoSocio";
            txtNroNoSocio.Size = new Size(129, 16);
            txtNroNoSocio.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(21, 48);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(89, 86);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblNroNoSocio
            // 
            lblNroNoSocio.AutoSize = true;
            lblNroNoSocio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroNoSocio.Location = new Point(52, 14);
            lblNroNoSocio.Name = "lblNroNoSocio";
            lblNroNoSocio.Size = new Size(128, 13);
            lblNroNoSocio.TabIndex = 0;
            lblNroNoSocio.Text = "NÚMERO DE NO SOCIO";
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(128, 255, 128);
            pnlTitulo.BorderStyle = BorderStyle.FixedSingle;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.ForeColor = SystemColors.ControlText;
            pnlTitulo.Location = new Point(237, 87);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(327, 64);
            pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(21, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(277, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Club Deportivo \"FITNESS\"";
            // 
            // CarnetNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "CarnetNoSocio";
            Text = "Carnet No Socio";
            Load += CarnetNoSocio_Load;
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnImprimir;
        private Panel pnlDatos;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private TextBox txtFecha;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblFechaAlta;
        private Label lblNombre;
        private TextBox txtNroNoSocio;
        private PictureBox picLogo;
        private Label lblNroNoSocio;
        private Panel pnlTitulo;
        private Label lblTitulo;
    }
}