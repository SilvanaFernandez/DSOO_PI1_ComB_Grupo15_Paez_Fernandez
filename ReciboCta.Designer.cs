namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class ReciboCta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboCta));
            pnlReciboCuota = new Panel();
            lblTexto4 = new Label();
            lblTexto3 = new Label();
            lblFirma = new Label();
            txtMotivo = new TextBox();
            picFirma = new PictureBox();
            txtNombreApellido = new TextBox();
            txtFecha = new TextBox();
            lblTexto2 = new Label();
            lblFecha = new Label();
            txtNroRecibo = new TextBox();
            lblNroRecibo = new Label();
            btnImprimir = new Button();
            txtImporte = new TextBox();
            pnlReciboCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFirma).BeginInit();
            SuspendLayout();
            // 
            // pnlReciboCuota
            // 
            pnlReciboCuota.BackColor = SystemColors.ButtonHighlight;
            pnlReciboCuota.Controls.Add(txtImporte);
            pnlReciboCuota.Controls.Add(lblTexto4);
            pnlReciboCuota.Controls.Add(lblTexto3);
            pnlReciboCuota.Controls.Add(lblFirma);
            pnlReciboCuota.Controls.Add(txtMotivo);
            pnlReciboCuota.Controls.Add(picFirma);
            pnlReciboCuota.Controls.Add(txtNombreApellido);
            pnlReciboCuota.Controls.Add(txtFecha);
            pnlReciboCuota.Controls.Add(lblTexto2);
            pnlReciboCuota.Controls.Add(lblFecha);
            pnlReciboCuota.Controls.Add(txtNroRecibo);
            pnlReciboCuota.Controls.Add(lblNroRecibo);
            pnlReciboCuota.Location = new Point(153, 78);
            pnlReciboCuota.Name = "pnlReciboCuota";
            pnlReciboCuota.Size = new Size(371, 274);
            pnlReciboCuota.TabIndex = 0;
            // 
            // lblTexto4
            // 
            lblTexto4.AutoSize = true;
            lblTexto4.Location = new Point(20, 151);
            lblTexto4.Name = "lblTexto4";
            lblTexto4.Size = new Size(74, 15);
            lblTexto4.TabIndex = 15;
            lblTexto4.Text = "por pago de:";
            // 
            // lblTexto3
            // 
            lblTexto3.AutoSize = true;
            lblTexto3.Location = new Point(19, 116);
            lblTexto3.Name = "lblTexto3";
            lblTexto3.Size = new Size(70, 15);
            lblTexto3.TabIndex = 14;
            lblTexto3.Text = "La suma de:";
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = true;
            lblFirma.Location = new Point(206, 245);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(136, 15);
            lblFirma.TabIndex = 13;
            lblFirma.Text = "Club Deportivo \"Fitness\"";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = SystemColors.Control;
            txtMotivo.BorderStyle = BorderStyle.None;
            txtMotivo.Location = new Point(95, 151);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(250, 16);
            txtMotivo.TabIndex = 12;
            // 
            // picFirma
            // 
            picFirma.BackgroundImageLayout = ImageLayout.None;
            picFirma.Image = (Image)resources.GetObject("picFirma.Image");
            picFirma.Location = new Point(234, 191);
            picFirma.Name = "picFirma";
            picFirma.Size = new Size(75, 42);
            picFirma.SizeMode = PictureBoxSizeMode.Zoom;
            picFirma.TabIndex = 9;
            picFirma.TabStop = false;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.BackColor = SystemColors.Control;
            txtNombreApellido.BorderStyle = BorderStyle.None;
            txtNombreApellido.Location = new Point(84, 78);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(262, 16);
            txtNombreApellido.TabIndex = 7;
            // 
            // txtFecha
            // 
            txtFecha.BackColor = SystemColors.Control;
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Location = new Point(252, 18);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(94, 16);
            txtFecha.TabIndex = 6;
            // 
            // lblTexto2
            // 
            lblTexto2.AutoSize = true;
            lblTexto2.Location = new Point(20, 78);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(58, 15);
            lblTexto2.TabIndex = 5;
            lblTexto2.Text = "Recibi de:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(206, 18);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // txtNroRecibo
            // 
            txtNroRecibo.BackColor = SystemColors.Control;
            txtNroRecibo.BorderStyle = BorderStyle.None;
            txtNroRecibo.Location = new Point(95, 18);
            txtNroRecibo.Name = "txtNroRecibo";
            txtNroRecibo.Size = new Size(105, 16);
            txtNroRecibo.TabIndex = 1;
            // 
            // lblNroRecibo
            // 
            lblNroRecibo.AutoSize = true;
            lblNroRecibo.Location = new Point(20, 18);
            lblNroRecibo.Name = "lblNroRecibo";
            lblNroRecibo.Size = new Size(69, 15);
            lblNroRecibo.TabIndex = 0;
            lblNroRecibo.Text = "Recibo Nro:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(424, 374);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtImporte
            // 
            txtImporte.BackColor = SystemColors.Control;
            txtImporte.BorderStyle = BorderStyle.None;
            txtImporte.Location = new Point(95, 115);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(251, 16);
            txtImporte.TabIndex = 16;
            // 
            // ReciboCta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(pnlReciboCuota);
            Name = "ReciboCta";
            Text = "Recibo Cuota";
            pnlReciboCuota.ResumeLayout(false);
            pnlReciboCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReciboCuota;
        private Label lblNroRecibo;
        private TextBox txtNroRecibo;
        private TextBox txtNombreApellido;
        private TextBox txtFecha;
        private Label lblTexto2;
        private Label lblFecha;
        private PictureBox picFirma;
        private Button btnImprimir;
        private TextBox txtMotivo;
        private Label lblFirma;
        private Label lblTexto4;
        private Label lblTexto3;
        private TextBox txtImporte;
    }
}