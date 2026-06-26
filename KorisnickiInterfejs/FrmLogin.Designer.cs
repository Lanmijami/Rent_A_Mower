namespace KorisnickiInterfejs
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSistem = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblSistem
            // 
            lblSistem.AutoSize = true;
            lblSistem.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblSistem.Location = new Point(27, 103);
            lblSistem.Margin = new Padding(4, 0, 4, 0);
            lblSistem.Name = "lblSistem";
            lblSistem.Size = new Size(502, 37);
            lblSistem.TabIndex = 0;
            lblSistem.Text = "Sistem za inzajmljivanje kosilica";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btnRegister.Location = new Point(27, 193);
            btnRegister.Margin = new Padding(4, 4, 4, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(296, 73);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registruj se";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            btnLogin.Location = new Point(639, 283);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 58);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Prijavi se";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(738, 103);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(141, 26);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(738, 169);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(141, 26);
            txtPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(634, 103);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(96, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(639, 169);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 380);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblSistem);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmLogin";
            Text = "Login";
            KeyDown += FrmLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistem;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;

        //public Panel Panel1 { get => panel1; set => panel1 = value; }
       // public PictureBox PicLogo { get => picLogo; set => picLogo = value; }
        public Label LblSistem { get => lblSistem; set => lblSistem = value; }
        public Button BtnRegister { get => btnRegister; set => btnRegister = value; }
        //public Label LblRegistruj { get => lblRegister; set => lblRegistruj = value; }
       // public Label LblMinimize { get => lblMinimize; set => lblMinimize = value; }
        public Button BtnLogin { get => btnLogin; set => btnLogin = value; }
        //public CheckBox CheckbxShow { get => checkbxShow; set => checkbxShow = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public Label Lblusername { get => lblUsername; set => lblUsername = value; }
        //public Label LblPrijavi { get => lblLogin; set => lblLogin = value; }
        //ublic Label LblX { get => lblX; set => lblX = value; }
    }
}
