using Common.Exceptions;
using System.Diagnostics;

namespace KorisnickiInterfejs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool loop = true;
            while (loop)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    DialogResult resultLogin = frmLogin.ShowDialog();
                    frmLogin.Dispose();
                    switch (resultLogin)
                    {
                        case DialogResult.OK:
                            FrmMain frmMain = new FrmMain();
                            DialogResult resultMain = frmMain.ShowDialog();
                            frmMain.Dispose();
                            switch (resultMain)
                            {
                                case DialogResult.Cancel:
                                    loop = false;
                                    break;
                                case DialogResult.OK:
                                    break;
                            }
                            break;
                        case DialogResult.Ignore:
                            FrmRegister frmRegister = new FrmRegister();
                            DialogResult resultRegister = frmRegister.ShowDialog();
                            frmRegister.Dispose();
                            switch (resultRegister)
                            {
                                case DialogResult.Cancel:
                                    loop = false;
                                    break;
                                case DialogResult.OK:
                                    break;
                                case DialogResult.Ignore:
                                    break;
                            }
                            break;
                        case DialogResult.Cancel:
                            loop = false;
                            break;
                    }
                }
                catch (ServerCommunicationException ex)
                {
                    MessageBox.Show("Greška pri komunikaciji sa serverom!");
                    Debug.WriteLine(">>>>>>>> " + ex.Message);
                }
            }
        }
    }
}