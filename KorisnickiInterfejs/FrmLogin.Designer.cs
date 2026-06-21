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
            lblSistem.Location = new Point(57, 149);
            lblSistem.Name = "lblSistem";
            lblSistem.Size = new Size(173, 15);
            lblSistem.TabIndex = 0;
            lblSistem.Text = "Sistem za inzajmljivanje kosilica";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(117, 365);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registruj se";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(441, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Prijavi se";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(441, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(441, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(444, 77);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(450, 158);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblSistem);
            Name = "FrmLogin";
            Text = "Form1";
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
