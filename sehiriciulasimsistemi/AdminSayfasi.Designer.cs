namespace sehiriciulasimsistemi
{
    partial class AdminSayfasi
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
            button4 = new Button();
            button7 = new Button();
            button9 = new Button();
            button11 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Location = new Point(83, 90);
            button4.Name = "button4";
            button4.Size = new Size(157, 54);
            button4.TabIndex = 38;
            button4.Text = "Güzergah İşlemleri";
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(83, 163);
            button7.Name = "button7";
            button7.Size = new Size(157, 54);
            button7.TabIndex = 40;
            button7.Text = "Şoför İşlemleri";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Lime;
            button9.Location = new Point(83, 241);
            button9.Name = "button9";
            button9.Size = new Size(157, 54);
            button9.TabIndex = 42;
            button9.Text = "Yolcu İşlemleri";
            button9.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Lime;
            button11.Location = new Point(83, 314);
            button11.Name = "button11";
            button11.Size = new Size(157, 54);
            button11.TabIndex = 44;
            button11.Text = "Araç İşlemleri";
            button11.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(259, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 426);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // AdminSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AdminSayfasi";
            Text = "AdminSayfasi";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button7;
        private Button button9;
        private Button button11;
        private GroupBox groupBox1;
    }
}