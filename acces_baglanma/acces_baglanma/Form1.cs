using System.Data;
using System.Data.OleDb;
namespace acces_baglanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//listele
            OleDbConnection baglanti =
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");
            string sql = "select * from ogrenci";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku[0].ToString() + " " + oku[1].ToString() +
                " " + oku[2].ToString() + " " + oku[3].ToString() +
                " " + oku[4].ToString());
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {//tablo olarak listele
            OleDbConnection baglanti =
           new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");
            string sql = "select * from ogrenci";
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sql, baglanti);
            DataSet veriKumesi = new DataSet();
            baglanti.Open();
            adaptor.Fill(veriKumesi, "ogrenciler");
            dataGridView1.DataSource = veriKumesi.Tables["ogrenciler"];
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {//kayýt ekle
            int numara = Convert.ToInt32(textBox1.Text);
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            int vize = Convert.ToInt32(textBox4.Text);
            int final = Convert.ToInt32(textBox5.Text);

            OleDbConnection baglanti =
           new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");

            string sql = $"insert into ogrenci values({numara},'{ad}','{soyad}',{vize},{final})";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {//sil

            int numara = Convert.ToInt32(textBox6.Text);

            OleDbConnection baglanti =
           new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");

            string sql = $"delete from ogrenci where numara={numara}";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();

        }

        public void listele()
        {
            OleDbConnection baglanti =
          new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");
            string sql = "select * from ogrenci";
            OleDbDataAdapter adaptor = new OleDbDataAdapter(sql, baglanti);
            DataSet veriKumesi = new DataSet();
            baglanti.Open();
            adaptor.Fill(veriKumesi, "ogrenciler");
            dataGridView1.DataSource = veriKumesi.Tables["ogrenciler"];
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti =
                new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");

            int numara = Convert.ToInt32(textBox7.Text);
            int vize = Convert.ToInt32(textBox8.Text);
            int final = Convert.ToInt32(textBox9.Text);
            string sql = $"update ogrenci set vize={vize},final={final} where numara={numara}";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//seç
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {//seçili olaný sil
            try
            {
                OleDbConnection baglanti =
                    new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");

                int numara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string sql = $"delete from ogrenci where numara={numara}";
                OleDbCommand komut = new OleDbCommand(sql, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            catch
            {
                MessageBox.Show("seçim yapýnýz");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {//baðlantý kontrol
            OleDbConnection baglanti =
                   new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");
            try
            {

                baglanti.Open();
                MessageBox.Show("baðlantý çalýþýyýr");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {//hata kontrolü sil

            OleDbConnection baglanti =
                new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ogrenciler.accdb");
            try
            {
                int numara = Convert.ToInt32(textBox6.Text);
                string sql = $"delete from ogrenci where numara={numara}";
                OleDbCommand komut = new OleDbCommand(sql, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                listele();
                MessageBox.Show("Kayýt silindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }

        }
    }
}