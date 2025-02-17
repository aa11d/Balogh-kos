
namespace szovegfajlok
{
    public partial class FoAblak : Form
    {
        string teljesSzoveg;
        string[] sovsor;
        public FoAblak()
        {
            InitializeComponent();
        }

        private void FoAblak_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Szeva", "Üzenet", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileUtvonal = ".\\..\\..\\..\\"+FileNevText.Text;
            string fileut2 = @"..\..\..\" + FileNevText.Text;
            //teljesSzoveg = File.ReadAllText(fileUtvonal, encoding: System.Text.Encoding.UTF8);
            //megjelen.Text = teljesSzoveg;
            //sovsor = File.ReadAllLines(fileut2);
            //megjelen.Lines = sovsor;
            StreamReader sr = new StreamReader(fileUtvonal);
            List<string> sorok = new List<string>();
            string sor = sr.ReadLine();
            while (sor != null)
            {
                if (sor.Trim()!="")
                {
                    sorok.Add(sor.Trim());
                }
                
                sor = sr.ReadLine();

            }

            sr.Close();
            megjelen.Lines = sorok.ToArray();

            string[] nev = new string[sorok.Count];
            string[] datum = new string[sorok.Count];
            string[] varos = new string[sorok.Count];
            int[] pont = new int[sorok.Count];

            for (int i = 0; i < sorok.Count; i++)
            {
                string[] darab = sorok[i].Split(';');
                nev[i] = darab[0];
                datum[i] = darab[1];
                varos[i] = darab[2];
                pont[i] = int.Parse(darab[3]);
            }
            int maxpont = pont.Max();
            int kivolt = Array.IndexOf(pont, maxpont);
            string sor1 = "\r\nLegnagyobb pontszám:" + maxpont;
            megjelen.AppendText(sor1);
            string sor2 = "\r\nLegtöbb pontot adta " + nev[kivolt] + " aki itt lakik:" + varos[kivolt];
            megjelen.AppendText(sor2);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void megjelen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
