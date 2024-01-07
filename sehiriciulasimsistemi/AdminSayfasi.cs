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
    public partial class AdminSayfasi : Form
    {
        public AdminSayfasi()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Soforİslemleri fr = new Soforİslemleri();
            fr.Show();
            // this.Hide();//ilk formu kapatmak için kullandık
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Guzergahİşlemleri fr = new Guzergahİşlemleri();
            fr.Show();
            // this.Hide();//ilk formu kapatmak için kullandık
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Yolcuİşlemleri fr = new Yolcuİşlemleri();
            fr.Show();
            // this.Hide();//ilk formu kapatmak için kullandık
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Aracİşlemleri fr = new Aracİşlemleri();
            fr.Show();
            // this.Hide();//ilk formu kapatmak için kullandık
        }
    }
}
