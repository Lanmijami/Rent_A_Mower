using Common.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControlls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class MainController
    {
        private static MainController instance;

        public static MainController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainController();
                }
                return instance;
            }
        }
        private MainController()
        {

        }

        internal void Init(FrmMain frmMain)
        {
            //frmMain.Icon = Properties.Resources.bicycle;
            //CollapseMenu(frmMain);
            frmMain.PanelMain.Controls.Add(new UCPocetna());
        }

        internal async void SignOut(FrmMain frmMain)
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
                frmMain.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        internal void Minimize(FrmMain frmMain)
        {
            frmMain.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        internal async void Exit(FrmMain frmMain)
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
                frmMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }

        }

        //internal void CollapseMenu(FrmMain frmMain)
        //{
        //    if (frmMain.PanelMenu.Width >= 200)
        //    {
        //        frmMain.PanelMenu.Width = 100;
        //        frmMain.PbLogo.Visible = false;
        //        frmMain.IbNavicon.Dock = DockStyle.Top;
        //        foreach (Button menuButton in frmMain.PanelMenu.Controls.OfType<Button>())
        //        {
        //            menuButton.Text = "";
        //            menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //            menuButton.Padding = new Padding(0);
        //        }
        //        if (frmMain.PanelMain.Controls.Count > 0)
        //        {
        //            StretchMainPanel(frmMain);
        //        }

        //    }
        //    else
        //    {
        //        frmMain.PanelMenu.Width = 200;
        //        frmMain.PbLogo.Visible = true;
        //        frmMain.IbNavicon.Dock = DockStyle.None;
        //        foreach (Button menuButton in frmMain.PanelMenu.Controls.OfType<Button>())
        //        {
        //            menuButton.Text = menuButton.Tag.ToString();
        //            menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //            menuButton.Padding = new Padding(10, 0, 0, 0);
        //        }
        //        if (frmMain.PanelMain.Controls.Count > 0)
        //        {
        //            ShrinkMainPanel(frmMain);
        //        }
        //    }
        //}

        //private static void ShrinkMainPanel(FrmMain frmMain)
        //{
        //    if (frmMain.PanelMain.Controls[0] is UCPoslovniPartneri)
        //    {
        //        ((UCPoslovniPartneri)frmMain.PanelMain.Controls[0]).PanelShow.Width = 320;
        //    }
        //    if (frmMain.PanelMain.Controls[0] is UCBicikle)
        //    {
        //        ((UCBicikle)frmMain.PanelMain.Controls[0]).PanelShow.Width = 320;
        //    }
        //    if (frmMain.PanelMain.Controls[0] is UCPocetna pocetna)
        //    {
        //        pocetna.PanelTop.Width = 560;
        //        pocetna.PanelBottom.Width = 560;
        //        pocetna.LblAutomati.Text = "";
        //        pocetna.LblBicikle.Text = "";
        //        pocetna.LblPartneri.Text = "";
        //        pocetna.PanelAutomati.Width = 156;
        //        pocetna.PanelBicikle.Width = 156;
        //        pocetna.PanelPartneri.Width = 156;
        //        pocetna.PanelAutomati.Location = new System.Drawing.Point(pocetna.PanelBicikle.Location.X + 156 + 25, pocetna.PanelAutomati.Location.Y);
        //    }
        //    if (frmMain.PanelMain.Controls[0] is UCIznajmljivanja iznajmljivanja)
        //    {
        //        iznajmljivanja.PanelStavke.Width = 185;
        //        iznajmljivanja.PanelStavkeControls.Width = 185;
        //        iznajmljivanja.TxtCena.Width = 80;
        //        iznajmljivanja.CmbBicikla.Width = 80;
        //        iznajmljivanja.BtnUbaciStavka.Location = new System.Drawing.Point(iznajmljivanja.BtnUbaciStavka.Location.X + 12, iznajmljivanja.BtnUbaciStavka.Location.Y);
        //        iznajmljivanja.BtnObrisiStavka.Location = new System.Drawing.Point(iznajmljivanja.BtnObrisiStavka.Location.X - 20, iznajmljivanja.BtnObrisiStavka.Location.Y);
        //    };
        //}

        //private static void StretchMainPanel(FrmMain frmMain)
        //{
        //    if (frmMain.PanelMain.Controls[0] is UCPoslovniPartneri)
        //    {
        //        ((UCPoslovniPartneri)frmMain.PanelMain.Controls[0]).PanelShow.Width = 420;
        //    }
        //    if (frmMain.PanelMain.Controls[0] is UCBicikle)
        //    {
        //        ((UCBicikle)frmMain.PanelMain.Controls[0]).PanelShow.Width = 420;
        //    }
        //    if (frmMain.PanelMain.Controls[0] is UCPocetna pocetna)
        //    {
        //        pocetna.PanelTop.Width = 660;
        //        pocetna.PanelBottom.Width = 660;
        //        pocetna.LblAutomati.Text = pocetna.LblAutomati.Tag.ToString();
        //        pocetna.LblBicikle.Text = pocetna.LblBicikle.Tag.ToString();
        //        pocetna.LblPartneri.Text = pocetna.LblPartneri.Tag.ToString();
        //        pocetna.PanelAutomati.Width = 190;
        //        pocetna.PanelBicikle.Width = 190;
        //        pocetna.PanelPartneri.Width = 190;
        //        pocetna.PanelAutomati.Location = new System.Drawing.Point(pocetna.PanelBicikle.Location.X + 190 + 25, pocetna.PanelAutomati.Location.Y);
        //    }
        //    if (frmMain.PanelMain.Controls[0] is UCIznajmljivanja iznajmljivanja)
        //    {
        //        iznajmljivanja.PanelStavke.Width = 285;
        //        iznajmljivanja.PanelStavkeControls.Width = 285;
        //        iznajmljivanja.TxtCena.Width = 148;
        //        iznajmljivanja.CmbBicikla.Width = 148;
        //        iznajmljivanja.BtnUbaciStavka.Location = new System.Drawing.Point(52, 122);
        //        iznajmljivanja.BtnObrisiStavka.Location = new System.Drawing.Point(168, 122);
        //    };
        //}

        internal void PrikaziPoslovniPartneri(FrmMain frmMain)
        {
            HandleIznajmljivanjaSelectionChangedBug(frmMain);
            frmMain.PanelMain.Controls.Clear();
            frmMain.PanelMain.Controls.Add(new UCPoslovniPartneri());
            //if (frmMain.PanelMenu.Width == 100)
            //{
            //    StretchMainPanel(frmMain);
            //}
            //else
            //{
            //    ShrinkMainPanel(frmMain);
            //}
        }

        internal void PrikaziBicikle(FrmMain frmMain)
        {
            HandleIznajmljivanjaSelectionChangedBug(frmMain);
            frmMain.PanelMain.Controls.Clear();
            frmMain.PanelMain.Controls.Add(new UCKosilice());
            //if (frmMain.PanelMenu.Width == 100)
            //{
            //    StretchMainPanel(frmMain);
            //}
            //else
            //{
            //    ShrinkMainPanel(frmMain);
            //}
        }

        internal void PrikaziPocetna(FrmMain frmMain)
        {
            HandleIznajmljivanjaSelectionChangedBug(frmMain);
            frmMain.PanelMain.Controls.Clear();
            frmMain.PanelMain.Controls.Add(new UCPocetna());
            //if (frmMain.PanelMenu.Width == 100)
            //{
            //    StretchMainPanel(frmMain);
            //}
            //else
            //{
            //    ShrinkMainPanel(frmMain);
            //}
        }

        internal void PrikaziIznajmljivanja(FrmMain frmMain)
        {
            HandleIznajmljivanjaSelectionChangedBug(frmMain);
            frmMain.PanelMain.Controls.Clear();
            frmMain.PanelMain.Controls.Add(new UCIznajmljivanja());
            //if (frmMain.PanelMenu.Width == 100)
            //{
            //    StretchMainPanel(frmMain);
            //}
            //else
            //{
            //    ShrinkMainPanel(frmMain);
            //}
        }

        private static void HandleIznajmljivanjaSelectionChangedBug(FrmMain frmMain)
        {
            var currentControl = frmMain.PanelMain.Controls[0];

            if (currentControl is UCIznajmljivanja iznajmljivanjaControl)
            {
                iznajmljivanjaControl.DgvIznajmljivanja.SelectionChanged -= iznajmljivanjaControl.dgvIznajmljivanja_SelectionChanged;
                iznajmljivanjaControl.DgvStavke.SelectionChanged -= iznajmljivanjaControl.dgvStavke_SelectionChanged;
            }
        }
    }
}
