namespace KorisnickiInterfejs.UserControlls
{
    partial class UCUbaciMesto
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
            lblUbaciMesto = new Label();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            txtOpstina = new TextBox();
            lblOpstina = new Label();
            txtDrzava = new TextBox();
            lblDrzava = new Label();
            btnUbaci = new Button();
            SuspendLayout();
            // 
            // lblUbaciMesto
            // 
            lblUbaciMesto.AutoSize = true;
            lblUbaciMesto.Location = new Point(124, 24);
            lblUbaciMesto.Name = "lblUbaciMesto";
            lblUbaciMesto.Size = new Size(73, 15);
            lblUbaciMesto.TabIndex = 0;
            lblUbaciMesto.Text = "Ubaci mesto";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(43, 78);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(43, 111);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(100, 23);
            txtNaziv.TabIndex = 2;
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(43, 180);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(100, 23);
            txtOpstina.TabIndex = 4;
            // 
            // lblOpstina
            // 
            lblOpstina.AutoSize = true;
            lblOpstina.Location = new Point(43, 153);
            lblOpstina.Name = "lblOpstina";
            lblOpstina.Size = new Size(48, 15);
            lblOpstina.TabIndex = 3;
            lblOpstina.Text = "Opstina";
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(43, 252);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(100, 23);
            txtDrzava.TabIndex = 6;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(43, 225);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(42, 15);
            lblDrzava.TabIndex = 5;
            lblDrzava.Text = "Drzava";
            // 
            // btnUbaci
            // 
            btnUbaci.Location = new Point(124, 333);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(75, 23);
            btnUbaci.TabIndex = 7;
            btnUbaci.Text = "Ubaci";
            btnUbaci.UseVisualStyleBackColor = true;
            // 
            // UCUbaciMesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUbaci);
            Controls.Add(txtDrzava);
            Controls.Add(lblDrzava);
            Controls.Add(txtOpstina);
            Controls.Add(lblOpstina);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(lblUbaciMesto);
            Name = "UCUbaciMesto";
            Size = new Size(318, 429);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUbaciMesto;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private TextBox txtOpstina;
        private Label lblOpstina;
        private TextBox txtDrzava;
        private Label lblDrzava;
        private Button btnUbaci;

        //public Label LblX { get => lblX; set => lblX = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
        public Label LblUbaci { get => lblUbaciMesto; set => lblUbaciMesto = value; }
        public TextBox TxtOpstina { get => txtOpstina; set => txtOpstina = value; }
        public Label LblOpstina { get => lblOpstina; set => lblOpstina = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public Label LblDrzava { get => lblDrzava; set => lblDrzava = value; }
    }
}
