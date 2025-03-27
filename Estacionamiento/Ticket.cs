using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class frmDatosSalida : Form
    {




        public frmDatosSalida()
        {
            InitializeComponent();
            MostrarLugares();
        }

        public string horaSalida
        {
            get { return txtHoraSalida.Text; }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHoraEntrada_Click(object sender, EventArgs e)
        {

        }

        private void DatosSalida_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impresion frmTickets = new Impresion();
            frmTickets.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {



        }

        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MostrarLugares()
        {
            for (int i = 1; i <= 40; i++)
            {
                comboBox2.Items.Add($"{i}");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
