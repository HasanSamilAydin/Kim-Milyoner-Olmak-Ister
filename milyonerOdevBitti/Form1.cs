namespace milyonerOdevBitti
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer dolanSES = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            dolanSES.SoundLocation = "giris.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
            dolanSES.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dolanSES.Play();
        }
    }
}