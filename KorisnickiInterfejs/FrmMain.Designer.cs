namespace KorisnickiInterfejs
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            btnPocetna = new Button();
            btnPoslovniPartneri = new Button();
            btnKosilice = new Button();
            btnIznajmljivanja = new Button();
            btnOdjava = new Button();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(335, -4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(467, 463);
            panelMain.TabIndex = 0;
            // 
            // btnPocetna
            // 
            btnPocetna.Location = new Point(38, 73);
            btnPocetna.Name = "btnPocetna";
            btnPocetna.Size = new Size(138, 23);
            btnPocetna.TabIndex = 1;
            btnPocetna.Text = "Pocetna";
            btnPocetna.UseVisualStyleBackColor = true;
            btnPocetna.Click += btnPocetna_Click;
            // 
            // btnPoslovniPartneri
            // 
            btnPoslovniPartneri.Location = new Point(38, 124);
            btnPoslovniPartneri.Name = "btnPoslovniPartneri";
            btnPoslovniPartneri.Size = new Size(138, 23);
            btnPoslovniPartneri.TabIndex = 2;
            btnPoslovniPartneri.Text = "Poslovni partneri";
            btnPoslovniPartneri.UseVisualStyleBackColor = true;
            btnPoslovniPartneri.Click += btnPoslovniPartneri_Click;
            // 
            // btnKosilice
            // 
            btnKosilice.Location = new Point(38, 178);
            btnKosilice.Name = "btnKosilice";
            btnKosilice.Size = new Size(138, 23);
            btnKosilice.TabIndex = 3;
            btnKosilice.Text = "Kosilice";
            btnKosilice.UseVisualStyleBackColor = true;
            btnKosilice.Click += btnKosilice_Click;
            // 
            // btnIznajmljivanja
            // 
            btnIznajmljivanja.Location = new Point(38, 235);
            btnIznajmljivanja.Name = "btnIznajmljivanja";
            btnIznajmljivanja.Size = new Size(138, 23);
            btnIznajmljivanja.TabIndex = 4;
            btnIznajmljivanja.Text = "Iznajmljivanja";
            btnIznajmljivanja.UseVisualStyleBackColor = true;
            btnIznajmljivanja.Click += btnIznajmljivanja_Click;
            // 
            // btnOdjava
            // 
            btnOdjava.Location = new Point(47, 418);
            btnOdjava.Name = "btnOdjava";
            btnOdjava.Size = new Size(75, 23);
            btnOdjava.TabIndex = 5;
            btnOdjava.Text = "Odjava";
            btnOdjava.UseVisualStyleBackColor = true;
            btnOdjava.Click += btnOdjava_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOdjava);
            Controls.Add(btnIznajmljivanja);
            Controls.Add(btnKosilice);
            Controls.Add(btnPoslovniPartneri);
            Controls.Add(btnPocetna);
            Controls.Add(panelMain);
            Name = "FrmMain";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button btnPocetna;
        private Button btnPoslovniPartneri;
        private Button btnKosilice;
        private Button btnIznajmljivanja;
        private Button btnOdjava;

        //public Panel PanelMenu { get => panelMenu; set => panelMenu = value; }
        //public Panel PanelLogo { get => panelLogo; set => panelLogo = value; }
        //public PictureBox PbLogo { get => pbLogo; set => pbLogo = value; }
        //public IconButton IbNavicon { get => ibNavicon; set => ibNavicon = value; }
        //public IconButton IbHome { get => ibHome; set => ibHome = value; }
        //public IconButton IbSignOut { get => ibSignOut; set => ibSignOut = value; }
        //public IconButton IbPoslovniPartneri { get => ibPoslovniPartneri; set => ibPoslovniPartneri = value; }
        //public Label LblMinimize { get => lblMinimize; set => lblMinimize = value; }
        //public Label LblX { get => lblX; set => lblX = value; }
        public Panel PanelMain { get => panelMain; set => panelMain = value; }
    }
}