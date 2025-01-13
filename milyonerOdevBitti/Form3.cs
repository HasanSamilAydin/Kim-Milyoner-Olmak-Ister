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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "cekildin.wav";
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            dolanSES.Stop();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "cekildin.wav";
            dolanSES.Play();
        }
    }
}
