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
            rdbtnCredito = new RadioButton();
            rdbtnEfectivo = new RadioButton();
            lblMetodoDePago = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(201, 95);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE COBROS POR DÍA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtitulo.Location = new Point(62, 188);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(443, 40);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "Registrar pago de actividad:";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNroNoSocio
            // 
            txtNroNoSocio.Location = new Point(148, 293);
            txtNroNoSocio.Margin = new Padding(3, 4, 3, 4);
            txtNroNoSocio.Name = "txtNroNoSocio";
            txtNroNoSocio.Size = new Size(117, 27);
            txtNroNoSocio.TabIndex = 0;
            txtNroNoSocio.TextChanged += txtNroNoSocio_TextChanged;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(235, 455);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(62, 20);
            lblImporte.TabIndex = 13;
            lblImporte.Text = "Importe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 455);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 12;
            label2.Text = "Actividad";
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.ItemHeight = 20;
            cboActividad.Items.AddRange(new object[] { "Musculación", "CrossFit", "Spinning", "Funcional", "Yoga", "Pilates", "Zumba", "Strong" });
            cboActividad.Location = new Point(47, 479);
            cboActividad.Margin = new Padding(3, 4, 3, 4);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(151, 28);
            cboActividad.TabIndex = 14;
            cboActividad.Text = "Actividad";
            cboActividad.SelectedIndexChanged += cboActividad_SelectedIndexChanged;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(235, 479);
            txtImporte.Margin = new Padding(3, 4, 3, 4);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(158, 27);
            txtImporte.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(789, 35);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNroNoSocio
            // 
            lblNroNoSocio.AutoSize = true;
            lblNroNoSocio.Location = new Point(148, 269);
            lblNroNoSocio.Name = "lblNroNoSocio";
            lblNroNoSocio.Size = new Size(70, 20);
            lblNroNoSocio.TabIndex = 29;
            lblNroNoSocio.Text = "No Socio";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(47, 362);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(136, 20);
            lblNombreApellido.TabIndex = 30;
            lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(47, 385);
            txtNombreApellido.Margin = new Padding(3, 4, 3, 4);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(316, 27);
            txtNombreApellido.TabIndex = 2;
            // 
            // btnRegEmitirRecibo
            // 
            btnRegEmitirRecibo.Location = new Point(755, 375);
            btnRegEmitirRecibo.Margin = new Padding(3, 4, 3, 4);
            btnRegEmitirRecibo.Name = "btnRegEmitirRecibo";
            btnRegEmitirRecibo.Size = new Size(120, 68);
            btnRegEmitirRecibo.TabIndex = 7;
            btnRegEmitirRecibo.Text = "Registrar y emitir recibo";
            btnRegEmitirRecibo.UseVisualStyleBackColor = true;
            btnRegEmitirRecibo.Click += btnRegEmitirRecibo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(696, 35);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(337, 269);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 34;
            lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(337, 293);
            txtFecha.Margin = new Padding(3, 4, 3, 4);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(129, 27);
            txtFecha.TabIndex = 1;
            // 
            // btnCarnetNoSocio
            // 
            btnCarnetNoSocio.Location = new Point(755, 451);
            btnCarnetNoSocio.Margin = new Padding(3, 4, 3, 4);
            btnCarnetNoSocio.Name = "btnCarnetNoSocio";
            btnCarnetNoSocio.Size = new Size(120, 59);
            btnCarnetNoSocio.TabIndex = 8;
            btnCarnetNoSocio.Text = "Generar carnet";
            btnCarnetNoSocio.UseVisualStyleBackColor = true;
            btnCarnetNoSocio.Click += btnCarnetNoSocio_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(400, 362);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 37;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(400, 386);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(154, 27);
            txtDni.TabIndex = 3;
            // 
            // txtCupoDisp
            // 
            txtCupoDisp.Location = new Point(440, 479);
            txtCupoDisp.Margin = new Padding(3, 4, 3, 4);
            txtCupoDisp.Name = "txtCupoDisp";
            txtCupoDisp.Size = new Size(114, 27);
            txtCupoDisp.TabIndex = 6;
            // 
            // lblCupoDisp
            // 
            lblCupoDisp.AutoSize = true;
            lblCupoDisp.Location = new Point(440, 457);
            lblCupoDisp.Name = "lblCupoDisp";
            lblCupoDisp.Size = new Size(120, 20);
            lblCupoDisp.TabIndex = 40;
            lblCupoDisp.Text = "Cupo Disponible";
            // 
            // rdbtnCredito
            // 
            rdbtnCredito.AutoSize = true;
            rdbtnCredito.Location = new Point(573, 325);
            rdbtnCredito.Margin = new Padding(3, 4, 3, 4);
            rdbtnCredito.Name = "rdbtnCredito";
            rdbtnCredito.Size = new Size(146, 24);
            rdbtnCredito.TabIndex = 47;
            rdbtnCredito.TabStop = true;
            rdbtnCredito.Text = "Tarjeta de crédito";
            rdbtnCredito.UseVisualStyleBackColor = true;
            // 
            // rdbtnEfectivo
            // 
            rdbtnEfectivo.AutoSize = true;
            rdbtnEfectivo.Location = new Point(573, 293);
            rdbtnEfectivo.Margin = new Padding(3, 4, 3, 4);
            rdbtnEfectivo.Name = "rdbtnEfectivo";
            rdbtnEfectivo.Size = new Size(83, 24);
            rdbtnEfectivo.TabIndex = 46;
            rdbtnEfectivo.TabStop = true;
            rdbtnEfectivo.Text = "Efectivo";
            rdbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMetodoDePago
            // 
            lblMetodoDePago.AutoSize = true;
            lblMetodoDePago.Location = new Point(573, 260);
            lblMetodoDePago.Name = "lblMetodoDePago";
            lblMetodoDePago.Size = new Size(120, 20);
            lblMetodoDePago.TabIndex = 48;
            lblMetodoDePago.Text = "Método de Pago";
            // 
            // Cobrar_por_actividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblMetodoDePago);
            Controls.Add(rdbtnCredito);
            Controls.Add(rdbtnEfectivo);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cobrar_por_actividad";
            Text = "Cobrar por actividad no socios";
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
        private RadioButton rdbtnCredito;
        private RadioButton rdbtnEfectivo;
        private Label lblMetodoDePago;
    }
}