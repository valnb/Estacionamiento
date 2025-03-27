using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        public frmEstacionamiento()
        {
            InitializeComponent();

        }

        private void Estacionamiento_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        { }



        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblHoras_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVehiculoIngresa_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculos = new frmVehiculo();
            frmVehiculos.ShowDialog();
        }

        private void btnVehiculoSale_Click(object sender, EventArgs e)
        {
            frmDatosSalida frmDatoSalida = new frmDatosSalida();
            frmDatoSalida.ShowDialog();
        }

        private void btnCajonEstaciona_Click(object sender, EventArgs e)
        {
            frmCajonesEstacionamiento frmCajonesEsta = new frmCajonesEstacionamiento();
            frmCajonesEsta.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblLugar1_Click(object sender, EventArgs e)
        {

        }
    }

}
    

            
 


