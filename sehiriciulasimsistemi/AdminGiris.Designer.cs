namespace sehiriciulasimsistemi
{
    partial class AdminGiris
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
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label31 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(228, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 423);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adim Giriş";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 36);
            textBox3.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(143, 308);
            button1.Name = "button1";
            button1.Size = new Size(116, 44);
            button1.TabIndex = 24;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(32, 208);
            label31.Name = "label31";
            label31.Size = new Size(85, 29);
            label31.TabIndex = 22;
            label31.Text = "Parola:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 36);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 130);
            label2.Name = "label2";
            label2.Size = new Size(44, 29);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // AdminGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(831, 780);
            Controls.Add(groupBox2);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "AdminGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminGiris";
     
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label31;
        private Button button10;
        private Button button11;
        private Button button8;
        private Button button9;
        private Button button6;
        private Button button7;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private Button button1;
        private TextBox textBox3;
    }
}