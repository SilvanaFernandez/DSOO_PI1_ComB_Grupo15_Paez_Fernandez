namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnReportesVtos = new Button();
            btnCobrosAct = new Button();
            btnGestionCuotas = new Button();
            btnRegistroSocio = new Button();
            btnRegistroNoSocios = new Button();
            lblPrincipal = new Label();
            picPpal1 = new PictureBox();
            picPpal2 = new PictureBox();
            btnSalir = new Button();
            lblDatosDeSesion = new Label();
            btnRegistroActividadSocio = new Button();
            ((System.ComponentModel.ISupportInitialize)picPpal1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPpal2).BeginInit();
            SuspendLayout();
            // 
            // btnReportesVtos
            // 
            btnReportesVtos.Location = new Point(526, 441);
            btnReportesVtos.Margin = new Padding(3, 4, 3, 4);
            btnReportesVtos.Name = "btnReportesVtos";
            btnReportesVtos.Size = new Size(113, 68);
            btnReportesVtos.TabIndex = 27;
            btnReportesVtos.Text = "Reportes de vtos del día";
            btnReportesVtos.UseVisualStyleBackColor = true;
            btnReportesVtos.Click += btnReportesVtos_Click;
            // 
            // btnCobrosAct
            // 
            btnCobrosAct.Location = new Point(526, 319);
            btnCobrosAct.Margin = new Padding(3, 4, 3, 4);
            btnCobrosAct.Name = "btnCobrosAct";
            btnCobrosAct.Size = new Size(113, 68);
            btnCobrosAct.TabIndex = 26;
            btnCobrosAct.Text = "Gestión de cobros por día";
            btnCobrosAct.UseVisualStyleBackColor = true;
            btnCobrosAct.Click += btnCobrosAct_Click;
            // 
            // btnGestionCuotas
            // 
            btnGestionCuotas.Location = new Point(526, 199);
            btnGestionCuotas.Margin = new Padding(3, 4, 3, 4);
            btnGestionCuotas.Name = "btnGestionCuotas";
            btnGestionCuotas.Size = new Size(113, 68);
            btnGestionCuotas.TabIndex = 25;
            btnGestionCuotas.Text = "Gestión de cuotas";
            btnGestionCuotas.UseVisualStyleBackColor = true;
            btnGestionCuotas.Click += btnGestionCuotas_Click;
            // 
            // btnRegistroSocio
            // 
            btnRegistroSocio.Location = new Point(275, 199);
            btnRegistroSocio.Margin = new Padding(3, 4, 3, 4);
            btnRegistroSocio.Name = "btnRegistroSocio";
            btnRegistroSocio.Size = new Size(113, 68);
            btnRegistroSocio.TabIndex = 24;
            btnRegistroSocio.Text = "Registro de Socios";
            btnRegistroSocio.UseVisualStyleBackColor = true;
            btnRegistroSocio.Click += btnRegistroSocio_Click;
            // 
            // btnRegistroNoSocios
            // 
            btnRegistroNoSocios.Location = new Point(275, 319);
            btnRegistroNoSocios.Margin = new Padding(3, 4, 3, 4);
            btnRegistroNoSocios.Name = "btnRegistroNoSocios";
            btnRegistroNoSocios.Size = new Size(113, 68);
            btnRegistroNoSocios.TabIndex = 23;
            btnRegistroNoSocios.Text = "Registro de No Socios";
            btnRegistroNoSocios.UseVisualStyleBackColor = true;
            btnRegistroNoSocios.Click += btnRegistroNoSocios_Click;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrincipal.ForeColor = SystemColors.ActiveCaptionText;
            lblPrincipal.Location = new Point(295, 83);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new Size(321, 40);
            lblPrincipal.TabIndex = 22;
            lblPrincipal.Text = "\"CLUB DEPORTIVO\"";
            lblPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picPpal1
            // 
            picPpal1.Image = (Image)resources.GetObject("picPpal1.Image");
            picPpal1.Location = new Point(33, 163);
            picPpal1.Margin = new Padding(3, 4, 3, 4);
            picPpal1.Name = "picPpal1";
            picPpal1.Size = new Size(195, 305);
            picPpal1.SizeMode = PictureBoxSizeMode.Zoom;
            picPpal1.TabIndex = 28;
            picPpal1.TabStop = false;
            // 
            // picPpal2
            // 
            picPpal2.Image = (Image)resources.GetObject("picPpal2.Image");
            picPpal2.Location = new Point(680, 175);
            picPpal2.Margin = new Padding(3, 4, 3, 4);
            picPpal2.Name = "picPpal2";
            picPpal2.Size = new Size(195, 305);
            picPpal2.SizeMode = PictureBoxSizeMode.Zoom;
            picPpal2.TabIndex = 29;
            picPpal2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(790, 21);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblDatosDeSesion
            // 
            lblDatosDeSesion.AutoSize = true;
            lblDatosDeSesion.Location = new Point(40, 32);
            lblDatosDeSesion.Name = "lblDatosDeSesion";
            lblDatosDeSesion.Size = new Size(114, 20);
            lblDatosDeSesion.TabIndex = 32;
            lblDatosDeSesion.Text = "Datos de sesión";
            // 
            // btnRegistroActividadSocio
            // 
            btnRegistroActividadSocio.Location = new Point(275, 438);
            btnRegistroActividadSocio.Name = "btnRegistroActividadSocio";
            btnRegistroActividadSocio.Size = new Size(113, 70);
            btnRegistroActividadSocio.TabIndex = 33;
            btnRegistroActividadSocio.Text = "Registro Actividad Socio";
            btnRegistroActividadSocio.UseVisualStyleBackColor = true;
            btnRegistroActividadSocio.Click += btnRegistroActividadSocio_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRegistroActividadSocio);
            Controls.Add(lblDatosDeSesion);
            Controls.Add(btnSalir);
            Controls.Add(picPpal2);
            Controls.Add(picPpal1);
            Controls.Add(btnReportesVtos);
            Controls.Add(btnCobrosAct);
            Controls.Add(btnGestionCuotas);
            Controls.Add(btnRegistroSocio);
            Controls.Add(btnRegistroNoSocios);
            Controls.Add(lblPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)picPpal1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPpal2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReportesVtos;
        private Button btnCobrosAct;
        private Button btnGestionCuotas;
        private Button btnRegistroSocio;
        private Button btnRegistroNoSocios;
        private Label lblPrincipal;
        private PictureBox picPpal1;
        private PictureBox picPpal2;
        private Button btnSalir;
        private Label lblDatosDeSesion;
        private Button btnRegistroActividadSocio;
    }
}