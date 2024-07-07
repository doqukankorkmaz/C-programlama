namespace radiobutton_ile_kdv_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            int adet = Convert.ToInt32(textBox2.Text);
            double toplam = fiyat * adet;
            double kdv = 0;
            if (radioButton1.Checked) { kdv = toplam * 0.01; }
            if (radioButton2.Checked) { kdv = toplam * 0.08; }
            if (radioButton3.Checked) { kdv = toplam * 0.18; }
            double toplamKdvTutatri = toplam + kdv;
            textBox3.Text = kdv.ToString() + " TL";
            textBox4.Text = toplamKdvTutatri.ToString() + " TL";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }
    }
}