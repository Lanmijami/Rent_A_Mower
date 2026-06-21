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
            panelIznajmljivanjaControls = new Panel();
            panelStavkeControls = new Panel();
            panelStavke = new Panel();
            dgvIznajmljivanja = new DataGridView();
            lblIznajmljivanja = new Label();
            btnKreiraj = new Button();
            lblStavke = new Label();
            dgvStavke = new DataGridView();
            lblDatumIznajmljivanja = new Label();
            lblDatumPovratka = new Label();
            lblPoslovniPartner = new Label();
            lblOstava = new Label();
            btnUbaciIznajmljivanje = new Button();
            btnPromeniIznajmljivanje = new Button();
            btnPretraziIznajmljivanje = new Button();
            btnObrisiIznajmljivanje = new Button();
            dtpDatumIznajmljivanja = new DateTimePicker();
            dtpDatumPovratka = new DateTimePicker();
            cmbPoslovniPartner = new ComboBox();
            cmbOstava = new ComboBox();
            cmbKosilica = new ComboBox();
            txtCena = new TextBox();
            lblCena = new Label();
            lblKosilica = new Label();
            btnUbaciStavka = new Button();
            btnObrisiStavka = new Button();
            panelIznajmljivanja.SuspendLayout();
            panelIznajmljivanjaControls.SuspendLayout();
            panelStavkeControls.SuspendLayout();
            panelStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIznajmljivanja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // panelIznajmljivanja
            // 
            panelIznajmljivanja.Controls.Add(btnKreiraj);
            panelIznajmljivanja.Controls.Add(lblIznajmljivanja);
            panelIznajmljivanja.Controls.Add(dgvIznajmljivanja);
            panelIznajmljivanja.Location = new Point(13, 14);
            panelIznajmljivanja.Name = "panelIznajmljivanja";
            panelIznajmljivanja.Size = new Size(368, 175);
            panelIznajmljivanja.TabIndex = 0;
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
            panelIznajmljivanjaControls.Location = new Point(13, 207);
            panelIznajmljivanjaControls.Name = "panelIznajmljivanjaControls";
            panelIznajmljivanjaControls.Size = new Size(368, 199);
            panelIznajmljivanjaControls.TabIndex = 1;
            // 
            // panelStavkeControls
            // 
            panelStavkeControls.Controls.Add(btnObrisiStavka);
            panelStavkeControls.Controls.Add(btnUbaciStavka);
            panelStavkeControls.Controls.Add(lblKosilica);
            panelStavkeControls.Controls.Add(lblCena);
            panelStavkeControls.Controls.Add(txtCena);
            panelStavkeControls.Controls.Add(cmbKosilica);
            panelStavkeControls.Location = new Point(402, 207);
            panelStavkeControls.Name = "panelStavkeControls";
            panelStavkeControls.Size = new Size(230, 199);
            panelStavkeControls.TabIndex = 2;
            // 
            // panelStavke
            // 
            panelStavke.Controls.Add(dgvStavke);
            panelStavke.Controls.Add(lblStavke);
            panelStavke.Location = new Point(402, 14);
            panelStavke.Name = "panelStavke";
            panelStavke.Size = new Size(230, 175);
            panelStavke.TabIndex = 3;
            // 
            // dgvIznajmljivanja
            // 
            dgvIznajmljivanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIznajmljivanja.Location = new Point(3, 64);
            dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            dgvIznajmljivanja.Size = new Size(314, 108);
            dgvIznajmljivanja.TabIndex = 0;
            // 
            // lblIznajmljivanja
            // 
            lblIznajmljivanja.AutoSize = true;
            lblIznajmljivanja.Location = new Point(19, 13);
            lblIznajmljivanja.Name = "lblIznajmljivanja";
            lblIznajmljivanja.Size = new Size(79, 15);
            lblIznajmljivanja.TabIndex = 1;
            lblIznajmljivanja.Text = "Iznajmljivanja";
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(242, 13);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(75, 23);
            btnKreiraj.TabIndex = 2;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            // 
            // lblStavke
            // 
            lblStavke.AutoSize = true;
            lblStavke.Location = new Point(32, 13);
            lblStavke.Name = "lblStavke";
            lblStavke.Size = new Size(41, 15);
            lblStavke.TabIndex = 0;
            lblStavke.Text = "Stavke";
            // 
            // dgvStavke
            // 
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(12, 43);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.Size = new Size(204, 117);
            dgvStavke.TabIndex = 1;
            // 
            // lblDatumIznajmljivanja
            // 
            lblDatumIznajmljivanja.AutoSize = true;
            lblDatumIznajmljivanja.Location = new Point(13, 15);
            lblDatumIznajmljivanja.Name = "lblDatumIznajmljivanja";
            lblDatumIznajmljivanja.Size = new Size(121, 15);
            lblDatumIznajmljivanja.TabIndex = 0;
            lblDatumIznajmljivanja.Text = "Datum iznajmljivanja:";
            // 
            // lblDatumPovratka
            // 
            lblDatumPovratka.AutoSize = true;
            lblDatumPovratka.Location = new Point(13, 48);
            lblDatumPovratka.Name = "lblDatumPovratka";
            lblDatumPovratka.Size = new Size(95, 15);
            lblDatumPovratka.TabIndex = 1;
            lblDatumPovratka.Text = "Datum povratka:";
            // 
            // lblPoslovniPartner
            // 
            lblPoslovniPartner.AutoSize = true;
            lblPoslovniPartner.Location = new Point(13, 84);
            lblPoslovniPartner.Name = "lblPoslovniPartner";
            lblPoslovniPartner.Size = new Size(96, 15);
            lblPoslovniPartner.TabIndex = 2;
            lblPoslovniPartner.Text = "Poslovni partner:";
            // 
            // lblOstava
            // 
            lblOstava.AutoSize = true;
            lblOstava.Location = new Point(13, 117);
            lblOstava.Name = "lblOstava";
            lblOstava.Size = new Size(46, 15);
            lblOstava.TabIndex = 3;
            lblOstava.Text = "Ostava:";
            // 
            // btnUbaciIznajmljivanje
            // 
            btnUbaciIznajmljivanje.Location = new Point(13, 165);
            btnUbaciIznajmljivanje.Name = "btnUbaciIznajmljivanje";
            btnUbaciIznajmljivanje.Size = new Size(60, 23);
            btnUbaciIznajmljivanje.TabIndex = 4;
            btnUbaciIznajmljivanje.Text = "Ubaci";
            btnUbaciIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // btnPromeniIznajmljivanje
            // 
            btnPromeniIznajmljivanje.Location = new Point(79, 165);
            btnPromeniIznajmljivanje.Name = "btnPromeniIznajmljivanje";
            btnPromeniIznajmljivanje.Size = new Size(60, 23);
            btnPromeniIznajmljivanje.TabIndex = 5;
            btnPromeniIznajmljivanje.Text = "Promeni";
            btnPromeniIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // btnPretraziIznajmljivanje
            // 
            btnPretraziIznajmljivanje.Location = new Point(145, 165);
            btnPretraziIznajmljivanje.Name = "btnPretraziIznajmljivanje";
            btnPretraziIznajmljivanje.Size = new Size(54, 23);
            btnPretraziIznajmljivanje.TabIndex = 6;
            btnPretraziIznajmljivanje.Text = "Pretrazi";
            btnPretraziIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // btnObrisiIznajmljivanje
            // 
            btnObrisiIznajmljivanje.Location = new Point(205, 165);
            btnObrisiIznajmljivanje.Name = "btnObrisiIznajmljivanje";
            btnObrisiIznajmljivanje.Size = new Size(57, 23);
            btnObrisiIznajmljivanje.TabIndex = 7;
            btnObrisiIznajmljivanje.Text = "Obrisi";
            btnObrisiIznajmljivanje.UseVisualStyleBackColor = true;
            // 
            // dtpDatumIznajmljivanja
            // 
            dtpDatumIznajmljivanja.Location = new Point(140, 9);
            dtpDatumIznajmljivanja.Name = "dtpDatumIznajmljivanja";
            dtpDatumIznajmljivanja.Size = new Size(200, 23);
            dtpDatumIznajmljivanja.TabIndex = 8;
            // 
            // dtpDatumPovratka
            // 
            dtpDatumPovratka.Location = new Point(140, 42);
            dtpDatumPovratka.Name = "dtpDatumPovratka";
            dtpDatumPovratka.Size = new Size(200, 23);
            dtpDatumPovratka.TabIndex = 9;
            // 
            // cmbPoslovniPartner
            // 
            cmbPoslovniPartner.FormattingEnabled = true;
            cmbPoslovniPartner.Location = new Point(130, 78);
            cmbPoslovniPartner.Name = "cmbPoslovniPartner";
            cmbPoslovniPartner.Size = new Size(121, 23);
            cmbPoslovniPartner.TabIndex = 10;
            // 
            // cmbOstava
            // 
            cmbOstava.FormattingEnabled = true;
            cmbOstava.Location = new Point(130, 114);
            cmbOstava.Name = "cmbOstava";
            cmbOstava.Size = new Size(121, 23);
            cmbOstava.TabIndex = 11;
            // 
            // cmbKosilica
            // 
            cmbKosilica.FormattingEnabled = true;
            cmbKosilica.Location = new Point(89, 78);
            cmbKosilica.Name = "cmbKosilica";
            cmbKosilica.Size = new Size(121, 23);
            cmbKosilica.TabIndex = 0;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(98, 45);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(100, 23);
            txtCena.TabIndex = 1;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(29, 48);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(37, 15);
            lblCena.TabIndex = 2;
            lblCena.Text = "Cena:";
            // 
            // lblKosilica
            // 
            lblKosilica.AutoSize = true;
            lblKosilica.Location = new Point(32, 81);
            lblKosilica.Name = "lblKosilica";
            lblKosilica.Size = new Size(50, 15);
            lblKosilica.TabIndex = 3;
            lblKosilica.Text = "Kosilica:";
            // 
            // btnUbaciStavka
            // 
            btnUbaciStavka.Location = new Point(29, 159);
            btnUbaciStavka.Name = "btnUbaciStavka";
            btnUbaciStavka.Size = new Size(75, 23);
            btnUbaciStavka.TabIndex = 4;
            btnUbaciStavka.Text = "Ubaci";
            btnUbaciStavka.UseVisualStyleBackColor = true;
            // 
            // btnObrisiStavka
            // 
            btnObrisiStavka.Location = new Point(141, 159);
            btnObrisiStavka.Name = "btnObrisiStavka";
            btnObrisiStavka.Size = new Size(75, 23);
            btnObrisiStavka.TabIndex = 5;
            btnObrisiStavka.Text = "Obrisi";
            btnObrisiStavka.UseVisualStyleBackColor = true;
            // 
            // UCIznajmljivanja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelStavke);
            Controls.Add(panelStavkeControls);
            Controls.Add(panelIznajmljivanjaControls);
            Controls.Add(panelIznajmljivanja);
            Name = "UCIznajmljivanja";
            Size = new Size(651, 420);
            panelIznajmljivanja.ResumeLayout(false);
            panelIznajmljivanja.PerformLayout();
            panelIznajmljivanjaControls.ResumeLayout(false);
            panelIznajmljivanjaControls.PerformLayout();
            panelStavkeControls.ResumeLayout(false);
            panelStavkeControls.PerformLayout();
            panelStavke.ResumeLayout(false);
            panelStavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIznajmljivanja).EndInit();
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
