namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class Registro_socios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_socios));
            lblRegistroSocios = new Label();
            picSocio = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            btnGuardar = new Button();
            btnVolver = new Button();
            lblNroSocio = new Label();
            txtNroSocio = new TextBox();
            lblNombre1 = new Label();
            lblApellido1 = new Label();
            lblDni1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)picSocio).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroSocios
            // 
            lblRegistroSocios.AutoSize = true;
            lblRegistroSocios.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroSocios.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistroSocios.Location = new Point(239, 41);
            lblRegistroSocios.Name = "lblRegistroSocios";
            lblRegistroSocios.Size = new Size(290, 31);
            lblRegistroSocios.TabIndex = 2;
            lblRegistroSocios.Text = "REGISTRO DE SOCIOS";
            lblRegistroSocios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picSocio
            // 
            picSocio.Image = (Image)resources.GetObject("picSocio.Image");
            picSocio.Location = new Point(473, 131);
            picSocio.Name = "picSocio";
            picSocio.Size = new Size(181, 122);
            picSocio.SizeMode = PictureBoxSizeMode.Zoom;
            picSocio.TabIndex = 3;
            picSocio.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(151, 201);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(151, 279);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(151, 351);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 12;
            lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 297);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(216, 23);
            txtApellido.TabIndex = 13;
            txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 219);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 14;
            txtNombre.Text = "Nombre";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(151, 369);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(139, 23);
            txtDni.TabIndex = 15;
            txtDni.Text = "XXXXXXXX";
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(521, 285);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 44);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(691, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Location = new Point(151, 131);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(98, 15);
            lblNroSocio.TabIndex = 18;
            lblNroSocio.Text = "Numero de socio";
            // 
            // txtNroSocio
            // 
            txtNroSocio.Location = new Point(151, 149);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(100, 23);
            txtNroSocio.TabIndex = 19;
            txtNroSocio.Text = "xxxx";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Location = new Point(373, 219);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(12, 15);
            lblNombre1.TabIndex = 20;
            lblNombre1.Text = "*";
            lblNombre1.Click += lblNombre1_Click;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(373, 297);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(12, 15);
            lblApellido1.TabIndex = 21;
            lblApellido1.Text = "*";
            // 
            // lblDni1
            // 
            lblDni1.AutoSize = true;
            lblDni1.Location = new Point(296, 369);
            lblDni1.Name = "lblDni1";
            lblDni1.Size = new Size(12, 15);
            lblDni1.TabIndex = 22;
            lblDni1.Text = "*";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(521, 351);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 44);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // Registro_socios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(lblDni1);
            Controls.Add(lblApellido1);
            Controls.Add(lblNombre1);
            Controls.Add(txtNroSocio);
            Controls.Add(lblNroSocio);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(picSocio);
            Controls.Add(lblRegistroSocios);
            Name = "Registro_socios";
            Text = "Registrar_socio";
            ((System.ComponentModel.ISupportInitialize)picSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroSocios;
        private PictureBox picSocio;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDni;
        private Button btnGuardar;
        private Button btnVolver;
        private Label lblNroSocio;
        private TextBox txtNroSocio;
        private Label lblNombre1;
        private Label lblApellido1;
        private Label lblDni1;
        private Button btnLimpiar;
    }
}