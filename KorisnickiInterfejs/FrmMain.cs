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
    public partial class FrmMain : BaseForm
    {
        private MainController mainController;
        public FrmMain()
        {
            InitializeComponent();
            this.mainController = MainController.Instance;
            mainController.Init(this);
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            mainController.PrikaziPocetna(this);
        }

        private void btnPoslovniPartneri_Click(object sender, EventArgs e)
        {
            mainController.PrikaziPoslovniPartneri(this);
        }

        private void btnKosilice_Click(object sender, EventArgs e)
        {
            mainController.PrikaziKosilice(this);
        }

        private void btnIznajmljivanja_Click(object sender, EventArgs e)
        {
            mainController.PrikaziIznajmljivanja(this);
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            mainController.SignOut(this);
        }

        private void btnUbaciVlasnika_Click(object sender, EventArgs e)
        {
            mainController.UbaciVlasnika(this);
        }
    }
}
