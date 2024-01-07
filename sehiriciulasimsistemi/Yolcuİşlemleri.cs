using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sehiriciulasimsistemi
{
    public partial class Yolcuİşlemleri : Form
    {
        BindingList<YolcuKayit> Yolcular = new BindingList<YolcuKayit>();
        public Yolcuİşlemleri()
        {
            InitializeComponent();
        }

        private void Yolcuİşlemleri_Load(object sender, EventArgs e)
        {

            YolcuKayit yolcu1 = new YolcuKayit { Id = 48101, Ad = "Muhammet ", Soyad = "Koç", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Öğrenci" };
            YolcuKayit yolcu2 = new YolcuKayit { Id = 48102, Ad = "Yasemin ", Soyad = "Alaca", DogumTarihi = DateTime.Now, Kadın = true, Erkek = false, Kategori = "Anne" };
            YolcuKayit yolcu3 = new YolcuKayit { Id = 48103, Ad = "Ahmet ", Soyad = "Dal", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Yaşlı" };
            YolcuKayit yolcu4 = new YolcuKayit { Id = 48104, Ad = "Yusuf ", Soyad = "Ateş", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Tam" };
            YolcuKayit yolcu5 = new YolcuKayit { Id = 48105, Ad = "Ayşe ", Soyad = "Değirmen", DogumTarihi = DateTime.Now, Kadın = true, Erkek = false, Kategori = "Engelli" };
            YolcuKayit yolcu6 = new YolcuKayit { Id = 48106, Ad = "Burak ", Soyad = "Dağ", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Kamu Görevlisi" };
            YolcuKayit yolcu7 = new YolcuKayit { Id = 48107, Ad = "Kahraman ", Soyad = "Albayoğlu", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Öğrenci" };
            YolcuKayit yolcu8 = new YolcuKayit { Id = 48108, Ad = "Leyla ", Soyad = "Fidan", DogumTarihi = DateTime.Now, Kadın = true, Erkek = false, Kategori = "Anne" };
            YolcuKayit yolcu9 = new YolcuKayit { Id = 48109, Ad = "Emre ", Soyad = "Gençoğlu", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Tam" };
            YolcuKayit yolcu10 = new YolcuKayit { Id = 48110, Ad = "Yasin ", Soyad = "Ak", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Tam" };
            YolcuKayit yolcu11 = new YolcuKayit { Id = 48111, Ad = "Zuhal ", Soyad = "Çoban", DogumTarihi = DateTime.Now, Kadın = true, Erkek = false, Kategori = "Öğrenci" };
            YolcuKayit yolcu12 = new YolcuKayit { Id = 48112, Ad = "Mustafa ", Soyad = "Tosun", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Öğrenci" };
            YolcuKayit yolcu13 = new YolcuKayit { Id = 48113, Ad = "Furkan ", Soyad = "Aksakal", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Tam" };
            YolcuKayit yolcu14 = new YolcuKayit { Id = 48114, Ad = "Narin ", Soyad = "Tatar", DogumTarihi = DateTime.Now, Kadın = true, Erkek = false, Kategori = "Engelli" };
            YolcuKayit yolcu15 = new YolcuKayit { Id = 48115, Ad = "Nurulah ", Soyad = "Yaman", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Kamu Görevlisi" };
            YolcuKayit yolcu16 = new YolcuKayit { Id = 48116, Ad = "Ferhat ", Soyad = "Albayoğlu", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Öğrenci" };
            YolcuKayit yolcu17 = new YolcuKayit { Id = 48117, Ad = "Neslihan ", Soyad = "Fidan", DogumTarihi = DateTime.Now, Kadın = true, Erkek = false, Kategori = "Anne" };
            YolcuKayit yolcu18 = new YolcuKayit { Id = 48118, Ad = "Gökhan ", Soyad = "Diri", DogumTarihi = DateTime.Now, Erkek = true, Kadın = false, Kategori = "Tam" };

            Yolcular.Add(yolcu1);
            Yolcular.Add(yolcu2);
            Yolcular.Add(yolcu3);
            Yolcular.Add(yolcu4);
            Yolcular.Add(yolcu5);
            Yolcular.Add(yolcu6);
            Yolcular.Add(yolcu7);
            Yolcular.Add(yolcu8);
            Yolcular.Add(yolcu9);
            Yolcular.Add(yolcu10);
            Yolcular.Add(yolcu11);
            Yolcular.Add(yolcu12);
            Yolcular.Add(yolcu13);
            Yolcular.Add(yolcu14);
            Yolcular.Add(yolcu15);
            Yolcular.Add(yolcu16);
            Yolcular.Add(yolcu17);
            Yolcular.Add(yolcu18);

            dataGridView1.DataSource = Yolcular;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textid.Text);
            string Ad = textad.Text;
            string Soyad = textsoyad.Text;
            DateTime dateTime = dtTime.Value;
            bool Erkek = checkBox1.Checked;
            bool Kadın = checkBox2.Checked;
            string Kategori = comboBox1.Text;

            YolcuKayit yolcu = new YolcuKayit { Id = Id, Ad = Ad, Soyad = Soyad, DogumTarihi = dateTime, Erkek = Erkek, Kadın = Kadın, Kategori = Kategori };
            Yolcular.Add(yolcu);
        }

        private void dataGridViev1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                YolcuKayit yolcu = (YolcuKayit)dataGridView1.SelectedRows[0].DataBoundItem;
                textid.Text = yolcu.Id.ToString();
                textad.Text = yolcu.Ad;
                textsoyad.Text = yolcu.Soyad;
                dtTime.Value = yolcu.DogumTarihi;
                checkBox1.Checked = yolcu.Erkek;
                checkBox2.Checked = yolcu.Kadın;
                comboBox1.Text = yolcu.Kategori;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                YolcuKayit yolcu = (YolcuKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                yolcu.Ad = textad.Text;
                yolcu.Soyad = textsoyad.Text;
                yolcu.Id = Convert.ToInt32(textid.Text);
                yolcu.DogumTarihi = dtTime.Value;
                yolcu.Erkek = checkBox1.Checked;
                yolcu.Kadın = checkBox2.Checked;
                yolcu.Kategori = comboBox1.Text;
                dataGridView1.Refresh();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                YolcuKayit yolcu = (YolcuKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show(yolcu.Ad+ yolcu.Soyad + " Silinsin mi?", " Yolcu Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Yolcular.Remove(yolcu);

                    dataGridView1.Refresh();
                }
            }

        }
    }
}
