namespace sehiriciulasimsistemi
{
    partial class Aracİşlemleri
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textsoyad = new TextBox();
            textad = new TextBox();
            textid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 429);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1922, 419);
            dataGridView1.TabIndex = 43;
            dataGridView1.SelectionChanged += dataGridViev1_SelectionChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1444, 251);
            button3.Margin = new Padding(6, 3, 6, 3);
            button3.Name = "button3";
            button3.Size = new Size(230, 82);
            button3.TabIndex = 42;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1440, 146);
            button2.Margin = new Padding(6, 3, 6, 3);
            button2.Name = "button2";
            button2.Size = new Size(230, 82);
            button2.TabIndex = 41;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1444, 40);
            button1.Margin = new Padding(6, 3, 6, 3);
            button1.Name = "button1";
            button1.Size = new Size(230, 82);
            button1.TabIndex = 40;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(470, 251);
            textBox4.Margin = new Padding(6, 3, 6, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(538, 38);
            textBox4.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(252, 265);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 31);
            label5.TabIndex = 38;
            label5.Text = "Kapasite:";
            // 
            // textsoyad
            // 
            textsoyad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textsoyad.Location = new Point(470, 203);
            textsoyad.Margin = new Padding(6, 3, 6, 3);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(538, 38);
            textsoyad.TabIndex = 35;
            // 
            // textad
            // 
            textad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textad.Location = new Point(470, 152);
            textad.Margin = new Padding(6, 3, 6, 3);
            textad.Name = "textad";
            textad.Size = new Size(538, 38);
            textad.TabIndex = 34;
            // 
            // textid
            // 
            textid.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textid.Location = new Point(470, 99);
            textid.Margin = new Padding(6, 3, 6, 3);
            textid.Name = "textid";
            textid.Size = new Size(538, 38);
            textid.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(252, 111);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 31);
            label3.TabIndex = 32;
            label3.Text = "Plaka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(252, 215);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 31);
            label2.TabIndex = 31;
            label2.Text = "Yıl:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(252, 164);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 30;
            label1.Text = "Model:";
            // 
            // Aracİşlemleri
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1928, 843);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textsoyad);
            Controls.Add(textad);
            Controls.Add(textid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Aracİşlemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aracİşlemleri";
            Load += Aracİşlemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textsoyad;
        private TextBox textad;
        private TextBox textid;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}