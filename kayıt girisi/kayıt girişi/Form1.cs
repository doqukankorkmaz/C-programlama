namespace kayıt_girişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tcno = 0;
            try 
            {
                tcno= Convert.ToInt64(textBox1.Text);
            }
            catch 
            {
                MessageBox.Show("TC No hatalı girildi:");
                textBox1.Clear();
            }
            if(textBox1.TextLength == 11 ) 
            {
                string ad = textBox2.Text;
                ad = ad.Substring(0,1).ToUpper() + ad.Substring(1).ToLower();
                string soyad = textBox3.Text;
                soyad=soyad.ToUpper();
                MessageBox.Show($"{tcno} {ad} {soyad}");
            }
            else
            {
                MessageBox.Show("TC No hatalı girildi");
                textBox1.Clear();
            }
        }
    }
}