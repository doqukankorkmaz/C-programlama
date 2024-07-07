namespace checkbox_ile_kdv_tutat_hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "programlama";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(43, 151);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(69, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "ingilizce";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(43, 176);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(44, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "evli";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(43, 201);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(109, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "seyehata uygun";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 4;
            label1.Text = "İLGİLENDİĞİNİZ ALANLAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 126);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "HAM TUTAR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 151);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "EK GELİR";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 176);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "KESİNTİ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(337, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 201);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 5;
            label5.Text = "NET TUTAR";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(337, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(362, 226);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
    }
}