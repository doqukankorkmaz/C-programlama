using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iki_formu_birbirine_gonderme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 frm1;
        private void button1_Click(object sender, EventArgs e)
        {
            frm1 = (Form1)Application.OpenForms["Form1"];//uygulamanıın açık olan formlarından form1'i frm değişkenine bağladık
            frm1.textBox1.Text = textBox1.Text;
            this.Close();
            frm1.Show();
        }
    }
}
