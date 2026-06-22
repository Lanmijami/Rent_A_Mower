using KorisnickiInterfejs.GUIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmRegister : Form
    {
        private RegisterController registerController;

        public FrmRegister()
        {
            InitializeComponent();
            registerController = RegisterController.Instance;
            registerController.Init(this);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            registerController.DodajLokacija(this);
        }

        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            registerController.RegistrujAutomat(this);
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            registerController.Prijavi(this);
        }

        private void checkbxShow_CheckedChanged(object sender, EventArgs e)
        {
            registerController.PrikaziSifru(this);
        }

        //private void lblX_Click(object sender, EventArgs e)
        //{
        //    registerController.Exit();
        //}

        //private void lblMinimize_Click(object sender, EventArgs e)
        //{
        //    registerController.Minimize(this);
        //}
    }
}
