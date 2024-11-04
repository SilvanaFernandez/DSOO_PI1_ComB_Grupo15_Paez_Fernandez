namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez
{
    partial class Gestion_Actividades_Socio
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
            btnInscribir = new Button();
            txtNroSocio = new TextBox();
            txtNombreApellido = new TextBox();
            txtDni = new TextBox();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblNroSocio = new Label();
            lblNombreApellido = new Label();
            lblDni = new Label();
            checkedListBox1 = new CheckedListBox();
            lblActividades = new Label();
            txtTotalCuota = new TextBox();
            lblTotalCuota = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(76, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(457, 31);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "INSCRIBIR SOCIO EN ACTIVIDADES";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(502, 346);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(98, 41);
            btnInscribir.TabIndex = 3;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // txtNroSocio
            // 
            txtNroSocio.Location = new Point(64, 146);
            txtNroSocio.Margin = new Padding(3, 2, 3, 2);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(187, 23);
            txtNroSocio.TabIndex = 4;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(64, 217);
            txtNombreApellido.Margin = new Padding(3, 2, 3, 2);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(187, 23);
            txtNombreApellido.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(64, 283);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(187, 23);
            txtDni.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(581, 48);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(680, 48);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Location = new Point(64, 129);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(59, 15);
            lblNroSocio.TabIndex = 16;
            lblNroSocio.Text = "Nro Socio";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(64, 200);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(107, 15);
            lblNombreApellido.TabIndex = 17;
            lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(64, 266);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 18;
            lblDni.Text = "DNI";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(318, 146);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(437, 130);
            checkedListBox1.TabIndex = 21;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(318, 128);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(68, 15);
            lblActividades.TabIndex = 22;
            lblActividades.Text = "Actividades";
            // 
            // txtTotalCuota
            // 
            txtTotalCuota.Location = new Point(249, 346);
            txtTotalCuota.Name = "txtTotalCuota";
            txtTotalCuota.Size = new Size(135, 23);
            txtTotalCuota.TabIndex = 23;
            txtTotalCuota.TextChanged += txtTotalCuota_TextChanged;
            // 
            // lblTotalCuota
            // 
            lblTotalCuota.AutoSize = true;
            lblTotalCuota.Location = new Point(158, 349);
            lblTotalCuota.Name = "lblTotalCuota";
            lblTotalCuota.Size = new Size(85, 15);
            lblTotalCuota.TabIndex = 24;
            lblTotalCuota.Text = "Monto cuota $";
            // 
            // Gestion_Actividades_Socio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalCuota);
            Controls.Add(txtTotalCuota);
            Controls.Add(lblActividades);
            Controls.Add(checkedListBox1);
            Controls.Add(lblDni);
            Controls.Add(lblNombreApellido);
            Controls.Add(lblNroSocio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(txtDni);
            Controls.Add(txtNombreApellido);
            Controls.Add(txtNroSocio);
            Controls.Add(btnInscribir);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Gestion_Actividades_Socio";
            Text = "Gestión Actividades Socio";
            Load += Registrar_Actividad_Socio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnInscribir;
        private TextBox txtNroSocio;
        private TextBox txtNombreApellido;
        private TextBox txtDni;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblNroSocio;
        private Label lblNombreApellido;
        private Label lblDni;
        private CheckedListBox checkedListBox1;
        private Label lblActividades;
        private TextBox txtTotalCuota;
        private Label lblTotalCuota;
    }
}