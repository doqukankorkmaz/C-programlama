namespace checkbox_ile_kdv_tutat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hamtutar = Convert.ToDouble(textBox1.Text);
            double kesinti, ek = 0, net_odeme;
            if (checkBox1.Checked)
                ek = ek + 500;
            if (checkBox2.Checked)
                ek = ek + 500;
            if (checkBox3.Checked)
                ek = ek + 1000;
            if (checkBox4.Checked)
                ek = ek + 700;
            textBox2.Text = ek.ToString();
            kesinti = (hamtutar + ek) * 0.18;
            textBox3.Text = ek.ToString();
            net_odeme = hamtutar + ek - kesinti;
            textBox4.Text = net_odeme.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }
    }
}