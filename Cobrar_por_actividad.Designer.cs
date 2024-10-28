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
            btnVolver = new Button();
            lblNroNoSocio = new Label();
            lblNombreApellido = new Label();
            txtNombreApellido = new TextBox();
            btnRegEmitirRecibo = new Button();
            btnLimpiar = new Button();
            lblFecha = new Label();
            txtFecha = new TextBox();
            btnCarnetNoSocio = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            txtCupoDisp = new TextBox();
            lblCupoDisp = new Label();
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
            txtNroNoSocio.Location = new Point(155, 224);
            txtNroNoSocio.Name = "txtNroNoSocio";
            txtNroNoSocio.Size = new Size(103, 23);
            txtNroNoSocio.TabIndex = 11;
            txtNroNoSocio.TextChanged += txtNroNoSocio_TextChanged;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(219, 341);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(49, 15);
            lblImporte.TabIndex = 13;
            lblImporte.Text = "Importe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 341);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Actividad";
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "Musculación", "CrossFit", "Spinning", "Funcional", "Yoga", "Pilates", "Zumba", "Strong" });
            cboActividad.Location = new Point(54, 359);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(133, 23);
            cboActividad.TabIndex = 14;
            cboActividad.Text = "Actividad";
            cboActividad.SelectedIndexChanged += cboActividad_SelectedIndexChanged;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(219, 359);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(139, 23);
            txtImporte.TabIndex = 15;
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
            lblNroNoSocio.Location = new Point(155, 206);
            lblNroNoSocio.Name = "lblNroNoSocio";
            lblNroNoSocio.Size = new Size(55, 15);
            lblNroNoSocio.TabIndex = 29;
            lblNroNoSocio.Text = "No Socio";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(54, 273);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(107, 15);
            lblNombreApellido.TabIndex = 30;
            lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(54, 290);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(277, 23);
            txtNombreApellido.TabIndex = 31;
            // 
            // btnRegEmitirRecibo
            // 
            btnRegEmitirRecibo.Location = new Point(558, 224);
            btnRegEmitirRecibo.Name = "btnRegEmitirRecibo";
            btnRegEmitirRecibo.Size = new Size(105, 51);
            btnRegEmitirRecibo.TabIndex = 32;
            btnRegEmitirRecibo.Text = "Registrar y emitir recibo";
            btnRegEmitirRecibo.UseVisualStyleBackColor = true;
            btnRegEmitirRecibo.Click += btnRegEmitirRecibo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(609, 26);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(320, 206);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 34;
            lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(320, 224);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(113, 23);
            txtFecha.TabIndex = 35;
            // 
            // btnCarnetNoSocio
            // 
            btnCarnetNoSocio.Location = new Point(558, 312);
            btnCarnetNoSocio.Name = "btnCarnetNoSocio";
            btnCarnetNoSocio.Size = new Size(105, 44);
            btnCarnetNoSocio.TabIndex = 36;
            btnCarnetNoSocio.Text = "Generar carnet";
            btnCarnetNoSocio.UseVisualStyleBackColor = true;
            btnCarnetNoSocio.Click += btnCarnetNoSocio_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(363, 273);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 37;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(363, 291);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(135, 23);
            txtDni.TabIndex = 38;
            // 
            // txtCupoDisp
            // 
            txtCupoDisp.Location = new Point(398, 359);
            txtCupoDisp.Name = "txtCupoDisp";
            txtCupoDisp.Size = new Size(100, 23);
            txtCupoDisp.TabIndex = 39;
            // 
            // lblCupoDisp
            // 
            lblCupoDisp.AutoSize = true;
            lblCupoDisp.Location = new Point(398, 343);
            lblCupoDisp.Name = "lblCupoDisp";
            lblCupoDisp.Size = new Size(95, 15);
            lblCupoDisp.TabIndex = 40;
            lblCupoDisp.Text = "Cupo Disponible";
            // 
            // Cobrar_por_actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCupoDisp);
            Controls.Add(txtCupoDisp);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnCarnetNoSocio);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegEmitirRecibo);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblNombreApellido);
            Controls.Add(lblNroNoSocio);
            Controls.Add(btnVolver);
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
        private Button btnVolver;
        private Label lblNroNoSocio;
        private Label lblNombreApellido;
        private TextBox txtNombreApellido;
        private Button btnRegEmitirRecibo;
        private Button btnLimpiar;
        private Label lblFecha;
        private TextBox txtFecha;
        private Button btnCarnetNoSocio;
        private Label lblDni;
        private TextBox txtDni;
        private TextBox txtCupoDisp;
        private Label lblCupoDisp;
    }
}