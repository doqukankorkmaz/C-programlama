using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static rehber_class.rehbersinif;

namespace rehber_class
{
    public partial class Form3 : Form
    {
        private readonly MyDatabaseClass _dbClass;

        public Form3()
        {
            InitializeComponent();
            Form2 frm = (Form2)Application.OpenForms["Form2"];
            _dbClass = new MyDatabaseClass(frm.textBox1.Text, frm.textBox4.Text, frm.textBox2.Text, frm.textBox3.Text);
        }

        private void listele()
        {
            dataGridView1.DataSource = _dbClass.GetRehber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
