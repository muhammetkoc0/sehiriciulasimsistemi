using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
    public class tambilet:yolcutarifesi
    {
        public override int mesafe { get; set; }
        public double fiyat(double ucret)
        {
            return ucret = mesafe * 1.20;
            Console.WriteLine(ucret);
            Console.WriteLine("Tam Bilet");
        }

    }
}
