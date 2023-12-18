using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class OgrenciTarifesi:yolcutarifesi
    {
        public override int mesafe { get; set; }
        public double fiyat(double ucret)
        {
            return ucret = mesafe * 0.60;
            Console.WriteLine(ucret);
            Console.WriteLine("Öğrenci Kart");
        }
    }
}
