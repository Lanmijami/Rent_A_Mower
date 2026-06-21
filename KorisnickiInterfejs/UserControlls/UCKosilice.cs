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

namespace KorisnickiInterfejs.UserControlls
{
    public partial class UCKosilice : UserControl
    {
        private KosiliceController kosiliceController;
        public UCKosilice()
        {
            InitializeComponent();
            this.kosiliceController = KosiliceController.Instance;
            kosiliceController.Init(this);
        }

        private void dgvKosilice_SelectionChanged(object sender, EventArgs e)
        {
            kosiliceController.SelectionChanged(this);
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            kosiliceController.Ubaci(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kosiliceController.Pretrazi(this);
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            kosiliceController.Promeni(this);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kosiliceController.Obrisi(this);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kosiliceController.Kreiraj(this);
        }
    }
}
