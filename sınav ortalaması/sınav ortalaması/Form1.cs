namespace sınav_ortalaması
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
                int vize = Convert.ToInt32(textBox1.Text);
                int final = Convert.ToInt32(textBox2.Text);
                double ortalama = vize * 0.4 + final * 0.6;
                if(vize<=100 && vize>=0 && final<=100 && final>=0)
                {
                    if(ortalama>=60) 
                    {
                        label3.Text = $"Ortalama:{ortalama}";
                        label4.Text = $"Durum: GEÇTİ";
                        label4.ForeColor = Color.Green;
                    }
                    else
                    {
                        label3.Text = $"Ortalama:{ortalama}";
                        label4.Text = $"Durum: Kaldı";
                        label4.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("GİRİLEN DEĞERLER 0-100 ARASINDA DEĞİLDİR");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Hatalı değer girişi", "Hata Mesajı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }

        }
    }
}