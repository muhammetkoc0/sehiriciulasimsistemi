using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sehiriciulasimsistemi
{
    public partial class SoforGiris : Form
    {
        List<SoforKayit> Soforler = new List<SoforKayit>();
       
        public SoforGiris()
        {
            InitializeComponent();
        }
      
        private void SoforGiris_Load(object sender, EventArgs e)
        {
            SoforKayit sofor1 = new SoforKayit { id = 1, isim = "Muhammet ", soyisim = "Koç", yas = 21, tarih = DateTime.Now, Sigorta = true };
            SoforKayit sofor2 = new SoforKayit { id = 2, isim = "Yasemin ", soyisim = "Alaca", yas = 32, tarih = DateTime.Now, Sigorta = false };
            SoforKayit sofor3 = new SoforKayit { id = 3, isim = "Ahmet ", soyisim = "Dal", yas = 46, tarih = DateTime.Now, Sigorta = true };

            Soforler.Add(sofor1);
            Soforler.Add(sofor2);
            Soforler.Add(sofor3);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int girilenId))
            {
                SoforKayit sofor = Soforler.FirstOrDefault(y => y.id == girilenId);

                if (sofor != null)
                {
                    SoforSayfasi fr = new SoforSayfasi();
                    fr.GosterSofor(sofor); // Şoför bilgilerini ikinci forma gönderme
                    fr.Show();
                    this.Hide(); // İlk formu gizleme (kapatmak yerine gizliyoruz)
                }
                else
                {
                    MessageBox.Show("Girilen ID'ye ait şoför kaydı bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Geçersiz ID formatı.");
            }
        }
    }
}






