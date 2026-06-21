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
    public partial class UCUbaciVlasnika : UserControl
    {
        private UbaciVlasnikController ubaciVlasnikaController;
        internal UserControlDialog frmDialog;

        public UCUbaciVlasnika(UserControlDialog frmDialog)
        {
            this.frmDialog = frmDialog;
            this.ubaciVlasnikaController = UbaciVlasnikController.Instance;
            InitializeComponent();
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            ubaciVlasnikaController.UbaciVlasnika(this, frmDialog);
        }

        //private void lblX_Click(object sender, EventArgs e)
        //{
        //    ubaciVlasnikaController.Close(this, frmDialog);
        //}
    }
}
