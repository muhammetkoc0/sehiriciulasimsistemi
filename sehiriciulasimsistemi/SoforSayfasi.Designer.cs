namespace sehiriciulasimsistemi
{
    partial class SoforSayfasi
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
            button14 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            labad = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button14
            // 
            button14.BackColor = Color.Lime;
            button14.Location = new Point(151, 406);
            button14.Name = "button14";
            button14.Size = new Size(130, 46);
            button14.TabIndex = 30;
            button14.Text = "Sefer Başlat";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 314);
            label11.Name = "label11";
            label11.Size = new Size(123, 23);
            label11.TabIndex = 26;
            label11.Text = "Güzergah Seç:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 238);
            label10.Name = "label10";
            label10.Size = new Size(83, 23);
            label10.TabIndex = 25;
            label10.Text = "Araç Seç:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 235);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 128, 0);
            groupBox1.Controls.Add(labad);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button14);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(182, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 553);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sefer Giriş";
            // 
            // labad
            // 
            labad.AutoSize = true;
            labad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labad.Location = new Point(33, 65);
            labad.Name = "labad";
            labad.Size = new Size(92, 28);
            labad.TabIndex = 34;
            labad.Text = "__________";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { " ", " 1-1 Yeniköy-AVM-Stadyum", " 1-2 Kampüs-AVM-Stadyum", " 1-41 Yeniköy-Tıp Fakültesi-Otogar", " 1-57 Yeniköy-Kampüs-Tıp Fakültesi" });
            comboBox2.Location = new Point(132, 311);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(272, 31);
            comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "48 MBB 45", "48 MBB 101", "48 MBB 102", "48 MBB 85" });
            comboBox1.Location = new Point(132, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 31);
            comboBox1.TabIndex = 31;
            // 
            // SoforSayfasi
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(798, 765);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "SoforSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoforSayfasi";
            Load += SoforSayfasi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button14;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label labad;
    }
}