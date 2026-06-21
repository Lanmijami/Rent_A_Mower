using Common.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class PocetnaController
    {
        private static PocetnaController instance;

        public static PocetnaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PocetnaController();
                }
                return instance;
            }
        }
        private PocetnaController()
        {

        }

        internal async void Init(UCPocetna uCPocetna)
        {
            try
            {
                uCPocetna.LblBrKosilice.Text = (await Communication.Instance.VratiListuSveKosilice()).Count.ToString();
                uCPocetna.LblBrPartneri.Text = (await Communication.Instance.VratiListuSviPoslovniPartner()).Count.ToString();
                uCPocetna.LblBrOstava.Text = (await Communication.Instance.VratiListuSveOstava()).Count.ToString();

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greška pri povezivanju sa serverom!");
                Console.WriteLine(">>>>>> " + ex.Message);
            }
        }
    }
}
