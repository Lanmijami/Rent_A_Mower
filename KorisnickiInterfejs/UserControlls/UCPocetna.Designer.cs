namespace KorisnickiInterfejs.UserControlls
{
    partial class UCPocetna
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
            panelBicikle = new Panel();
            lblKosilica = new Label();
            lblBrKosilica = new Label();
            panelOstave = new Panel();
            lblOstave = new Label();
            lblBrOstava = new Label();
            panelPartneri = new Panel();
            lblPartneri = new Label();
            lblBrPartnera = new Label();
            pictureBox1 = new PictureBox();
            panelBicikle.SuspendLayout();
            panelOstave.SuspendLayout();
            panelPartneri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBicikle
            // 
            panelBicikle.Controls.Add(lblKosilica);
            panelBicikle.Controls.Add(lblBrKosilica);
            panelBicikle.Location = new Point(41, 45);
            panelBicikle.Name = "panelBicikle";
            panelBicikle.Size = new Size(134, 100);
            panelBicikle.TabIndex = 0;
            // 
            // lblKosilica
            // 
            lblKosilica.AutoSize = true;
            lblKosilica.Location = new Point(45, 72);
            lblKosilica.Name = "lblKosilica";
            lblKosilica.Size = new Size(70, 15);
            lblKosilica.TabIndex = 1;
            lblKosilica.Text = "Broj kosilica";
            // 
            // lblBrKosilica
            // 
            lblBrKosilica.AutoSize = true;
            lblBrKosilica.Location = new Point(102, 6);
            lblBrKosilica.Name = "lblBrKosilica";
            lblBrKosilica.Size = new Size(13, 15);
            lblBrKosilica.TabIndex = 0;
            lblBrKosilica.Text = "0";
            // 
            // panelOstave
            // 
            panelOstave.Controls.Add(lblOstave);
            panelOstave.Controls.Add(lblBrOstava);
            panelOstave.Location = new Point(228, 45);
            panelOstave.Name = "panelOstave";
            panelOstave.Size = new Size(140, 100);
            panelOstave.TabIndex = 1;
            // 
            // lblOstave
            // 
            lblOstave.AutoSize = true;
            lblOstave.Location = new Point(62, 75);
            lblOstave.Name = "lblOstave";
            lblOstave.Size = new Size(65, 15);
            lblOstave.TabIndex = 1;
            lblOstave.Text = "Broj ostava";
            // 
            // lblBrOstava
            // 
            lblBrOstava.AutoSize = true;
            lblBrOstava.Location = new Point(114, 6);
            lblBrOstava.Name = "lblBrOstava";
            lblBrOstava.Size = new Size(13, 15);
            lblBrOstava.TabIndex = 0;
            lblBrOstava.Text = "0";
            // 
            // panelPartneri
            // 
            panelPartneri.Controls.Add(lblPartneri);
            panelPartneri.Controls.Add(lblBrPartnera);
            panelPartneri.Location = new Point(412, 45);
            panelPartneri.Name = "panelPartneri";
            panelPartneri.Size = new Size(158, 100);
            panelPartneri.TabIndex = 2;
            // 
            // lblPartneri
            // 
            lblPartneri.AutoSize = true;
            lblPartneri.Location = new Point(80, 75);
            lblPartneri.Name = "lblPartneri";
            lblPartneri.Size = new Size(75, 15);
            lblPartneri.TabIndex = 1;
            lblPartneri.Text = "Broj partnera";
            // 
            // lblBrPartnera
            // 
            lblBrPartnera.AutoSize = true;
            lblBrPartnera.Location = new Point(130, 6);
            lblBrPartnera.Name = "lblBrPartnera";
            lblBrPartnera.Size = new Size(13, 15);
            lblBrPartnera.TabIndex = 0;
            lblBrPartnera.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(92, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 137);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UCPocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(panelPartneri);
            Controls.Add(panelOstave);
            Controls.Add(panelBicikle);
            Name = "UCPocetna";
            Size = new Size(630, 414);
            panelBicikle.ResumeLayout(false);
            panelBicikle.PerformLayout();
            panelOstave.ResumeLayout(false);
            panelOstave.PerformLayout();
            panelPartneri.ResumeLayout(false);
            panelPartneri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBicikle;
        private Label lblKosilica;
        private Label lblBrKosilica;
        private Panel panelOstave;
        private Label lblOstave;
        private Label lblBrOstava;
        private Panel panelPartneri;
        private Label lblPartneri;
        private Label lblBrPartnera;
        private PictureBox pictureBox1;

        //public Panel PanelTop { get => panelTop; set => panelTop = value; }
        //public Panel PanelBottom { get => panelBottom; set => panelBottom = value; }
        public Panel PanelBicikle { get => panelBicikle; set => panelBicikle = value; }
        public Panel PanelPartneri { get => panelPartneri; set => panelPartneri = value; }
        public Panel PanelOstave{ get => panelOstave; set => panelOstave = value; }
        //public PictureBox PbBicikle { get => pbBicikle; set => pbBicikle = value; }
        //public PictureBox PbAutomati { get => pbAutomati; set => pbAutomati = value; }
        //public PictureBox PbPartneri { get => pbPartneri; set => pbPartneri = value; }
        public Label LblKosilice { get => lblKosilica; set => lblKosilica = value; }
        public Label LblBrKosilice { get => lblBrKosilica; set => lblBrKosilica = value; }
        public Label LblBrPartneri { get => lblBrPartnera; set => lblBrPartnera = value; }
        public Label LblPartneri { get => lblPartneri; set => lblPartneri = value; }
        public Label LblBrOstava { get => lblBrOstava; set => lblBrOstava = value; }
        public Label LblOstave { get => lblOstave; set => lblOstave = value; }
    }
}
