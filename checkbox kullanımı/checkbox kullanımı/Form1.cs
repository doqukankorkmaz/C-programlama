namespace checkbox_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                MessageBox.Show("checkbox1 seçili");
            }
            if(checkBox2.Checked==true) 
            {
                MessageBox.Show("checkbox2 seçili");
            }
        }
    }
}