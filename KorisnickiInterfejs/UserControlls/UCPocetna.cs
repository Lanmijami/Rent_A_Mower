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
    public partial class UCPocetna : BaseUserControl
    {
        private PocetnaController pocetnaController;
        public UCPocetna()
        {
            InitializeComponent();
            this.pocetnaController = PocetnaController.Instance;
            pocetnaController.Init(this);
        }
    }
}
