using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class PoslovniPartnerController
    {
        private static PoslovniPartnerController instance;

        public static PoslovniPartnerController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PoslovniPartnerController();
                }
                return instance;
            }
        }
        private PoslovniPartnerController()
        {

        }

        internal async void Init(UCPoslovniPartneri uCPoslovniPartneri)
        {
            try
            {
                ClearFields(uCPoslovniPartneri);
                uCPoslovniPartneri.CmbMesto.DataSource = await Communication.Instance.VratiListuSviMesto();
                uCPoslovniPartneri.CmbMesto.ValueMember = "IdMesto";
                uCPoslovniPartneri.CmbMesto.DisplayMember = null;
                uCPoslovniPartneri.CmbMesto.SelectedItem = null;
                uCPoslovniPartneri.DgvPoslovniPartneri.DataSource = new BindingList<PoslovniPartner>(await Communication.Instance.VratiListuSviPoslovniPartner());
                FormatDgv(uCPoslovniPartneri);
                uCPoslovniPartneri.DgvPoslovniPartneri.ClearSelection();
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

        private void FormatDgv(UCPoslovniPartneri uCPoslovniPartneri)
        {
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["TableName"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["InsertColumns"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["InsertParameters"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["UpdateStatement"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["Condition"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["Parameters"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["IdPoslovniPartner"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["SearchableProperties"].Visible = false;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["Ime"].Width = 58;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["Prezime"].Width = 58;
            uCPoslovniPartneri.DgvPoslovniPartneri.Columns["Email"].Width = 120;
        }

        internal async void SelectionChanged(UCPoslovniPartneri uCPoslovniPartneri)
        {
            if (uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows.Count > 0)
            {
                PoslovniPartner partner = await Communication.Instance.PretraziPoslovniPartner((PoslovniPartner)uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows[0].DataBoundItem);

                uCPoslovniPartneri.TxtIme.Text = partner.Ime;
                uCPoslovniPartneri.TxtPrezime.Text = partner.Prezime;
                uCPoslovniPartneri.TxtEmail.Text = partner.Email;
                uCPoslovniPartneri.CmbMesto.SelectedValue = partner.Mesto.IdMesto;

                uCPoslovniPartneri.TxtIme.BackColor = Color.White;
                uCPoslovniPartneri.TxtPrezime.BackColor = Color.White;
                uCPoslovniPartneri.TxtEmail.BackColor = Color.White;
                uCPoslovniPartneri.CmbMesto.BackColor = Color.White;
            }
        }

        internal void ClearFields(UCPoslovniPartneri uCPoslovniPartneri)
        {
            uCPoslovniPartneri.TxtIme.Text = "";
            uCPoslovniPartneri.TxtPrezime.Text = "";
            uCPoslovniPartneri.TxtEmail.Text = "";
        }

        private bool ValidateFields(UCPoslovniPartneri uCPoslovniPartneri)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(uCPoslovniPartneri.TxtIme.Text))
            {
                uCPoslovniPartneri.TxtIme.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCPoslovniPartneri.TxtIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCPoslovniPartneri.TxtPrezime.Text))
            {
                uCPoslovniPartneri.TxtPrezime.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCPoslovniPartneri.TxtPrezime.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCPoslovniPartneri.TxtEmail.Text) || !uCPoslovniPartneri.TxtEmail.Text.Contains('@'))
            {
                uCPoslovniPartneri.TxtEmail.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCPoslovniPartneri.TxtEmail.BackColor = Color.White;
            }
            if (uCPoslovniPartneri.CmbMesto.SelectedItem == null)
            {
                uCPoslovniPartneri.CmbMesto.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCPoslovniPartneri.CmbMesto.BackColor = Color.White;
            }

            return temp;
        }

        internal async void Ubaci(UCPoslovniPartneri uCPoslovniPartneri)
        {
            if (!ValidateFields(uCPoslovniPartneri))
            {
                return;
            }

            string ime = uCPoslovniPartneri.TxtIme.Text;
            string prezime = uCPoslovniPartneri.TxtPrezime.Text;
            string email = uCPoslovniPartneri.TxtEmail.Text;
            Mesto mesto = (Mesto)uCPoslovniPartneri.CmbMesto.SelectedItem;

            try
            {
                PoslovniPartner partner = new PoslovniPartner
                {
                    Ime = ime,
                    Prezime = prezime,
                    Email = email,
                    Mesto = mesto,
                };

                await Communication.Instance.UbaciPoslovniPartner(partner);
                MessageBox.Show("Sistem je ubacio poslovnog partnera!");
                Init(uCPoslovniPartneri);
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

        internal async void Obrisi(UCPoslovniPartneri uCPoslovniPartneri)
        {
            if (uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabran poslovni partner!");
                return;
            }

            try
            {
                for (int i = 0; i < uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows.Count; i++)
                {
                    PoslovniPartner partner = (PoslovniPartner)uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows[i].DataBoundItem;
                    await Communication.Instance.ObrisiPoslovniPartner(partner);
                }
                MessageBox.Show("Sistem je obrisao poslovne partnera!");
                Init(uCPoslovniPartneri);
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

        internal async void Promeni(UCPoslovniPartneri uCPoslovniPartneri)
        {
            if (uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabran poslovni partner!");
                return;
            }
            if (uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jednog poslovnog partnera!");
                return;
            }

            try
            {
                if (!ValidateFields(uCPoslovniPartneri))
                {
                    return;
                }
                PoslovniPartner partner = (PoslovniPartner)uCPoslovniPartneri.DgvPoslovniPartneri.SelectedRows[0].DataBoundItem;
                partner.Ime = uCPoslovniPartneri.TxtIme.Text;
                partner.Prezime = uCPoslovniPartneri.TxtPrezime.Text;
                partner.Email = uCPoslovniPartneri.TxtEmail.Text;
                partner.Mesto = (Mesto)uCPoslovniPartneri.CmbMesto.SelectedItem;
                await Communication.Instance.PromeniPoslovniPartner(partner);
                MessageBox.Show("Sistem je zapamtio poslovnog partnera!");
                Init(uCPoslovniPartneri);
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

        internal async void Pretrazi(UCPoslovniPartneri uCPoslovniPartneri)
        {
            try
            {
                Mesto mesto = null;
                if (uCPoslovniPartneri.CmbMesto.SelectedItem != null)
                {
                    mesto = (Mesto)uCPoslovniPartneri.CmbMesto.SelectedItem;
                }
                PoslovniPartner partner = new PoslovniPartner
                {
                    Ime = uCPoslovniPartneri.TxtIme.Text,
                    Prezime = uCPoslovniPartneri.TxtPrezime.Text,
                    Email = uCPoslovniPartneri.TxtEmail.Text,
                    Mesto = mesto
                };
                uCPoslovniPartneri.DgvPoslovniPartneri.DataSource = new BindingList<PoslovniPartner>(await Communication.Instance.VratiListuPoslovniPartner(partner));
                FormatDgv(uCPoslovniPartneri);
                uCPoslovniPartneri.DgvPoslovniPartneri.ClearSelection();
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

        internal async void Kreiraj(UCPoslovniPartneri uCPoslovniPartneri)
        {
            try
            {
                PoslovniPartner partner = new PoslovniPartner
                {
                    Ime = "Novi",
                    Prezime = "Partner",
                    Email = "novi@partner.com",
                    Mesto = (Mesto)uCPoslovniPartneri.CmbMesto.Items[0]
                };

                await Communication.Instance.KreirajPoslovniPartner(partner);
                MessageBox.Show("Sistem je kreirao novog poslovnog partnera!");
                Init(uCPoslovniPartneri);
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

        internal void DodajMesto(UCPoslovniPartneri uCPoslovniPartneri)
        {
            UserControlDialog dialog = new UserControlDialog();
            UCUbaciMesto uCUbaciMesto = new UCUbaciMesto(dialog);
            dialog.Add(uCUbaciMesto);
            dialog.ShowDialog();
            Init(uCPoslovniPartneri);
        }
    }
}
