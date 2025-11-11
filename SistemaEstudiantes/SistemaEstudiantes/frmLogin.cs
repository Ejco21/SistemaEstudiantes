namespace SistemaEstudiantes
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtPassword.Text == "")
            {
                frmInicio FrmInicio = new frmInicio();
                this.Hide();
                FrmInicio.Show();

            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtUsuario.Clear();
                txtPassword.Clear();
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
