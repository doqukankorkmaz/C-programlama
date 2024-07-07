namespace form1den_kullaniciadi_şifre_yi_form2_ye_gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAd, Sifre;
            kAd = textBox1.Text;
            Sifre = textBox2.Text;

            if (kAd == "admin" && Sifre == "123")
            {
                Form2 form2 = new Form2();
                form2.textBox1.Text = kAd + " " + Sifre;
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI DEĞER GİRİŞİ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}