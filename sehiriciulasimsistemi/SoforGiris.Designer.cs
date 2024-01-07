namespace sehiriciulasimsistemi
{
    partial class SoforGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoforGiris));
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            button13 = new Button();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 128, 255);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(254, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(396, 567);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Şoför Giriş";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 36);
            textBox3.TabIndex = 17;
            // 
            // button13
            // 
            button13.BackColor = Color.Lime;
            button13.Location = new Point(108, 386);
            button13.Name = "button13";
            button13.Size = new Size(177, 54);
            button13.TabIndex = 16;
            button13.Text = "Kart Okut";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 128);
            label8.Name = "label8";
            label8.Size = new Size(105, 29);
            label8.TabIndex = 2;
            label8.Text = "Şoför ID:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(140, 213);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // SoforGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(920, 791);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SoforGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoforGiris";
            Load += SoforGiris_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox textBox3;
        private Button button13;
        private Label label8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label2;
    }
}