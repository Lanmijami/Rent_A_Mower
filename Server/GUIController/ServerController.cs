using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.GUIController
{
    public class ServerController
    {
        private static ServerController instance;
        private Server server;

        public static ServerController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServerController();
                }
                return instance;
            }
        }

        private ServerController() { 
            
        }

        //internal void Init(FrmServer frmServer)
        //{
        //    //frmServer.Icon = Properties.Resources.server;
        //    //FormDragHelper.EnableDragging(frmServer.LblMove);
        //}

        internal void Exit()
        {
            if (server != null && server.isRunning)
            {
                server.Stop();
            }
            Environment.Exit(0);
        }

        //internal void Minimize(FrmServer frmServer)
        //{
        //    frmServer.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        //}

        internal void Start(FrmServer frmServer) {
            server = new Server();

            if (server.Start())
            {
                MessageBox.Show("Server is running ...");
                frmServer.BtnStop.Enabled = true;
                frmServer.BtnStart.Enabled = false;
                //frmServer.PicServer.Image = global::Server.Properties.Resources.serverIconOn;
                Task.Run(() => server.Listen());   
            }
            else MessageBox.Show("Error!");
        }

        internal void Stop(FrmServer frmServer)
        {
            server?.Stop();
            MessageBox.Show("Server is stopped!");
            frmServer.BtnStart.Enabled = true;
            frmServer.BtnStop.Enabled = false;
            //frmServer.PicServer.Image = global::Server.Properties.Resources.serverIcon;
        }
    }
}
