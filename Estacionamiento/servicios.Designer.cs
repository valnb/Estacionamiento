namespace Estacionamiento
{
    partial class frmEstacionamiento
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            btnVehiculoIngresa = new Button();
            btnVehiculoSale = new Button();
            btnCajonEstaciona = new Button();
            groupBox2 = new GroupBox();
            lblFecha = new Label();
            groupBox3 = new GroupBox();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblLugar5 = new Label();
            lblLugar4 = new Label();
            lblLugar3 = new Label();
            lblLugar2 = new Label();
            lblLugar1 = new Label();
            label3 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            lblHora.ForeColor = Color.DarkSlateBlue;
            lblHora.Location = new Point(20, 52);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(66, 27);
            lblHora.TabIndex = 0;
            lblHora.Text = "label";
            lblHora.Click += label1_Click;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Tick += timerHora_Tick;
            // 
            // btnVehiculoIngresa
            // 
            btnVehiculoIngresa.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnVehiculoIngresa.Location = new Point(97, 373);
            btnVehiculoIngresa.Name = "btnVehiculoIngresa";
            btnVehiculoIngresa.Size = new Size(99, 53);
            btnVehiculoIngresa.TabIndex = 3;
            btnVehiculoIngresa.Text = "Entrada";
            btnVehiculoIngresa.UseVisualStyleBackColor = true;
            btnVehiculoIngresa.Click += btnVehiculoIngresa_Click;
            // 
            // btnVehiculoSale
            // 
            btnVehiculoSale.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnVehiculoSale.Location = new Point(540, 373);
            btnVehiculoSale.Name = "btnVehiculoSale";
            btnVehiculoSale.Size = new Size(99, 53);
            btnVehiculoSale.TabIndex = 4;
            btnVehiculoSale.Text = "Vehiculo Sale";
            btnVehiculoSale.UseVisualStyleBackColor = true;
            btnVehiculoSale.Click += btnVehiculoSale_Click;
            // 
            // btnCajonEstaciona
            // 
            btnCajonEstaciona.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCajonEstaciona.Location = new Point(289, 373);
            btnCajonEstaciona.Name = "btnCajonEstaciona";
            btnCajonEstaciona.Size = new Size(168, 53);
            btnCajonEstaciona.TabIndex = 5;
            btnCajonEstaciona.Text = "Cajones de Estacionamiento";
            btnCajonEstaciona.UseVisualStyleBackColor = true;
            btnCajonEstaciona.Click += btnCajonEstaciona_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImageLayout = ImageLayout.Center;
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblHora);
            groupBox2.Location = new Point(476, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hora Actual";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            lblFecha.ForeColor = Color.DarkSlateBlue;
            lblFecha.Location = new Point(50, 79);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 27);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(label32);
            groupBox3.Controls.Add(label33);
            groupBox3.Controls.Add(label34);
            groupBox3.Controls.Add(label35);
            groupBox3.Controls.Add(label36);
            groupBox3.Controls.Add(label37);
            groupBox3.Controls.Add(label38);
            groupBox3.Controls.Add(label39);
            groupBox3.Controls.Add(label40);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lblLugar5);
            groupBox3.Controls.Add(lblLugar4);
            groupBox3.Controls.Add(lblLugar3);
            groupBox3.Controls.Add(lblLugar2);
            groupBox3.Controls.Add(lblLugar1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(729, 204);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Estacionamiento";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Gainsboro;
            label31.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label31.Location = new Point(58, 158);
            label31.Name = "label31";
            label31.Size = new Size(30, 23);
            label31.TabIndex = 39;
            label31.Text = "31";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Gainsboro;
            label32.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label32.Location = new Point(122, 158);
            label32.Name = "label32";
            label32.Size = new Size(30, 23);
            label32.TabIndex = 38;
            label32.Text = "32";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Gainsboro;
            label33.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label33.Location = new Point(186, 158);
            label33.Name = "label33";
            label33.Size = new Size(30, 23);
            label33.TabIndex = 37;
            label33.Text = "33";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.Gainsboro;
            label34.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label34.Location = new Point(250, 158);
            label34.Name = "label34";
            label34.Size = new Size(30, 23);
            label34.TabIndex = 36;
            label34.Text = "34";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Gainsboro;
            label35.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label35.Location = new Point(314, 158);
            label35.Name = "label35";
            label35.Size = new Size(30, 23);
            label35.TabIndex = 35;
            label35.Text = "35";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = Color.Gainsboro;
            label36.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label36.Location = new Point(378, 158);
            label36.Name = "label36";
            label36.Size = new Size(30, 23);
            label36.TabIndex = 34;
            label36.Text = "36";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.Gainsboro;
            label37.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label37.Location = new Point(442, 158);
            label37.Name = "label37";
            label37.Size = new Size(30, 23);
            label37.TabIndex = 33;
            label37.Text = "37";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = Color.Gainsboro;
            label38.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label38.Location = new Point(506, 158);
            label38.Name = "label38";
            label38.Size = new Size(30, 23);
            label38.TabIndex = 32;
            label38.Text = "38";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = Color.Gainsboro;
            label39.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label39.Location = new Point(571, 158);
            label39.Name = "label39";
            label39.Size = new Size(30, 23);
            label39.TabIndex = 31;
            label39.Text = "39";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = Color.Gainsboro;
            label40.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label40.Location = new Point(634, 158);
            label40.Name = "label40";
            label40.Size = new Size(30, 23);
            label40.TabIndex = 30;
            label40.Text = "40";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Gainsboro;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label21.Location = new Point(58, 115);
            label21.Name = "label21";
            label21.Size = new Size(30, 23);
            label21.TabIndex = 29;
            label21.Text = "21";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Gainsboro;
            label22.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label22.Location = new Point(122, 115);
            label22.Name = "label22";
            label22.Size = new Size(30, 23);
            label22.TabIndex = 28;
            label22.Text = "22";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Gainsboro;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label23.Location = new Point(186, 115);
            label23.Name = "label23";
            label23.Size = new Size(30, 23);
            label23.TabIndex = 27;
            label23.Text = "23";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Gainsboro;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label24.Location = new Point(250, 115);
            label24.Name = "label24";
            label24.Size = new Size(30, 23);
            label24.TabIndex = 26;
            label24.Text = "24";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Gainsboro;
            label25.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label25.Location = new Point(314, 115);
            label25.Name = "label25";
            label25.Size = new Size(30, 23);
            label25.TabIndex = 25;
            label25.Text = "25";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Gainsboro;
            label26.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label26.Location = new Point(378, 115);
            label26.Name = "label26";
            label26.Size = new Size(30, 23);
            label26.TabIndex = 24;
            label26.Text = "26";
            label26.Click += label26_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Gainsboro;
            label27.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label27.Location = new Point(442, 115);
            label27.Name = "label27";
            label27.Size = new Size(30, 23);
            label27.TabIndex = 23;
            label27.Text = "27";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Gainsboro;
            label28.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label28.Location = new Point(506, 115);
            label28.Name = "label28";
            label28.Size = new Size(30, 23);
            label28.TabIndex = 22;
            label28.Text = "28";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Gainsboro;
            label29.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label29.Location = new Point(571, 115);
            label29.Name = "label29";
            label29.Size = new Size(30, 23);
            label29.TabIndex = 21;
            label29.Text = "29";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Gainsboro;
            label30.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label30.Location = new Point(634, 115);
            label30.Name = "label30";
            label30.Size = new Size(30, 23);
            label30.TabIndex = 20;
            label30.Text = "30";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.Location = new Point(58, 74);
            label11.Name = "label11";
            label11.Size = new Size(30, 23);
            label11.TabIndex = 19;
            label11.Text = "11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label12.Location = new Point(122, 74);
            label12.Name = "label12";
            label12.Size = new Size(30, 23);
            label12.TabIndex = 18;
            label12.Text = "12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label13.Location = new Point(186, 74);
            label13.Name = "label13";
            label13.Size = new Size(30, 23);
            label13.TabIndex = 17;
            label13.Text = "13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label14.Location = new Point(250, 74);
            label14.Name = "label14";
            label14.Size = new Size(30, 23);
            label14.TabIndex = 16;
            label14.Text = "14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Gainsboro;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label15.Location = new Point(314, 74);
            label15.Name = "label15";
            label15.Size = new Size(30, 23);
            label15.TabIndex = 15;
            label15.Text = "15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Gainsboro;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label16.Location = new Point(378, 74);
            label16.Name = "label16";
            label16.Size = new Size(30, 23);
            label16.TabIndex = 14;
            label16.Text = "16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Gainsboro;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label17.Location = new Point(442, 74);
            label17.Name = "label17";
            label17.Size = new Size(30, 23);
            label17.TabIndex = 13;
            label17.Text = "17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Gainsboro;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label18.Location = new Point(506, 74);
            label18.Name = "label18";
            label18.Size = new Size(30, 23);
            label18.TabIndex = 12;
            label18.Text = "18";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Gainsboro;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label19.Location = new Point(570, 74);
            label19.Name = "label19";
            label19.Size = new Size(30, 23);
            label19.TabIndex = 11;
            label19.Text = "19";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Gainsboro;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label20.Location = new Point(634, 74);
            label20.Name = "label20";
            label20.Size = new Size(30, 23);
            label20.TabIndex = 10;
            label20.Text = "20";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.Location = new Point(634, 32);
            label10.Name = "label10";
            label10.Size = new Size(30, 23);
            label10.TabIndex = 9;
            label10.Text = "10";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Location = new Point(571, 32);
            label9.Name = "label9";
            label9.Size = new Size(20, 23);
            label9.TabIndex = 8;
            label9.Text = "9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(506, 32);
            label8.Name = "label8";
            label8.Size = new Size(20, 23);
            label8.TabIndex = 7;
            label8.Text = "8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(442, 32);
            label7.Name = "label7";
            label7.Size = new Size(20, 23);
            label7.TabIndex = 6;
            label7.Text = "7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(378, 32);
            label6.Name = "label6";
            label6.Size = new Size(20, 23);
            label6.TabIndex = 5;
            label6.Text = "6";
            // 
            // lblLugar5
            // 
            lblLugar5.AutoSize = true;
            lblLugar5.BackColor = Color.Gainsboro;
            lblLugar5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblLugar5.Location = new Point(314, 32);
            lblLugar5.Name = "lblLugar5";
            lblLugar5.Size = new Size(20, 23);
            lblLugar5.TabIndex = 4;
            lblLugar5.Text = "5";
            // 
            // lblLugar4
            // 
            lblLugar4.AutoSize = true;
            lblLugar4.BackColor = Color.Gainsboro;
            lblLugar4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblLugar4.Location = new Point(250, 32);
            lblLugar4.Name = "lblLugar4";
            lblLugar4.Size = new Size(20, 23);
            lblLugar4.TabIndex = 3;
            lblLugar4.Text = "4";
            // 
            // lblLugar3
            // 
            lblLugar3.AutoSize = true;
            lblLugar3.BackColor = Color.Gainsboro;
            lblLugar3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblLugar3.Location = new Point(186, 32);
            lblLugar3.Name = "lblLugar3";
            lblLugar3.Size = new Size(20, 23);
            lblLugar3.TabIndex = 2;
            lblLugar3.Text = "3";
            // 
            // lblLugar2
            // 
            lblLugar2.AutoSize = true;
            lblLugar2.BackColor = Color.Gainsboro;
            lblLugar2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblLugar2.Location = new Point(122, 32);
            lblLugar2.Name = "lblLugar2";
            lblLugar2.Size = new Size(20, 23);
            lblLugar2.TabIndex = 1;
            lblLugar2.Text = "2";
            // 
            // lblLugar1
            // 
            lblLugar1.AutoSize = true;
            lblLugar1.BackColor = Color.Gainsboro;
            lblLugar1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblLugar1.Location = new Point(58, 32);
            lblLugar1.Name = "lblLugar1";
            lblLugar1.Size = new Size(20, 23);
            lblLugar1.TabIndex = 0;
            lblLugar1.Text = "1";
            lblLugar1.Click += lblLugar1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 254);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 11;
            label3.Text = "Servicio";
            // 
            // frmEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(753, 537);
            Controls.Add(label3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnCajonEstaciona);
            Controls.Add(btnVehiculoSale);
            Controls.Add(btnVehiculoIngresa);
            Name = "frmEstacionamiento";
            Text = "Servicio";
            Load += Estacionamiento_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private Button btnVehiculoIngresa;
        private Button btnVehiculoSale;
        private Button btnCajonEstaciona;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblFecha;
        private Label lblLugar5;
        private Label lblLugar4;
        private Label lblLugar3;
        private Label lblLugar2;
        private Label lblLugar1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label3;
    }
}