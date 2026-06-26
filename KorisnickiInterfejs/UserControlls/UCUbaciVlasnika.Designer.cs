namespace KorisnickiInterfejs.UserControlls
{
    partial class UCUbaciVlasnika
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
            lblUbaciVlasnika = new Label();
            lblIme = new Label();
            lblPrezime = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            btnUbaci = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // lblUbaciVlasnika
            // 
            lblUbaciVlasnika.AutoSize = true;
            lblUbaciVlasnika.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            lblUbaciVlasnika.Location = new Point(157, 36);
            lblUbaciVlasnika.Margin = new Padding(4, 0, 4, 0);
            lblUbaciVlasnika.Name = "lblUbaciVlasnika";
            lblUbaciVlasnika.Size = new Size(204, 31);
            lblUbaciVlasnika.TabIndex = 0;
            lblUbaciVlasnika.Text = "Ubaci vlasnika";
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(36, 109);
            lblIme.Margin = new Padding(4, 0, 4, 0);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(44, 20);
            lblIme.TabIndex = 1;
            lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(36, 201);
            lblPrezime.Margin = new Padding(4, 0, 4, 0);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(78, 20);
            lblPrezime.TabIndex = 2;
            lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(40, 133);
            txtIme.Margin = new Padding(4, 4, 4, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(141, 26);
            txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(40, 225);
            txtPrezime.Margin = new Padding(4, 4, 4, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(141, 26);
            txtPrezime.TabIndex = 4;
            // 
            // btnUbaci
            // 
            btnUbaci.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            btnUbaci.Location = new Point(183, 389);
            btnUbaci.Margin = new Padding(4, 4, 4, 4);
            btnUbaci.Name = "btnUbaci";
            btnUbaci.Size = new Size(140, 64);
            btnUbaci.TabIndex = 5;
            btnUbaci.Text = "Ubaci";
            btnUbaci.UseVisualStyleBackColor = true;
            btnUbaci.Click += btnUbaci_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(303, 109);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 133);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 26);
            txtEmail.TabIndex = 7;
            // 
            // UCUbaciVlasnika
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnUbaci);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(lblPrezime);
            Controls.Add(lblIme);
            Controls.Add(lblUbaciVlasnika);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCUbaciVlasnika";
            Size = new Size(506, 484);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUbaciVlasnika;
        private Label lblIme;
        private Label lblPrezime;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private Button btnUbaci;
        private Label lblEmail;
        private TextBox txtEmail;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label LblPrezime{ get => lblPrezime; set => lblPrezime = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblUbaciVlasnika { get => lblUbaciVlasnika; set => lblUbaciVlasnika = value; }
        public Button BtnUbaci { get => btnUbaci; set => btnUbaci = value; }
    }
}
