using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sehiriciulasimsistemi
{
    public partial class AdminGiris : Form
    {
        public class Admin
        {
            public int ID { get; set; }
            public string Sifre { get; set; }
        }

        private List<Admin> adminListesi;

        public AdminGiris()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
            adminListesi = new List<Admin>
        {
            new Admin { ID = 1001, Sifre = "1234" },
            new Admin { ID = 1002, Sifre = "4321" }
            // Buraya diğer adminler eklenebilir
        };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                bool isValidId = int.TryParse(textBox1.Text, out int girilenId);
                if (isValidId)
                {
                    string girilenSifre = textBox3.Text;

              

            bool girisBasarili = false;

            foreach (Admin admin in adminListesi)
            {
                if (admin.ID == girilenId && admin.Sifre == girilenSifre)
                {
                    girisBasarili = true;
                    break;
                }
            }

            if (girisBasarili)
            {
                MessageBox.Show(textBox1.Text + " Giriş Başarılı...");
                AdminSayfasi fr = new AdminSayfasi();
                fr.Show();
                this.Hide(); // İlk formu kapatmak için
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. Lütfen geçerli bir ID ve şifre girin.");
            }
                }
                else
                {
                    MessageBox.Show("Geçerli bir ID girin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen ID ve şifre girin.");
            }
        }
       
    }

      
    
}
