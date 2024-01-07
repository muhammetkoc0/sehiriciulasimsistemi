using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    internal class AdminIslemleri
    {
    }
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
