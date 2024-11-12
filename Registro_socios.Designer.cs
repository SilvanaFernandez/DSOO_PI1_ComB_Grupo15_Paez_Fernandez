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
            lblApellido1 = new Label();
            btnLimpiar = new Button();
            lblNombre1 = new Label();
            lblDni1 = new Label();
            chkAptoMedico = new CheckBox();
            lblApto = new Label();
            ((System.ComponentModel.ISupportInitialize)picSocio).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroSocios
            // 
            lblRegistroSocios.AutoSize = true;
            lblRegistroSocios.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroSocios.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistroSocios.Location = new Point(273, 55);
            lblRegistroSocios.Name = "lblRegistroSocios";
            lblRegistroSocios.Size = new Size(356, 40);
            lblRegistroSocios.TabIndex = 2;
            lblRegistroSocios.Text = "REGISTRO DE SOCIOS";
            lblRegistroSocios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picSocio
            // 
            picSocio.Image = (Image)resources.GetObject("picSocio.Image");
            picSocio.Location = new Point(541, 175);
            picSocio.Margin = new Padding(3, 4, 3, 4);
            picSocio.Name = "picSocio";
            picSocio.Size = new Size(207, 163);
            picSocio.SizeMode = PictureBoxSizeMode.Zoom;
            picSocio.TabIndex = 3;
            picSocio.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(157, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(157, 252);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(157, 355);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 12;
            lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(157, 276);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(246, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 183);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(157, 379);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(172, 27);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(595, 380);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 59);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(790, 33);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(406, 280);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(15, 20);
            lblApellido1.TabIndex = 21;
            lblApellido1.Text = "*";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(595, 468);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 59);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Location = new Point(406, 187);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(15, 20);
            lblNombre1.TabIndex = 24;
            lblNombre1.Text = "*";
            // 
            // lblDni1
            // 
            lblDni1.AutoSize = true;
            lblDni1.Location = new Point(336, 383);
            lblDni1.Name = "lblDni1";
            lblDni1.Size = new Size(15, 20);
            lblDni1.TabIndex = 25;
            lblDni1.Text = "*";
            // 
            // chkAptoMedico
            // 
            chkAptoMedico.AutoSize = true;
            chkAptoMedico.Location = new Point(157, 456);
            chkAptoMedico.Name = "chkAptoMedico";
            chkAptoMedico.Size = new Size(118, 24);
            chkAptoMedico.TabIndex = 26;
            chkAptoMedico.Text = "Apto Médico";
            chkAptoMedico.UseVisualStyleBackColor = true;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Location = new Point(272, 456);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(15, 20);
            lblApto.TabIndex = 27;
            lblApto.Text = "*";
            // 
            // Registro_socios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblApto);
            Controls.Add(chkAptoMedico);
            Controls.Add(lblDni1);
            Controls.Add(lblNombre1);
            Controls.Add(btnLimpiar);
            Controls.Add(lblApellido1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registro_socios";
            Text = "Registrar socio";
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
        private Label lblApellido1;
        private Button btnLimpiar;
        private Label lblNombre1;
        private Label lblDni1;
        private CheckBox chkAptoMedico;
        private Label lblApto;
    }
}