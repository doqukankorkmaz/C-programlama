﻿namespace form1den_kullaniciadi_şifre_yi_form2_ye_gönderme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 0;
            label1.Text = "FORM1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 94);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 1;
            label2.Text = "KULLANICI ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 166);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "ŞİFRE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 39);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(304, 223);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 5;
            button1.Text = "GÖNDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 365);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}