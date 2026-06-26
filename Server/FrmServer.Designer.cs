namespace Server
{
    partial class FrmServer
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
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(143, 154);
            btnStart.Margin = new Padding(6, 4, 6, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(379, 201);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(583, 154);
            btnStop.Margin = new Padding(6, 4, 6, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(399, 201);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(13F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 510);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FrmServer";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        public Button BtnStop { get => btnStop; set => btnStop = value; }
        public Button BtnStart { get => btnStart; set => btnStart = value; }
    }
}
