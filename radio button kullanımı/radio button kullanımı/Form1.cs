namespace radio_button_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("radio1 işaretli");
            if (radioButton2.Checked)
                MessageBox.Show("radio2 işaretli");
        }
    }
}