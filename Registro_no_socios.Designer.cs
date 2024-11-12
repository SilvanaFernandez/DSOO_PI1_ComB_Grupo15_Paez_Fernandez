namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class Registro_no_socios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_no_socios));
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            picNoSocio = new PictureBox();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            lblNombre1 = new Label();
            lblDni1 = new Label();
            lblApellido1 = new Label();
            lblRegistroNoSocio = new Label();
            chkAptoMedico = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picNoSocio).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(583, 376);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 59);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 199);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(146, 289);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(246, 27);
            txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(146, 259);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(146, 175);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // picNoSocio
            // 
            picNoSocio.Image = (Image)resources.GetObject("picNoSocio.Image");
            picNoSocio.Location = new Point(529, 171);
            picNoSocio.Margin = new Padding(3, 4, 3, 4);
            picNoSocio.Name = "picNoSocio";
            picNoSocio.Size = new Size(207, 163);
            picNoSocio.SizeMode = PictureBoxSizeMode.Zoom;
            picNoSocio.TabIndex = 18;
            picNoSocio.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(583, 475);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 59);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(784, 36);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(146, 352);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 28;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(146, 376);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(158, 27);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Location = new Point(400, 203);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(15, 20);
            lblNombre1.TabIndex = 30;
            lblNombre1.Text = "*";
            // 
            // lblDni1
            // 
            lblDni1.AutoSize = true;
            lblDni1.Location = new Point(312, 380);
            lblDni1.Name = "lblDni1";
            lblDni1.Size = new Size(15, 20);
            lblDni1.TabIndex = 31;
            lblDni1.Text = "*";
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(400, 293);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(15, 20);
            lblApellido1.TabIndex = 32;
            lblApellido1.Text = "*";
            // 
            // lblRegistroNoSocio
            // 
            lblRegistroNoSocio.AutoSize = true;
            lblRegistroNoSocio.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroNoSocio.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistroNoSocio.Location = new Point(247, 75);
            lblRegistroNoSocio.Name = "lblRegistroNoSocio";
            lblRegistroNoSocio.Size = new Size(419, 40);
            lblRegistroNoSocio.TabIndex = 33;
            lblRegistroNoSocio.Text = "REGISTRO DE NO SOCIOS";
            lblRegistroNoSocio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkAptoMedico
            // 
            chkAptoMedico.AutoSize = true;
            chkAptoMedico.Location = new Point(146, 450);
            chkAptoMedico.Name = "chkAptoMedico";
            chkAptoMedico.Size = new Size(118, 24);
            chkAptoMedico.TabIndex = 34;
            chkAptoMedico.Text = "Apto Medico";
            chkAptoMedico.UseVisualStyleBackColor = true;
            // 
            // Registro_no_socios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(chkAptoMedico);
            Controls.Add(lblRegistroNoSocio);
            Controls.Add(lblApellido1);
            Controls.Add(lblDni1);
            Controls.Add(lblNombre1);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(picNoSocio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registro_no_socios";
            Text = "Registro_no_socios";
            ((System.ComponentModel.ISupportInitialize)picNoSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
        private PictureBox picNoSocio;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblNombre1;
        private Label lblDni1;
        private Label lblApellido1;
        private Label lblRegistroNoSocio;
        private CheckBox chkAptoMedico;
    }
}