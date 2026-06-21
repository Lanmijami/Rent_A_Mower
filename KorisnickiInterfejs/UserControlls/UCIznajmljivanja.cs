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
    public partial class UCIznajmljivanja : UserControl
    {
        IznajmljivanjaController iznajmljivanjaController;
        public UCIznajmljivanja()
        {
            InitializeComponent();
            this.iznajmljivanjaController = IznajmljivanjaController.Instance;
            iznajmljivanjaController.Init(this);
        }

        public void dgvIznajmljivanja_SelectionChanged(object sender, EventArgs e)
        {
            iznajmljivanjaController.IznajmljivanjaSelectionChanged(this);
        }

        public void dgvStavke_SelectionChanged(object sender, EventArgs e)
        {
            iznajmljivanjaController.StavkeSelectionChanged(this);
        }

        private void btnObrisiStavka_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.ObrisiStavka(this);
        }

        private void btnUbaciStavka_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.UbaciStavka(this);
        }

        private void btnObrisiIznajmljivanje_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.ObrisiIznajmljivanje(this);
        }

        private void btnKreirajIznajmljivanje_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.KreirajIznajmljivanje(this);
        }

        private void btnUbaciIznajmljivanje_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.UbaciIznajmljivanje(this);
        }

        private void btnPromeniIznajmljivanje_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.PromeniIznajmljivanje(this);
        }

        private void btnPretraziIznajmljivanje_Click(object sender, EventArgs e)
        {
            iznajmljivanjaController.PretraziIznajmljivanje(this);
        }

        private void dtpIznajmljivanja_ValueChanged(object sender, EventArgs e)
        {
            iznajmljivanjaController.HandleDtpIznajmljivanjaValueChanged(this);
        }

        private void dtpPovratka_ValueChanged(object sender, EventArgs e)
        {
            iznajmljivanjaController.HandleDtpPovratkaValueChanged(this);
        }
    }
}
