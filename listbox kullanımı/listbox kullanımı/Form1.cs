namespace listbox_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//ekle
            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {//dizi ekle
            string[] dizi = { "muhammed", "doğukan", "mehmet", "elif" };
            listBox1.Items.AddRange(dizi);
        }

        private void button3_Click(object sender, EventArgs e)
        {//sayı ekle
            for (int i = 1; i <= 10; i++)
                listBox1.Items.Add(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {//temizle
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = listBox1.Items.Count;
            MessageBox.Show($"liste içinde {sayi} eleman var");
        }

        private void button6_Click(object sender, EventArgs e)
        {//bul
            int konum = listBox1.Items.IndexOf(textBox1.Text);
            if (konum == -1)
            {
                //değer bulunmazsa -1 değeri döner
                //değer kontrolleri büyük küçük harf duyarlıdır
                MessageBox.Show("aranana eleman bulunamadı");
            }
            else
            {
                //aranan değerinin ilk bulunduğu konumu gösterir
                listBox1.SelectedIndex = konum; //verilen index değerini almak içi
                MessageBox.Show($"aranan değer {konum} konumu");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {//araya ekle
            listBox1.Items.Insert(3, textBox1.Text); //3.konuma değeri ekler
            //listBox1.Items.Insert(konum,değer);
        }

        private void button8_Click(object sender, EventArgs e)
        {//değere göre sil
            listBox1.Items.Remove(textBox1.Text);
            //değer kontrolü büyük/küçük harf duyarlıdır
            //ilk bulunan değeri siler
        }

        private void button9_Click(object sender, EventArgs e)
        {//konuma göre sil
            listBox1.Items.RemoveAt(0);//0. konumdaki değeri siler
        }

        private void button10_Click(object sender, EventArgs e)
        {//seçili olanı sil
            //listBox1.SelectedIndex olanın sıra numarasını verir
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button11_Click(object sender, EventArgs e)
        {//seçili olan değer
            MessageBox.Show(listBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {//değer var mı
            if (listBox1.Items.Contains(textBox1.Text))
                MessageBox.Show("değer var");
            else
                MessageBox.Show("değer yok");
        }

        private void button13_Click(object sender, EventArgs e)
        {//tümünü bul ve sil
            while (listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Remove(textBox1.Text);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {//kontrollü ekle
            if (listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Değer zaten var");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {//sırala
            listBox1.Sorted = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {//değeri sınırlı ekle 5 adetle sınırı
            if (listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Değer zaten var");
            }
            else
            {
                if (listBox1.Items.Count < 5)
                {
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Liste dolu");
                }
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            string konum = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == aranan)
                {

                    konum += i.ToString() + ",";
                }
            }
            MessageBox.Show($"aranan değer {konum} konumunda");
        }

        private void button18_Click(object sender, EventArgs e)
        {//combobox ekle
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //dizi ekle combobox
            string[] dizi = { "ali", "veli", "ayşe", "fatma" };
            comboBox1.Items.AddRange(dizi);
        }
    }
}