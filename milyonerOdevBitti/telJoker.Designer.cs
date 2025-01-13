namespace milyonerOdevBitti
{
    partial class telJoker
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telJoker));
            pbİlber = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbİlber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbİlber
            // 
            pbİlber.Image = Properties.Resources.ilber;
            pbİlber.Location = new Point(52, 12);
            pbİlber.Name = "pbİlber";
            pbİlber.Size = new Size(241, 141);
            pbİlber.SizeMode = PictureBoxSizeMode.StretchImage;
            pbİlber.TabIndex = 0;
            pbİlber.TabStop = false;
            pbİlber.Click += pbİlber_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zeci_celal;
            pictureBox1.Location = new Point(52, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ege;
            pictureBox2.Location = new Point(52, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // telJoker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(393, 461);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbİlber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telJoker";
            StartPosition = FormStartPosition.CenterParent;
            Text = "telJoker";
            FormClosed += telJoker_FormClosed;
            Load += telJoker_Load;
            ((System.ComponentModel.ISupportInitialize)pbİlber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbİlber;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}