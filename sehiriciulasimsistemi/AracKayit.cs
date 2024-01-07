using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class AracKayit
    {
        string plaka;
        string model;
        int yil;
        int kapasite;
        public string PlakaNo { get { return plaka; } set { plaka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Yil { get { return yil; } set { yil = value; } }
        public int Kapasite { get { return kapasite; } set { kapasite = value; } }
    }
}
