using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milyonerOdevBitti
{
    public partial class kaybetti : Form
    {
        public kaybetti()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "kaybettin.wav";
            dolanSES.Stop();
            Form1 form = new Form1();
            form.Show();
            this.Close();
            dolanSES.Stop();
        }

        private void kaybetti_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "kaybettin.wav";
            dolanSES.Play();
        }
    }
}
