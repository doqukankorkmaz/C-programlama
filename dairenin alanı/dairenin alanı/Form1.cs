namespace dairenin_alanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            try
            {
                double r = double.Parse(textBox1.Text);
                double alan = pi * r * r;
                double cevre = 2 * pi * r;
                textBox2.Text= alan.ToString();
                textBox3.Text= cevre.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("hatalı değer girdiniz", "Hata!",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}