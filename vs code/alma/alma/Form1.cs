namespace alma
{

    public partial class Form1 : Form
    {
        static PictureBox[,] kepek = new PictureBox[6, 8];
        static int darab = 0;
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kepek.GetLength(0); i++)
            {
                for (int j = 0; j < kepek.GetLength(1); j++)
                {
                    kepek[i,j] = new PictureBox();
                    kepek[i, j].Location = new Point(50 + 100 * i, 50 + 100 * j);
                    kepek[i, j].Size = new Size(100, 100);
                    kepek[i, j].Image = Image.FromFile(@"D:\Balogh Ákos\Balogh-kos\vs code\alma\figura.png");
                    kepek[i, j].Name = "kep" + i.ToString() + "," + j.ToString();
                    Controls.Add(kepek[i, j]);
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
