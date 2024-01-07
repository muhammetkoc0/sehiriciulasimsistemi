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
    public partial class Soforİslemleri : Form
    {
        BindingList<SoforKayit> Soforler = new BindingList<SoforKayit>();
        public Soforİslemleri()
        {
            InitializeComponent();
        }


        private void Soforİslemleri_Load(object sender, EventArgs e)
        {

            SoforKayit sofor1 = new SoforKayit { id = 1, isim = "Muhammet ", soyisim = "Koç", yas = 21, tarih = DateTime.Now, Sigorta = true };
            SoforKayit sofor2 = new SoforKayit { id = 2, isim = "Yasemin ", soyisim = "Alaca", yas = 32, tarih = DateTime.Now , Sigorta = false };
            SoforKayit sofor3 = new SoforKayit { id = 3, isim = "Ahmet ", soyisim = "Dal", yas = 46, tarih = DateTime.Now , Sigorta = true };

            Soforler.Add(sofor1);
            Soforler.Add(sofor2);
            Soforler.Add(sofor3);

            dataGridView1.DataSource = Soforler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textid.Text);
            string Ad = textad.Text;
            string Soyad = textsoyad.Text;
            int Yas = Convert.ToInt32(textBox4.Text);
            DateTime dateTime = dtTime.Value;
            bool Sigorta = checkBox1.Checked;

            SoforKayit sofor = new SoforKayit { id = Id, isim = Ad, soyisim = Soyad, yas = Yas, tarih = dateTime, Sigorta= Sigorta };
            Soforler.Add(sofor);
        }


        private void dataGridViev1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SoforKayit sofor = (SoforKayit)dataGridView1.SelectedRows[0].DataBoundItem;
                textid.Text = sofor.id.ToString();
                textad.Text = sofor.isim;
                textsoyad.Text = sofor.soyisim;
                textBox4.Text = sofor.yas.ToString();
                dtTime.Value = sofor.tarih;
                checkBox1.Checked = sofor.Sigorta;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SoforKayit sofor = (SoforKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                sofor.isim = textad.Text;
                sofor.soyisim = textsoyad.Text;
                sofor.id = Convert.ToInt32(textid.Text);
                sofor.yas = Convert.ToInt32(textBox4.Text);
                sofor.tarih = dtTime.Value;
                sofor.Sigorta = checkBox1.Checked;

                dataGridView1.Refresh();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SoforKayit sofor = (SoforKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show(sofor.isim + sofor.soyisim + " Silinsin mi?", "Şoför Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Soforler.Remove(sofor);

                    dataGridView1.Refresh();
                }
            }

        }
    }
}
