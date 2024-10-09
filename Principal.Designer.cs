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
            label1 = new Label();
            registroNoSociosBTN = new Button();
            registroSocioBTN = new Button();
            gestionCuotasBTN = new Button();
            gestionCobrosBTN = new Button();
            reportesVtosBTN = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(296, 65);
            label1.Name = "label1";
            label1.Size = new Size(321, 40);
            label1.TabIndex = 1;
            label1.Text = "\"CLUB DEPORTIVO\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // registroNoSociosBTN
            // 
            registroNoSociosBTN.Location = new Point(277, 301);
            registroNoSociosBTN.Margin = new Padding(3, 4, 3, 4);
            registroNoSociosBTN.Name = "registroNoSociosBTN";
            registroNoSociosBTN.Size = new Size(113, 68);
            registroNoSociosBTN.TabIndex = 17;
            registroNoSociosBTN.Text = "Registro de No Socios";
            registroNoSociosBTN.UseVisualStyleBackColor = true;
            registroNoSociosBTN.Click += registroNoSociosBTN_Click;
            // 
            // registroSocioBTN
            // 
            registroSocioBTN.Location = new Point(277, 181);
            registroSocioBTN.Margin = new Padding(3, 4, 3, 4);
            registroSocioBTN.Name = "registroSocioBTN";
            registroSocioBTN.Size = new Size(113, 68);
            registroSocioBTN.TabIndex = 18;
            registroSocioBTN.Text = "Registro de Socios";
            registroSocioBTN.UseVisualStyleBackColor = true;
            registroSocioBTN.Click += registroSocioBTN_Click;
            // 
            // gestionCuotasBTN
            // 
            gestionCuotasBTN.Location = new Point(527, 181);
            gestionCuotasBTN.Margin = new Padding(3, 4, 3, 4);
            gestionCuotasBTN.Name = "gestionCuotasBTN";
            gestionCuotasBTN.Size = new Size(113, 68);
            gestionCuotasBTN.TabIndex = 19;
            gestionCuotasBTN.Text = "Gestión de cuotas";
            gestionCuotasBTN.UseVisualStyleBackColor = true;
            gestionCuotasBTN.Click += gestionCuotasBTN_Click;
            // 
            // gestionCobrosBTN
            // 
            gestionCobrosBTN.Location = new Point(527, 301);
            gestionCobrosBTN.Margin = new Padding(3, 4, 3, 4);
            gestionCobrosBTN.Name = "gestionCobrosBTN";
            gestionCobrosBTN.Size = new Size(113, 68);
            gestionCobrosBTN.TabIndex = 20;
            gestionCobrosBTN.Text = "Gestión de cobros por día";
            gestionCobrosBTN.UseVisualStyleBackColor = true;
            gestionCobrosBTN.Click += gestionCobrosBTN_Click;
            // 
            // reportesVtosBTN
            // 
            reportesVtosBTN.Location = new Point(406, 432);
            reportesVtosBTN.Margin = new Padding(3, 4, 3, 4);
            reportesVtosBTN.Name = "reportesVtosBTN";
            reportesVtosBTN.Size = new Size(113, 68);
            reportesVtosBTN.TabIndex = 21;
            reportesVtosBTN.Text = "Reportes de vtos del día";
            reportesVtosBTN.UseVisualStyleBackColor = true;
            reportesVtosBTN.Click += reportesVtosBTN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(695, 195);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 197);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 305);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(reportesVtosBTN);
            Controls.Add(gestionCobrosBTN);
            Controls.Add(gestionCuotasBTN);
            Controls.Add(registroSocioBTN);
            Controls.Add(registroNoSociosBTN);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button registroNoSociosBTN;
        private Button gestionCuotasBTN;
        private Button gestionCobrosBTN;
        private Button reportesVtosBTN;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button registroSocioBTN;
    }
}