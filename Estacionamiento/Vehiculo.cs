using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        public string horaEntrada
        {
            get { return txtHoraEntrada.Text; }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha guardado correctamente");


        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtHoraEntrada_TextChanged(object sender, EventArgs e)
        {
            
      
               

        }
    }
}
