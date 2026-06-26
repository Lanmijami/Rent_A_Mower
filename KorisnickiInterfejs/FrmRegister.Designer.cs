namespace KorisnickiInterfejs
{
    partial class FrmRegister
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
            lblSistem = new Label();
            lblPrijavi = new Label();
            btnPrijavi = new Button();
            panel1 = new Panel();
            lblRegistruj = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            checkbxShow = new CheckBox();
            lblDatum = new Label();
            dtpDatumProizvodnje = new DateTimePicker();
            lblVlasnik = new Label();
            cmbVlasnik = new ComboBox();
            buttonDodaj = new Button();
            btnRegistruj = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSistem
            // 
            lblSistem.AutoSize = true;
            lblSistem.Font = new Font("Arial Unicode MS", 20F, FontStyle.Bold);
            lblSistem.Location = new Point(14, 15);
            lblSistem.Margin = new Padding(4, 0, 4, 0);
            lblSistem.Name = "lblSistem";
            lblSistem.Size = new Size(435, 36);
            lblSistem.TabIndex = 0;
            lblSistem.Text = "Sistem za inzajmljivanje kosilica";
            lblSistem.Click += lblSistem_Click;
            // 
            // lblPrijavi
            // 
            lblPrijavi.AutoSize = true;
            lblPrijavi.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            lblPrijavi.Location = new Point(14, 339);
            lblPrijavi.Margin = new Padding(4, 0, 4, 0);
            lblPrijavi.Name = "lblPrijavi";
            lblPrijavi.Size = new Size(190, 31);
            lblPrijavi.TabIndex = 1;
            lblPrijavi.Text = "Prijavi ostavu";
            // 
            // btnPrijavi
            // 
            btnPrijavi.Location = new Point(231, 344);
            btnPrijavi.Margin = new Padding(4, 4, 4, 4);
            btnPrijavi.Name = "btnPrijavi";
            btnPrijavi.Size = new Size(107, 31);
            btnPrijavi.TabIndex = 2;
            btnPrijavi.Text = "Prijavi";
            btnPrijavi.UseVisualStyleBackColor = true;
            btnPrijavi.Click += btnPrijavi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSistem);
            panel1.Controls.Add(btnPrijavi);
            panel1.Controls.Add(lblPrijavi);
            panel1.Location = new Point(17, 16);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 568);
            panel1.TabIndex = 3;
            // 
            // lblRegistruj
            // 
            lblRegistruj.AutoSize = true;
            lblRegistruj.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            lblRegistruj.Location = new Point(524, 31);
            lblRegistruj.Margin = new Padding(4, 0, 4, 0);
            lblRegistruj.Name = "lblRegistruj";
            lblRegistruj.Size = new Size(226, 31);
            lblRegistruj.TabIndex = 4;
            lblRegistruj.Text = "Registruj ostavu";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(524, 104);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Korisnicko ime:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(524, 215);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Sifra:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(524, 128);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 26);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(524, 239);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(240, 26);
            txtPassword.TabIndex = 8;
            // 
            // checkbxShow
            // 
            checkbxShow.AutoSize = true;
            checkbxShow.Location = new Point(647, 273);
            checkbxShow.Margin = new Padding(4, 4, 4, 4);
            checkbxShow.Name = "checkbxShow";
            checkbxShow.Size = new Size(121, 24);
            checkbxShow.TabIndex = 9;
            checkbxShow.Text = "Prikazi sifru";
            checkbxShow.UseVisualStyleBackColor = true;
            checkbxShow.CheckedChanged += checkbxShow_CheckedChanged;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(546, 355);
            lblDatum.Margin = new Padding(4, 0, 4, 0);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(163, 20);
            lblDatum.TabIndex = 10;
            lblDatum.Text = "Datum proizvodnje:";
            // 
            // dtpDatumProizvodnje
            // 
            dtpDatumProizvodnje.Location = new Point(546, 379);
            dtpDatumProizvodnje.Margin = new Padding(4, 4, 4, 4);
            dtpDatumProizvodnje.Name = "dtpDatumProizvodnje";
            dtpDatumProizvodnje.Size = new Size(284, 26);
            dtpDatumProizvodnje.TabIndex = 11;
            // 
            // lblVlasnik
            // 
            lblVlasnik.AutoSize = true;
            lblVlasnik.Location = new Point(546, 455);
            lblVlasnik.Margin = new Padding(4, 0, 4, 0);
            lblVlasnik.Name = "lblVlasnik";
            lblVlasnik.Size = new Size(72, 20);
            lblVlasnik.TabIndex = 12;
            lblVlasnik.Text = "Vlasnik:";
            // 
            // cmbVlasnik
            // 
            cmbVlasnik.FormattingEnabled = true;
            cmbVlasnik.Location = new Point(546, 479);
            cmbVlasnik.Margin = new Padding(4, 4, 4, 4);
            cmbVlasnik.Name = "cmbVlasnik";
            cmbVlasnik.Size = new Size(171, 28);
            cmbVlasnik.TabIndex = 13;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(751, 477);
            buttonDodaj.Margin = new Padding(4, 4, 4, 4);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(107, 31);
            buttonDodaj.TabIndex = 14;
            buttonDodaj.Text = "+";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // btnRegistruj
            // 
            btnRegistruj.Location = new Point(546, 528);
            btnRegistruj.Margin = new Padding(4, 4, 4, 4);
            btnRegistruj.Name = "btnRegistruj";
            btnRegistruj.Size = new Size(312, 31);
            btnRegistruj.TabIndex = 15;
            btnRegistruj.Text = "Registruj";
            btnRegistruj.UseVisualStyleBackColor = true;
            btnRegistruj.Click += btnRegistruj_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 600);
            Controls.Add(btnRegistruj);
            Controls.Add(buttonDodaj);
            Controls.Add(cmbVlasnik);
            Controls.Add(lblVlasnik);
            Controls.Add(dtpDatumProizvodnje);
            Controls.Add(lblDatum);
            Controls.Add(checkbxShow);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblRegistruj);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmRegister";
            Text = "FrmRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistem;
        private Label lblPrijavi;
        private Button btnPrijavi;
        private Panel panel1;
        private Label lblRegistruj;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox checkbxShow;
        private Label lblDatum;
        private DateTimePicker dtpDatumProizvodnje;
        private Label lblVlasnik;
        private ComboBox cmbVlasnik;
        private Button buttonDodaj;
        private Button btnRegistruj;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        //public PictureBox PicLogo { get => picLogo; set => picLogo = value; }
        public Label LblSistem { get => lblSistem; set => lblSistem = value; }
        public Button BtnPrijavi { get => btnPrijavi; set => btnPrijavi = value; }
        public Label LblPrijavi { get => lblPrijavi; set => lblPrijavi = value; }
        public Button BtnRegistruj { get => btnRegistruj; set => btnRegistruj = value; }
        public CheckBox CheckbxShow { get => checkbxShow; set => checkbxShow = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public Label Lblusername { get => lblUsername; set => lblUsername = value; }
        public Label LblRegistrujOstavu { get => lblRegistruj; set => lblRegistruj = value; }
        //public Label LblX { get => lblX; set => lblX = value; }
        //public Label LblMinimize { get => lblMinimize; set => lblMinimize = value; }
        public DateTimePicker DtpDatumProizvodnje { get => dtpDatumProizvodnje; set => dtpDatumProizvodnje = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public ComboBox CmbVlasnik { get => cmbVlasnik; set => cmbVlasnik = value; }
        public Label LblLokacija { get => lblVlasnik; set => lblVlasnik = value; }
    }
}