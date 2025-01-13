using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace milyonerOdevBitti
{
    public partial class dolanSure : Form
    {
        public dolanSure()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "sureDoldu.wav";
            dolanSES.Stop();
        }

        private void dolanSure_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();
            dolanSES.SoundLocation = "sureDoldu.wav";
            dolanSES.Play();
        }
    }
}
