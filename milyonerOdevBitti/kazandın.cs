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
    public partial class kazandın : Form
    {
        public kazandın()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "cekildin.wav";
            dolanSES.Stop();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void kazandın_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "kazandin.wav";
            dolanSES.Play();
        }
    }
}
