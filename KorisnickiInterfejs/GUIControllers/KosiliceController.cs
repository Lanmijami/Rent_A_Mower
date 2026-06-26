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
    internal class KosiliceController
    {
        private static KosiliceController instance;
        public static KosiliceController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KosiliceController();
                }
                return instance;
            }
        }
        public KosiliceController()
        {
            
        }

        internal async void Init(UCKosilice uCKosilice)
        {
            try
            {
                ClearFields(uCKosilice);
                uCKosilice.DgvKosilice.DataSource = new BindingList<Kosilica>(await Communication.Instance.VratiListuSveKosilice());
                FormatDgv(uCKosilice);
                uCKosilice.DgvKosilice.ClearSelection();
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

        private void FormatDgv(UCKosilice uCKosilice)
        {
            uCKosilice.DgvKosilice.Columns["TableName"].Visible = false;
            uCKosilice.DgvKosilice.Columns["InsertColumns"].Visible = false;
            uCKosilice.DgvKosilice.Columns["InsertParameters"].Visible = false;
            uCKosilice.DgvKosilice.Columns["UpdateStatement"].Visible = false;
            uCKosilice.DgvKosilice.Columns["Condition"].Visible = false;
            uCKosilice.DgvKosilice.Columns["Parameters"].Visible = false;
            uCKosilice.DgvKosilice.Columns["IdKosilica"].Visible = false;
            uCKosilice.DgvKosilice.Columns["SearchableProperties"].Visible = false;
            uCKosilice.DgvKosilice.Columns["Model"].Width = 68;
            uCKosilice.DgvKosilice.Columns["Boja"].Width = 68;
            uCKosilice.DgvKosilice.Columns["CenaKosilice"].Width = 100;
            uCKosilice.DgvKosilice.Columns["GodinaProizvodnje"].Width = 100;
        }

        private void ClearFields(UCKosilice uCKosilice)
        {
            uCKosilice.TxtModel.Text = "";
            uCKosilice.TxtBoja.Text = "";
            uCKosilice.TxtCena.Text = "";
            uCKosilice.TxtGodinaProizvodnje.Text = "";

        }

        internal async void SelectionChanged(UCKosilice uCKosilice)
        {
            if (uCKosilice.DgvKosilice.SelectedRows.Count > 0)
            {
                Kosilica kosilica = await Communication.Instance.PretraziBicikla((Kosilica)uCKosilice.DgvKosilice.SelectedRows[0].DataBoundItem);

                uCKosilice.TxtModel.Text = kosilica.Model;
                uCKosilice.TxtBoja.Text = kosilica.Boja;
                uCKosilice.TxtCena.Text = kosilica.CenaKosilice.ToString();
                uCKosilice.TxtGodinaProizvodnje.Text = kosilica.GodinaProizvodnje.ToString();

                uCKosilice.TxtModel.BackColor = Color.White;
                uCKosilice.TxtBoja.BackColor = Color.White;
                uCKosilice.TxtCena.BackColor = Color.White;
                uCKosilice.TxtGodinaProizvodnje.BackColor = Color.White;
            }
        }

        private bool ValidateFields(UCKosilice uCKosilice)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(uCKosilice.TxtModel.Text))
            {
                uCKosilice.TxtModel.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCKosilice.TxtModel.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCKosilice.TxtBoja.Text))
            {
                uCKosilice.TxtBoja.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCKosilice.TxtBoja.BackColor = Color.White;
            }
            if (!int.TryParse(uCKosilice.TxtGodinaProizvodnje.Text, out _))
            {
                uCKosilice.TxtGodinaProizvodnje.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCKosilice.TxtGodinaProizvodnje.BackColor = Color.White;
            }
            if (!double.TryParse(uCKosilice.TxtCena.Text, out _))
            {
                uCKosilice.TxtCena.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCKosilice.TxtCena.BackColor = Color.White;
            }

            return temp;
        }

        private bool ValidateFieldsForSearch(UCKosilice uCKosilice)
        {
            bool temp = true;
            if (!string.IsNullOrWhiteSpace(uCKosilice.TxtGodinaProizvodnje.Text))
            {

                if (!int.TryParse(uCKosilice.TxtGodinaProizvodnje.Text, out _))
                {
                    uCKosilice.TxtGodinaProizvodnje.BackColor = Color.Salmon;
                    temp = false;
                }
                else
                {
                    uCKosilice.TxtGodinaProizvodnje.BackColor = Color.White;
                }
            }
            else
            {
                uCKosilice.TxtGodinaProizvodnje.BackColor = Color.White;
            }

            if (!string.IsNullOrWhiteSpace(uCKosilice.TxtCena.Text))
            {
                if (!double.TryParse(uCKosilice.TxtCena.Text, out _))
                {
                    uCKosilice.TxtCena.BackColor = Color.Salmon;
                    temp = false;
                }
                else
                {
                    uCKosilice.TxtCena.BackColor = Color.White;
                }
            }
            else
            {
                uCKosilice.TxtCena.BackColor = Color.White;
            }

            return temp;
        }

        internal async void Kreiraj(UCKosilice uCKosilice)
        {
            try
            {
                Kosilica kosilica = new Kosilica
                {
                    Model = "Nova Kosilica",
                    Boja = "/",
                    GodinaProizvodnje = DateTime.Now.Year,
                    CenaKosilice = 1,
                };

                await Communication.Instance.KreirajKosilica(kosilica);
                MessageBox.Show("Sistem je kreirao novu kosilicu!");
                Init(uCKosilice);
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

        internal async void Obrisi(UCKosilice uCKosilice)
        {
            if (uCKosilice.DgvKosilice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrana kosilica!");
                return;
            }

            try
            {
                for (int i = 0; i < uCKosilice.DgvKosilice.SelectedRows.Count; i++)
                {
                    Kosilica kosilica = (Kosilica)uCKosilice.DgvKosilice.SelectedRows[i].DataBoundItem;
                    await Communication.Instance.ObrisiKosilica(kosilica);
                }
                MessageBox.Show("Sistem je obrisao bicikle!");
                Init(uCKosilice);
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

        internal async void Pretrazi(UCKosilice uCKosilice)
        {
            try
            {
                if (!ValidateFieldsForSearch(uCKosilice))
                {
                    return;
                }
                Kosilica kosilica = new Kosilica
                {
                    Model = uCKosilice.TxtModel.Text,
                    Boja = uCKosilice.TxtBoja.Text,
                    GodinaProizvodnje = string.IsNullOrWhiteSpace(uCKosilice.TxtGodinaProizvodnje.Text) ? (int?)null : int.Parse(uCKosilice.TxtGodinaProizvodnje.Text),
                    CenaKosilice = string.IsNullOrWhiteSpace(uCKosilice.TxtCena.Text) ? (double?)null : double.Parse(uCKosilice.TxtCena.Text),
                };
                uCKosilice.DgvKosilice.DataSource = new BindingList<Kosilica>(await Communication.Instance.VratiListuKosilica(kosilica));
                FormatDgv(uCKosilice);
                uCKosilice.DgvKosilice.ClearSelection();
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

        internal async void Promeni(UCKosilice uCKosilice)
        {
            if (uCKosilice.DgvKosilice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrana kosilica");
                return;
            }
            if (uCKosilice.DgvKosilice.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jednu kosilicu");
                return;
            }

            try
            {
                if (!ValidateFields(uCKosilice))
                {
                    return;
                }
                Kosilica kosilica = (Kosilica)uCKosilice.DgvKosilice.SelectedRows[0].DataBoundItem;
                kosilica.Model = uCKosilice.TxtModel.Text;
                kosilica.Boja = uCKosilice.TxtBoja.Text;
                kosilica.GodinaProizvodnje = Int32.Parse(uCKosilice.TxtGodinaProizvodnje.Text);
                kosilica.CenaKosilice = Double.Parse(uCKosilice.TxtCena.Text);

                await Communication.Instance.PromeniKosilica(kosilica);
                MessageBox.Show("Sistem je zapamtio kodilicu!");
                Init(uCKosilice);
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

        internal async void Ubaci(UCKosilice uCKosilice)
        {
            if (!ValidateFields(uCKosilice))
            {
                return;
            }

            string model = uCKosilice.TxtModel.Text;
            string boja = uCKosilice.TxtBoja.Text;
            int godina = Int32.Parse(uCKosilice.TxtGodinaProizvodnje.Text);
            Double cena = Double.Parse(uCKosilice.TxtCena.Text);

            try
            {
                Kosilica kosilica = new Kosilica
                {
                    Model = model,
                    Boja = boja,
                    GodinaProizvodnje = godina,
                    CenaKosilice = cena,
                };

                await Communication.Instance.UbaciKosilica(kosilica);
                MessageBox.Show("Sistem je ubacio kosilicu!");
                Init(uCKosilice);
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
