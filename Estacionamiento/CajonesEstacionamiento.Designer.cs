namespace Estacionamiento
{
    partial class frmCajonesEstacionamiento
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
            lblPlacas = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(185, 22);
            label1.TabIndex = 21;
            label1.Text = "Cupos Disponibles :";
            // 
            // lblPlacas
            // 
            lblPlacas.AutoSize = true;
            lblPlacas.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblPlacas.ForeColor = Color.DarkBlue;
            lblPlacas.Location = new Point(145, 97);
            lblPlacas.Name = "lblPlacas";
            lblPlacas.Size = new Size(84, 22);
            lblPlacas.TabIndex = 19;
            lblPlacas.Text = "Puesto :";
            // 
            // button2
            // 
            button2.Location = new Point(71, 205);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(416, 205);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 25;
            button3.Text = "Dar de Baja";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(238, 205);
            button4.Name = "button4";
            button4.Size = new Size(122, 29);
            button4.TabIndex = 26;
            button4.Text = "Configuracion";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(248, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 50);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 28;
            label2.Text = "label2";
            // 
            // frmCajonesEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 322);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(lblPlacas);
            Name = "frmCajonesEstacionamiento";
            Text = "CajonesEstacionamiento";
            Load += frmCajonesEstacionamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblPlacas;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Label label2;
    }
}