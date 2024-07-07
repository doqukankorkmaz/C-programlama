﻿using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        public Form5()
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
            string sql = $"delete from rehber where numara='{textBox1.Text}'";
            MySqlCommand komut = new MySqlCommand(sql, baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt silindi");
        }
    }
}