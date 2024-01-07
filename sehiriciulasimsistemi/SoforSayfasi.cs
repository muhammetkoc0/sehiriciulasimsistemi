using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sehiriciulasimsistemi
{
    public partial class SoforSayfasi : Form
    {
        public SoforSayfasi()
        {
            InitializeComponent();
        }
        public void GosterSofor(SoforKayit sofor)
        {
            
            labad.Text ="Şoför "+ sofor.isim + sofor.soyisim +" İyi Yolculuklar";

            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null) 
            {
                string secilenDeger1 = comboBox1.SelectedItem.ToString(); 
                string secilenDeger2 = comboBox2.SelectedItem.ToString(); 

                Sefer fr = new Sefer();
                Console.WriteLine("SEFER BİLGİLERİ");
                fr.ListBoxItems.Add("Plaka No: " + secilenDeger1);
                fr.ListBoxItems.Add("Güzergah: " + secilenDeger2);

                fr.Show();
                this.Hide();
                MessageBox.Show("Sefer Başarıyla Oluşturuldu");
            }
            else
            {

                MessageBox.Show("Lütfen her iki alanıda seçin!");
            }
        }

        private void SoforSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
