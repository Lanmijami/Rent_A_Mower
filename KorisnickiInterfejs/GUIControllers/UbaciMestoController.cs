using Common.Exceptions;
using Domain;
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
    internal class UbaciMestoController
    {
        private static UbaciMestoController instance;

        public static UbaciMestoController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UbaciMestoController();
                }
                return instance;
            }
        }
        private UbaciMestoController()
        {

        }

        private bool ValidateFields(UCUbaciMesto uCUbaciLMesto)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(uCUbaciLMesto.TxtNaziv.Text))
            {
                uCUbaciLMesto.TxtNaziv.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciLMesto.TxtNaziv.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCUbaciLMesto.TxtOpstina.Text))
            {
                uCUbaciLMesto.TxtOpstina.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciLMesto.TxtDrzava.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCUbaciLMesto.TxtDrzava.Text))
            {
                uCUbaciLMesto.TxtDrzava.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciLMesto.TxtDrzava.BackColor = Color.White;
            }
            return temp;
        }

        internal void Close(UCUbaciMesto uCUbaciLMesto, UserControlDialog frmDialog)
        {
            frmDialog.DialogResult = DialogResult.Cancel;
        }

        internal async void UbaciMesto(UCUbaciMesto uCUbaciMesto, UserControlDialog frmDialog)
        {
            if (!ValidateFields(uCUbaciMesto))
            {
                return;
            }

            string naziv = uCUbaciMesto.TxtNaziv.Text;
            string opstina = uCUbaciMesto.TxtOpstina.Text;
            string drzava = uCUbaciMesto.TxtDrzava.Text;

            try
            {
                Mesto mesto = new Mesto
                {
                    Naziv = naziv,
                    Opstina = opstina,
                    Drzava = drzava
                };

                await Communication.Instance.UbaciMesto(mesto);

                MessageBox.Show("Sistem je ubacio mesto!");
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
    }
}
