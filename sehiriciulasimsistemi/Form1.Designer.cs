﻿namespace sehiriciulasimsistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Harlow Solid Italic", 60F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(424, 39);
            label1.Name = "label1";
            label1.Size = new Size(1022, 126);
            label1.TabIndex = 0;
            label1.Text = "Şehiriçi Ulaşım Sistemi";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(118, 170);
            button1.Name = "button1";
            button1.Size = new Size(287, 78);
            button1.TabIndex = 1;
            button1.Text = "Admin Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Corbel", 30F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(717, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 606);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Paneli";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Location = new Point(118, 417);
            button3.Name = "button3";
            button3.Size = new Size(287, 78);
            button3.TabIndex = 3;
            button3.Text = "Yolcu Giriş";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(118, 292);
            button2.Name = "button2";
            button2.Size = new Size(287, 78);
            button2.TabIndex = 2;
            button2.Text = "Şoför Giriş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1560, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 231);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1784, 932);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
    }
}