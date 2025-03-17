namespace szamologepekkettablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        



        private void MuveletKatt(object sender, EventArgs e)
        {
            int bal = int.Parse(balszovegdoboz.Text);
          
            int ered = 0;
            bool hiba = false;

            char muv = (sender as Button).Text[0];
            switch(muv)
            {
                case '+':
                    ered = bal;
                    break;
                case '-':
                    ered = bal ;
                    break;
                case '*':
                    ered = bal ;
                    break;
                
                   
            }
            if (!hiba)
            {
                balszovegdoboz.Text = ered.ToString();
                
            }
            else 
            {
                MessageBox.Show("Nem oszt nullával!");
            }
        }
    }
}
