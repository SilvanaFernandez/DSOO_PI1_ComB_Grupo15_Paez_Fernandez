namespace DSOO_PI1_ComB_Grupo15_Paez_Fernandez.Documentos
{
    partial class GrillaVtos
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
            dtgvVtos = new DataGridView();
            NroSocio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            VtoCuota = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvVtos).BeginInit();
            SuspendLayout();
            // 
            // dtgvVtos
            // 
            dtgvVtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVtos.Columns.AddRange(new DataGridViewColumn[] { NroSocio, Nombre, Apellido, Dni, VtoCuota });
            dtgvVtos.Location = new Point(111, 12);
            dtgvVtos.Name = "dtgvVtos";
            dtgvVtos.RowTemplate.Height = 25;
            dtgvVtos.Size = new Size(540, 383);
            dtgvVtos.TabIndex = 0;
            // 
            // NroSocio
            // 
            NroSocio.HeaderText = "Nro de Socio";
            NroSocio.Name = "NroSocio";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Dni
            // 
            Dni.HeaderText = "DNI";
            Dni.Name = "Dni";
            // 
            // VtoCuota
            // 
            VtoCuota.HeaderText = "Vto cuota";
            VtoCuota.Name = "VtoCuota";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(682, 29);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(682, 77);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // GrillaVtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(btnVolver);
            Controls.Add(dtgvVtos);
            Name = "GrillaVtos";
            Text = "Grilla Vtos del día";
            Load += GrillaVtos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvVtos;
        private DataGridViewTextBoxColumn NroSocio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn VtoCuota;
        private Button btnVolver;
        private Button btnImprimir;
    }
}