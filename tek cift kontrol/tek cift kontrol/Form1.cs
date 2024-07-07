namespace tek_cift_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                if (sayi % 2 == 0)
                {
                    this.BackColor = Color.Green;
                    label2.Text = "say� �ift";
                    label2.Visible = true;
                }
                else
                {
                    this.BackColor = Color.Blue;
                    label2.Text = "say� tek";
                    label2.Visible = true;
                }
            }
            catch
            {
                label2.Text = "l�tfen say� giriniz";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}