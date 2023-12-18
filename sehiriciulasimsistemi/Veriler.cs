using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
     class Veriler:AnaVeriler
    {
        public override void Vizeleme()
        {
            
        }
    }

    abstract class AnaVeriler
    {
        public abstract void Vizeleme();
        public void deneme()
        {
            Console.WriteLine("öğrenci ve anne kart 1 yıl süre ile sınırlandırılır.");
        }

    }
}
