namespace Estacionamiento
{
    partial class frmVehiculo
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
            btnAgregar = new Button();
            lblPlacas = new Label();
            lblModelo = new Label();
            lblColor = new Label();
            lblHoraEntrada = new Label();
            txtPlaca = new TextBox();
            txtColor = new TextBox();
            txtModelo = new TextBox();
            txtHoraEntrada = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(76, 279);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 53);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblPlacas
            // 
            lblPlacas.AutoSize = true;
            lblPlacas.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblPlacas.ForeColor = Color.DarkBlue;
            lblPlacas.Location = new Point(124, 48);
            lblPlacas.Name = "lblPlacas";
            lblPlacas.Size = new Size(71, 22);
            lblPlacas.TabIndex = 1;
            lblPlacas.Text = "Placa :";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblModelo.ForeColor = Color.DarkBlue;
            lblModelo.Location = new Point(108, 96);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(87, 22);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo :";
            lblModelo.UseMnemonic = false;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblColor.ForeColor = Color.DarkBlue;
            lblColor.Location = new Point(126, 150);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(69, 22);
            lblColor.TabIndex = 3;
            lblColor.Text = "Color :";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblHoraEntrada.ForeColor = Color.DarkBlue;
            lblHoraEntrada.Location = new Point(26, 197);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(169, 22);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Hora de Entrada :";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(204, 47);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(287, 27);
            txtPlaca.TabIndex = 5;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(201, 145);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(287, 27);
            txtColor.TabIndex = 6;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(204, 91);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(287, 27);
            txtModelo.TabIndex = 7;
            // 
            // txtHoraEntrada
            // 
            txtHoraEntrada.Location = new Point(201, 192);
            txtHoraEntrada.Name = "txtHoraEntrada";
            txtHoraEntrada.Size = new Size(287, 27);
            txtHoraEntrada.TabIndex = 8;
            txtHoraEntrada.TextChanged += txtHoraEntrada_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHoraEntrada);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(lblPlacas);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(lblColor);
            groupBox1.Controls.Add(lblHoraEntrada);
            groupBox1.Controls.Add(lblModelo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 249);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Vehiculo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(321, 279);
            button1.Name = "button1";
            button1.Size = new Size(149, 53);
            button1.TabIndex = 10;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 393);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregar);
            Name = "frmVehiculo";
            Text = "Vehiculo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Label lblPlacas;
        private Label lblModelo;
        private Label lblColor;
        private Label lblHoraEntrada;
        private TextBox txtPlaca;
        private TextBox txtColor;
        private TextBox txtModelo;
        private TextBox txtHoraEntrada;
        private GroupBox groupBox1;
        private Button button1;
    }
}