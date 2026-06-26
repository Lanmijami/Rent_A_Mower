using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIControllers
{
    public class LoginController
    {
        public Ostava TrenutnaOstava {  get; private set; }
        private static LoginController instance;
        public static LoginController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginController();
                }
                return instance;
            }
        }
        public LoginController()
        {
            
        }

        internal void Init(FrmLogin frmLogin)
        {
            //frmLogin.Icon = Properties.Resources.mower;
            frmLogin.TxtPassword.Text = "admin";
            frmLogin.TxtUsername.Text = "admin";
        }

        internal async void Exit()
        {
            try
            {
                await Communication.Instance.Close();
            }
            catch (ServerCommunicationException ex)
            {
                Debug.WriteLine(">>>>>> FORMCLOSED EVENT >>>>>>>> " + ex.Message);
            }
            finally
            {
                Environment.Exit(0);
            }

        }

        internal void Minimize(FrmLogin frmLogin)
        {
            frmLogin.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        internal async void PrijaviOstavu(FrmLogin frmLogin)
        {

            if (!ValidateFields(frmLogin))
            {
                return;
            }

            string korisnickoIme = frmLogin.TxtUsername.Text;
            string sifra = frmLogin.TxtPassword.Text;

            try
            {
                Ostava ostava = new Ostava
                {
                    KorisnickoIme = korisnickoIme,
                    Sifra = sifra,
                };

                Communication.Instance.Connect();
                TrenutnaOstava = await Communication.Instance.PrijaviOstava(ostava);


                if (TrenutnaOstava != null)
                {
                    MessageBox.Show("Korisničko ime i šifra su ispravni!");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisničko ime i šifra nisu ispravni!");
                }
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

        private bool ValidateFields(FrmLogin frmLogin)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(frmLogin.TxtUsername.Text))
            {
                frmLogin.TxtUsername.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                frmLogin.TxtUsername.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(frmLogin.TxtPassword.Text))
            {
                frmLogin.TxtPassword.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                frmLogin.TxtPassword.BackColor = Color.White;
            }
            return temp;

        }

        //internal void PrikaziSifru(FrmLogin frmLogin)
        //{
        //    if (frmLogin.CheckbxShow.Checked)
        //    {
        //        frmLogin.TxtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        frmLogin.TxtPassword.PasswordChar = '*';
        //    }
        //}

        internal void Registruj(FrmLogin frmLogin)
        {
            try
            {
                Communication.Instance.Connect();
                frmLogin.DialogResult = DialogResult.Ignore;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greška pri povezivanju sa serverom!");
                Console.WriteLine(">>>>>> " + ex.Message);
            }
        }
    }
}
