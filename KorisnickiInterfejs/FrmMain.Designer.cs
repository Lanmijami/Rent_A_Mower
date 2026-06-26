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
            btnUbaciVlasnika = new Button();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(259, -5);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1160, 617);
            panelMain.TabIndex = 0;
            // 
            // btnPocetna
            // 
            btnPocetna.Location = new Point(54, 97);
            btnPocetna.Margin = new Padding(4);
            btnPocetna.Name = "btnPocetna";
            btnPocetna.Size = new Size(197, 31);
            btnPocetna.TabIndex = 1;
            btnPocetna.Text = "Pocetna";
            btnPocetna.UseVisualStyleBackColor = true;
            btnPocetna.Click += btnPocetna_Click;
            // 
            // btnPoslovniPartneri
            // 
            btnPoslovniPartneri.Location = new Point(54, 165);
            btnPoslovniPartneri.Margin = new Padding(4);
            btnPoslovniPartneri.Name = "btnPoslovniPartneri";
            btnPoslovniPartneri.Size = new Size(197, 31);
            btnPoslovniPartneri.TabIndex = 2;
            btnPoslovniPartneri.Text = "Poslovni partneri";
            btnPoslovniPartneri.UseVisualStyleBackColor = true;
            btnPoslovniPartneri.Click += btnPoslovniPartneri_Click;
            // 
            // btnKosilice
            // 
            btnKosilice.Location = new Point(54, 237);
            btnKosilice.Margin = new Padding(4);
            btnKosilice.Name = "btnKosilice";
            btnKosilice.Size = new Size(197, 31);
            btnKosilice.TabIndex = 3;
            btnKosilice.Text = "Kosilice";
            btnKosilice.UseVisualStyleBackColor = true;
            btnKosilice.Click += btnKosilice_Click;
            // 
            // btnIznajmljivanja
            // 
            btnIznajmljivanja.Location = new Point(54, 313);
            btnIznajmljivanja.Margin = new Padding(4);
            btnIznajmljivanja.Name = "btnIznajmljivanja";
            btnIznajmljivanja.Size = new Size(197, 31);
            btnIznajmljivanja.TabIndex = 4;
            btnIznajmljivanja.Text = "Iznajmljivanja";
            btnIznajmljivanja.UseVisualStyleBackColor = true;
            btnIznajmljivanja.Click += btnIznajmljivanja_Click;
            // 
            // btnOdjava
            // 
            btnOdjava.Location = new Point(67, 557);
            btnOdjava.Margin = new Padding(4);
            btnOdjava.Name = "btnOdjava";
            btnOdjava.Size = new Size(107, 31);
            btnOdjava.TabIndex = 5;
            btnOdjava.Text = "Odjava";
            btnOdjava.UseVisualStyleBackColor = true;
            btnOdjava.Click += btnOdjava_Click;
            // 
            // btnUbaciVlasnika
            // 
            btnUbaciVlasnika.Location = new Point(54, 378);
            btnUbaciVlasnika.Name = "btnUbaciVlasnika";
            btnUbaciVlasnika.Size = new Size(197, 32);
            btnUbaciVlasnika.TabIndex = 6;
            btnUbaciVlasnika.Text = "Ubaci vlasnika";
            btnUbaciVlasnika.UseVisualStyleBackColor = true;
            btnUbaciVlasnika.Click += btnUbaciVlasnika_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 600);
            Controls.Add(btnUbaciVlasnika);
            Controls.Add(btnOdjava);
            Controls.Add(btnIznajmljivanja);
            Controls.Add(btnKosilice);
            Controls.Add(btnPoslovniPartneri);
            Controls.Add(btnPocetna);
            Controls.Add(panelMain);
            Margin = new Padding(4);
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
        private Button btnUbaciVlasnika;

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