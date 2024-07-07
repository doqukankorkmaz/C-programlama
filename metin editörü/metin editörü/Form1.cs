namespace metin_editörü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {//yeni
            richTextBox1.Clear();
            saved = false;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {//aç
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "RTF Dosyaları(*.rtf)|*.rtf|Tüm Dosyalar(*.*)|*.*";
            openFileDialog1.Title = "Dosya Aç";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        bool saved = false;
        string DosyaYolu = "";
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {//kaydet
            if (saved == false)
            {
                saveFileDialog1.DefaultExt = "*.rtf";
                saveFileDialog1.FileName = "Dosya";
                saveFileDialog1.Filter = "RTF Dosyaları(*.rtf)|*.rtf|Tüm Dosyalar(*.*)|*.*";
                saveFileDialog1.Title = "Dosya Kaydet";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    DosyaYolu = saveFileDialog1.FileName;
                    saved = true;
                }
            }
            else
            {
                richTextBox1.SaveFile(DosyaYolu);
            }


        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {//farklı kaydet
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.FileName = "Dosya";
            saveFileDialog1.Filter = "RTF Dosyaları(*.rtf)|*.rtf|Tüm Dosyalar(*.*)|*.*";
            saveFileDialog1.Title = "Dosya Kaydet";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                DosyaYolu = saveFileDialog1.FileName;
                saved = true;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {//çıkış
            DialogResult cevap;
            cevap = MessageBox.Show("Çıkış", "Programdan Çıkmak İstiyormusunuz?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {//kes
            richTextBox1.Cut();

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {//kopyala
            richTextBox1.Copy();
        }

        private void yağıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {//yapıştır
            richTextBox1.Paste();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {//yazı tipi
            if (richTextBox1.SelectionLength > 0)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
            }
            else
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
            }

        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {//yazı rengi
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                    richTextBox1.ForeColor = colorDialog1.Color;
            }

        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {//zemin rengi
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionBackColor = colorDialog1.Color;
                }
                else
                    richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void solaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {//sola hizala
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ortalaToolStripMenuItem_Click(object sender, EventArgs e)
        {//Ortala
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void sağaHizalaToolStripMenuItem_Click(object sender, EventArgs e)
        {//sağa hizala
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void maddeİmiToolStripMenuItem_Click(object sender, EventArgs e)
        {//madde imi
            if (richTextBox1.SelectionBullet)
            { richTextBox1.SelectionBullet = false; }
            else
            { richTextBox1.SelectionBullet = true; }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {//kalın
            Font yeni, eski;
            eski = richTextBox1.SelectionFont;
            if (eski.Bold == true)
            {
                yeni = new Font(eski, eski.Style & ~FontStyle.Bold);
                toolStripButton4.Checked = false;
            }
            else
            {
                yeni = new Font(eski, eski.Style | FontStyle.Bold);
                toolStripButton4.Checked = true;
            }
            richTextBox1.SelectionFont = yeni;
            richTextBox1.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {//italik
            Font yeni, eski;
            eski = richTextBox1.SelectionFont;
            if (eski.Italic == true)
            {
                yeni = new Font(eski, eski.Style & ~FontStyle.Italic);
                toolStripButton5.Checked = false;
            }
            else
            {
                yeni = new Font(eski, eski.Style | FontStyle.Italic);
                toolStripButton5.Checked = true;
            }
            richTextBox1.SelectionFont = yeni;
            richTextBox1.Focus();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {//altıçizili
            Font yeni, eski;
            eski = richTextBox1.SelectionFont;
            if (eski.Underline == true)
            {
                yeni = new Font(eski, eski.Style & ~FontStyle.Underline);
                toolStripButton6.Checked = false;
            }
            else
            {
                yeni = new Font(eski, eski.Style | FontStyle.Underline);
                toolStripButton6.Checked = true;
            }
            richTextBox1.SelectionFont = yeni;
            richTextBox1.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Line: " + (richTextBox1.GetLineFromCharIndex(Int32.MaxValue) + 1) + "Cols: " + richTextBox1.Text.Length;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Line: 1 " + "cols: 0";
        }

        private void maskıÖnİzlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 100);
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width - 15;
            richTextBox1.Height = this.Height - 30;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                toolStripButton4.Checked = true;
            }
            else
            {
                toolStripButton4.Checked = false;
            }

            if (richTextBox1.SelectionFont.Italic)
            {
                toolStripButton5.Checked = true;
            }
            else
            {
                toolStripButton5.Checked = false;
            }
            if (richTextBox1.SelectionFont.Underline)
            {
                toolStripButton6.Checked = true;
            }
            else
            {
                toolStripButton6.Checked = false;
            }
        }
    }
}