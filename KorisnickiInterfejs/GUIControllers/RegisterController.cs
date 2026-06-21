using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControlls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class RegisterController
    {
        private static RegisterController instance;

        public static RegisterController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegisterController();
                }
                return instance;
            }
        }
        private RegisterController()
        {

        }

        internal async void Init(FrmRegister frmRegister)
        {
            //frmRegister.Icon = Properties.Resources.bicycle;
            try
            {
                frmRegister.CmbVlasnik.DataSource = await Communication.Instance.VratiListuSveVlasnik();
                frmRegister.CmbVlasnik.SelectedItem = null;
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

        internal void Minimize(FrmRegister frmRegister)
        {
            frmRegister.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        internal void PrikaziSifru(FrmRegister frmRegister)
        {
            if (frmRegister.CheckbxShow.Checked)
            {
                frmRegister.TxtPassword.PasswordChar = '\0';
            }
            else
            {
                frmRegister.TxtPassword.PasswordChar = '*';
            }
        }

        internal void Prijavi(FrmRegister frmRegister)
        {
            frmRegister.DialogResult = DialogResult.Ignore;
        }

        internal async void RegistrujAutomat(FrmRegister frmRegister)
        {
            if (!ValidateFields(frmRegister))
            {
                return;
            }

            string korisnickoIme = frmRegister.TxtUsername.Text;
            string sifra = frmRegister.TxtPassword.Text;
            DateTime datumOtvaranja = frmRegister.DtpDatumProizvodnje.Value;

            try
            {
                Ostava ostava = new Ostava
                {
                    KorisnickoIme = korisnickoIme,
                    Sifra = sifra,
                    DatumOtvaranja = datumOtvaranja,
                };

                Vlasnik vlasnik = frmRegister.CmbVlasnik.SelectedItem as Vlasnik;

                if (vlasnik != null)
                {
                    await Communication.Instance.UbaciOstavaVlasnik(ostava, vlasnik);
                    MessageBox.Show("Ostava uspešno registrovana!" + " Vlasnik postavljen!");
                    frmRegister.DialogResult = DialogResult.OK;
                }
                else
                {
                    await Communication.Instance.UbaciOstava(ostava);
                    MessageBox.Show("Ostava uspešno registrovan!");
                    frmRegister.DialogResult = DialogResult.OK;
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

        private bool ValidateFields(FrmRegister frmRegister)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(frmRegister.TxtUsername.Text))
            {
                frmRegister.TxtUsername.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                frmRegister.TxtUsername.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(frmRegister.TxtPassword.Text))
            {
                frmRegister.TxtPassword.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                frmRegister.TxtPassword.BackColor = Color.White;
            }
            if (DateTime.Compare(frmRegister.DtpDatumProizvodnje.Value, DateTime.Now) > 0)
            {
                MessageBox.Show("Datum mora biti u prošlosti!");
                temp = false;
            }
            else
            {
                frmRegister.DtpDatumProizvodnje.CalendarForeColor = Color.White;
            }
            return temp;

        }

        internal void DodajLokacija(FrmRegister frmRegister)
        {
            UserControlDialog dialog = new UserControlDialog();
            UCUbaciVlasnika uCUbaciVlasnika = new UCUbaciVlasnika(dialog);
            dialog.Add(uCUbaciVlasnika);
            dialog.ShowDialog();
            Init(frmRegister);
        }
    }
}
