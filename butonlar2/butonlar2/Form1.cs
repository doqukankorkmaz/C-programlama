namespace butonlar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//textbox1 i�ine girilen de�eri b�y�k harflerle yazar
            textBox1.CharacterCasing = CharacterCasing.Upper;
        }

        private void button2_Click(object sender, EventArgs e)
        {//textbox i�ine girile de�eri k���k harf yapar
            textBox1.CharacterCasing = CharacterCasing.Lower;
        }

        private void button3_Click(object sender, EventArgs e)
        { //textbox i�ine girilen metin k���k harf veya b�y�k harf olabilir
            textBox1.CharacterCasing = CharacterCasing.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            metin = metin.Substring(0, 1).ToUpper() + metin.Substring(1).ToLower();
            textBox1.Text = metin;
        }

        private void button5_Click(object sender, EventArgs e)
        {// o anki tarih saat bilgisi
            DateTime tarih = DateTime.Now;
            textBox1.Text = tarih.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {//formatl� metin;
            decimal para = 25035.50m;
            textBox1.Text = para.ToString("#,###.00 TL");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {//sola hizala
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void button8_Click(object sender, EventArgs e)
        {//sa�a hizala
            textBox1.TextAlign = HorizontalAlignment.Right;
        }
        private void button9_Click(object sender, EventArgs e)
        {//ortala
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button10_Click(object sender, EventArgs e)
        {//salt okunur
            if (textBox1.ReadOnly)
            {
                textBox1.ReadOnly = false;
            }
            else
                textBox1.ReadOnly = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {//aktif
            if (textBox1.Enabled)
            {
                textBox1.Enabled = false;
            }
            else
                textBox1.Enabled = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {//maksimum uzunluk
            textBox1.MaxLength = 10;
        }

        private void button13_Click(object sender, EventArgs e)
        {//karakter say�s�
            int uzunluk = textBox1.TextLength;
            MessageBox.Show($"metnin uzunlu�u: {uzunluk}");
        }

        private void button14_Click(object sender, EventArgs e)
        {//se�ili metin
            if (textBox1.SelectionLength > 0)
                MessageBox.Show(textBox1.SelectedText);
            else
                MessageBox.Show("textbox i�inde se�ili metin yok");
        }

        private void button15_Click(object sender, EventArgs e)
        {//kes
            textBox1.Cut();
        }

        private void button16_Click(object sender, EventArgs e)
        {//kopyala
            textBox1.Copy();
        }

        private void button17_Click(object sender, EventArgs e)
        {//yap��t�r
            textBox1.Paste();
        }

        private void button18_Click(object sender, EventArgs e)
        {//geri al
            textBox1.Undo();   
        }

        private void button19_Click(object sender, EventArgs e)
        {//temizle
            textBox1.Clear();
        }
    }
}