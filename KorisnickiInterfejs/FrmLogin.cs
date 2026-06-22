using KorisnickiInterfejs.GUIControllers;
using System.Diagnostics;

namespace KorisnickiInterfejs
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;
        public FrmLogin()
        {
            InitializeComponent();
            loginController = LoginController.Instance;
            loginController.Init(this);
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            loginController.Registruj(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(">>> Prijavi se!");
            loginController.PrijaviOstavu(this);
        }

        //private void lblX_Click(object sender, EventArgs e)
        //{
        //    loginController.Exit();
        //}

        //private void lblMinimize_Click(object sender, EventArgs e)
        //{
        //    loginController.Minimize(this);
        //}



        //private void checkbxShow_CheckedChanged(object sender, EventArgs e)
        //{
        //    loginController.PrikaziSifru(this);
        //}
    }
}
