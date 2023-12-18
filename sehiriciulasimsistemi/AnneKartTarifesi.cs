using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class AnneKartTarifesi:yolcutarifesi
    {
        public override int mesafe { get; set; }
        public double fiyat(double ucret)
        {
            return ucret = mesafe * 0.80;
            Console.WriteLine(ucret);
            Console.WriteLine("Anne Kart");
        }
    }
}
