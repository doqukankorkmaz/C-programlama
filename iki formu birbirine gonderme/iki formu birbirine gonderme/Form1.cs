namespace iki_formu_birbirine_gonderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.textBox1.Text = textBox1.Text;

            form2.Show();

        }
    }
}