namespace KorisnickiInterfejs.UserControlls
{
    partial class UCIznajmljivanja
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
            panelIznajmljivanja = new Panel();
            btnKreiraj = new Button();
            lblIznajmljivanja = new Label();
            dgvIznajmljivanja = new DataGridView();
            panelIznajmljivanjaControls = new Panel();
            cmbOstava = new ComboBox();
            cmbPoslovniPartner = new ComboBox();
            dtpDatumPovratka = new DateTimePicker();
            dtpDatumIznajmljivanja = new DateTimePicker();
            btnObrisiIznajmljivanje = new Button();
            btnPretraziIznajmljivanje = new Button();
            btnPromeniIznajmljivanje = new Button();
            btnUbaciIznajmljivanje = new Button();
            lblOstava = new Label();
            lblPoslovniPartner = new Label();
            lblDatumPovratka = new Label();
            lblDatumIznajmljivanja = new Label();
            panelStavkeControls = new Panel();
            btnObrisiStavka = new Button();
            btnUbaciStavka = new Button();
            lblKosilica = new Label();
            lblCena = new Label();
            txtCena = new TextBox();
            cmbKosilica = new ComboBox();
            panelStavke = new Panel();
            dgvStavke = new DataGridView();
            lblStavke = new Label();
            panelIznajmljivanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIznajmljivanja).BeginInit();
            panelIznajmljivanjaControls.SuspendLayout();
            panelStavkeControls.SuspendLayout();
            panelStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // panelIznajmljivanja
            // 
            panelIznajmljivanja.Controls.Add(btnKreiraj);
            panelIznajmljivanja.Controls.Add(lblIznajmljivanja);
            panelIznajmljivanja.Controls.Add(dgvIznajmljivanja);
            panelIznajmljivanja.Location = new Point(19, 19);
            panelIznajmljivanja.Margin = new Padding(4);
            panelIznajmljivanja.Name = "panelIznajmljivanja";
            panelIznajmljivanja.Size = new Size(619, 233);
            panelIznajmljivanja.TabIndex = 0;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(490, 17);
            btnKreiraj.Margin = new Padding(4);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(107, 31);
            btnKreiraj.TabIndex = 2;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // lblIznajmljivanja
            // 
            lblIznajmljivanja.AutoSize = true;
            lblIznajmljivanja.Location = new Point(27, 17);
            lblIznajmljivanja.Margin = new Padding(4, 0, 4, 0);
            lblIznajmljivanja.Name = "lblIznajmljivanja";
            lblIznajmljivanja.Size = new Size(116, 20);
            lblIznajmljivanja.TabIndex = 1;
            lblIznajmljivanja.Text = "Iznajmljivanja";
            // 
            // dgvIznajmljivanja
            // 
            dgvIznajmljivanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIznajmljivanja.Location = new Point(4, 68);
            dgvIznajmljivanja.Margin = new Padding(4);
            dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            dgvIznajmljivanja.Size = new Size(593, 165);
            dgvIznajmljivanja.TabIndex = 0;
            dgvIznajmljivanja.SelectionChanged += dgvIznajmljivanja_SelectionChanged;
            // 
            // panelIznajmljivanjaControls
            // 
            panelIznajmljivanjaControls.Controls.Add(cmbOstava);
            panelIznajmljivanjaControls.Controls.Add(cmbPoslovniPartner);
            panelIznajmljivanjaControls.Controls.Add(dtpDatumPovratka);
            panelIznajmljivanjaControls.Controls.Add(dtpDatumIznajmljivanja);
            panelIznajmljivanjaControls.Controls.Add(btnObrisiIznajmljivanje);
            panelIznajmljivanjaControls.Controls.Add(btnPretraziIznajmljivanje);
            panelIznajmljivanjaControls.Controls.Add(btnPromeniIznajmljivanje);
            panelIznajmljivanjaControls.Controls.Add(btnUbaciIznajmljivanje);
            panelIznajmljivanjaControls.Controls.Add(lblOstava);
            panelIznajmljivanjaControls.Controls.Add(lblPoslovniPartner);
            panelIznajmljivanjaControls.Controls.Add(lblDatumPovratka);
            panelIznajmljivanjaControls.Controls.Add(lblDatumIznajmljivanja);
            panelIznajmljivanjaControls.Location = new Point(19, 276);
            panelIznajmljivanjaControls.Margin = new Padding(4);
            panelIznajmljivanjaControls.Name = "panelIznajmljivanjaControls";
            panelIznajmljivanjaControls.Size = new Size(619, 265);
            panelIznajmljivanjaControls.TabIndex = 1;
            // 
            // cmbOstava
            // 
            cmbOstava.FormattingEnabled = true;
            cmbOstava.Location = new Point(200, 152);
            cmbOstava.Margin = new Padding(4);
            cmbOstava.Name = "cmbOstava";
            cmbOstava.Size = new Size(284, 28);
            cmbOstava.TabIndex = 11;
            // 
            // cmbPoslovniPartner
            // 
            cmbPoslovniPartner.FormattingEnabled = true;
            cmbPoslovniPartner.Location = new Point(200, 104);
            cmbPoslovniPartner.Margin = new Padding(4);
            cmbPoslovniPartner.Name = "cmbPoslovniPartner";
            cmbPoslovniPartner.Size = new Size(284, 28);
            cmbPoslovniPartner.TabIndex = 10;
            // 
            // dtpDatumPovratka
            // 
            dtpDatumPovratka.Location = new Point(200, 56);
            dtpDatumPovratka.Margin = new Padding(4);
            dtpDatumPovratka.Name = "dtpDatumPovratka";
            dtpDatumPovratka.Size = new Size(284, 26);
            dtpDatumPovratka.TabIndex = 9;
            dtpDatumPovratka.ValueChanged += dtpDatumPovratka_ValueChanged;
            // 
            // dtpDatumIznajmljivanja
            // 
            dtpDatumIznajmljivanja.Location = new Point(200, 12);
            dtpDatumIznajmljivanja.Margin = new Padding(4);
            dtpDatumIznajmljivanja.Name = "dtpDatumIznajmljivanja";
            dtpDatumIznajmljivanja.Size = new Size(284, 26);
            dtpDatumIznajmljivanja.TabIndex = 8;
            dtpDatumIznajmljivanja.ValueChanged += dtpDatumIznajmljivanja_ValueChanged;
            // 
            // btnObrisiIznajmljivanje
            // 
            btnObrisiIznajmljivanje.Location = new Point(505, 150);
            btnObrisiIznajmljivanje.Margin = new Padding(4);
            btnObrisiIznajmljivanje.Name = "btnObrisiIznajmljivanje";
            btnObrisiIznajmljivanje.Size = new Size(92, 31);
            btnObrisiIznajmljivanje.TabIndex = 7;
            btnObrisiIznajmljivanje.Text = "Obrisi";
            btnObrisiIznajmljivanje.UseVisualStyleBackColor = true;
            btnObrisiIznajmljivanje.Click += btnObrisiIznajmljivanje_Click;
            // 
            // btnPretraziIznajmljivanje
            // 
            btnPretraziIznajmljivanje.Location = new Point(505, 90);
            btnPretraziIznajmljivanje.Margin = new Padding(4);
            btnPretraziIznajmljivanje.Name = "btnPretraziIznajmljivanje";
            btnPretraziIznajmljivanje.Size = new Size(92, 31);
            btnPretraziIznajmljivanje.TabIndex = 6;
            btnPretraziIznajmljivanje.Text = "Pretrazi";
            btnPretraziIznajmljivanje.UseVisualStyleBackColor = true;
            btnPretraziIznajmljivanje.Click += btnPretraziIznajmljivanje_Click;
            // 
            // btnPromeniIznajmljivanje
            // 
            btnPromeniIznajmljivanje.Location = new Point(505, 34);
            btnPromeniIznajmljivanje.Margin = new Padding(4);
            btnPromeniIznajmljivanje.Name = "btnPromeniIznajmljivanje";
            btnPromeniIznajmljivanje.Size = new Size(92, 31);
            btnPromeniIznajmljivanje.TabIndex = 5;
            btnPromeniIznajmljivanje.Text = "Promeni";
            btnPromeniIznajmljivanje.UseVisualStyleBackColor = true;
            btnPromeniIznajmljivanje.Click += btnPromeniIznajmljivanje_Click;
            // 
            // btnUbaciIznajmljivanje
            // 
            btnUbaciIznajmljivanje.Location = new Point(505, 206);
            btnUbaciIznajmljivanje.Margin = new Padding(4);
            btnUbaciIznajmljivanje.Name = "btnUbaciIznajmljivanje";
            btnUbaciIznajmljivanje.Size = new Size(92, 31);
            btnUbaciIznajmljivanje.TabIndex = 4;
            btnUbaciIznajmljivanje.Text = "Ubaci";
            btnUbaciIznajmljivanje.UseVisualStyleBackColor = true;
            btnUbaciIznajmljivanje.Click += btnUbaciIznajmljivanje_Click;
            // 
            // lblOstava
            // 
            lblOstava.AutoSize = true;
            lblOstava.Location = new Point(19, 156);
            lblOstava.Margin = new Padding(4, 0, 4, 0);
            lblOstava.Name = "lblOstava";
            lblOstava.Size = new Size(70, 20);
            lblOstava.TabIndex = 3;
            lblOstava.Text = "Ostava:";
            // 
            // lblPoslovniPartner
            // 
            lblPoslovniPartner.AutoSize = true;
            lblPoslovniPartner.Location = new Point(19, 112);
            lblPoslovniPartner.Margin = new Padding(4, 0, 4, 0);
            lblPoslovniPartner.Name = "lblPoslovniPartner";
            lblPoslovniPartner.Size = new Size(143, 20);
            lblPoslovniPartner.TabIndex = 2;
            lblPoslovniPartner.Text = "Poslovni partner:";
            // 
            // lblDatumPovratka
            // 
            lblDatumPovratka.AutoSize = true;
            lblDatumPovratka.Location = new Point(19, 64);
            lblDatumPovratka.Margin = new Padding(4, 0, 4, 0);
            lblDatumPovratka.Name = "lblDatumPovratka";
            lblDatumPovratka.Size = new Size(141, 20);
            lblDatumPovratka.TabIndex = 1;
            lblDatumPovratka.Text = "Datum povratka:";
            // 
            // lblDatumIznajmljivanja
            // 
            lblDatumIznajmljivanja.AutoSize = true;
            lblDatumIznajmljivanja.Location = new Point(19, 20);
            lblDatumIznajmljivanja.Margin = new Padding(4, 0, 4, 0);
            lblDatumIznajmljivanja.Name = "lblDatumIznajmljivanja";
            lblDatumIznajmljivanja.Size = new Size(177, 20);
            lblDatumIznajmljivanja.TabIndex = 0;
            lblDatumIznajmljivanja.Text = "Datum iznajmljivanja:";
            // 
            // panelStavkeControls
            // 
            panelStavkeControls.AutoScroll = true;
            panelStavkeControls.Controls.Add(btnObrisiStavka);
            panelStavkeControls.Controls.Add(btnUbaciStavka);
            panelStavkeControls.Controls.Add(lblKosilica);
            panelStavkeControls.Controls.Add(lblCena);
            panelStavkeControls.Controls.Add(txtCena);
            panelStavkeControls.Controls.Add(cmbKosilica);
            panelStavkeControls.Location = new Point(646, 276);
            panelStavkeControls.Margin = new Padding(4);
            panelStavkeControls.Name = "panelStavkeControls";
            panelStavkeControls.Size = new Size(416, 265);
            panelStavkeControls.TabIndex = 2;
            // 
            // btnObrisiStavka
            // 
            btnObrisiStavka.Location = new Point(201, 212);
            btnObrisiStavka.Margin = new Padding(4);
            btnObrisiStavka.Name = "btnObrisiStavka";
            btnObrisiStavka.Size = new Size(107, 31);
            btnObrisiStavka.TabIndex = 5;
            btnObrisiStavka.Text = "Obrisi";
            btnObrisiStavka.UseVisualStyleBackColor = true;
            btnObrisiStavka.Click += btnObrisiStavka_Click;
            // 
            // btnUbaciStavka
            // 
            btnUbaciStavka.Location = new Point(41, 212);
            btnUbaciStavka.Margin = new Padding(4);
            btnUbaciStavka.Name = "btnUbaciStavka";
            btnUbaciStavka.Size = new Size(107, 31);
            btnUbaciStavka.TabIndex = 4;
            btnUbaciStavka.Text = "Ubaci";
            btnUbaciStavka.UseVisualStyleBackColor = true;
            btnUbaciStavka.Click += btnUbaciStavka_Click;
            // 
            // lblKosilica
            // 
            lblKosilica.AutoSize = true;
            lblKosilica.Location = new Point(35, 107);
            lblKosilica.Margin = new Padding(4, 0, 4, 0);
            lblKosilica.Name = "lblKosilica";
            lblKosilica.Size = new Size(75, 20);
            lblKosilica.TabIndex = 3;
            lblKosilica.Text = "Kosilica:";
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(35, 64);
            lblCena.Margin = new Padding(4, 0, 4, 0);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(56, 20);
            lblCena.TabIndex = 2;
            lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            txtCena.Location = new Point(127, 58);
            txtCena.Margin = new Padding(4);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(171, 26);
            txtCena.TabIndex = 1;
            // 
            // cmbKosilica
            // 
            cmbKosilica.FormattingEnabled = true;
            cmbKosilica.Location = new Point(127, 104);
            cmbKosilica.Margin = new Padding(4);
            cmbKosilica.Name = "cmbKosilica";
            cmbKosilica.Size = new Size(171, 28);
            cmbKosilica.TabIndex = 0;
            // 
            // panelStavke
            // 
            panelStavke.AutoScroll = true;
            panelStavke.Controls.Add(dgvStavke);
            panelStavke.Controls.Add(lblStavke);
            panelStavke.Location = new Point(646, 19);
            panelStavke.Margin = new Padding(4);
            panelStavke.Name = "panelStavke";
            panelStavke.Size = new Size(416, 233);
            panelStavke.TabIndex = 3;
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(4, 73);
            dgvStavke.Margin = new Padding(4);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.Size = new Size(408, 156);
            dgvStavke.TabIndex = 1;
            dgvStavke.SelectionChanged += dgvStavke_SelectionChanged;
            // 
            // lblStavke
            // 
            lblStavke.AutoSize = true;
            lblStavke.Location = new Point(46, 17);
            lblStavke.Margin = new Padding(4, 0, 4, 0);
            lblStavke.Name = "lblStavke";
            lblStavke.Size = new Size(64, 20);
            lblStavke.TabIndex = 0;
            lblStavke.Text = "Stavke";
            // 
            // UCIznajmljivanja
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelStavke);
            Controls.Add(panelStavkeControls);
            Controls.Add(panelIznajmljivanjaControls);
            Controls.Add(panelIznajmljivanja);
            Margin = new Padding(4);
            Name = "UCIznajmljivanja";
            Size = new Size(1207, 545);
            panelIznajmljivanja.ResumeLayout(false);
            panelIznajmljivanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIznajmljivanja).EndInit();
            panelIznajmljivanjaControls.ResumeLayout(false);
            panelIznajmljivanjaControls.PerformLayout();
            panelStavkeControls.ResumeLayout(false);
            panelStavkeControls.PerformLayout();
            panelStavke.ResumeLayout(false);
            panelStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIznajmljivanja;
        private Button btnKreiraj;
        private Label lblIznajmljivanja;
        private DataGridView dgvIznajmljivanja;
        private Panel panelIznajmljivanjaControls;
        private Button btnPretraziIznajmljivanje;
        private Button btnPromeniIznajmljivanje;
        private Button btnUbaciIznajmljivanje;
        private Label lblOstava;
        private Label lblPoslovniPartner;
        private Label lblDatumPovratka;
        private Label lblDatumIznajmljivanja;
        private Panel panelStavkeControls;
        private Panel panelStavke;
        private DataGridView dgvStavke;
        private Label lblStavke;
        private ComboBox cmbOstava;
        private ComboBox cmbPoslovniPartner;
        private DateTimePicker dtpDatumPovratka;
        private DateTimePicker dtpDatumIznajmljivanja;
        private Button btnObrisiIznajmljivanje;
        private Button btnObrisiStavka;
        private Button btnUbaciStavka;
        private Label lblKosilica;
        private Label lblCena;
        private TextBox txtCena;
        private ComboBox cmbKosilica;

        public DataGridView DgvIznajmljivanja { get => dgvIznajmljivanja; set => dgvIznajmljivanja = value; }
        public Panel PanelIznajmljivanja { get => panelIznajmljivanja; set => panelIznajmljivanja = value; }
        public Button BtnKreirajIznajmljivanje { get => btnKreiraj; set => btnKreiraj = value; }
        public Label LblIznajmljivanja { get => lblIznajmljivanja; set => lblIznajmljivanja = value; }
        public Label LblStavke { get => lblStavke; set => lblStavke = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Panel PanelStavke { get => panelStavke; set => panelStavke = value; }
        public Panel PanelIznajmljivanjaControls { get => panelIznajmljivanjaControls; set => panelIznajmljivanjaControls = value; }
        public DateTimePicker DtpIznajmljivanja { get => dtpDatumIznajmljivanja; set => dtpDatumIznajmljivanja = value; }
        public Label LblDatumIznajmljivanja { get => lblDatumIznajmljivanja; set => lblDatumIznajmljivanja = value; }
        public Label LblDatumPovratka { get => lblDatumPovratka; set => lblDatumPovratka = value; }
        public DateTimePicker DtpPovratka { get => dtpDatumPovratka; set => dtpDatumPovratka = value; }
        public Panel PanelStavkeControls { get => panelStavkeControls; set => panelStavkeControls = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public ComboBox CmbKosilica { get => cmbKosilica; set => cmbKosilica = value; }
        public Label LblKosilica { get => lblKosilica; set => lblKosilica = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Button BtnObrisiIznajmljivanje { get => btnObrisiIznajmljivanje; set => btnObrisiIznajmljivanje = value; }
        public Button BtnPretraziIznajmljivanje { get => btnPretraziIznajmljivanje; set => btnPretraziIznajmljivanje = value; }
        public Button BtnPromeniIznajmljivanje { get => btnPromeniIznajmljivanje; set => btnPromeniIznajmljivanje = value; }
        public Button BtnUbaciIznajmljivanje { get => btnUbaciIznajmljivanje; set => btnUbaciIznajmljivanje = value; }
        public ComboBox CmbPoslovniPartner { get => cmbPoslovniPartner; set => cmbPoslovniPartner = value; }
        public Button BtnObrisiStavka { get => btnObrisiStavka; set => btnObrisiStavka = value; }
        public Button BtnUbaciStavka { get => btnUbaciStavka; set => btnUbaciStavka = value; }
        public Label LblPoslovniPartner { get => lblPoslovniPartner; set => lblPoslovniPartner = value; }
        public Label LblAutomat { get => lblOstava; set => lblOstava = value; }
        public ComboBox CmbOstava { get => cmbOstava; set => cmbOstava = value; }
    }
}
