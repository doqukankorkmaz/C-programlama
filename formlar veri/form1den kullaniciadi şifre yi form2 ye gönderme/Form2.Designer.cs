﻿namespace form1den_kullaniciadi_şifre_yi_form2_ye_gönderme
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 0;
            label1.Text = "FORM2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 39);
            textBox1.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 365);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox textBox1;
    }
}