namespace KorisnickiInterfejs.UserControlls
{
    partial class UCKosilice
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
            txtCena = new TextBox();
            lblCena = new Label();
            txtGodinaProizvodnje = new TextBox();
            lblGodinaProizvodnje = new Label();
            txtBoja = new TextBox();
            lblBoja = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            panelShow = new Panel();
            dgvKosilice = new DataGridView();
            btnKreiraj = new Button();
            lblKosilice = new Label();
            panelInfo.SuspendLayout();
            panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKosilice).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(btnObrisi);
            panelInfo.Controls.Add(btnPromeni);
            panelInfo.Controls.Add(btnPretrazi);
            panelInfo.Controls.Add(btnUbaci);
            panelInfo.Controls.Add(txtCena);
            panelInfo.Controls.Add(lblCena);
            panelInfo.Controls.Add(txtGodinaProizvodnje);
            panelInfo.Controls.Add(lblGodinaProizvodnje);
            panelInfo.Controls.Add(txtBoja);
            panelInfo.Controls.Add(lblBoja);
            panelInfo.Controls.Add(txtModel);
            panelInfo.Controls.Add(lblModel);
            panelInfo.Location = new Point(22, 12);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(200, 454);
            panelInfo.TabIndex = 0;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(104, 349);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(75, 23);
            btnObrisi.TabIndex = 11;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnPromeni
            // 
            btnPromeni.Location = new Point(23, 349);
            btnPromeni.Name = "btnPromeni";
            btnPromeni.Size = new Size(75, 23);
            btnPromeni.TabIndex = 10;
            btnPromeni.Text = "Promeni";
            btnPromeni.UseVisualStyleBackColor = true;
            btnPromeni.Click += btnPromeni_Click;
            // 
            // btnPretrazi
            // 
            btnPretrazi.Location = new Point(104, 320);
            btnPretrazi.Name = "btnPretrazi";
            btnPretrazi.Size = new Size(75, 23);
            btnPretrazi.TabIndex = 9;
            btnPretrazi.Text = "Pretrazi";
            btnPretrazi.UseVisualStyleBackColor = true;
            btnPretrazi.Click += btnPretrazi_Click;
            // 
            // btnUbaci
            // 
            btnUbaci.Location = new Point(23, 320);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(75, 23);
            btnUbaci.TabIndex = 8;
            btnUbaci.Text = "Ubaci";
            btnUbaci.UseVisualStyleBackColor = true;
            btnUbaci.Click += btnUbaci_Click;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(23, 253);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(100, 23);
            txtCena.TabIndex = 7;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(23, 226);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(37, 15);
            lblCena.TabIndex = 6;
            lblCena.Text = "Cena:";
            // 
            // txtGodinaProizvodnje
            // 
            txtGodinaProizvodnje.Location = new Point(23, 184);
            txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            txtGodinaProizvodnje.Size = new Size(100, 23);
            txtGodinaProizvodnje.TabIndex = 5;
            // 
            // lblGodinaProizvodnje
            // 
            lblGodinaProizvodnje.AutoSize = true;
            lblGodinaProizvodnje.Location = new Point(23, 157);
            lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            lblGodinaProizvodnje.Size = new Size(113, 15);
            lblGodinaProizvodnje.TabIndex = 4;
            lblGodinaProizvodnje.Text = "Godina proizvodnje:";
            // 
            // txtBoja
            // 
            txtBoja.Location = new Point(23, 112);
            txtBoja.Name = "txtBoja";
            txtBoja.Size = new Size(100, 23);
            txtBoja.TabIndex = 3;
            // 
            // lblBoja
            // 
            lblBoja.AutoSize = true;
            lblBoja.Location = new Point(23, 85);
            lblBoja.Name = "lblBoja";
            lblBoja.Size = new Size(33, 15);
            lblBoja.TabIndex = 2;
            lblBoja.Text = "Boja:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(23, 47);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 1;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(23, 20);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 0;
            lblModel.Text = "Model:";
            // 
            // panelShow
            // 
            panelShow.Controls.Add(dgvKosilice);
            panelShow.Controls.Add(btnKreiraj);
            panelShow.Controls.Add(lblKosilice);
            panelShow.Location = new Point(251, 12);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(452, 454);
            panelShow.TabIndex = 1;
            // 
            // dgvKosilice
            // 
            dgvKosilice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKosilice.Location = new Point(28, 57);
            dgvKosilice.Name = "dgvKosilice";
            dgvKosilice.Size = new Size(408, 378);
            dgvKosilice.TabIndex = 2;
            dgvKosilice.SelectionChanged += dgvKosilice_SelectionChanged;
            // 
            // btnKreiraj
            // 
            btnKreiraj.Location = new Point(361, 16);
            btnKreiraj.Name = "btnKreiraj";
            btnKreiraj.Size = new Size(75, 23);
            btnKreiraj.TabIndex = 1;
            btnKreiraj.Text = "Kreiraj";
            btnKreiraj.UseVisualStyleBackColor = true;
            btnKreiraj.Click += btnKreiraj_Click;
            // 
            // lblKosilice
            // 
            lblKosilice.AutoSize = true;
            lblKosilice.Location = new Point(28, 20);
            lblKosilice.Name = "lblKosilice";
            lblKosilice.Size = new Size(47, 15);
            lblKosilice.TabIndex = 0;
            lblKosilice.Text = "Kosilice";
            // 
            // UCKosilice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelShow);
            Controls.Add(panelInfo);
            Name = "UCKosilice";
            Size = new Size(732, 486);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelShow.ResumeLayout(false);
            panelShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKosilice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Button btnObrisi;
        private Button btnPromeni;
        private Button btnPretrazi;
        private Button btnUbaci;
        private TextBox txtCena;
        private Label lblCena;
        private TextBox txtGodinaProizvodnje;
        private Label lblGodinaProizvodnje;
        private TextBox txtBoja;
        private Label lblBoja;
        private TextBox txtModel;
        private Label lblModel;
        private Panel panelShow;
        private DataGridView dgvKosilice;
        private Button btnKreiraj;
        private Label lblKosilice;

        public Panel PanelShow { get => panelShow; set => panelShow = value; }
        public Button ButtonKreiraj { get => btnKreiraj; set => btnKreiraj = value; }
        public Label LblKosilice { get => lblKosilice; set => lblKosilice = value; }
        public DataGridView DgvKosilice { get => dgvKosilice; set => dgvKosilice = value; }
        public Panel PanelInfo { get => panelInfo; set => panelInfo = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Button BrnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Button BtnPromeni { get => btnPromeni; set => btnPromeni = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblGodinaProizvodnje { get => lblGodinaProizvodnje; set => lblGodinaProizvodnje = value; }
        public TextBox TxtBoja { get => txtBoja; set => txtBoja = value; }
        public Label LblBoja { get => lblBoja; set => lblBoja = value; }
        public TextBox TxtModel { get => txtModel; set => txtModel = value; }
        public Label LblModel { get => lblModel; set => lblModel = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtGodinaProizvodnje { get => txtGodinaProizvodnje; set => txtGodinaProizvodnje = value; }
    }
}
