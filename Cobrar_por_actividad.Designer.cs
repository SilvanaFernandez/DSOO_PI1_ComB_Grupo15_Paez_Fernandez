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
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(201, 95);
            label1.Name = "label1";
            label1.Size = new Size(500, 40);
            label1.TabIndex = 1;
            label1.Text = "GESTIÓN DE COBROS POR DÍA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(62, 188);
            label3.Name = "label3";
            label3.Size = new Size(443, 40);
            label3.TabIndex = 4;
            label3.Text = "Registrar pago de actividad:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 299);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 10;
            label6.Text = "No Socio";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 323);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "Número de no socio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 421);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 13;
            label4.Text = "Importe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 299);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 12;
            label2.Text = "Actividad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Musculación", "CrossFit", "Spinning", "Funcional", "Yoga", "Pilates", "Zumba", "Strong" });
            comboBox1.Location = new Point(400, 323);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "Actividad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 445);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "$";
            // 
            // button1
            // 
            button1.Location = new Point(632, 373);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 68);
            button1.TabIndex = 16;
            button1.Text = "Registrar y emitir recibo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(632, 473);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 59);
            button2.TabIndex = 27;
            button2.Text = "Generar carnet";
            button2.UseVisualStyleBackColor = true;
            // 
            // Cobrar_por_actividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cobrar_por_actividad";
            Text = "Cobrar_por_actividad";
            Load += Cobrar_por_actividad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label6;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}