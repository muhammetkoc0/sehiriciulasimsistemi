using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class GuzergahKayit
    {
        string id;
        string Ad;
        string ilkDurak;
        string sonDurak;

        public string GuzergahKodu { get { return id; } set { id = value; } }
        public string GuzergahAdı { get { return Ad; } set { Ad = value; } }
        public string Ilkdurak { get { return ilkDurak; } set { ilkDurak = value; } }
        public string SonDurak { get { return sonDurak; } set { sonDurak = value; } }

      
    }
}
