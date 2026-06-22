namespace KorisnickiInterfejs.UserControlls
{
    partial class UCPoslovniPartneri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelInfo = new Panel();
            btnObrisi = new Button();
            btnPromeni = new Button();
            btnPretrazi = new Button();
            btnUbaci = new Button();
            buttonDodaj = new Button();
            cmbMesto = new ComboBox();
            lblMesto = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            txtIme = new TextBox();
            lblIme = new Label();
            panelShow = new Panel();
            dgvPoslovniPartner = new DataGridView();
            btnKreiraj = new Button();
            lblPoslovniPartner = new Label();
            panelInfo.SuspendLayout();
            panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoslovniPartner).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(btnObrisi);
            panelInfo.Controls.Add(btnPromeni);
            panelInfo.Controls.Add(btnPretrazi);
            panelInfo.Controls.Add(btnUbaci);
            panelInfo.Controls.Add(buttonDodaj);
            panelInfo.Controls.Add(cmbMesto);
            panelInfo.Controls.Add(lblMesto);
            panelInfo.Controls.Add(txtEmail);
            panelInfo.Controls.Add(lblEmail);
            panelInfo.Controls.Add(txtPrezime);
            panelInfo.Controls.Add(lblPrezime);
            panelInfo.Controls.Add(txtIme);
            panelInfo.Controls.Add(lblIme);
            panelInfo.Location = new Point(25, 18);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(212, 457);
            panelInfo.TabIndex = 0;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(26, 380);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(75, 23);
            btnObrisi.TabIndex = 12;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnPromeni
            // 
            btnPromeni.Location = new Point(26, 351);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(75, 23);
            btnPromeni.TabIndex = 11;
            btnPromeni.Text = "Promeni";
            btnPromeni.UseVisualStyleBackColor = true;
            btnPromeni.Click += btnPromeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(26, 322);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 10;
            btnPretrazi.Text = "Pretrazi";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnUbaci
            // 
            btnUbaci.Location = new Point(26, 293);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(75, 23);
            btnUbaci.TabIndex = 9;
            btnUbaci.Text = "Ubaci";
            btnUbaci.UseVisualStyleBackColor = true;
            btnUbaci.Click += btnUbaci_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(156, 251);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(39, 23);
            buttonDodaj.TabIndex = 8;
            buttonDodaj.Text = "+";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // cmbMesto
            // 
            cmbMesto.FormattingEnabled = true;
            cmbMesto.Location = new Point(29, 251);
            cmbMesto.Name = "cmbMesto";
            cmbMesto.Size = new Size(121, 23);
            cmbMesto.TabIndex = 7;
            // 
            // lblMesto
            // 
            lblMesto.AutoSize = true;
            lblMesto.Location = new Point(26, 233);
            lblMesto.Name = "lblMesto";
            lblMesto.Size = new Size(40, 15);
            lblMesto.TabIndex = 6;
            lblMesto.Text = "Mesto";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(26, 125);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(100, 23);
            txtPrezime.TabIndex = 3;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(23, 98);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(26, 56);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(100, 23);
            txtIme.TabIndex = 1;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(23, 29);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            // 
            // panelShow
            // 
            panelShow.Controls.Add(dgvPoslovniPartner);
            panelShow.Controls.Add(btnKreiraj);
            panelShow.Controls.Add(lblPoslovniPartner);
            panelShow.Location = new Point(260, 18);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(534, 457);
            panelShow.TabIndex = 1;
            // 
            // dgvPoslovniPartner
            // 
            dgvPoslovniPartner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoslovniPartner.Location = new Point(26, 71);
            dgvPoslovniPartner.Name = "dgvPoslovniPartner";
            dgvPoslovniPartner.Size = new Size(483, 372);
            dgvPoslovniPartner.TabIndex = 2;
            dgvPoslovniPartner.SelectionChanged += dgvPoslovniPartner_SelectionChanged;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(350, 27);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(75, 23);
            btnKreiraj.TabIndex = 1;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // lblPoslovniPartner
            // 
            lblPoslovniPartner.AutoSize = true;
            lblPoslovniPartner.Location = new Point(26, 21);
            lblPoslovniPartner.Name = "lblPoslovniPartner";
            lblPoslovniPartner.Size = new Size(93, 15);
            lblPoslovniPartner.TabIndex = 0;
            lblPoslovniPartner.Text = "Poslovni partner";
            // 
            // UCPoslovniPartneri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelShow);
            Controls.Add(panelInfo);
            Name = "UCPoslovniPartneri";
            Size = new Size(825, 495);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoslovniPartner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private TextBox txtIme;
        private Label lblIme;
        private Panel panelShow;
        private Button btnObrisi;
        private Button btnPromeni;
        private Button btnPretrazi;
        private Button btnUbaci;
        private Button buttonDodaj;
        private ComboBox cmbMesto;
        private Label lblMesto;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPrezime;
        private Label lblPrezime;
        private DataGridView dgvPoslovniPartner;
        private Button btnKreiraj;
        private Label lblPoslovniPartner;

        public Panel PanelInfo { get => panelInfo; set => panelInfo = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public ComboBox CmbMesto { get => cmbMesto; set => cmbMesto = value; }
        public Label LblMesto { get => lblMesto; set => lblMesto = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Button BrnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Button BtnPromeni { get => btnPromeni; set => btnPromeni = value; }
        public Button BtnKreiraj { get => btnUbaci; set => btnUbaci = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Panel PanelShow { get => panelShow; set => panelShow = value; }
        public DataGridView DgvPoslovniPartneri { get => dgvPoslovniPartner; set => dgvPoslovniPartner = value; }
        public Label LblPoslovni { get => lblPoslovniPartner; set => lblPoslovniPartner = value; }
        public Button BtnPretrazi1 { get => btnPretrazi; set => btnPretrazi = value; }
        public Button ButtonKreiraj { get => btnKreiraj; set => btnKreiraj = value; }
    }
}
