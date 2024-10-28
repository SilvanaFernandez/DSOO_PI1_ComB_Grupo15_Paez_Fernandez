namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class CarnetSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarnetSocio));
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlDatos = new Panel();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            txtFecha = new TextBox();
            txtDni = new TextBox();
            lblDni = new Label();
            lblFechaAlta = new Label();
            lblNombre = new Label();
            txtNroSocio = new TextBox();
            picLogo = new PictureBox();
            lblNroSocio = new Label();
            btnImprimir = new Button();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(128, 255, 128);
            pnlTitulo.BorderStyle = BorderStyle.FixedSingle;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.ForeColor = SystemColors.ControlText;
            pnlTitulo.Location = new Point(134, 43);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(327, 64);
            pnlTitulo.TabIndex = 0;
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
            pnlDatos.Controls.Add(txtNroSocio);
            pnlDatos.Controls.Add(picLogo);
            pnlDatos.Controls.Add(lblNroSocio);
            pnlDatos.Location = new Point(134, 101);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(327, 174);
            pnlDatos.TabIndex = 1;
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
            // txtNroSocio
            // 
            txtNroSocio.BackColor = Color.FromArgb(128, 255, 128);
            txtNroSocio.BorderStyle = BorderStyle.None;
            txtNroSocio.ForeColor = SystemColors.ActiveCaptionText;
            txtNroSocio.Location = new Point(167, 11);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(129, 16);
            txtNroSocio.TabIndex = 2;
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
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroSocio.Location = new Point(52, 14);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(109, 13);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "NÚMERO DE SOCIO";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(333, 296);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // CarnetSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "CarnetSocio";
            Text = "Carnet Socio";
            Load += Carnet_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlDatos;
        private Label lblTitulo;
        private Label lblNroSocio;
        private PictureBox picLogo;
        private TextBox txtNroSocio;
        private Label lblDni;
        private Label lblFechaAlta;
        private Label lblNombre;
        private TextBox txtDni;
        private Button btnImprimir;
        private TextBox txtApellido;
        private TextBox txtFecha;
        private Label lblApellido;
        private TextBox txtNombre;
    }
}