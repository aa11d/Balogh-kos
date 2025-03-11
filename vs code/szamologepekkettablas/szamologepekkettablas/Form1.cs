namespace szamologepekkettablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jobbszovegdoboz_TextChanged(object sender, EventArgs e)
        {

        }

        private void balszamokkatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (balszovegdoboz.Text == "0")
            {
                balszovegdoboz.Text = szam.ToString();

            }
            else
            {
                balszovegdoboz.Text += szam.ToString();
            }

        }

        private void baldelgomb_Click(object sender, EventArgs e)
        {
            balszovegdoboz.Text = balszovegdoboz.Text.Substring(0, balszovegdoboz.Text.Length - 1);
            if (balszovegdoboz.Text == "")
            {
                balszovegdoboz.Text = "0";
            }
        }

        private void jobbszamkatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (jobbszovegdoboz.Text == "0")
            {
                jobbszovegdoboz.Text = szam.ToString();

            }
            else
            {
                jobbszovegdoboz.Text += szam.ToString();
            }

        }

        private void jobbdelgomb_Click(object sender, EventArgs e)
        {
            jobbszovegdoboz.Text = jobbszovegdoboz.Text.Substring(0, jobbszovegdoboz.Text.Length - 1);
            if (jobbszovegdoboz.Text == "")
            {
                jobbszovegdoboz.Text = "0";
            }
        }

        private void MuveletKatt(object sender, EventArgs e)
        {
            int bal = int.Parse(balszovegdoboz.Text);
            int jobb = int.Parse(jobbszovegdoboz.Text);
            int ered = 0;
            bool hiba = false;

            char muv = (sender as Button).Text[0];
            switch(muv)
            {
                case '+':
                    ered = bal+jobb;
                    break;
                case '-':
                    ered = bal - jobb;
                    break;
                case '*':
                    ered = bal * jobb;
                    break;
                case '/':
                    if (jobb != 0)
                    {
                        ered = bal / jobb;
                    }
                    else 
                    {
                        hiba = true;
                    }
                    break;
            }
            if (!hiba)
            {
                balszovegdoboz.Text = ered.ToString();
                jobbszovegdoboz.Text = "0";
            }
            else 
            {
                MessageBox.Show("Nem oszt nullával!");
            }
        }
    }
}
