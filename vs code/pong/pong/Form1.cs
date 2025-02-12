namespace pong
{
    public partial class Form1 : Form
    {
        int vx, vy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            vx = random.Next(5, 11);
            if (random.NextDouble() < 0.5)
            {
                vx *= -1;
            }
            vy = random.Next(-5, 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bfel = pictureBox1.Top + vy;
            int balal = pictureBox1.Left + vx;
            int joblent = bfel + pictureBox1.Height;
            int jobjob = balal + pictureBox1.Width;
            if (balal < 0 || jobjob > ClientRectangle.Width)
            {
                vx *= -1;
            }
            else
            {
                pictureBox1.Left = balal;
            }
            if (bfel < 0 || joblent > ClientRectangle.Height)
            {
                vy *= -1;
            }
            else
            {
                pictureBox1.Top = bfel;
            }
            if (pictureBox1.Left+pictureBox1.Width>=pictureBox2.Left&&pictureBox1.Top>=pictureBox2.Top&&pictureBox1.Top+pictureBox1.Height<=pictureBox2.Top+pictureBox2.Height)
            {
                vx *= -1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDone(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (pictureBox2.Top > 10)
                {
                    pictureBox2.Top -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (pictureBox2.Top + pictureBox2.Height + 10 < ClientRectangle.Height)
                {
                    pictureBox2.Top += 10;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
