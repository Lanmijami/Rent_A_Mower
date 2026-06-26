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
    public partial class UCUbaciMesto : BaseUserControl
    {
        private UbaciMestoController ubaciMestoController;
        internal UserControlDialog frmDialog;

        public UCUbaciMesto(UserControlDialog frmDialog)
        {
            this.frmDialog = frmDialog;
            this.ubaciMestoController = UbaciMestoController.Instance;
            InitializeComponent();
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            ubaciMestoController.UbaciMesto(this, frmDialog);
        }

        //private void lblX_Click(object sender, EventArgs e)
        //{
        //    ubaciMestoController.Close(this, frmDialog);
        //}


    }
}
