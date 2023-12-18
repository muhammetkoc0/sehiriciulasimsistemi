using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace sehiriciulasimsistemi
{
   
    abstract public class yolcutarifesi
    {
        public abstract int mesafe {  get; set; }
        public string ad {  get; set; }
        public string soyad { get; set; }
        public int id { get; set; }

        
    }
}
