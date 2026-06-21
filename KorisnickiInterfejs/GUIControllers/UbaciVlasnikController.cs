using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class UbaciVlasnikController
    {
        private static UbaciVlasnikController instance;

        public static UbaciVlasnikController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UbaciVlasnikController();
                }
                return instance;
            }
        }
        private UbaciVlasnikController()
        {

        }

        internal async void UbaciVlasnika(UCUbaciVlasnika uCUbaciVlasnika, UserControlDialog frmDialog)
        {
            if (!ValidateFields(uCUbaciVlasnika))
            {
                return;
            }

            string ime = uCUbaciVlasnika.TxtIme.Text;
            string prezime = uCUbaciVlasnika.TxtPrezime.Text;
            string email = uCUbaciVlasnika.TxtEmail.Text;

            try
            {
                Vlasnik vlasnik = new Vlasnik
                {
                    Ime = ime,
                    Prezime = prezime,
                    Email = email
                };

                await Communication.Instance.UbaciVlasnik(vlasnik);

                MessageBox.Show("Sistem je ubacio vlasnika!");
                frmDialog.DialogResult = DialogResult.OK;
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

        private bool ValidateFields(UCUbaciVlasnika uCUbaciVlasnika)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(uCUbaciVlasnika.TxtIme.Text))
            {
                uCUbaciVlasnika.TxtIme.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciVlasnika.TxtIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCUbaciVlasnika.TxtPrezime.Text))
            {
                uCUbaciVlasnika.TxtPrezime.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciVlasnika.TxtPrezime.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCUbaciVlasnika.TxtEmail.Text))
            {
                uCUbaciVlasnika.TxtEmail.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciVlasnika.TxtEmail.BackColor = Color.White;
            }
            return temp;
        }

        internal void Close(UCUbaciVlasnika uCUbaciVlasnika, UserControlDialog frmDialog)
        {
            frmDialog.DialogResult = DialogResult.Cancel;
        }
    }
}
