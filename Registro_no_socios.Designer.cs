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
            lblRegistroNoSocio = new Label();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            lblNombre1 = new Label();
            lblDni1 = new Label();
            lblApellido1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picNoSocio).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(510, 282);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 44);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 23;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 227);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(216, 23);
            txtApellido.TabIndex = 22;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(128, 205);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(128, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // picNoSocio
            // 
            picNoSocio.Image = (Image)resources.GetObject("picNoSocio.Image");
            picNoSocio.Location = new Point(463, 128);
            picNoSocio.Name = "picNoSocio";
            picNoSocio.Size = new Size(181, 122);
            picNoSocio.SizeMode = PictureBoxSizeMode.Zoom;
            picNoSocio.TabIndex = 18;
            picNoSocio.TabStop = false;
            // 
            // lblRegistroNoSocio
            // 
            lblRegistroNoSocio.AutoSize = true;
            lblRegistroNoSocio.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroNoSocio.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistroNoSocio.Location = new Point(198, 54);
            lblRegistroNoSocio.Name = "lblRegistroNoSocio";
            lblRegistroNoSocio.Size = new Size(341, 31);
            lblRegistroNoSocio.TabIndex = 17;
            lblRegistroNoSocio.Text = "REGISTRO DE NO SOCIOS";
            lblRegistroNoSocio.TextAlign = ContentAlignment.MiddleCenter;
            lblRegistroNoSocio.Click += lblRegistroNoSocio_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(510, 356);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 44);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(686, 27);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(128, 303);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 28;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(128, 321);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(139, 23);
            txtDni.TabIndex = 29;
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Location = new Point(350, 149);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(12, 15);
            lblNombre1.TabIndex = 30;
            lblNombre1.Text = "*";
            // 
            // lblDni1
            // 
            lblDni1.AutoSize = true;
            lblDni1.Location = new Point(273, 324);
            lblDni1.Name = "lblDni1";
            lblDni1.Size = new Size(12, 15);
            lblDni1.TabIndex = 31;
            lblDni1.Text = "*";
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(350, 230);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(12, 15);
            lblApellido1.TabIndex = 32;
            lblApellido1.Text = "*";
            // 
            // Registro_no_socios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(lblRegistroNoSocio);
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
        private Label lblRegistroNoSocio;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblNombre1;
        private Label lblDni1;
        private Label lblApellido1;
    }
}