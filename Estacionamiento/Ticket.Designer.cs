namespace Estacionamiento
{
    partial class frmDatosSalida
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
            txtHoraSalida = new TextBox();
            lblPlacas = new Label();
            lblColor = new Label();
            lblHoraSalida = new Label();
            lblModelo = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblTotalAPagar = new Label();
            button2 = new Button();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoraSalida
            // 
            txtHoraSalida.Location = new Point(233, 246);
            txtHoraSalida.Name = "txtHoraSalida";
            txtHoraSalida.Size = new Size(287, 27);
            txtHoraSalida.TabIndex = 16;
            txtHoraSalida.TextChanged += txtHoraSalida_TextChanged;
            // 
            // lblPlacas
            // 
            lblPlacas.AutoSize = true;
            lblPlacas.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblPlacas.ForeColor = Color.DarkBlue;
            lblPlacas.Location = new Point(156, 102);
            lblPlacas.Name = "lblPlacas";
            lblPlacas.Size = new Size(71, 22);
            lblPlacas.TabIndex = 9;
            lblPlacas.Text = "Placa :";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblColor.ForeColor = Color.DarkBlue;
            lblColor.Location = new Point(158, 204);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(69, 22);
            lblColor.TabIndex = 11;
            lblColor.Text = "Color :";
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblHoraSalida.ForeColor = Color.DarkBlue;
            lblHoraSalida.Location = new Point(58, 251);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(152, 22);
            lblHoraSalida.TabIndex = 12;
            lblHoraSalida.Text = "Hora de Salida :";
            lblHoraSalida.Click += lblHoraEntrada_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblModelo.ForeColor = Color.DarkBlue;
            lblModelo.Location = new Point(140, 150);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(87, 22);
            lblModelo.TabIndex = 10;
            lblModelo.Text = "Modelo :";
            lblModelo.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(156, 58);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 17;
            label1.Text = "Puesto :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalAPagar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 125);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "pago";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.Location = new Point(244, 33);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(50, 20);
            lblTotalAPagar.TabIndex = 22;
            lblTotalAPagar.Text = "label3";
            lblTotalAPagar.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 59);
            button2.Name = "button2";
            button2.Size = new Size(138, 60);
            button2.TabIndex = 21;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(87, 31);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 21;
            label2.Text = "Total a Pagar :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(264, 60);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 101);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 22;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 150);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 23;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 205);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // frmDatosSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtHoraSalida);
            Controls.Add(lblPlacas);
            Controls.Add(lblColor);
            Controls.Add(lblHoraSalida);
            Controls.Add(lblModelo);
            Name = "frmDatosSalida";
            Text = "DatosSalida";
            Load += DatosSalida_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoraSalida;
        private Label lblPlacas;
        private Label lblColor;
        private Label lblHoraSalida;
        private Label lblModelo;
        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label2;
        private Label lblTotalAPagar;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}