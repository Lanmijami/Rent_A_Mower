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
            lblUbaciMesto.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            lblUbaciMesto.Location = new Point(141, 29);
            lblUbaciMesto.Margin = new Padding(4, 0, 4, 0);
            lblUbaciMesto.Name = "lblUbaciMesto";
            lblUbaciMesto.Size = new Size(176, 31);
            lblUbaciMesto.TabIndex = 0;
            lblUbaciMesto.Text = "Ubaci mesto";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(61, 124);
            lblNaziv.Margin = new Padding(4, 0, 4, 0);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(57, 20);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(61, 148);
            txtNaziv.Margin = new Padding(4, 4, 4, 4);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(141, 26);
            txtNaziv.TabIndex = 2;
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(61, 240);
            txtOpstina.Margin = new Padding(4, 4, 4, 4);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(141, 26);
            txtOpstina.TabIndex = 4;
            // 
            // lblOpstina
            // 
            lblOpstina.AutoSize = true;
            lblOpstina.Location = new Point(61, 216);
            lblOpstina.Margin = new Padding(4, 0, 4, 0);
            lblOpstina.Name = "lblOpstina";
            lblOpstina.Size = new Size(71, 20);
            lblOpstina.TabIndex = 3;
            lblOpstina.Text = "Opstina";
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(61, 336);
            txtDrzava.Margin = new Padding(4, 4, 4, 4);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(141, 26);
            txtDrzava.TabIndex = 6;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(61, 312);
            lblDrzava.Margin = new Padding(4, 0, 4, 0);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(65, 20);
            lblDrzava.TabIndex = 5;
            lblDrzava.Text = "Drzava";
            // 
            // btnUbaci
            // 
            btnUbaci.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            btnUbaci.Location = new Point(156, 471);
            btnUbaci.Margin = new Padding(4, 4, 4, 4);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(149, 55);
            btnUbaci.TabIndex = 7;
            btnUbaci.Text = "Ubaci";
            btnUbaci.UseVisualStyleBackColor = true;
            btnUbaci.Click += btnUbaci_Click;
            // 
            // UCUbaciMesto
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUbaci);
            Controls.Add(txtDrzava);
            Controls.Add(lblDrzava);
            Controls.Add(txtOpstina);
            Controls.Add(lblOpstina);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(lblUbaciMesto);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCUbaciMesto";
            Size = new Size(454, 572);
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
