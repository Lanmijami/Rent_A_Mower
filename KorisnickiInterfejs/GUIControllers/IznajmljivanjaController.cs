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
    internal class IznajmljivanjaController
    {
        private static IznajmljivanjaController instance;

        public static IznajmljivanjaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new IznajmljivanjaController();
                }
                return instance;
            }
        }
        private IznajmljivanjaController()
        {

        }

        internal async Task Init(UCIznajmljivanja uCIznajmljivanja)
        {
            try
            {
                uCIznajmljivanja.CmbKosilica.DataSource = await Communication.Instance.VratiListuSveKosilice();
                uCIznajmljivanja.CmbKosilica.ValueMember = "IdKosilica";
                //Zanimljivi override - property wrapper postavlja display member da bude prvi property klase, ovde ga overridujemo
                uCIznajmljivanja.CmbKosilica.DisplayMember = null;
                uCIznajmljivanja.CmbPoslovniPartner.DataSource = await Communication.Instance.VratiListuSviPoslovniPartner();
                uCIznajmljivanja.CmbPoslovniPartner.ValueMember = "IdPoslovniPartner";
                uCIznajmljivanja.CmbPoslovniPartner.DisplayMember = null;
                uCIznajmljivanja.CmbOstava.DataSource = await Communication.Instance.VratiListuSveOstava();
                uCIznajmljivanja.CmbOstava.ValueMember = "IdOstava";
                uCIznajmljivanja.CmbOstava.DisplayMember = null;
                uCIznajmljivanja.DgvIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>(await Communication.Instance.VratiListuSviIznajmljivanje());
                FormatIznajmljivanjaDgv(uCIznajmljivanja);
                ClearFields(uCIznajmljivanja);
                uCIznajmljivanja.DgvIznajmljivanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                uCIznajmljivanja.DgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                uCIznajmljivanja.DtpIznajmljivanja.Value = DateTime.Today;
                uCIznajmljivanja.DtpIznajmljivanja.Value = DateTime.Today;
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

        private void FormatIznajmljivanjaDgv(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DgvIznajmljivanja.Columns["TableName"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["InsertColumns"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["InsertParameters"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["UpdateStatement"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["Condition"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["Parameters"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["IdIznajmljivanje"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["SearchableProperties"].Visible = false;
        }

        private void ClearFields(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DtpIznajmljivanja.Value = DateTime.Now;
            uCIznajmljivanja.DtpPovratka.Value = DateTime.Now;
            uCIznajmljivanja.CmbPoslovniPartner.SelectedItem = null;
            uCIznajmljivanja.TxtCena.Text = "";
            uCIznajmljivanja.CmbKosilica.SelectedItem = null;
            uCIznajmljivanja.CmbOstava.SelectedItem = null;
        }

        internal async void IznajmljivanjaSelectionChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count > 0)
            {
                Iznajmljivanje iznajmljivanje = await Communication.Instance.PretraziIznajmljivanje((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem);
                uCIznajmljivanja.DgvStavke.DataSource = new BindingList<StavkaIznajmljivanja>(iznajmljivanje.Stavke);
                FormatStavkeDgv(uCIznajmljivanja);
                uCIznajmljivanja.DtpIznajmljivanja.Value = (DateTime)iznajmljivanje.DatumIznajmljivanja;
                uCIznajmljivanja.DtpPovratka.Value = (DateTime)iznajmljivanje.DatumPovratka;
                uCIznajmljivanja.CmbPoslovniPartner.SelectedValue = iznajmljivanje.PoslovniPartner.IdPoslovniPartner;
                uCIznajmljivanja.CmbOstava.SelectedValue = iznajmljivanje.Ostava.IdOstava;
            }
        }


        //internal void StavkeSelectionChanged(UCIznajmljivanja uCIznajmljivanja)
        //{
        //    if (uCIznajmljivanja.DgvStavke.SelectedRows.Count > 0)
        //    {
        //        StavkaIznajmljivanja stavka = (StavkaIznajmljivanja)uCIznajmljivanja.DgvStavke.SelectedRows[0].DataBoundItem;
        //        uCIznajmljivanja.TxtCena.Text = stavka.CenaNajma.ToString();
        //        uCIznajmljivanja.CmbKosilica.SelectedValue = stavka.Kosilica.IdKosilica;
        //    }
        //}

        internal void StavkeSelectionChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvStavke.SelectedRows.Count == 0)
                return;

            var row = uCIznajmljivanja.DgvStavke.SelectedRows[0];

            if (row.DataBoundItem is not StavkaIznajmljivanja stavka)
                return;

            uCIznajmljivanja.TxtCena.Text = stavka.CenaNajma.ToString();
            uCIznajmljivanja.CmbKosilica.SelectedValue = stavka.Kosilica?.IdKosilica;
        }


        private void FormatStavkeDgv(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DgvStavke.Columns["TableName"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["InsertColumns"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["InsertParameters"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["UpdateStatement"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["Condition"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["Parameters"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["SearchableProperties"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["IdIznajmljivanje"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["NewRb"].Visible = false;
        }

        private async Task RefreshDgvIznajmljivanja(UCIznajmljivanja uCIznajmljivanja, int rowIndex)
        {
            await Init(uCIznajmljivanja);
            uCIznajmljivanja.DgvIznajmljivanja.ClearSelection();
            uCIznajmljivanja.DgvIznajmljivanja.Rows[rowIndex].Selected = true;
            uCIznajmljivanja.DgvIznajmljivanja.CurrentCell = uCIznajmljivanja.DgvIznajmljivanja.Rows[rowIndex].Cells[1];
        }

        internal void ObrisiStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrana stavka!");
                return;
            }

            try
            {
                StavkaIznajmljivanja stavka = (StavkaIznajmljivanja)uCIznajmljivanja.DgvStavke.SelectedRows[0].DataBoundItem;
                uCIznajmljivanja.DgvStavke.CurrentCell = null;
                ((BindingList<StavkaIznajmljivanja>)uCIznajmljivanja.DgvStavke.DataSource).Remove(stavka);
                PoredjajStavke(uCIznajmljivanja);
                uCIznajmljivanja.DgvStavke.Refresh();
                MessageBox.Show("Sistem je obrisao stavku! Pritisnite 'Promeni' kako bi sačuvali promene!");
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

        private void PoredjajStavke(UCIznajmljivanja uCIznajmljivanja)
        {
            int i = 1;
            foreach (StavkaIznajmljivanja si in ((BindingList<StavkaIznajmljivanja>)uCIznajmljivanja.DgvStavke.DataSource).ToList())
            {
                si.Rb = i;
                i++;
            }
        }

        //internal void UbaciStavka(UCIznajmljivanja uCIznajmljivanja)
        //{
        //    if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Nije odabrano iznajmljivanje!");
        //        return;
        //    }

        //    if (!ValidateFieldsStavka(uCIznajmljivanja))
        //    {
        //        return;
        //    }

        //    int cenaNajma = Int32.Parse(uCIznajmljivanja.TxtCena.Text);
        //    Kosilica Kosilica = (Kosilica)uCIznajmljivanja.CmbKosilica.SelectedItem;
        //    int rb = ((BindingList<StavkaIznajmljivanja>)uCIznajmljivanja.DgvStavke.DataSource).Count + 1;

        //    try
        //    {
        //        StavkaIznajmljivanja stavka = new StavkaIznajmljivanja
        //        {
        //            Rb = rb,
        //            CenaNajma = cenaNajma,
        //            Kosilica = Kosilica,
        //            IdIznajmljivanje = ((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).IdIznajmljivanje,
        //        };

        //        ((BindingList<StavkaIznajmljivanja>)uCIznajmljivanja.DgvStavke.DataSource).Add(stavka);
        //        uCIznajmljivanja.DgvStavke.CurrentCell = uCIznajmljivanja.DgvStavke.Rows[uCIznajmljivanja.DgvStavke.RowCount - 1].Cells[1];
        //        uCIznajmljivanja.DgvStavke.Refresh();
        //        MessageBox.Show("Sistem je dodao stavku! Pritisnite 'Promeni' kako bi sačuvali promene!");
        //    }
        //    catch (SystemOperationException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    catch (SocketException ex)
        //    {
        //        MessageBox.Show("Greška pri povezivanju sa serverom!");
        //        Console.WriteLine(">>>>>> " + ex.Message);
        //    }
        //}

        internal void UbaciStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrano iznajmljivanje!");
                return;
            }

            if (!ValidateFieldsStavka(uCIznajmljivanja))
            {
                return;
            }

            try
            {
                var list = uCIznajmljivanja.DgvStavke.DataSource as BindingList<StavkaIznajmljivanja>;

                if (list == null)
                {
                    MessageBox.Show("Lista stavki nije inicijalizovana!");
                    return;
                }

                int cenaNajma = int.Parse(uCIznajmljivanja.TxtCena.Text);

                Kosilica kosilica = uCIznajmljivanja.CmbKosilica.SelectedItem as Kosilica;
                if (kosilica == null)
                {
                    MessageBox.Show("Nije odabrana kosilica!");
                    return;
                }

                var iznajmljivanje = uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem as Iznajmljivanje;
                if (iznajmljivanje == null)
                {
                    MessageBox.Show("Greška pri čitanju iznajmljivanja!");
                    return;
                }

                int rb = list.Count + 1;

                StavkaIznajmljivanja stavka = new StavkaIznajmljivanja
                {
                    Rb = rb,
                    CenaNajma = cenaNajma,
                    Kosilica = kosilica,
                    IdIznajmljivanje = iznajmljivanje.IdIznajmljivanje
                };

                list.Add(stavka);

                // safer UI refresh (no CurrentCell crash)
                uCIznajmljivanja.DgvStavke.ClearSelection();

                int lastIndex = list.Count - 1;
                if (lastIndex >= 0 && uCIznajmljivanja.DgvStavke.ColumnCount > 0)
                {
                    uCIznajmljivanja.DgvStavke.Rows[lastIndex].Selected = true;
                }

                MessageBox.Show("Sistem je dodao stavku! Pritisnite 'Promeni' kako bi sačuvali promene!");
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

        private bool ValidateFieldsStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            bool temp = true;
            if (!string.IsNullOrWhiteSpace(uCIznajmljivanja.TxtCena.Text))
            {
                if (!double.TryParse(uCIznajmljivanja.TxtCena.Text, out _))
                {
                    uCIznajmljivanja.TxtCena.BackColor = Color.Salmon;
                    temp = false;
                }
                else
                {
                    uCIznajmljivanja.TxtCena.BackColor = Color.White;
                }
            }
            else
            {
                uCIznajmljivanja.TxtCena.BackColor = Color.Salmon;
                temp = false;
            }
            if (uCIznajmljivanja.CmbKosilica.SelectedItem == null)
            {
                uCIznajmljivanja.CmbKosilica.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCIznajmljivanja.CmbKosilica.BackColor = Color.White;
            }
            return temp;
        }

        internal async void ObrisiIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrano iznajmljivanje!");
                return;
            }

            if (((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).Stavke.Count > 0)
            {
                MessageBox.Show("Prvo obrišite sve stavke!");
                return;
            }

            try
            {
                for (int i = 0; i < uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count; i++)
                {
                    Iznajmljivanje iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[i].DataBoundItem;
                    await Communication.Instance.ObrisiIznajmljivanje(iznajmljivanje);
                }
                MessageBox.Show("Sistem je obrisao iznajmljivanja!");
                Init(uCIznajmljivanja);
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

        internal async void KreirajIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            try
            {
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                {
                    DatumIznajmljivanja = DateTime.Now,
                    DatumPovratka = DateTime.Now,
                    PoslovniPartner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.Items[0],
                    Ostava = (Ostava)uCIznajmljivanja.CmbOstava.Items[0]
                };

                await Communication.Instance.KreirajIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Sistem je kreirao novo iznajmljivanje!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, uCIznajmljivanja.DgvIznajmljivanja.RowCount);
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

        internal async void UbaciIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            if (!ValidateFieldsIznajmljivanje(uCIznajmljivanja))
            {
                return;
            }

            DateTime datumIznajmljivanja = uCIznajmljivanja.DtpIznajmljivanja.Value;
            DateTime datumPovratka = uCIznajmljivanja.DtpPovratka.Value;
            PoslovniPartner partner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.SelectedItem;
            Ostava Ostava = (Ostava)uCIznajmljivanja.CmbOstava.SelectedItem;

            try
            {
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                {
                    DatumIznajmljivanja = datumIznajmljivanja,
                    DatumPovratka = datumPovratka,
                    PoslovniPartner = partner,
                    Ostava = Ostava,
                };

                await Communication.Instance.UbaciIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Sistem je ubacio iznajmljivanje!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, uCIznajmljivanja.DgvIznajmljivanja.RowCount);
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

        private bool ValidateFieldsIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            bool temp = true;
            if (DateTime.Compare(uCIznajmljivanja.DtpIznajmljivanja.Value, uCIznajmljivanja.DtpPovratka.Value) > 0)
            {
                MessageBox.Show("Datum iznajmljivanja mora biti pre datuma povratka!");
                temp = false;
            }
            if (uCIznajmljivanja.CmbOstava.SelectedItem == null)
            {
                uCIznajmljivanja.CmbOstava.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCIznajmljivanja.CmbOstava.BackColor = Color.White;
            }
            if (uCIznajmljivanja.CmbPoslovniPartner.SelectedItem == null)
            {
                uCIznajmljivanja.CmbPoslovniPartner.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCIznajmljivanja.CmbPoslovniPartner.BackColor = Color.White;
            }
            return temp;
        }

        internal async void PromeniIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrano iznajmljivanje!");
                return;
            }
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jedno iznajmljivanje!");
                return;
            }

            try
            {
                if (!ValidateFieldsIznajmljivanje(uCIznajmljivanja))
                {
                    return;
                }

                Iznajmljivanje iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem;
                iznajmljivanje.DatumIznajmljivanja = uCIznajmljivanja.DtpIznajmljivanja.Value;
                iznajmljivanje.DatumPovratka = uCIznajmljivanja.DtpPovratka.Value;
                iznajmljivanje.Ostava = (Ostava)uCIznajmljivanja.CmbOstava.SelectedItem;
                iznajmljivanje.PoslovniPartner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.SelectedItem;
                iznajmljivanje.Stavke = ((BindingList<StavkaIznajmljivanja>)uCIznajmljivanja.DgvStavke.DataSource).ToList();

                await Communication.Instance.PromeniIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Sistem je zapamtio iznajmljivanje!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].Index);
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

        internal async void PretraziIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            try
            {
                PoslovniPartner partner = null;
                if (uCIznajmljivanja.CmbPoslovniPartner.SelectedItem != null)
                {
                    partner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.SelectedItem;
                }
                Ostava Ostava = null;
                {
                    Ostava = (Ostava)uCIznajmljivanja.CmbOstava.SelectedItem;
                }
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                {
                    Ostava = Ostava,
                    PoslovniPartner = partner
                };

                DialogResult result = MessageBox.Show("Da li želite da uključite i odabrane datume u pretragu?", "Pretraga", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    iznajmljivanje.DatumIznajmljivanja = uCIznajmljivanja.DtpIznajmljivanja.Value;
                    iznajmljivanje.DatumPovratka = uCIznajmljivanja.DtpPovratka.Value;
                }
                else
                {
                    iznajmljivanje.DatumIznajmljivanja = null;
                    iznajmljivanje.DatumPovratka = null;
                }

                uCIznajmljivanja.DgvIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>(await Communication.Instance.VratiListuIznajmljivanje(iznajmljivanje));
                FormatIznajmljivanjaDgv(uCIznajmljivanja);
                uCIznajmljivanja.DgvIznajmljivanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        internal void HandleDtpIznajmljivanjaValueChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DtpIznajmljivanja.Value = uCIznajmljivanja.DtpIznajmljivanja.Value.Date;
        }

        internal void HandleDtpPovratkaValueChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DtpPovratka.Value = uCIznajmljivanja.DtpPovratka.Value.Date;
        }
    }
}
