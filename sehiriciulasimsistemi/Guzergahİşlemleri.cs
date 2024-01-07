using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace sehiriciulasimsistemi
{
    public partial class Guzergahİşlemleri : Form
    {
        BindingList<GuzergahKayit> Guzergahlar = new BindingList<GuzergahKayit>();
        public Guzergahİşlemleri()
        {
            InitializeComponent();
        }

        private void Guzergahİşlemleri_Load(object sender, EventArgs e)
        {
            
            GuzergahKayit guzergah1 = new GuzergahKayit { GuzergahKodu = "1-1", GuzergahAdı = "Yeniköy-AVM-Stadyum", Ilkdurak = "Yeniköy Meydan", SonDurak = "Atatürk Stadyumu" };    
            GuzergahKayit guzergah2 = new GuzergahKayit { GuzergahKodu = "1-2", GuzergahAdı = "Kampüs-AVM-Stadyum", Ilkdurak = "Eğitim Fakültesi", SonDurak = "Atatürk Stadyumu" };
            GuzergahKayit guzergah3 = new GuzergahKayit { GuzergahKodu = "1-41", GuzergahAdı = "Yeniköy-Tıp Fakültesi-Otogar", Ilkdurak = "Yeniköy Meydan", SonDurak = "Otogar" };
            GuzergahKayit guzergah4 = new GuzergahKayit { GuzergahKodu = "1-57", GuzergahAdı = "Yeniköy-Kampüs-Tıp Fakültesi", Ilkdurak = "Yeniköy Meydan", SonDurak = "Tıp Fakültesi" };

            Guzergahlar.Add(guzergah1);
            Guzergahlar.Add(guzergah2);
            Guzergahlar.Add(guzergah3);
            Guzergahlar.Add(guzergah4);
            dataGridView1.DataSource = Guzergahlar;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GuzergahKodu =textid.Text;
            string GuzergahAdı = textad.Text;
            string IlkDurak = textsoyad.Text;
            string SonDurak = textBox4.Text;
            GuzergahKayit guzergah = new GuzergahKayit { GuzergahKodu = GuzergahKodu, GuzergahAdı = GuzergahAdı, Ilkdurak = IlkDurak, SonDurak = SonDurak };
            Guzergahlar.Add(guzergah);
        }

        private void dataGridViev1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GuzergahKayit guzergah = (GuzergahKayit)dataGridView1.SelectedRows[0].DataBoundItem;
                textid.Text = guzergah.GuzergahKodu.ToString();
                textad.Text = guzergah.GuzergahAdı;
                textsoyad.Text = guzergah.Ilkdurak;
                textBox4.Text = guzergah.SonDurak;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GuzergahKayit guzergah = (GuzergahKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                guzergah.GuzergahKodu = textid.Text;
                guzergah.GuzergahAdı = textad.Text;
                guzergah.Ilkdurak = textsoyad.Text;
                guzergah.SonDurak = textBox4.Text;

                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                GuzergahKayit guzergah = (GuzergahKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show(guzergah.GuzergahAdı + " Silinsin mi?", "Güzergah Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Guzergahlar.Remove(guzergah);

                    dataGridView1.Refresh();
                }
            }
        }
    }
}
        