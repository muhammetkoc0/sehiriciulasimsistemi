namespace sehiriciulasimsistemi
{
    partial class Guzergahİşlemleri
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
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            textid = new TextBox();
            textad = new TextBox();
            textsoyad = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-5, 611);
            dataGridView1.Margin = new Padding(6, 5, 6, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1881, 389);
            dataGridView1.TabIndex = 27;
            dataGridView1.SelectionChanged += dataGridViev1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(155, 202);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 14;
            label1.Text = "Güzergah Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 270);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 15;
            label2.Text = "İlk Durak:";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1370, 363);
            button3.Margin = new Padding(7, 5, 7, 5);
            button3.Name = "button3";
            button3.Size = new Size(247, 110);
            button3.TabIndex = 26;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textid
            // 
            textid.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textid.Location = new Point(427, 113);
            textid.Margin = new Padding(7, 5, 7, 5);
            textid.Name = "textid";
            textid.Size = new Size(575, 30);
            textid.TabIndex = 17;
            // 
            // textad
            // 
            textad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textad.Location = new Point(427, 183);
            textad.Margin = new Padding(7, 5, 7, 5);
            textad.Name = "textad";
            textad.Size = new Size(575, 30);
            textad.TabIndex = 18;
            // 
            // textsoyad
            // 
            textsoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textsoyad.Location = new Point(427, 249);
            textsoyad.Margin = new Padding(7, 5, 7, 5);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(575, 30);
            textsoyad.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 132);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 16;
            label3.Text = "Güzergah Kodu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(155, 337);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 22;
            label5.Text = "Son Durak:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(427, 315);
            textBox4.Margin = new Padding(7, 5, 7, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(575, 30);
            textBox4.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1370, 83);
            button1.Margin = new Padding(7, 5, 7, 5);
            button1.Name = "button1";
            button1.Size = new Size(247, 110);
            button1.TabIndex = 24;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1365, 223);
            button2.Margin = new Padding(7, 5, 7, 5);
            button2.Name = "button2";
            button2.Size = new Size(247, 110);
            button2.TabIndex = 25;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Guzergahİşlemleri
            // 
            AutoScaleDimensions = new SizeF(15F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1875, 999);
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
            Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Guzergahİşlemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guzergahİşlemleri";
            Load += Guzergahİşlemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox textid;
        private TextBox textad;
        private TextBox textsoyad;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}