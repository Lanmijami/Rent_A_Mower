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
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {
            Font = new Font("ArialUnicodeMS", 12, FontStyle.Bold);
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.ForeColor = Color.Black;
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
