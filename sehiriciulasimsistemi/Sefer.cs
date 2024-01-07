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
    public partial class Sefer : Form
    {
        public string TaşınanMetin { get; set; }
        public List<string> ListBoxItems { get; set; }

        public Sefer()
        {
            InitializeComponent();
            ListBoxItems = new List<string>();
        }

        private void Sefer_Load(object sender, EventArgs e)
        {
          
            foreach (var item in ListBoxItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void labad_Click(object sender, EventArgs e)
        {

        }
    }


}

