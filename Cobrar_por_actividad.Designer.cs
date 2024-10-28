namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class Cobrar_por_actividad
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtNroNoSocio = new TextBox();
            lblImporte = new Label();
            label2 = new Label();
            cboActividad = new ComboBox();
            txtImporte = new TextBox();
            btnCarnet = new Button();
            btnVolver = new Button();
            lblNroNoSocio = new Label();
            lblNombreApellido = new Label();
            txtNombreApellido = new TextBox();
            btnRegEmitirRecibo = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(176, 71);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(407, 31);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE COBROS POR DÍA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtitulo.Location = new Point(54, 141);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(360, 31);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "Registrar pago de actividad:";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNroNoSocio
            // 
            txtNroNoSocio.Location = new Point(100, 224);
            txtNroNoSocio.Name = "txtNroNoSocio";
            txtNroNoSocio.Size = new Size(139, 23);
            txtNroNoSocio.TabIndex = 11;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(292, 298);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(49, 15);
            lblImporte.TabIndex = 13;
            lblImporte.Text = "Importe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 298);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Actividad";
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "Musculación", "CrossFit", "Spinning", "Funcional", "Yoga", "Pilates", "Zumba", "Strong" });
            cboActividad.Location = new Point(100, 316);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(133, 23);
            cboActividad.TabIndex = 14;
            cboActividad.Text = "Actividad";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(292, 316);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(139, 23);
            txtImporte.TabIndex = 15;
            // 
            // btnCarnet
            // 
            btnCarnet.Location = new Point(600, 298);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(105, 44);
            btnCarnet.TabIndex = 27;
            btnCarnet.Text = "Generar carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(690, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 28;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNroNoSocio
            // 
            lblNroNoSocio.AutoSize = true;
            lblNroNoSocio.Location = new Point(100, 206);
            lblNroNoSocio.Name = "lblNroNoSocio";
            lblNroNoSocio.Size = new Size(55, 15);
            lblNroNoSocio.TabIndex = 29;
            lblNroNoSocio.Text = "No Socio";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(292, 206);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(107, 15);
            lblNombreApellido.TabIndex = 30;
            lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(292, 224);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(243, 23);
            txtNombreApellido.TabIndex = 31;
            // 
            // btnRegEmitirRecibo
            // 
            btnRegEmitirRecibo.Location = new Point(600, 209);
            btnRegEmitirRecibo.Name = "btnRegEmitirRecibo";
            btnRegEmitirRecibo.Size = new Size(105, 51);
            btnRegEmitirRecibo.TabIndex = 32;
            btnRegEmitirRecibo.Text = "Registrar y emitir recibo";
            btnRegEmitirRecibo.UseVisualStyleBackColor = true;
            btnRegEmitirRecibo.Click += btnRegEmitirRecibo_Click;
            // 
            // Cobrar_por_actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegEmitirRecibo);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblNombreApellido);
            Controls.Add(lblNroNoSocio);
            Controls.Add(btnVolver);
            Controls.Add(btnCarnet);
            Controls.Add(txtImporte);
            Controls.Add(cboActividad);
            Controls.Add(lblImporte);
            Controls.Add(label2);
            Controls.Add(txtNroNoSocio);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "Cobrar_por_actividad";
            Text = "Cobrar_por_actividad";
            Load += Cobrar_por_actividad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private TextBox txtNroNoSocio;
        private Label lblImporte;
        private Label label2;
        private ComboBox cboActividad;
        private TextBox txtImporte;
        private Button button1;
        private Button btnCarnet;
        private Button btnVolver;
        private Label lblNroNoSocio;
        private Label lblNombreApellido;
        private TextBox txtNombreApellido;
        private Button btnRegEmitirRecibo;
    }
}