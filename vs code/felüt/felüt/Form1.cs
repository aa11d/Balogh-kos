namespace felüt
{
    public partial class Form1 : Form
    {
        List<PictureBox> labdak = new List<PictureBox>();
        List<int> labdavx = new List<int>();
        List<int> labdavy = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }



        private void platform_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 1)
            {
                PictureBox labda = new PictureBox();
                int vx = rnd.Next(-5, 6);
                int vy = rnd.Next(2, 6);
                labda.Location = new Point(ClientRectangle.Width / 2, 0);
                labda.Size = new Size(25, 25);
                labda.Image = Image.FromFile(@"..\..\..\labd.png");
                labda.SizeMode = PictureBoxSizeMode.StretchImage;
                labdak.Add(labda);
                labdavy.Add(vy);
                labdavx.Add(vx);
                Controls.Add(labda);
            }
            for (int i = 0; i < labdak.Count; i++)
            {
                int newLeft = labdak[i].Left + labdavx[i];
                int newTop = labdak[i].Top + labdavy[i];
                if (newLeft < 0)
                {
                    labdavx[i] *= -1;
                }
                else if (newTop < 0)
                {
                    labdavy[i] *= -1;
                }
                else if (newLeft + labdak[i].Width > ClientRectangle.Width)
                {
                    labdavx[i] *= -1;
                }
                else
                {
                    labdak[i].Top = newTop;
                    labdak[i].Left = newLeft;
                }

            }
            int k = 0;
            while (k < labdak.Count)
            {
                if (labdak[k].Top > ClientRectangle.Height)
                {
                    Controls.Remove(labdak[k]);
                    labdak.RemoveAt(k);
                    labdavx.RemoveAt(k);
                    labdavy.RemoveAt(k);
                    
                }
                else
                {
                    k++;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (platform.Left>10)
                {
                    platform.Left -= 10;
                }
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (platform.Left+platform.Width+10<ClientRectangle.Width)
                {
                    platform.Left += 10;
                }
            }
        }
    }
}
