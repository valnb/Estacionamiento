
namespace Estacionamiento
{
    partial class frmUsuario
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblIdUser = new Label();
            txtIdUser = new TextBox();
            btnConsultar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblNombre.ForeColor = Color.DarkBlue;
            lblNombre.Location = new Point(65, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 24);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(189, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblIdUser
            // 
            lblIdUser.AutoSize = true;
            lblIdUser.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblIdUser.ForeColor = Color.DarkBlue;
            lblIdUser.Location = new Point(120, 119);
            lblIdUser.Name = "lblIdUser";
            lblIdUser.Size = new Size(48, 24);
            lblIdUser.TabIndex = 2;
            lblIdUser.Text = "ID :";
            lblIdUser.Click += lblIdUser_Click;
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(189, 116);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(319, 27);
            txtIdUser.TabIndex = 3;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnConsultar.Location = new Point(32, 26);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(114, 48);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAgregar.Location = new Point(221, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 48);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(430, 26);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 48);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnEditar.Location = new Point(131, 103);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(114, 48);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAceptar.Location = new Point(324, 103);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(114, 48);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = " Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Location = new Point(23, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 157);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Controls.Add(txtIdUser);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(lblIdUser);
            groupBox2.Location = new Point(23, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 194);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Usuario";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmUsuario";
            Text = "Usuario del Sistema";
            Load += frmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmEstacionamiento frmEstaciona = new frmEstacionamiento();
            frmEstaciona.ShowDialog();
           
            
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblIdUser;
        private TextBox txtIdUser;
        private Button btnConsultar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAceptar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
