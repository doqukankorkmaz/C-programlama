using MySql.Data;
using MySql.Data.MySqlClient;
namespace rehber_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //ayar kaydet
                INIKaydet INI = new INIKaydet(Application.StartupPath + @"\ayarlar.ini");
                INI.Yaz("Kullanici", "kullaniciadi", textBox1.Text);
                INI.Yaz("Kullanici", "sifre", textBox2.Text);

            }

            rehbersinif rhber = new rehbersinif();
            rehber giris = new rehber();
            giris.kullaniciAd=textBox1.Text;
            giris.Sifre = textBox2.Text;
            rhber.kullanicigiris(giris);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //beni unut
            INIKaydet INI = new INIKaydet(Application.StartupPath + @"\ayarlar.ini");
            INI.Yaz("Kullanici", "kullaniciadi", "");
            INI.Yaz("Kullanici", "sifre", "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            INIKaydet INI = new INIKaydet(Application.StartupPath + @"\ayarlar.ini");
            textBox1.Text = INI.Oku("Kullanici", "kullaniciadi");
            textBox2.Text = INI.Oku("Kullanici", "sifre");
        }
    }
}