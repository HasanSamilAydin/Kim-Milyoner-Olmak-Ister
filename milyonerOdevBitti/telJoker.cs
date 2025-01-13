using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace milyonerOdevBitti
{
    public partial class telJoker : Form
    {
        public string degisken;
        public string cevapA;
        public string cevapB;
        public string cevapC;
        public string cevapD;
        public string sesSure;


        public telJoker()
        {
            InitializeComponent();
        }

        private void pbİlber_Click(object sender, EventArgs e)
        {


        }

        private void pbCelal_Click(object sender, EventArgs e)
        {

        }

        private void pbEge_Click(object sender, EventArgs e)
        {

            MessageBox.Show(degisken, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void telJoker_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
            sesSure.SoundLocation = "sure.wav";
            sesSure.Stop();
        }

        private void telJoker_FormClosed(object sender, FormClosedEventArgs e)
        {





        }

        private void pbİlber_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ilber = new System.Media.SoundPlayer();
            ilber.SoundLocation = "ilber.wav";
            ilber.Play();
            if (MessageBox.Show(degisken, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //celal
            System.Media.SoundPlayer celal = new System.Media.SoundPlayer();
            celal.SoundLocation = "celal.wav";
            celal.Play();
            if (MessageBox.Show(degisken, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ege = new System.Media.SoundPlayer();
            ege.SoundLocation = "ege.wav";
            ege.Play();
            Random rnd = new Random();
            Random rnd2 = new Random();
            int cevap = rnd.Next(1, 3);
            int cevap2 = rnd2.Next(1, 5);
            if (cevap == 1)
            {
                if (MessageBox.Show(degisken, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();

                }
            }
            else
            {
                if (cevap2 == 1)
                {
                    if (MessageBox.Show(cevapA, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();

                    }
                }
                if (cevap2 == 2)
                {
                    if (MessageBox.Show(cevapB, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();

                    }
                }
                if (cevap2 == 3)
                {
                    if (MessageBox.Show(cevapC, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();

                    }
                }
                if (cevap2 == 4)
                {
                    if (MessageBox.Show(cevapD, "cevap", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();

                    }
                }
            }




        }
    }
}
