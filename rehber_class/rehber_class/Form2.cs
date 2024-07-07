using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber_class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ayar kaydet
            INIKaydet INI = new INIKaydet(Application.StartupPath + @"\ayarlar.ini");
            INI.Yaz("Ayar", "sunucu", textBox1.Text);
            INI.Yaz("Ayar", "kullanici", textBox2.Text);
            INI.Yaz("Ayar", "sifre", textBox3.Text);
            INI.Yaz("Ayar", "veritabani", textBox4.Text);
            MessageBox.Show("Ayarlar kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ayar oku
            INIKaydet INI = new INIKaydet(Application.StartupPath + @"\ayarlar.ini");
            textBox1.Text = INI.Oku("Ayar", "sunucu");
            textBox2.Text = INI.Oku("Ayar", "kullanici");
            textBox3.Text = INI.Oku("Ayar", "sifre");
            textBox4.Text = INI.Oku("Ayar", "veritabani");
            MessageBox.Show("Ayarlar getirildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rehbersinif.baglantikontrol(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text))
            {
                label5.Text = "Bağlı";
                label5.ForeColor = Color.Green;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                MessageBox.Show("Veri Tabanı bağlandı");
            }
            else
            {
                MessageBox.Show("Veri Tabanı Bağlantı Hatası");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (label5.Text == "Bağlı")
            {
                if (rehbersinif.tablo_olustur(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text))
                {
                    MessageBox.Show("tablo oluşturuldu");
                }
                else
                {
                    MessageBox.Show("tablo oluşturmada hata");
                }
            }
            else
            {
                MessageBox.Show("önce bağlantı kodlarına bakın");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Bağlı")
            {
                Form3 frm = new Form3();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Önce bağlantı kontrolü yapın");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Bağlı")
            {
                Form4 frm = new Form4();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Önce bağlantı kontrolü yapın");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Bağlı")
            {
                Form5 frm = new Form5();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Önce bağlantı kontrolü yapın");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Bağlı")
            {
                Form6 frm = new Form6();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Önce bağlantı kontrolü yapın");
            }

        }
    }
}
