using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Numerics;

namespace milyonerOdevBitti
{
    public partial class Form2 : Form
    {
        private string[] sorular;
        private string[] secenekA;
        private string[] secenekB;
        private string[] secenekC;
        private string[] secenekD;
        private string[] cevaplar;
        private string cevap;




        private int baslangic = 16;

        private int urrentQuestionIndex;

        private int saniye = 40;

        private int para = 0;
        private int paraSayac = 0;



        public Form2()
        {
            InitializeComponent();

            LoadQuestions();

            ShowQuestion();


        }


        SoundPlayer yanlisSes, dogruSes, sesSure;


        private void LoadQuestions()
        {
            try
            {
                // Soruları dosyadan oku
                sorular = File.ReadAllLines("sorular.txt");
                secenekA = File.ReadAllLines("A.txt");
                secenekB = File.ReadAllLines("B.txt");
                secenekC = File.ReadAllLines("C.txt");
                secenekD = File.ReadAllLines("D.txt");
                cevaplar = File.ReadAllLines("cevap.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorular yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
        
        private void ShowQuestion()
        {
            Ses(out yanlisSes, out dogruSes, out sesSure);
            Random random = new Random();

            int currentQuestionIndex;
           
            
            if (paraSayac==0)
                 currentQuestionIndex = random.Next(0, 3);
            else if (paraSayac == 1)
            {
                currentQuestionIndex = random.Next(3, 6);
                pictureBox1.Enabled= true;
            }
            else if (paraSayac == 2)
                currentQuestionIndex = random.Next(6, 9);
            else if (paraSayac == 3)
                currentQuestionIndex = random.Next(9, 12);
            else if (paraSayac == 4)
                currentQuestionIndex = random.Next(12, 15);
            else if (paraSayac == 5)
                currentQuestionIndex = random.Next(15, 18);
            else if (paraSayac == 6)
                currentQuestionIndex = random.Next(18, 21);
            else if (paraSayac == 7)
                currentQuestionIndex = random.Next(21, 24);
            else if (paraSayac == 8)
                currentQuestionIndex = random.Next(24, 27);
            else if (paraSayac == 9)
                currentQuestionIndex = random.Next(27, 30);
            else if (paraSayac == 10)
                currentQuestionIndex = random.Next(30, 33);
           
            else
                currentQuestionIndex = random.Next(33, 41);

            
            cevap = cevaplar[currentQuestionIndex];
            lblDogru.Text = cevap;
            lblSoru.Text = sorular[currentQuestionIndex];
            lblA.Text = secenekA[currentQuestionIndex];
            lblB.Text = secenekB[currentQuestionIndex];
            lblC.Text = secenekC[currentQuestionIndex];
            lblD.Text = secenekD[currentQuestionIndex];
            saniye = 40;


            if (lblD.Visible)
            {
                sure.Start();
            }
           
            sesSure.Play();
            


        }

        private void CheckAnswerA(string selectedAnswer)
        {
            Ses(out yanlisSes, out dogruSes, out sesSure);

            if (lblA.Text == cevap)
            {
                lblA.BackColor=Color.Green;
                DogruCevap(dogruSes, sesSure);
            }
              
            else
            {
                lblA.BackColor=Color.Red;
                YanlisCevap(yanlisSes, sesSure);
            }
                

            // Bir sonraki soruya geç

        }
        private void CheckAnswerB(string selectedAnswer)
        {
            Ses(out yanlisSes, out dogruSes, out sesSure);

            if (lblB.Text == cevap)
            {
                lblB.BackColor = Color.Green;
                DogruCevap(dogruSes, sesSure);
            }
                
            else
            {
                lblB.BackColor = Color.Red;
                YanlisCevap(yanlisSes, sesSure);
            }


        }
        private void CheckAnswerC(string selectedAnswer)
        {

            Ses(out yanlisSes, out dogruSes, out sesSure);

            if (lblC.Text == cevap)
            {
                lblC.BackColor = Color.Green;
                DogruCevap(dogruSes, sesSure);
            }
            else
            {
                lblC.BackColor = Color.Red;
                YanlisCevap(yanlisSes, sesSure);
            }
        }
        private void CheckAnswerD(string selectedAnswer)
        {
            Ses(out  yanlisSes, out  dogruSes, out  sesSure);
           
            if (lblD.Text == cevap)
            {
                lblD.BackColor = Color.Green;
                DogruCevap(dogruSes, sesSure);
            }
            else
            {
                lblD.BackColor = Color.Red;
                YanlisCevap(yanlisSes, sesSure);
            }

        }

        private void YanlisCevap(SoundPlayer yanlisSes, SoundPlayer sesSure)
        {
            sure.Stop();
            sesSure.Stop();
            yanlisSes.Play();
            MessageBox.Show("Yanlış! Doğru cevap: " + cevap + "paranız::" + para, "KAYBETTİN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            kaybetti kaybetti = new kaybetti();
            kaybetti.Show();
            this.Hide();
            lblC.BackColor = lblA.BackColor = lblB.BackColor = lblD.BackColor = Color.Transparent;
        }

        private void DogruCevap(SoundPlayer dogruSes, SoundPlayer sesSure)
        {
            sure.Stop();
            sesSure.Stop();
            
            dogruSes.Play();

            paraSayac = paraSayac + 1;

            if (MessageBox.Show("Cevabınız doğru.", "Doğru", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (paraSayac == 1)
                {
                    para = 1000;
                    btn1000.BackColor = Color.Green;
                  
                }
                else if (paraSayac == 2)
                {
                    para = 2500;
                    btn2500.BackColor = Color.Green;
                    pictureBox1.Enabled = true;
                   
                }
                else if (paraSayac == 3)
                {
                    para = 5000;
                    btn5000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 4)
                {
                    para = 10000;
                    btn10000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 5)
                {
                    para = 20000;
                    btn20000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 6)
                {
                    para = 40000;
                    btn40000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 7)
                {
                    para = 50000;
                    btn50000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 8)
                {
                    para = 100000;
                    btn100000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 9)
                {
                    para = 200000;
                    btn200000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 10)
                {
                    para = 500000;
                    btn500000.BackColor = Color.Green;
                   
                }
                else if (paraSayac == 11)
                {
                    para = 700000;
                    btn700000.BackColor = Color.Green;
                   
                }
                else
                {
                    para = 1000000;
                    btn1000000.BackColor = Color.Green;
                    kazandın kaz = new kazandın();
                    kaz.Show();
                    this.Hide();
                }
                if (paraSayac != 12) {
                    ShowQuestion();
                }
            }
            lblC.BackColor = lblA.BackColor = lblB.BackColor = lblD.BackColor = Color.Transparent;
        }

        private static void Ses(out SoundPlayer yanlisSes, out SoundPlayer dogruSes, out SoundPlayer sesSure)
        {
            yanlisSes = new System.Media.SoundPlayer();
            yanlisSes.SoundLocation = "yanlisCevap.wav";
            dogruSes = new System.Media.SoundPlayer();
            dogruSes.SoundLocation = "dogru.wav";
            sesSure = new System.Media.SoundPlayer();
            sesSure.SoundLocation = "sure.wav";
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            pictureBox1.Enabled = false;
            lblSoru.Visible = false;
            lblA.Visible = false;
            lblB.Visible = false;
            lblC.Visible = false;
            lblD.Visible = false;
            tanitim.Start();
        }
        private async  void lblC_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("kabul ediyormusun ", "dur kardeşim geçme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                lblC.BackColor = Color.Yellow;
                await Task.Delay(2000);
                CheckAnswerC("C");


            }

        }

        private async void lblA_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("kabul ediyormusun ", "dur kardeşim geçme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                lblA.BackColor = Color.Yellow;
                await Task.Delay(2000);
                CheckAnswerA("A");

            }
        }

        private async void lblD_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("kabul ediyormusun ", "dur kardeşim geçme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                lblD.BackColor = Color.Yellow;
                await Task.Delay(2000);
                CheckAnswerD("D");

            }
        }

        private async void lblB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("kabul ediyormusun ", "dur kardeşim geçme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                lblB.BackColor = Color.Yellow;
                await Task.Delay(2000);
                CheckAnswerB("B");

            }
        }

        private void sure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = saniye.ToString();

            saniye = saniye - 1;
            if (saniye == 0)
            {
                System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
                sesSure.SoundLocation = "sure.wav";
                sure.Stop();
                sesSure.Stop();
                lblSure.Text = "0";
                MessageBox.Show("süren doldu süre doldu süre yok artık öldü");
                dolanSure dolanSur = new dolanSure();
                dolanSur.Show();
                this.Hide();


            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tanitim_Tick(object sender, EventArgs e)
        {
            tanitim.Interval = 250;
            baslangic--;

            if (baslangic == 15)
            {
                tanitim.Stop();
                if (MessageBox.Show("yarışmada sorular var bilince para alıyon", "tanıtım", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tanitim.Start();
                    btn1000.BackColor = Color.Green;
                }

            }
            if (baslangic == 14)
                btn2500.BackColor = Color.Green;
            if (baslangic == 13)
                btn5000.BackColor = Color.Green;
            if (baslangic == 12)
                btn10000.BackColor = Color.Green;
            if (baslangic == 11)
                btn20000.BackColor = Color.Green;
            if (baslangic == 10)
                btn40000.BackColor = Color.Green;
            if (baslangic == 9)
                btn50000.BackColor = Color.Green;
            if (baslangic == 8)
                btn100000.BackColor = Color.Green;
            if (baslangic == 7)
                btn200000.BackColor = Color.Green;
            if (baslangic == 6)
                btn500000.BackColor = Color.Green;
            if (baslangic == 5)
                btn700000.BackColor = Color.Green;
            if (baslangic == 4)
            {
                btn1000000.BackColor = Color.Green;
                tanitim.Stop();
                if (MessageBox.Show("3 tane joker var", "jokerleri tanıtım", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    tanitim.Start();
            }
            if (baslangic == 3)
            {
                tanitim.Stop();
                if (MessageBox.Show("pass,seyirci ve telefon joker hakkı", "jokerler", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    tanitim.Start();
            }
            if (baslangic == 2)
            {
                btn1000.BackColor = Color.Transparent;
                btn2500.BackColor = Color.Transparent;
                btn5000.BackColor = Color.Transparent;
                btn10000.BackColor = Color.Transparent;
                btn20000.BackColor = Color.Transparent;
                btn40000.BackColor = Color.Transparent;
                btn50000.BackColor = Color.Transparent;
                btn100000.BackColor = Color.Transparent;
                btn200000.BackColor = Color.Transparent;
                btn500000.BackColor = Color.Transparent;
                btn700000.BackColor = Color.Transparent;
                btn1000000.BackColor = Color.Transparent;



                lblSoru.Visible = true;
                lblA.Visible = true;
                lblB.Visible = true;
                lblC.Visible = true;
                lblD.Visible = true;

                pbSeyirci.Enabled = true;
                pbPas.Enabled = true;
                pbTel.Enabled = true;

                System.Media.SoundPlayer yanlisSes = new System.Media.SoundPlayer();
                yanlisSes.SoundLocation = "yanlisCevap.wav";
                System.Media.SoundPlayer dogruSes = new System.Media.SoundPlayer();
                dogruSes.SoundLocation = "doğru cevap.wav";
                System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
                sesSure.SoundLocation = "sure.wav";


                sure.Start();
                sesSure.Play();


            }
            if (baslangic == 0)
            {
                tanitim.Stop();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Media.SoundPlayer yanlisSes = new System.Media.SoundPlayer();
            yanlisSes.SoundLocation = "yanlisCevap.wav";
            System.Media.SoundPlayer dogruSes = new System.Media.SoundPlayer();
            dogruSes.SoundLocation = "doğru cevap.wav";
            System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
            sesSure.SoundLocation = "sure.wav";
            tanitim.Stop();


            if (MessageBox.Show("Programdan çıkmayı kabul ediyormusunuz?", "uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                tanitim.Start();
                e.Cancel = true;
                sure.Stop();
                sesSure.Stop();
            }
            else
                e.Cancel = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pbSeyirci.Enabled = false;
            SetProgressBarValues(100);
            seyirciler.Visible = true;
        }

        private void pbYarı_Click(object sender, EventArgs e)
        {
            pbPas.Enabled = false;
            ShowQuestion();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void SetProgressBarValues(int totalValue)
        {
            // Rastgele değer üretmek için kullanılacak Random nesnesi
            Random random = new Random();

            // 4 ProgressBar'ın toplam değeri 10 olacak şekilde rastgele değer atama
            for (int i = 0; i < 4; i++)
            {
                // ProgressBar'ın değerine rastgele bir miktar ekle
                int randomValue = random.Next(0, totalValue + 1);

                // Toplam değeri 10'dan büyük olmamasını sağlama
                if (totalValue - randomValue >= 0)
                {
                    // İlgili ProgressBar'a değeri atama
                    SetProgressBarValue(i + 1, randomValue);


                    totalValue -= randomValue;
                }
            }
        }

        private void SetProgressBarValue(int progressBarIndex, int value)
        {
            // Verilen ProgressBar'a belirtilen değeri atama
            switch (progressBarIndex)
            {
                case 1:
                    progressBar1.Value = value;
                    break;
                case 2:
                    progressBar2.Value = value;
                    break;
                case 3:
                    progressBar3.Value = value;
                    break;
                case 4:
                    progressBar4.Value = value;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seyirciler.Visible = false;
        }

        private void pbTel_Click(object sender, EventArgs e)
        {
            pbTel.Enabled = false;
            System.Media.SoundPlayer yanlisSes = new System.Media.SoundPlayer();
            yanlisSes.SoundLocation = "yanlisCevap.wav";
            System.Media.SoundPlayer dogruSes = new System.Media.SoundPlayer();
            dogruSes.SoundLocation = "doğru cevap.wav";
            System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
            sesSure.SoundLocation = "sure.wav";
            sure.Stop();
            sesSure.Stop();



            telJoker forma = new telJoker();
            forma.degisken = this.cevap;
            forma.cevapA = this.lblA.Text;
            forma.cevapB = this.lblB.Text;
            forma.cevapC = this.lblC.Text;
            forma.cevapD = this.lblD.Text;
            forma.ShowDialog();




        }
        private void teletelJoker_FormClosing(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
            sesSure.SoundLocation = "sure.wav";
            sure.Start();
            sesSure.Play();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer yanlisSes = new System.Media.SoundPlayer();
            yanlisSes.SoundLocation = "yanlisCevap.wav";
            System.Media.SoundPlayer dogruSes = new System.Media.SoundPlayer();
            dogruSes.SoundLocation = "doğru cevap.wav";
            System.Media.SoundPlayer sesSure = new System.Media.SoundPlayer();
            sesSure.SoundLocation = "sure.wav";
            if (MessageBox.Show("Yarışmadan çekiliyorsunuz eminmisiniz?", "çekilicekmisin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sure.Stop();
                sesSure.Stop();
                MessageBox.Show("yarışmadan çekildiniz paranız::" + para, "çekildin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 cekil = new Form3();
                this.Hide();
                cekil.Show();

               
            }
        }
    }
}
