namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class Gestion_cuota
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNroSocio1 = new TextBox();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtFechaUltPago = new TextBox();
            lblFechaUltPago = new Label();
            txtNroSocio2 = new TextBox();
            lblNroSocio2 = new Label();
            txtProxVto = new TextBox();
            txtFecha = new TextBox();
            lblImporte = new Label();
            txtImporte = new TextBox();
            btnVolver = new Button();
            lblTituloPpal = new Label();
            lblSubtitulo1 = new Label();
            lblNroSocio1 = new Label();
            lblSubtitulo2 = new Label();
            lblFecha = new Label();
            lblProxVto = new Label();
            lblNombreApellido1 = new Label();
            txtNombreApellido1 = new TextBox();
            lblNombreApellido2 = new Label();
            txtNombreApellido2 = new TextBox();
            btnLimpiar = new Button();
            btnRegEmitirRecibo = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            btnCarnetSocio = new Button();
            rdbtnEfectivo = new RadioButton();
            rdbtnCredito = new RadioButton();
            SuspendLayout();
            // 
            // txtNroSocio1
            // 
            txtNroSocio1.Location = new Point(93, 130);
            txtNroSocio1.Name = "txtNroSocio1";
            txtNroSocio1.Size = new Size(139, 23);
            txtNroSocio1.TabIndex = 0;
            txtNroSocio1.TextChanged += txtNroSocio1_TextChanged;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(93, 194);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(139, 23);
            txtEstado.TabIndex = 2;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(93, 176);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // txtFechaUltPago
            // 
            txtFechaUltPago.Location = new Point(288, 194);
            txtFechaUltPago.Name = "txtFechaUltPago";
            txtFechaUltPago.Size = new Size(139, 23);
            txtFechaUltPago.TabIndex = 3;
            // 
            // lblFechaUltPago
            // 
            lblFechaUltPago.AutoSize = true;
            lblFechaUltPago.Location = new Point(290, 179);
            lblFechaUltPago.Name = "lblFechaUltPago";
            lblFechaUltPago.Size = new Size(137, 15);
            lblFechaUltPago.TabIndex = 8;
            lblFechaUltPago.Text = "Vto última cuota pagada";
            // 
            // txtNroSocio2
            // 
            txtNroSocio2.Location = new Point(69, 309);
            txtNroSocio2.Name = "txtNroSocio2";
            txtNroSocio2.Size = new Size(107, 23);
            txtNroSocio2.TabIndex = 4;
            txtNroSocio2.TextChanged += txtNroSocio2_TextChanged;
            // 
            // lblNroSocio2
            // 
            lblNroSocio2.AutoSize = true;
            lblNroSocio2.Location = new Point(69, 291);
            lblNroSocio2.Name = "lblNroSocio2";
            lblNroSocio2.Size = new Size(59, 15);
            lblNroSocio2.TabIndex = 11;
            lblNroSocio2.Text = "Nro Socio";
            // 
            // txtProxVto
            // 
            txtProxVto.Location = new Point(368, 378);
            txtProxVto.Name = "txtProxVto";
            txtProxVto.Size = new Size(139, 23);
            txtProxVto.TabIndex = 9;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(206, 378);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(139, 23);
            txtFecha.TabIndex = 8;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(69, 360);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(49, 15);
            lblImporte.TabIndex = 28;
            lblImporte.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(69, 378);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(107, 23);
            txtImporte.TabIndex = 7;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(690, 22);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTituloPpal
            // 
            lblTituloPpal.AutoSize = true;
            lblTituloPpal.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloPpal.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloPpal.Location = new Point(223, 22);
            lblTituloPpal.Name = "lblTituloPpal";
            lblTituloPpal.Size = new Size(284, 31);
            lblTituloPpal.TabIndex = 31;
            lblTituloPpal.Text = "GESTIÓN DE CUOTAS";
            lblTituloPpal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo1
            // 
            lblSubtitulo1.AutoSize = true;
            lblSubtitulo1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtitulo1.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtitulo1.Location = new Point(59, 63);
            lblSubtitulo1.Name = "lblSubtitulo1";
            lblSubtitulo1.Size = new Size(276, 31);
            lblSubtitulo1.TabIndex = 32;
            lblSubtitulo1.Text = "Ver estado de cuota:";
            lblSubtitulo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNroSocio1
            // 
            lblNroSocio1.AutoSize = true;
            lblNroSocio1.Location = new Point(93, 112);
            lblNroSocio1.Name = "lblNroSocio1";
            lblNroSocio1.Size = new Size(59, 15);
            lblNroSocio1.TabIndex = 33;
            lblNroSocio1.Text = "Nro Socio";
            // 
            // lblSubtitulo2
            // 
            lblSubtitulo2.AutoSize = true;
            lblSubtitulo2.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtitulo2.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtitulo2.Location = new Point(59, 241);
            lblSubtitulo2.Name = "lblSubtitulo2";
            lblSubtitulo2.Size = new Size(320, 31);
            lblSubtitulo2.TabIndex = 34;
            lblSubtitulo2.Text = "Registrar pago de cuota:";
            lblSubtitulo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(206, 360);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 35;
            lblFecha.Text = "Fecha";
            // 
            // lblProxVto
            // 
            lblProxVto.AutoSize = true;
            lblProxVto.Location = new Point(368, 360);
            lblProxVto.Name = "lblProxVto";
            lblProxVto.Size = new Size(121, 15);
            lblProxVto.TabIndex = 36;
            lblProxVto.Text = "Próximo vencimiento";
            // 
            // lblNombreApellido1
            // 
            lblNombreApellido1.AutoSize = true;
            lblNombreApellido1.Location = new Point(290, 112);
            lblNombreApellido1.Name = "lblNombreApellido1";
            lblNombreApellido1.Size = new Size(107, 15);
            lblNombreApellido1.TabIndex = 37;
            lblNombreApellido1.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido1
            // 
            txtNombreApellido1.Location = new Point(288, 130);
            txtNombreApellido1.Name = "txtNombreApellido1";
            txtNombreApellido1.Size = new Size(251, 23);
            txtNombreApellido1.TabIndex = 1;
            // 
            // lblNombreApellido2
            // 
            lblNombreApellido2.AutoSize = true;
            lblNombreApellido2.Location = new Point(206, 291);
            lblNombreApellido2.Name = "lblNombreApellido2";
            lblNombreApellido2.Size = new Size(107, 15);
            lblNombreApellido2.TabIndex = 39;
            lblNombreApellido2.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido2
            // 
            txtNombreApellido2.Location = new Point(206, 309);
            txtNombreApellido2.Name = "txtNombreApellido2";
            txtNombreApellido2.Size = new Size(237, 23);
            txtNombreApellido2.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(609, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegEmitirRecibo
            // 
            btnRegEmitirRecibo.Location = new Point(660, 285);
            btnRegEmitirRecibo.Name = "btnRegEmitirRecibo";
            btnRegEmitirRecibo.Size = new Size(105, 55);
            btnRegEmitirRecibo.TabIndex = 10;
            btnRegEmitirRecibo.Text = "Registrar y emitir recibo";
            btnRegEmitirRecibo.UseVisualStyleBackColor = true;
            btnRegEmitirRecibo.Click += btnRegEmitirRecibo_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(467, 291);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 43;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(467, 309);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(130, 23);
            txtDni.TabIndex = 6;
            // 
            // btnCarnetSocio
            // 
            btnCarnetSocio.Location = new Point(660, 346);
            btnCarnetSocio.Name = "btnCarnetSocio";
            btnCarnetSocio.Size = new Size(105, 55);
            btnCarnetSocio.TabIndex = 11;
            btnCarnetSocio.Text = "Generar carnet";
            btnCarnetSocio.UseVisualStyleBackColor = true;
            btnCarnetSocio.Click += btnCarnetSocio_Click;
            // 
            // rdbtnEfectivo
            // 
            rdbtnEfectivo.AutoSize = true;
            rdbtnEfectivo.Location = new Point(531, 356);
            rdbtnEfectivo.Name = "rdbtnEfectivo";
            rdbtnEfectivo.Size = new Size(67, 19);
            rdbtnEfectivo.TabIndex = 44;
            rdbtnEfectivo.TabStop = true;
            rdbtnEfectivo.Text = "Efectivo";
            rdbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbtnCredito
            // 
            rdbtnCredito.AutoSize = true;
            rdbtnCredito.Location = new Point(531, 382);
            rdbtnCredito.Name = "rdbtnCredito";
            rdbtnCredito.Size = new Size(115, 19);
            rdbtnCredito.TabIndex = 45;
            rdbtnCredito.TabStop = true;
            rdbtnCredito.Text = "Tarjeta de crédito";
            rdbtnCredito.UseVisualStyleBackColor = true;
            // 
            // Gestion_cuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdbtnCredito);
            Controls.Add(rdbtnEfectivo);
            Controls.Add(btnCarnetSocio);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnRegEmitirRecibo);
            Controls.Add(btnLimpiar);
            Controls.Add(txtNombreApellido2);
            Controls.Add(lblNombreApellido2);
            Controls.Add(txtNombreApellido1);
            Controls.Add(lblNombreApellido1);
            Controls.Add(lblProxVto);
            Controls.Add(lblFecha);
            Controls.Add(lblSubtitulo2);
            Controls.Add(lblNroSocio1);
            Controls.Add(lblSubtitulo1);
            Controls.Add(lblTituloPpal);
            Controls.Add(btnVolver);
            Controls.Add(txtImporte);
            Controls.Add(lblImporte);
            Controls.Add(txtFecha);
            Controls.Add(txtProxVto);
            Controls.Add(lblNroSocio2);
            Controls.Add(txtNroSocio2);
            Controls.Add(lblFechaUltPago);
            Controls.Add(txtFechaUltPago);
            Controls.Add(lblEstado);
            Controls.Add(txtEstado);
            Controls.Add(txtNroSocio1);
            Name = "Gestion_cuota";
            Text = "Cobrar_cuota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNroSocio1;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtFechaUltPago;
        private Label lblFechaUltPago;
        private TextBox txtNroSocio2;
        private Label lblNroSocio2;
        private Label label9;
        private TextBox txtProxVto;
        private TextBox txtFecha;
        private Label lblImporte;
        private TextBox txtImporte;
        private Button btnVolver;
        private Label lblTituloPpal;
        private Label lblSubtitulo1;
        private Label lblNroSocio1;
        private Label lblSubtitulo2;
        private Label lblFecha;
        private Label lblProxVto;
        private Label lblNombreApellido1;
        private TextBox txtNombreApellido1;
        private Label lblNombreApellido2;
        private TextBox txtNombreApellido2;
        private Button btnLimpiar;
        private Button btnRegEmitirRecibo;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnCarnetSocio;
        private RadioButton rdbtnEfectivo;
        private RadioButton rdbtnCredito;
    }
}
