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
    public partial class Aracİşlemleri : Form
    {

     public   BindingList<AracKayit> Araclar = new BindingList<AracKayit>();
        public Aracİşlemleri()
        {
            InitializeComponent();
        }


        public void Aracİşlemleri_Load(object sender, EventArgs e)
        {
            AracKayit Arac1 = new AracKayit { PlakaNo = "48 MBB 45", Model = "Karsan", Yil = 2018, Kapasite = 45 };
            AracKayit Arac2 = new AracKayit { PlakaNo = "48 MBB 101", Model = "Otokar", Yil = 2020, Kapasite = 85 };
            AracKayit Arac3 = new AracKayit { PlakaNo = "48 MBB 102", Model = "Otokar", Yil = 2020, Kapasite = 85 };
            AracKayit Arac4 = new AracKayit { PlakaNo = "48 MBB 85", Model = "Ford", Yil = 2021, Kapasite = 27 };

            Araclar.Add(Arac1);
            Araclar.Add(Arac2);
            Araclar.Add(Arac3);
            Araclar.Add(Arac4);
           
            

            dataGridView1.DataSource = Araclar;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string PlakaNo = textid.Text;
            string Model = textad.Text;
            int Yil = Convert.ToInt32(textsoyad.Text);
            int Kapasite = Convert.ToInt32(textBox4.Text);
            AracKayit arac = new AracKayit { PlakaNo = PlakaNo, Model = Model, Yil = Yil, Kapasite = Kapasite };
            Araclar.Add(arac);
        }
        private void dataGridViev1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                AracKayit Arac = (AracKayit)dataGridView1.SelectedRows[0].DataBoundItem;
                textid.Text = Arac.PlakaNo;
                textad.Text = Arac.Model;
                textsoyad.Text = Arac.Yil.ToString();
                textBox4.Text = Arac.Kapasite.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AracKayit Arac = (AracKayit)dataGridView1.SelectedRows[0].DataBoundItem;
                Arac.PlakaNo=textid.Text;
                Arac.Model=textad.Text;
                Arac.Yil= Convert.ToInt32(textsoyad.Text);
                Arac.Kapasite = Convert.ToInt32(textBox4.Text);

                dataGridView1.Refresh();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AracKayit arac = (AracKayit)dataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show(arac.PlakaNo + " Plakalı Araç Silinsin mi?", "Araç Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Araclar.Remove(arac);

                    dataGridView1.Refresh();
                }

            }

        }

      
    }
}