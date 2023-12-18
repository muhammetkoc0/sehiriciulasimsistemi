namespace sehiriciulasimsistemi
{
    partial class Soforİslemleri
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
            label2 = new Label();
            label3 = new Label();
            textid = new TextBox();
            textad = new TextBox();
            textsoyad = new TextBox();
            dtTime = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 24);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 24);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // textid
            // 
            textid.Location = new Point(286, 49);
            textid.Margin = new Padding(4, 3, 4, 3);
            textid.Name = "textid";
            textid.Size = new Size(309, 32);
            textid.TabIndex = 3;
            // 
            // textad
            // 
            textad.Location = new Point(286, 89);
            textad.Margin = new Padding(4, 3, 4, 3);
            textad.Name = "textad";
            textad.Size = new Size(309, 32);
            textad.TabIndex = 4;
            // 
            // textsoyad
            // 
            textsoyad.Location = new Point(286, 127);
            textsoyad.Margin = new Padding(4, 3, 4, 3);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(309, 32);
            textsoyad.TabIndex = 5;
            // 
            // dtTime
            // 
            dtTime.Location = new Point(286, 203);
            dtTime.Margin = new Padding(4, 3, 4, 3);
            dtTime.Name = "dtTime";
            dtTime.Size = new Size(309, 32);
            dtTime.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 211);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 7;
            label4.Text = "İşe Başlama:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 8;
            label5.Text = "Yaş:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(286, 165);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 32);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(810, 31);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(132, 63);
            button1.TabIndex = 10;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(808, 111);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(132, 63);
            button2.TabIndex = 11;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(810, 191);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(132, 63);
            button3.TabIndex = 12;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1111, 222);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridViev1_SelectionChanged;
            // 
            // Soforİslemleri
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1100, 540);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtTime);
            Controls.Add(textsoyad);
            Controls.Add(textad);
            Controls.Add(textid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Soforİslemleri";
            Text = "Soforİslemleri";
            Load += Soforİslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textid;
        private TextBox textad;
        private TextBox textsoyad;
        private DateTimePicker dtTime;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}