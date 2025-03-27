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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estacionamiento
{
    public partial class frmCajonesEstacionamiento : Form
    {
        public frmCajonesEstacionamiento()
        {
            InitializeComponent();
            MostrarLugares();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCajonesEstacionamiento frmCajones = new frmCajonesEstacionamiento();
            frmCajones.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDatosSalida frmDatosSalida = new frmDatosSalida();
            frmDatosSalida.ShowDialog();
        }

        private void frmCajonesEstacionamiento_Load(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MostrarLugares()
        {
            for (int i = 1; i <= 40; i++)
            {
                comboBox1.Items.Add($"{i}");
            }

            
        }

    }
            






        
}
