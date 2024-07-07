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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Form2 frm;
        private void button1_Click(object sender, EventArgs e)
        {
            frm = (Form2)Application.OpenForms["Form2"];
            MySqlConnection baglan = new MySqlConnection(
            $"server='{frm.textBox1.Text}';" +
            $"Database='{frm.textBox4.Text}';" +
            $"Uid='{frm.textBox2.Text}';" +
            $"Pwd='{frm.textBox3.Text}';");
            string sql = $"update rehber set ad = '{textBox1.Text}',soyad = '{textBox2.Text}',adres = '{textBox3.Text}' where numara = '{comboBox1.Text}'";
            MySqlCommand komut = new MySqlCommand(sql, baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt güncellendi");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            frm = (Form2)Application.OpenForms["Form2"];
            MySqlConnection baglan = new MySqlConnection(
            $"server='{frm.textBox1.Text}';" +
            $"Database='{frm.textBox4.Text}';" +
            $"Uid='{frm.textBox2.Text}';" +
            $"Pwd='{frm.textBox3.Text}';");
            string sql = "select numara from rehber";
            MySqlCommand komut = new MySqlCommand(sql, baglan);
            baglan.Open();
            MySqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                comboBox1.Items.Add(veri["numara"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm = (Form2)Application.OpenForms["Form2"];
            MySqlConnection baglan = new MySqlConnection(
            $"server='{frm.textBox1.Text}';" +
            $"Database='{frm.textBox4.Text}';" +
            $"Uid='{frm.textBox2.Text}';" +
            $"Pwd='{frm.textBox3.Text}';");
            string sql = $"select * from rehber where numara='{comboBox1.Text}'";
            MySqlCommand komut = new MySqlCommand(sql, baglan);
            baglan.Open();
            MySqlDataReader veri = komut.ExecuteReader();
            while (veri.Read())
            {
                textBox1.Text = veri["ad"].ToString();
                textBox2.Text = veri["soyad"].ToString();
                textBox3.Text = veri["adres"].ToString();
            }
        }
    }
}
