namespace sehiriciulasimsistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris fr = new AdminGiris();
            fr.Show();
            // this.Hide();//ilk formu kapatmak için kullandýk
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoforGiris fr = new SoforGiris();
            fr.Show();
            // this.Hide();//ilk formu kapatmak için kullandýk
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YolcuGiris fr = new YolcuGiris();
            fr.Show();
            //  this.Hide();//ilk formu kapatmak için kullandýk
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}