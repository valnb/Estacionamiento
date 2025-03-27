
namespace Estacionamiento
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblIdUser_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int bandera = 0;
            UsuarioBO cUser = new UsuarioBO();
            UsuarioDAO UserDAO = new UsuarioDAO();

            UsuarioDAO.IdUsuario = Convert.ToInt32(txt..Text.Trim());
            UsuarioDAO.Marca = txtMarca.Text.Trim();
            UsuarioDAO.Modelo = txtModelo.Text.Trim();
            UsuarioDAO.TipPantalla = txtTipPantalla.Text.Trim();
            celuDAO.NumSIMS = int.Parse(txtNumSIMS.Text.Trim());
            celuDAO.FechFabrica = DateTime.Parse(dtpFechFabrica.Text.Trim());
            bandera = celuDAO.CreaCelulares(cCelulares);
            if (bandera == 0)
            {
                MessageBox.Show("La información no se pudo guardar");
            }
            else
            {
                MessageBox.Show("La información se guardo con exito");
            }

        }
    }
}
